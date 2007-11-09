using System;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Expression;
using FSO_NH.Core;
using FSO_NHDATA;
using FSO_NHDATA.DataInterfaces;
using FSO_NH.Data;



namespace FSO_NH.bb
{
    /// <summary>
    /// Business layer Generic  --------------
    /// Acceso a Datos del Negocio
    /// </summary>
    /// <typeparam name="T">Entidad NH</typeparam>
    public class FNegocio<T> :  FNegocioBase<T> where T : IDomainObject,new()  
                                
    {
        private string CampoCodigo;
        public FNegocio()
        {
            
            T x = new T();
            CampoCodigo = x.NombreCampoCodigo;
            
        }



        #region Region de Manejo de Sesion

                public void Flush()
                {
                    dao.Session.Flush();
                }
                public void ClearSession()
                {
                    NHibernateSessionManager.Instance.GetSession().Clear();
                }
                public void OpenSession()
                {
                    NHibernateSessionManager.Instance.StartSession();
                }
                public void CloseSession()
                {
                    NHibernateSessionManager.Instance.CloseSession();
                }
            
        #endregion

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
        new public static List<T> SortCollection(List<T> listObjects, string sortableProperty,
                                                 SortDirection sortDirection)
        {

            return dao.SortCollection(listObjects, sortableProperty, sortDirection);
        }

        #region IFSOComboDataSource Members

        public static List<ICriterion> GetFiltrosFromString(string Filtros)
        {
            string[] Parametros = Filtros.Split(';');
            string Campo;
            string Valor;
            List<ICriterion> filtrosActivos = new List<ICriterion>();
            ICriterion filtro;
            if (Filtros.Trim() != "")
            {
                foreach (string p in Parametros)
                {
                    Campo = p.Split('=')[0];
                    Valor = p.Split('=')[1];
                    if (Valor == "TRUE" || Valor == "FALSE")
                    {
                        filtro = Expression.Eq(Campo,(Valor == "TRUE"));
                    }
                    else
                    {
                        filtro = Expression.Eq(Campo, Valor);
                    }
                    filtrosActivos.Add(filtro);
                }
            }
            return filtrosActivos;
        }

        public virtual IList GetDataSource(string Filtros)
        {
            List<ICriterion> filtrosActivos = new List<ICriterion>();
            filtrosActivos = GetFiltrosFromString(Filtros);
            return base.GetAllList(filtrosActivos);
        }





        #endregion

        #region Persistencia
                    public virtual void BorrarDatos(int pId)
                    {

                        T dominio = default(T);
                        try
                        {
                            dominio = GetById(pId, true);
                            Delete(dominio);
                            Flush();
                            CloseSession();
                        }
                        catch (Exception ex)
                        {
                            CloseSession();
                            throw new Exception("Error al Eliminar: " + ex.Message);
                        }

                    }

                    protected void PersistirDatos(T dominio)
                    {
                        Validar(dominio);
                        if (dominio.EsNuevo)
                        {
                            SaveOrUpdate(dominio);
                        }
                        else
                        {

                            Save(dominio);
                        }
                    }
                    public virtual void Validar(T dominio) { } 
        #endregion

    
    }


   



    
}