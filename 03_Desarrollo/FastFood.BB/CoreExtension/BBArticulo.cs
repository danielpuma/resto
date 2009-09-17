using System;
using System.Collections.Generic;
using System.Text;
using FSO.NH.bb;
using FastFood.Core;
using FSO.NHDATA.DataInterfaces;
using FSO.NH.UserInterfaz;
using NHibernate.Criterion;
using FSO_NH.log4Net;
using System.Collections;
using NHibernate;
using FastFood.Core.Domain.Consultas;

namespace FastFood.BB.CoreExtension
{
    public class BBArticulo : FNegocio<Articulo>, IGenericDao<Articulo, Int32>, IFSOComboDataSource
    {
        public List<Articulo> GetFiltered(string Codigo, string Nombre, int IdGrupo)
        {
            try
            {
                List<ICriterion> filtrosActivos = new List<ICriterion>();
                if (IdGrupo > 0)
                {
                    ICriterion f1 = Expression.Eq("MyGrupoArticulo.ID", IdGrupo);
                    filtrosActivos.Add(f1);
                }
                if (Codigo.Trim() != "")
                {
                    ICriterion f2 = Expression.InsensitiveLike("Codigo", Codigo, MatchMode.Start);
                    filtrosActivos.Add(f2);
                }
                if (Nombre.Trim() != "")
                {
                    ICriterion f3 = Expression.InsensitiveLike("Nombre", Nombre, MatchMode.Start);
                    filtrosActivos.Add(f3);
                }
                return SortCollection(this.GetAll((filtrosActivos)), "Nombre", FSO.NHDATA.SortDirection.Ascending);
            }
            catch (Exception ex)
            {
                FSOLog4Net.LogDebug("Error Al Buscar Artículo: " + ex.Message);
                return new List<Articulo>();
            }
        }

        public Articulo GetNuevo()
        {
            return new Articulo();
        }
        public override void OnPostSaveData(Articulo dominio)
        {
            if (!dominio.EsCompuesto)
            {
                BBComposicionArticulo BBCA = new BBComposicionArticulo();
                BBCA.BorrarPorArticulo(dominio);
            }
        }
        public override void ValidarDatos(Articulo dominio)
        {
            
            if (dominio.Codigo.Trim() == "")
            {
                throw new Exception("El Código del Artículo es obligatorio");
            }
            if (dominio.Nombre.Trim() == "")
            {
                throw new Exception("El Nombre del Artículo es obligatorio");
            }
        }

        public IList<Ranking> GetRanking(DateTime Desde, DateTime Hasta, int IdMesa, int IDMozo )
        {
            try
            {
                    IQuery query = Session.GetNamedQuery("spRankingPorArticulo");
                    query.SetDateTime("FechaDesde", Desde);
                    query.SetDateTime("FechaHasta", Hasta);
                    query.SetInt32("IdMesa", IdMesa);
                    query.SetInt32("IdUsuario", IDMozo);
                    return query.List<Ranking>();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void GetStock(ref Articulo MyArticulo)
        {
            try
            {
                if (MyArticulo.ManejaStock)
                {
                    IQuery query = Session.GetNamedQuery("spConsultaStock");
                    query.SetInt32("IdArticulo", MyArticulo.ID);
                    IList<Stock> s = query.List<Stock>();
                    if (s.Count > 0)
                    {
                        MyArticulo.MyStock = s[0].MyStock;
                    }   
                }
            }
            catch (Exception ex)
            {
 
            }
        }
        public decimal GetStockCantidad(Articulo MyArticulo, DateTime FechaHasta)
        {
            try
            {
                if (MyArticulo.ManejaStock)
                {
                    IQuery query = Session.GetNamedQuery("spConsultaStockPorFecha");
                    query.SetInt32("xID", MyArticulo.ID);
                    query.SetString("FechaHasta", FechaHasta.AddDays(-1).ToString("yyyyMMdd") + " 23:59");
                    IList<Stock> s = query.List<Stock>();
                    if (s.Count > 0)
                    {
                        return s[0].MyStock;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public decimal GetStockCantidad( Articulo MyArticulo)
        {
            try
            {
                if (MyArticulo.ManejaStock)
                {
                    IQuery query = Session.GetNamedQuery("spConsultaStock");
                    query.SetInt32("xID", MyArticulo.ID);
                    IList<Stock> s = query.List<Stock>();
                    if (s.Count > 0)
                    {
                        return s[0].MyStock;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public List<Articulo> GetFiltered(string Codigo, string Nombre, int IdGrupo, bool CalcularStock, bool SoloArticulosConStock, bool SoloArticulosConStockCritico)
        {
            try
            {
                List<ICriterion> filtrosActivos = new List<ICriterion>();
                if (IdGrupo > 0)
                {
                    ICriterion f1 = Expression.Eq("MyGrupoArticulo.ID", IdGrupo);
                    filtrosActivos.Add(f1);
                }
                if (Codigo.Trim() != "")
                {
                    ICriterion f2 = Expression.InsensitiveLike("Codigo", Codigo, MatchMode.Start);
                    filtrosActivos.Add(f2);
                }
                if (Nombre.Trim() != "")
                {
                    ICriterion f3 = Expression.InsensitiveLike("Nombre", Nombre, MatchMode.Start);
                    filtrosActivos.Add(f3);
                }
                if (SoloArticulosConStock || CalcularStock || SoloArticulosConStockCritico)
                {
                    ICriterion f4 = Expression.Eq("ManejaStock", true);
                    filtrosActivos.Add(f4);
                }
                if (CalcularStock || SoloArticulosConStockCritico)
                {
                    List<Articulo> lista = SortCollection(this.GetAll((filtrosActivos)), "Nombre", FSO.NHDATA.SortDirection.Ascending);
                    List<Articulo> listafinal = new List<Articulo>();
                    foreach (Articulo a in lista)
                    {

                        a.MyStock = GetStockCantidad(a);
                        if (SoloArticulosConStockCritico)
                        {
                            if (a.PuntoDePedido >= a.MyStock)
                            {
                                listafinal.Add(a);
                            }
                        }
                        else {
                            listafinal.Add(a);
                        }
                    }
                    return listafinal;
                }
                else
                {
                    return SortCollection(this.GetAll((filtrosActivos)), "Nombre", FSO.NHDATA.SortDirection.Ascending);
                }
            }
            catch (Exception ex)
            {
                FSOLog4Net.LogDebug("Error Al Buscar Artículo: " + ex.Message);
                return new List<Articulo>();
            }
        }
    }

}
