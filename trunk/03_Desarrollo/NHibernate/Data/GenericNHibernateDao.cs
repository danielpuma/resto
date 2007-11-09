using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using NHibernate;
using NHibernate.Expression;
using NHibernate.Type;
using FSO_NHDATA.DataInterfaces;
using FSO_NHDATA;

namespace FSO_NH.Data
{
    /// <summary>
    /// Provee Acceso Generico DIRECTO a Datos 
    /// No utiliza el Negocio para acceder 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class NHDao<T> : GenericNHibernateDao<T, Int32>, IGenericDao<T, Int32>
    {
        public virtual ISession Session
        {
            get {

                return session;
                
            }
        }


        /// <summary>
        /// encapsula ConvertToGenericCollection
        /// </summary>
        /// <param name="listObjects"></param>
        /// <returns></returns>
        new public List<T> ConvertToGenericCollection(ICollection listObjects)
        {
            return base.ConvertToGenericCollection(listObjects);
        }
    }


    /// <summary>
    /// abstract class GenericNHibernateDao
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="ID"></typeparam>
    public abstract class GenericNHibernateDao<T, ID> : IGenericDao<T, ID>
    {
        #region ----persitentType----

              protected Type persitentType = typeof (T);

        #endregion

        #region Transacciones

            /// <summary>
            /// Exposes the ISession used within the DAO.
            /// </summary>
            protected ISession session
            {
                get { return NHibernateSessionManager.Instance.GetSession(); }
            }

            public void BeginTransaction()
            {
                NHibernateSessionManager.Instance.BeginTransaction();
            }

            public void CommitTransaction()
            {
                NHibernateSessionManager.Instance.CommitTransaction();
            }

            public void RollbackTransaction()
            {
                NHibernateSessionManager.Instance.RollbackTransaction();
            }

        #endregion

        #region ----GetById----

        /// <summary>
        ///  Loads an instance of type T from the DB based on its ID.
        /// </summary>
        /// <param name="id"> id de la clase </param>
        /// <param name="shouldLock"> false para ReadOnly y True para autopersistir </param>
        /// <returns> T entity</returns>
        public T GetById(ID id, bool shouldLock)
        {
            T entity;

            if (shouldLock)
            {
                entity = (T) session.Load(persitentType, id, LockMode.Upgrade);
            }
            else
            {
                entity = (T) session.Load(persitentType, id);
            }

            return entity;
        }

        #endregion

        #region ----GetAll----

        /// <summary>
        /// Loads every instance of the requested type with no filtering.
        /// </summary>
        public List<T> GetAll()
        {
            return GetByCriteria();
        }
        public IList GetAllList()
        {
            return GetByCriteriaList();
        }
        #endregion

        #region by ale sfrede : session.Filter(........

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
            ICollection orderedCollection = session.Filter(lista, filterWhere + " " + orderby);
            return orderedCollection;
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
            ICollection orderedCollection = session.Filter(lista, filterWhere + " " + orderby, values, types);
            return orderedCollection;
        }

        #endregion

        #region by ale sfrede : List<T> GetAll(........

        /// <summary>
        /// Counts how many objects will be returned by the GetAll() 
        /// !! revisar !!!
        /// ale sfrede
        /// </summary>
        /// <remarks>
        /// Future NHibernate version will contain a better Count() technique so the current implementation will change to use ICriteria.Count instead of using the GetAll(pFilters) method.
        /// </remarks>
        ///<returns>Returns the amount of objects that meet the criteria specified on the parameters.<returns>
        public int Count()
        {
            int count = GetAll(new List<ICriterion>(), null, null, null, null).Count;
            // Make sure that after the count the session if closed.
            //CloseSession(true);
            return count;
        }

