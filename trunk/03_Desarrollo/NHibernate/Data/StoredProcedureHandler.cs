using System.Collections;
using System.Data;
using NHibernate;

namespace FSO_NH.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class StoredProceduresHandler
    {
        //   private NHSessionManager nhSessionManager;
        private DBAccessBuilder mDbAccessBuilder;
        private DBServerType mServerType;
        private IDbConnection mConnection;
        private IDbTransaction mTransaction;
        private int mCurrentPageIndex = -1;
        private int mPageCount = -1;
        private int mMaxResults = -1;
        private int mPageNumber = 0;
        private ISession session;

        /// <summary>
        /// 
        /// </summary>
        public StoredProceduresHandler(ISession psession)
        {
            mDbAccessBuilder = DBAccessBuilder.Instance;
            session = psession;
            mConnection = session.Connection;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="namedQuery"></param>
        /// <param name="paramCollection"></param>
        /// <returns></returns>
        public IList ExecuteNamedQuery(string namedQuery, IDataParameter[] paramCollection)
        {
            // ISession session = this.nhSessionManager.GetSession();
            if (paramCollection == null)
            {
                return session.GetNamedQuery(namedQuery).List();
            }
            IQuery query = session.GetNamedQuery(namedQuery);
            foreach (IDataParameter parameter in paramCollection)
            {
                object var = parameter.Value;
                if (var is ICollection)
                    query = query.SetParameterList(parameter.ParameterName, (ICollection) parameter.Value);
                else
                    query = query.SetParameter(parameter.ParameterName, parameter.Value);
            }
            return query.List();
        }

        public IList ExecuteNamedQueryPaged(string namedQuery, IDataParameter[] paramCollection)
        {
            //    ISession session = this.nhSessionManager.GetSession();
            IList datos;
            IQuery query = session.GetNamedQuery(namedQuery);
            query.SetFirstResult((mPageNumber - 1)*mMaxResults);
            query.SetMaxResults(mMaxResults);
            if (paramCollection != null)
            {
                foreach (IDataParameter parameter in paramCollection)
                {
                    object var = parameter.Value;
                    if (var is ICollection)
                        query = query.SetParameterList(parameter.ParameterName, (ICollection) parameter.Value);
                    else
                        query = query.SetParameter(parameter.ParameterName, parameter.Value);
                }
            }
            datos = query.List();

            // Setear la información de paginado. 
            IQuery pagerQuery = session.GetNamedQuery("Count_" + namedQuery);
            if (paramCollection != null)
            {
                foreach (IDataParameter parameter in paramCollection)
                {
                    object var = parameter.Value;
                    if (var is ICollection)
                        pagerQuery = pagerQuery.SetParameterList(parameter.ParameterName, (ICollection) parameter.Value);
                    else
                        pagerQuery = pagerQuery.SetParameter(parameter.ParameterName, parameter.Value);
                }
            }
            int totalResultados = (int) pagerQuery.List()[0];

            // Calcular la cantidad de páginas. Calcular la página actual y los restantes. 
            mPageCount = (totalResultados%mMaxResults) == 0
                             ? totalResultados/mMaxResults
                             : (totalResultados/mMaxResults) + 1;
            mCurrentPageIndex = mPageNumber;

            return datos;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="spName"></param>
        /// <param name="paramCollection"></param>
        /// <returns></returns>
        public DataSet ExecuteStoredProcedure(string spName, IDataParameterCollection paramCollection)
        {
            DataSet dataSet = new DataSet();
            IDbCommand command;

            if (mTransaction != null)
            {
                command = mDbAccessBuilder.BuildCommand(mServerType, spName, mConnection, mTransaction);
            }
            else
            {
                command = mDbAccessBuilder.BuildCommand(mServerType, spName, mConnection);
            }
            command.CommandType = CommandType.StoredProcedure;
            mDbAccessBuilder.SetCommandParameters(mServerType, command, paramCollection);
            IDbDataAdapter dataAdapter = mDbAccessBuilder.BuildDataAdapter(mServerType, command);
            dataAdapter.Fill(dataSet);
            return dataSet;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="parameterList"></param>
        public void ExecuteNonQuery(string name, IDataParameterCollection parameterList)
        {
            IDbCommand command;

            if (mTransaction != null)
            {
                command = mDbAccessBuilder.BuildCommand(mServerType, name, mConnection, mTransaction);
            }
            else
            {
                command = mDbAccessBuilder.BuildCommand(mServerType, name, mConnection);
            }
            command.CommandType = CommandType.Text;
            mDbAccessBuilder.SetCommandParameters(mServerType, command, parameterList);
            command.ExecuteNonQuery();
            for (int i = 0; i < parameterList.Count; i++)
            {
                ((IDataParameter) parameterList[i]).Value = ((IDataParameter) command.Parameters[i]).Value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataSet ExecuteQuery(string query)
        {
            DataSet dataSet = new DataSet();
            IDbCommand command;

            if (mTransaction != null)
            {
                command = mDbAccessBuilder.BuildCommand(mServerType, query, mConnection, mTransaction);
            }
            else
            {
                command = mDbAccessBuilder.BuildCommand(mServerType, query, mConnection);
            }
            command.CommandType = CommandType.Text;
            IDbDataAdapter dataAdapter = mDbAccessBuilder.BuildDataAdapter(mServerType, command);
            dataAdapter.Fill(dataSet);
            return dataSet;
        }

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public int CurrentPageIndex
        {
            get { return mCurrentPageIndex; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int PageCount
        {
            get { return mPageCount; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int MaxResults
        {
            get { return mMaxResults; }
            set { mMaxResults = value; }
        }

        public int PageNumber
        {
            get { return mPageNumber; }
            set { mPageNumber = value; }
        }

        #endregion
    }
}