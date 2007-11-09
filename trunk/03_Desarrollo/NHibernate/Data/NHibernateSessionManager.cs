using System.Configuration;
using System.Runtime.Remoting.Messaging;
using NHibernate;
using NHibernate.Cache;
using Configuration=NHibernate.Cfg.Configuration;
using System.Collections;
using ToolBox;


namespace FSO_NH.Data
{
    /// <summary>
    /// Handles creation and management of sessions and transactions.  It is a singleton because 
    /// building the initial session factory is very expensive. Inspiration for this class came 
    /// from Chapter 8 of Hibernate in Action by Bauer and King.  Although it is a sealed singleton
    /// you can use TypeMock (http://www.typemock.com) for more flexible testing.
    /// </summary>
    public sealed class NHibernateSessionManager
    {
        private string Assembly;
        #region Thread-safe, lazy Singleton

        /// <summary>
        /// This is a thread-safe, lazy singleton.  See http://www.yoda.arachsys.com/csharp/singleton.html
        /// for more details about its implementation.
        /// </summary>
        public static NHibernateSessionManager Instance
        {
            get { return Nested.nHibernateSessionManager; }
        }

        /// <summary>
        /// Initializes the NHibernate session factory upon instantiation.
        /// </summary>
        private NHibernateSessionManager()
        {
            InitSessionFactory();
        }

        /// <summary>
        /// Assists with ensuring thread-safe, lazy singleton
        /// </summary>
        private class Nested
        {
            static Nested()
            {
            }

            internal static readonly NHibernateSessionManager nHibernateSessionManager = new NHibernateSessionManager();
        }

        #endregion

        private void InitSessionFactory()
        {
            Configuration configuration = new Configuration();


            IDictionary props = new Hashtable();

            Assembly = ConfigurationManager.AppSettings["HBM_ASSEMBLY"];
            string sProvider = ConfigurationManager.AppSettings[Assembly + ".connection.provider"];
            string sDialect = ConfigurationManager.AppSettings[Assembly + ".dialect"];
            string ConnectionString = ConfigurationManager.AppSettings[Assembly + ".connection.connection_string"];
            string sIsolation = ConfigurationManager.AppSettings[Assembly + ".connection.isolation"];
            string sDriverClass = ConfigurationManager.AppSettings[Assembly + ".connection.driver_class"];
            string sDesencriptar = ConfigurationManager.AppSettings[Assembly + ".UsarCadenaConexionEncriptada"];

            if (sDesencriptar.Trim().ToUpper() == "TRUE")
            {
                TripleDES_Encriptador Encriptador = new TripleDES_Encriptador(@"CMom9EfyoR7cu4qabv2PyUC9SuyWrN9V", @"xRnyk/GTKMI=");
                ConnectionString = Encriptador.DecryptString(ConnectionString);
            }


            props["hibernate.connection.provider"] = sProvider;
            props["hibernate.dialect"] = sDialect;
            props["hibernate.connection.connection_string"] = ConnectionString;
            props["hibernate.connection.isolation"] = sIsolation;
            props["hibernate.connection.driver_class"] = sDriverClass;

            foreach (DictionaryEntry de in props)
            {
                configuration.SetProperty(de.Key.ToString(), de.Value.ToString());
            }
            configuration.AddAssembly(Assembly);
            sessionFactory = configuration.BuildSessionFactory();

        }

        /// <summary>
        /// Allows you to register an interceptor on a new session.  This may not be called if there is already
        /// an open session attached to the HttpContext.  If you have an interceptor to be used, modify
        /// the HttpModule to call this before calling BeginTransaction().
        /// </summary>
        public void RegisterInterceptor(IInterceptor interceptor)
        {
            ISession session = threadSession;

            if (session != null && session.IsOpen)
            {
                throw new CacheException("You cannot register an interceptor once a session has already been opened");
            }

            GetSession(interceptor);
        }

        public ISession GetSession()
        {
            return GetSession(null);
        }

        /// <summary>
        /// Gets a session with or without an interceptor.  This method is not called directly; instead,
        /// it gets invoked from other public methods.
        /// </summary>
        private ISession GetSession(IInterceptor interceptor)
        {
            ISession session = threadSession;

            if (session == null)
            {
                if (interceptor != null)
                {
                    session = sessionFactory.OpenSession(interceptor);

                }
                else
                {
                    session = sessionFactory.OpenSession();
                  
                }

                threadSession = session;
            }

            return session;
        }
        
        public void StartSession()
        {
            if (this.threadSession == null)
            {
                this.threadSession = this.sessionFactory.OpenSession();
               
            }
        }

        public void CloseSession()
        {
            ISession session = threadSession;
            threadSession = null;

            if (session != null && session.IsOpen)
            {
                session.Close();
            }
        }

        public void BeginTransaction()
        {
            ITransaction transaction = threadTransaction;

            if (transaction == null)
            {
                transaction = GetSession().BeginTransaction();
                threadTransaction = transaction;
            }
        }

        public void CommitTransaction()
        {
            ITransaction transaction = threadTransaction;

            try
            {
                if (transaction != null && !transaction.WasCommitted && !transaction.WasRolledBack)
                {                    
                    transaction.Commit();
                    threadTransaction = null;
                }
            }
            catch (HibernateException ex)
            {
                RollbackTransaction();
                throw ex;
            }
        }

        public void RollbackTransaction()
        {
            ITransaction transaction = threadTransaction;

            try
            {
                threadTransaction = null;

                if (transaction != null && !transaction.WasCommitted && !transaction.WasRolledBack)
                {
                    transaction.Rollback();
                }
            }
            catch (HibernateException ex)
            {
                throw ex;
            }
            finally
            {
                CloseSession();
            }
        }

        private ITransaction threadTransaction
        {
            get { return (ITransaction)CallContext.GetData("FastFood.Core"); }
            set { CallContext.SetData("FastFood.Core", value); }
        }

        private ISession threadSession
        {
            get { return (ISession)CallContext.GetData("FastFood.Core"); }
            set { CallContext.SetData("FastFood.Core", value); }
        }

        private ISessionFactory sessionFactory;
    }
}