        /// <summary>
        /// Counts how many objects will be returned by the GetAll() method according to the Criteria parameters.
        /// by ale
        /// </summary>
        /// <remarks>
        /// Future NHibernate version will contain a better Count() technique so the current implementation will change to use ICriteria.Count instead of using the GetAll(pFilters) method.
        /// </remarks>
        ///<param name="pFilters">(Optional) Pass a list of criterias that will limit/filter the result.</param>
        ///<returns>Returns the amount of objects that meet the criteria specified on the parameters.<returns>
        public int Count(List<ICriterion> pFilters)
        {
            int count = GetAll(pFilters, null, null, null, null).Count;
            // Make sure that after the count the session if closed.
            // CloseSession(true);
            return count;
        }

        /// <summary>
        /// Get a strongly typed collection of  objects given a list of ICriterion expressions (Filters).
        ///        
        /// by ale sfrede...............
        /// </summary>
        ///<param name="pFilters">(Optional) Pass a list of criterias that will limit/filter the result.</param>
        public List<T> GetAll(List<ICriterion> pFilters)
        {
            return GetAll(pFilters, null, null, null, null);
        }
        /// <summary>
        /// Get a strongly typed collection of  objects given a list of ICriterion expressions (Filters).
        ///        
        /// by ale FSO
        /// </summary>
        ///<param name="pFilters">(Optional) Pass a list of criterias that will limit/filter the result.</param>
        public IList GetAllList(List<ICriterion> pFilters)
        {
            return GetAllList(pFilters, null, null, null, null);
        }
        /// <summary>
        /// Get a strongly typed collection of   objects given a SortExpression + Paging Information.
        /// </summary>
        ///<param name="pSortExpression">(Optional)  Specify a Sorting Expression. 
        ///  Property  DESC  /  Property   
        ///  (Note: This method expects a Property Name.) </param>
        ///<param name="pFirstResult">(Optional) If present it determines a starting row index from the complete DataSource.</param>
        ///<param name="pMaxResult">(Optional) How many object should be retrieved? (Also know as Page Size)</param>
        public List<T> GetAll(String pSortExpression, Int32? pFirstResult, Int32? pMaxResult)
        {
            return GetAll(null, null, pSortExpression, pFirstResult, pMaxResult);
        }
        /// <summary>
        /// Get a strongly typed collection of   objects given a SortExpression + Paging Information.
        /// </summary>
        ///<param name="pSortExpression">(Optional)  Specify a Sorting Expression. 
        ///  Property  DESC  /  Property   
        ///  (Note: This method expects a Property Name.) </param>
        ///<param name="pFirstResult">(Optional) If present it determines a starting row index from the complete DataSource.</param>
        ///<param name="pMaxResult">(Optional) How many object should be retrieved? (Also know as Page Size)</param>
        public IList GetAllList(String pSortExpression, Int32? pFirstResult, Int32? pMaxResult)
        {
            return GetAllList(null, null, pSortExpression, pFirstResult, pMaxResult);
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
        public List<T> GetAll(List<ICriterion> pFilters, String pSQLExpression, String pSortExpression,
                              Int32? pFirstResult, Int32? pMaxResult)
        {
            //TerritoriesCollection pList = new TerritoriesCollection(this);
            List<T> pList = new List<T>();
            try
            {
                ICriteria _criteria = session.CreateCriteria(persitentType);

                if (pFilters != null && pFilters.Count > 0)
                {
                    foreach (ICriterion _filter in pFilters)
                    {
                        _criteria.Add(_filter);
                    }
                }

                // If SQLExpression parameters are passed then modify the Criteria to include them.
                if (!string.IsNullOrEmpty(pSQLExpression))
                {
                    _criteria.Add(Expression.Sql(pSQLExpression));
                }

                // Set the Filter Result
                if (pFirstResult.HasValue)
                {
                    _criteria.SetFirstResult(pFirstResult.Value);
                }
                else
                {
                    _criteria.SetFirstResult(0);
                }
                if (pMaxResult.HasValue)
                {
                    _criteria.SetMaxResults(pMaxResult.Value);
                }
                else
                {
                    _criteria.SetMaxResults(-1);
                }

                if (!String.IsNullOrEmpty(pSortExpression))
                {
                    if (pSortExpression.EndsWith("DESC"))
                    {
                        _criteria.AddOrder(Order.Desc(pSortExpression.Split(' ')[0]));
                    }
                    else
                    {
                        _criteria.AddOrder(Order.Asc(pSortExpression));
                    }
                }
                pList = ConvertToGenericList(_criteria.List());
                // pList.AddRange(_criteria.List());
            }
            catch (Exception ex)
            {
                string _msg = ex.Message;
                throw ex;
            }
            finally
            {
            }
            return pList;
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
        public IList GetAllList(List<ICriterion> pFilters, String pSQLExpression, String pSortExpression,
                              Int32? pFirstResult, Int32? pMaxResult)
        {
            //TerritoriesCollection pList = new TerritoriesCollection(this);
            IList pList = new ArrayList();
            try
            {
                ICriteria _criteria = session.CreateCriteria(persitentType);

                if (pFilters != null && pFilters.Count > 0)
                {
                    foreach (ICriterion _filter in pFilters)
                    {
                        _criteria.Add(_filter);
                    }
                }

                // If SQLExpression parameters are passed then modify the Criteria to include them.
                if (!string.IsNullOrEmpty(pSQLExpression))
                {
                    _criteria.Add(Expression.Sql(pSQLExpression));
                }

                // Set the Filter Result
                if (pFirstResult.HasValue)
                {
                    _criteria.SetFirstResult(pFirstResult.Value);
                }
                else
                {
                    _criteria.SetFirstResult(0);
                }
                if (pMaxResult.HasValue)
                {
                    _criteria.SetMaxResults(pMaxResult.Value);
                }
                else
                {
                    _criteria.SetMaxResults(-1);
                }

                if (!String.IsNullOrEmpty(pSortExpression))
                {
                    if (pSortExpression.EndsWith("DESC"))
                    {
                        _criteria.AddOrder(Order.Desc(pSortExpression.Split(' ')[0]));
                    }
                    else
                    {
                        _criteria.AddOrder(Order.Asc(pSortExpression));
                    }
                }
                pList = _criteria.List();

            }
            catch (Exception ex)
            {
                string _msg = ex.Message;
                throw ex;
            }
            finally
            {
            }
            return pList;
        }

        public IList GetHQL(String namedQuery, IList kParameters)
        {
            StoredProceduresHandler sph = new StoredProceduresHandler(session);
            IList listaTmp;

            IDataParameter[] parameters = new IDataParameter[kParameters.Count]; //+1
            int c = 0;
            foreach (kParameter p in kParameters)
            {
                parameters[c] = new SqlParameter(p.ParamName, p.Tipo);
                parameters[c].Value = p.Value;
                c ++;
            }
            //parameters[0] = new SqlParameter("IdPersona", SqlDbType.Int);
            //parameters[0].Value =5;


            listaTmp = sph.ExecuteNamedQuery(namedQuery, parameters);
            return listaTmp;
        }

        #endregion

        #region ----GetByCriteria----

        /// <summary>
        /// se puede acceder por NHibernateDaoFactory.PersonaDaoNHibernate personaDaoNHibernate = new NHibernateDaoFactory.PersonaDaoNHibernate() 
        /// ver http://www.hibernate.org/hib_docs/nhibernate/html/querycriteria.html
        /// ----------------------------------------------------------------------------------------------------------------------------
        /// Loads every instance of the requested type using the supplied <see cref="ICriterion" />.
        /// If no <see cref="ICriterion" /> is supplied, this behaves like <see cref="GetAll" />.
        /// </summary>
        public List<T> GetByCriteria(params ICriterion[] criterion)
        {
            ICriteria criteria = session.CreateCriteria(persitentType);

            foreach (ICriterion criterium in criterion)
            {
                criteria.Add(criterium);
            }

            return ConvertToGenericList(criteria.List());
        }
        public IList GetByCriteriaList(params ICriterion[] criterion)
        {
            ICriteria criteria = session.CreateCriteria(persitentType);

            foreach (ICriterion criterium in criterion)
            {
                criteria.Add(criterium);
            }

            return criteria.List();
        }

        #endregion

        #region ----GetByExample----

        public List<T> GetByExample(T exampleInstance, params string[] propertiesToExclude)
        {
            ICriteria criteria = session.CreateCriteria(persitentType);
            Example example = Example.Create(exampleInstance);

            foreach (string propertyToExclude in propertiesToExclude)
            {
                example.ExcludeProperty(propertyToExclude);
            }

            criteria.Add(example);

            return ConvertToGenericList(criteria.List());
        }

        #endregion

        #region ----GetUniqueByExample----

        /// <summary>
        /// Looks for a single instance using the example provided.
        /// </summary>
        /// <exception cref="NonUniqueResultException" />
        public T GetUniqueByExample(T exampleInstance, params string[] propertiesToExclude)
        {
            List<T> foundList = GetByExample(exampleInstance, propertiesToExclude);

            if (foundList.Count > 1)
            {
                //throw new NonUniqueResultException(foundList.Count);
                return foundList[0];
            }

            if (foundList.Count > 0)
            {
                return foundList[0];
            }
            else
            {
                return default(T);
            }
        }

        #endregion

        #region ----SortCollection MultiPropertyComparer   by ale----

        /// <summary>
        /// MultiPropertyComparer SortCollection by ale
        /// from 
        /// http://www.paulstovell.net/Posts/Post.aspx?postId=613c2327-22d4-42a5-8cc2-8dab06058cb9
        /// 
        /// </summary>
        /// <param name="listObjects">List<T></param>
        /// <param name="sortableProperty"> Property de la entidad <T> .property</param>
        /// <param name="sortDirection">SortDirection.Descending</param>
        /// <returns>List<T> orderedCollection</returns>
        public List<T> SortCollection(List<T> listObjects, string sortableProperty, SortDirection sortDirection)
        {

            MultiPropertyComparer<T> multiPropertyComparer = new MultiPropertyComparer<T>();
            SortableProperty property = new SortableProperty(sortableProperty, sortDirection);
            multiPropertyComparer.SortableProperties.Add(property);
            List<T> orderedCollection = listObjects;
            orderedCollection.Sort(multiPropertyComparer);

            return orderedCollection;
        }

        #endregion

        #region ----ConvertToGenericCollection / ConvertToGenericList  ----

                /// <summary>
                /// ConvertToGenericCollection ICollection to  List<T>
                /// </summary>
                /// <param name="listObjects"></param>
                /// <returns></returns>
                protected List<T> ConvertToGenericCollection(ICollection listObjects)
                {
                    List<T> convertedList = new List<T>();

                    foreach (object listObject in listObjects)
                    {
                        convertedList.Add((T) listObject);
                    }

                    return convertedList;
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
                        convertedList.Add((T) listObject);
                    }

                    return convertedList;
                }

        #endregion

        #region ----Save SaveOrUpdate Delete  ----

        /// <summary>
        /// For entities that have assigned ID's, you must explicitly call Save to add a new one.
        /// See http://www.hibernate.org/hib_docs/reference/en/html/mapping.html#mapping-declaration-id-assigned.
        /// </summary>
        public T Save(T entity)
        {
            session.Save(entity);
            return entity;
        }

        /// <summary>
        /// For entities with automatatically generated IDs, such as identity, SaveOrUpdate may 
        /// be called when saving a new entity.  SaveOrUpdate can also be called to update any 
        /// entity, even if its ID is assigned.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public T SaveOrUpdate(T entity)
        {
            session.SaveOrUpdate(entity);
            return entity;
        }
        /// <summary>
        /// Elimina de la persistencia de datos el Objeto seleccionado
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(T entity)
        {
            session.Delete(entity);
        }

        /// <summary>
        /// Actualiza la información a persistir del Objeto seleccionado
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public T Update(T entity)
        {
            session.Update(entity);
            return entity;
        }

        #endregion

    }

    #region **********----  public class kParameter----*****************

    /// <summary>
    /// para usar con stores
    /// </summary>
    public class kParameter
    {
        public kParameter()
        {
        }

        public string ParamName;
        public SqlDbType Tipo;
        public object Value;
    }

    #endregion
}