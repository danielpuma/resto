using System;
using System.Collections;
using System.Collections.Generic;
using NHibernate.Expression;
using NHibernate.Type;
using FSO_NHDATA.DataInterfaces;
using FSO_NH.Data;
using FSO_NHDATA;
using NHibernate.Collection;
using System.Configuration;
using ToolBox;


namespace FSO_NH.bb
{
    /// <summary>
    ///       Implementa Acceso a Datos Basico de IGenericDao
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class FNegocioBase<T> : IGenericDao<T,Int32>
    {
        private static NHDao<T> _dao;
        protected static NHDao<T> dao
        {
            get {
                if (_dao == null)
                {
                    _dao = new NHDao<T>();
                }
                return _dao;
            }
        }

        #region ConnectionStringData
            public string GetConnectionString()
            {
                
                return dao.Session.Connection.ConnectionString;
            }
            public string GetDataBaseName()
            {
                string[] conn = GetConnectionString().Split(';');

                return conn[1].Split('=')[1].Trim();

            }
            public string GetServerName()
            {
                string[] conn = GetConnectionString().Split(';');

                return conn[0].Split('=')[1].Trim();
            }
            public string GetUserName()
            {
                string[] conn = GetConnectionString().Split(';');

                return conn[2].Split('=')[1].Trim();
            }
            public string GetDBPassWord()
            {
                
                string Assembly = ConfigurationManager.AppSettings["HBM_ASSEMBLY"];
                string sDesencriptar = ConfigurationManager.AppSettings[Assembly + ".UsarCadenaConexionEncriptada"];
                string DBPassword = ConfigurationManager.AppSettings["ReportDBPassword"];

                
                if (sDesencriptar.Trim().ToUpper() == "TRUE")
                {
                    TripleDES_Encriptador Encriptador = new TripleDES_Encriptador(@"CMom9EfyoR7cu4qabv2PyUC9SuyWrN9V", @"xRnyk/GTKMI=");
                    DBPassword = Encriptador.DecryptString(DBPassword);
                }
                return DBPassword;
            }
        #endregion
        #region CRUD METHODS
                    /// <summary>
                    /// Save(T entity)
                    /// </summary>
                    /// <param name="entity"></param>
                    /// <returns></returns>
                    public T Save(T entity)
                    {
                       
                        return dao.Save(entity);
                    }

                    /// <summary>
                    /// SaveOrUpdate
                    /// </summary>
                    /// <param name="entity"></param>
                    /// <returns></returns>
                    public T SaveOrUpdate(T entity)
                    {
                        
                        return dao.SaveOrUpdate(entity);
                    }


                    /// <summary>
                    /// Update An existing object
                    /// FSO
                    /// </summary>
                    /// <param name="entity"></param>
                    /// <returns></returns>
                    public T Update(T entity)
                    {
                       
                        return dao.Update(entity);
                    }


                    /// <summary>
                    /// Delete
                    /// </summary>
                    /// <param name="entity"></param>
                    public void Delete(T entity)
                    {
                        
                        dao.Delete(entity);
                    } 
                    #endregion
        #region METODOS DE CONSULTA

                    /// <summary>
                    /// GetByExample
                    /// </summary>
                    /// <param name="exampleInstance">Obj de ejemplo que se usa para filtrar las mismas propiedades que él.</param>
                    /// <param name="propertiesToExclude">propertiesToExclude</param>
                    /// <returns></returns>
                    public List<T> GetByExample(T exampleInstance, params string[] propertiesToExclude)
                    {
                        
                        return dao.GetByExample(exampleInstance, propertiesToExclude);
                    }

                    /// <summary>
                    /// GetUniqueByExample Obj de ejemplo que se usa para filtrar las mismas propiedades que él.
                    /// </summary>
                    /// <param name="exampleInstance"></param>
                    /// <param name="propertiesToExclude"></param>
                    /// <returns></returns>
                    public T GetUniqueByExample(T exampleInstance, params string[] propertiesToExclude)
                    {
                        
                        return dao.GetUniqueByExample(exampleInstance, propertiesToExclude);
                    }


                    /// <summary>
                    /// GetById
                    /// </summary>
                    /// <param name="id">ID</param>
                    /// <param name="shouldLock"> shouldLock = FALSE ES PARA READ ONLY  </param>
                    /// <returns></returns>
                    public T GetById(int id, bool shouldLock)
                    {
                        
                      
                        return dao.GetById(id, shouldLock);
                    }

                    /// <summary>
                    /// GetHQL / martin 2
                    /// </summary>
                    /// <param name="namedQuery"></param>
                    /// <param name="kParameters"></param>
                    /// <returns></returns>
                    public virtual IList GetHQL(string namedQuery, IList kParameters)
                    {
                        
                        return dao.GetHQL(namedQuery, kParameters);
                    }

                    public virtual IList GetHQL(string HQLQuery)
                    {
                        
                        return dao.Session.Find(HQLQuery);
                    }
                    /// <summary>
                    /// GetAll
                    /// </summary>
                    /// <returns></returns>
                    public virtual List<T> GetAll()
                    {
                       
                        return dao.GetAll();
                    }
                   /// <summary>
                    /// By FSO
                    /// </summary>
                    /// <param name="pFilters"></param>
                    /// <returns></returns>
                    public IList GetAllList(List<ICriterion> pFilters)
                    {
                        return dao.GetAllList(pFilters);
                    }
                    public virtual IList GetAllList()
                    {
                        return dao.GetAllList();
                    }

                    /// <summary>
                    /// By ale
                    /// </summary>
                    /// <param name="pFilters"></param>
                    /// <returns></returns>
                    public List<T> GetAll(List<ICriterion> pFilters)
                    {
                        return dao.GetAll(pFilters);
                    }
              
                    /// <summary>
                    /// Get a strongly typed collection of   objects given a SortExpression + Paging Information.
                    /// by ale
                    /// </summary>
                    ///<param name="pSortExpression">(Optional)  Specify a Sorting Expression. 
                    ///  Property  DESC  /  Property  ASC
                    ///  (Note: This method expects a Property Name.) </param>
                    ///<param name="pFirstResult">(Optional) If present it determines a starting row index from the complete DataSource.</param>
                    ///<param name="pMaxResult">(Optional) How many object should be retrieved? (Also know as Page Size)</param>
                    public List<T> GetAll(string pSortExpression, int? pFirstResult, int? pMaxResult)
                    {
                        return dao.GetAll(pSortExpression, pFirstResult, pMaxResult);
                    }

                    /// <summary>
                    /// Use this method to Get a strongly typed collection 
                    /// of    contain objects that match the parameters.
                    /// 
                    /// by ale sfrede...............
                    /// </summary>
                    ///<param name="pFilters">(Optional) Pass a list of criterias that will limit/filter the result.</param>
                    ///<param name="pSQLExpression">(Optional) Specify an SQL Filter expression.</param>
                    ///<param name="pSortExpression">(Optional) Specify a Sorting Expression. (Note: This method expects a Property Name.)</param>
                    ///<param name="pFirstResult">(Optional) If present it determines a starting row index from the complete DataSource.</param>
                    ///<param name="pMaxResult">(Optional) How many object should be retrieved? (Also know as Page Size)</param>
                    public List<T> GetAll(List<ICriterion> pFilters, string pSQLExpression, string pSortExpression,
                                          int? pFirstResult, int? pMaxResult)
                    {

                        return dao.GetAll(pFilters, pSQLExpression, pSortExpression, pFirstResult, pMaxResult);
                    }

                    /// <summary>
                    /// Counts how many objects will be returned by the GetAll() 
                    /// !! revisar !!!
                    /// ale sfrede
                    /// </summary>
                    /// <remarks>
                    /// Future NHibernate version will contain a better Count() technique so the current implementation will change to use ICriteria.Count instead of using the GetAll(pFilters) method.
                    /// </remarks>
                    public int Count()
                    {

                        return dao.Count();
                    }

                    /// <summary>
                    /// Counts how many objects will be returned by the GetAll() method according to the Criteria parameters.
                    /// by ale
                    /// </summary>
                    /// <remarks>
                    /// Future NHibernate version will contain a better Count() technique so the current implementation will change to use ICriteria.Count instead of using the GetAll(pFilters) method.
                    /// </remarks>
                    ///<param name="pFilters">(Optional) Pass a list of criterias that will limit/filter the result.</param>
                    /// <returns></returns>
                    public int Count(List<ICriterion> pFilters)
                    {

                        return dao.Count(pFilters);
                    }
                    
        #endregion
        #region METODOS DE MANEJO DE LISTAS

        /// <summary>
        /// filtra y ordena colecciones r retorna una nueva coleccion
        ///  "where this.Descripcion='des4'  order by this.Descripcion"
        /// </summary>
        /// <param name="lista">IList tipo BAG</param>
        /// <param name="filterWhere">where this.Descripcion='des4' </param>
        /// <param name="orderby">order by this.Descripcion</param>
        /// <returns></returns>
        public ICollection FilterSortCollectionBAG(IList lista, string filterWhere, string orderby)
        {

            return dao.FilterSortCollectionBAG(lista, filterWhere, orderby);

        }

        /// <summary>
        /// Sobrecarga completa de  session.Filter
        /// NHibernate.Reference.chm
        /// ref: http://nhibernate.sourceforge.net/h2.0.3-docs/reference/html/query-language.html
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="filterWhere"></param>
        /// <param name="orderby"></param>
        /// <param name="values"></param>
        /// <param name="types"></param>
        /// <returns></returns>
        public ICollection FilterSortCollectionBAG(IList lista, string filterWhere, string orderby, object[] values,
                                                   IType[] types)
        {

            return dao.FilterSortCollectionBAG(lista, filterWhere, orderby, values, types);
        }

        /// <summary>
        /// Accepts a list of objects and converts them to a strongly typed list.
        /// </summary>
        /// <remarks>This should be put into a utility class as it's not directly
        /// related to data access.</remarks>
        protected List<T> ConvertToGenericList(IList listObjects)
        {
            List<T> convertedList = new List<T>();

            foreach (object listObject in listObjects)
            {
                convertedList.Add((T)listObject);
            }

            return convertedList;
        }


        /// <summary>
        /// MultiPropertyComparer SortCollection by ale
        /// from 
        /// http://www.paulstovell.net/Posts/Post.aspx?postId=613c2327-22d4-42a5-8cc2-8dab06058cb9
        /// 
        /// </summary>
        /// <param name="listObjects">List<T></param>
        /// <param name="sortableProperty"> Property de la entidad <T> .property</param>
        /// <param name="sortDirection">0 o 1  -  SortDirection.Descending = 1 </param>
        /// <returns>List<T> orderedCollection</returns>
        public List<T> SortCollection(List<T> listObjects, string sortableProperty, SortDirection sortDirection)
        {


            return dao.SortCollection(listObjects, sortableProperty, sortDirection);
        }
        
        #endregion
        #region Transaction Region
                protected void BeginTransaction()
                {

                    dao.BeginTransaction();
                }
                protected void CommitTransaction()
                {

                    dao.CommitTransaction();
                }
                protected void RollBackTransaction()
                {

                    dao.RollbackTransaction();
                }
        #endregion
    }
}