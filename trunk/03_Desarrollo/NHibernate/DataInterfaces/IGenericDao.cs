using System;
using System.Collections;
using System.Collections.Generic;
using NHibernate.Expression;
using NHibernate.Type;

namespace FSO_NHDATA.DataInterfaces
{
    /// <summary>
    /// interface IGenericDao
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="ID"></typeparam>
    public interface IGenericDao<T, ID>
    {
        /// <summary>
        /// GetById
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="shouldLock"> shouldLock = FALSE ES PARA READ ONLY  </param>
        /// <returns></returns>
        T GetById(ID id, bool shouldLock);
        /// <summary>
        /// GetAll
        /// </summary>
        /// <returns></returns>
        List<T> GetAll();
        /// <summary>
        /// GetByExample
        /// </summary>
        /// <param name="exampleInstance">Obj de ejemplo que se usa para filtrar las mismas propiedades que él.</param>
        /// <param name="propertiesToExclude">propertiesToExclude</param>
        /// <returns></returns>
        List<T> GetByExample(T exampleInstance, params string[] propertiesToExclude);

        /// <summary>
        /// GetUniqueByExample Obj de ejemplo que se usa para filtrar las mismas propiedades que él.
        /// </summary>
        /// <param name="exampleInstance"></param>
        /// <param name="propertiesToExclude"></param>
        /// <returns></returns>
        T GetUniqueByExample(T exampleInstance, params string[] propertiesToExclude);

        /// <summary>
        /// Save(T entity)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        T Save(T entity);

        /// <summary>
        /// SaveOrUpdate
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        T SaveOrUpdate(T entity);

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);




        #region ....... Metodos sumados por ALE desde  http://www.hibernate.org/hib_docs/nhibernate/html/queryhql.html#queryhql-examples ..................

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
        List<T> SortCollection(List<T> listObjects, string sortableProperty, SortDirection sortDirection);
        
        #endregion

        #region ....... Metodos sumados por ALE desde GenWise ..................


        /// <summary>
        /// GetHQL / martin 2
        /// </summary>
        /// <param name="namedQuery"></param>
        /// <param name="kParameters"></param>
        /// <returns></returns>
        IList GetHQL(String namedQuery, IList kParameters);
        
        /// <summary>
        /// By ale
        /// </summary>
        /// <param name="pFilters"></param>
        /// <returns></returns>
        List<T> GetAll(List<ICriterion> pFilters);

        /// <summary>
        /// Get a strongly typed collection of   objects given a SortExpression + Paging Information.
        /// by ale
        /// </summary>
        ///<param name="pSortExpression">(Optional)  Specify a Sorting Expression. 
        ///  Property  DESC  /  Property  ASC
        ///  (Note: This method expects a Property Name.) </param>
        ///<param name="pFirstResult">(Optional) If present it determines a starting row index from the complete DataSource.</param>
        ///<param name="pMaxResult">(Optional) How many object should be retrieved? (Also know as Page Size)</param>
        List<T> GetAll(System.String pSortExpression, System.Int32? pFirstResult, System.Int32? pMaxResult);
        
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
        List<T> GetAll(List<ICriterion> pFilters, System.String pSQLExpression, System.String pSortExpression, System.Int32? pFirstResult, System.Int32? pMaxResult);
        
        /// <summary>
        /// Counts how many objects will be returned by the GetAll() 
        /// !! revisar !!!
        /// ale sfrede
        /// </summary>
        /// <remarks>
        /// Future NHibernate version will contain a better Count() technique so the current implementation will change to use ICriteria.Count instead of using the GetAll(pFilters) method.
        /// </remarks>
        int Count();


        /// <summary>
        /// Counts how many objects will be returned by the GetAll() method according to the Criteria parameters.
        /// by ale
        /// </summary>
        /// <remarks>
        /// Future NHibernate version will contain a better Count() technique so the current implementation will change to use ICriteria.Count instead of using the GetAll(pFilters) method.
        /// </remarks>
        ///<param name="pFilters">(Optional) Pass a list of criterias that will limit/filter the result.</param>
        /// <returns></returns>
        int Count(List<ICriterion> pFilters);

        
        
        #endregion 


        
        #region ....... Metodos sumados por ALE session.Filter ..................
        /// <summary>
        /// filtra y ordena colecciones r retorna una nueva coleccion
        ///  "where this.Descripcion='des4'  order by this.Descripcion"
        /// </summary>
        /// <param name="lista">IList tipo BAG</param>
        /// <param name="filterWhere">where this.Descripcion='des4' </param>
        /// <param name="orderby">order by this.Descripcion</param>
        /// <returns></returns>
        ICollection FilterSortCollectionBAG(IList lista, string filterWhere, string orderby);
      

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
        ICollection FilterSortCollectionBAG(IList lista, string filterWhere, string orderby, object[] values, IType[] types);
       
        
        #endregion
    }
}
