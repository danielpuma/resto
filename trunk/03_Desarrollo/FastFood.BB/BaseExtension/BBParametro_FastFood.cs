using System;
using System.Collections.Generic;
using System.Text;
using FSO.NH.ClasesBase.BB;
using FSO.NH.ClasesBase.Core;
using FastFood.BB.CoreExtension;
using FastFood.Core;
using FastFood.BB.Syncro;



namespace FastFood.BB.BaseExtension
{
    public class BBParametro_FastFood:BBParametro
    {
        public BBParametro_FastFood(String pSubTipo):base(pSubTipo)
        { }
        public override Parametro GetNuevo()
        {
            Parametro MyParam;
            switch (SubTipo)
            {
                case "ListaPrecio": MyParam = new ListaDePrecio(); break;
                case "GrupoArticulo": MyParam = new GrupoArticulo(); break;
                case "Mesa": MyParam = new Mesa(); break;
                default: return base.GetNuevo(); 
               
            }


            MyParam.Codigo = "";
            MyParam.Nombre = "";
            MyParam.SubTipo = SubTipo;
            return (Parametro)MyParam;
        }
        public override Parametro GetById(int id, bool shouldLock)
        {
            
            switch (SubTipo)
            {

                case "ListaPrecio":
                    {
                        FSO.NH.bb.FNegocio<ListaDePrecio> F = new FSO.NH.bb.FNegocio<ListaDePrecio>();
                        return (Parametro)F.GetById(id, shouldLock);
                    }
                    break;

                case "GrupoArticulo":
                    {
                        FSO.NH.bb.FNegocio<GrupoArticulo> F = new FSO.NH.bb.FNegocio<GrupoArticulo>();
                        return (Parametro)F.GetById(id, shouldLock);
                    }
                    break;

                case "Mesa":
                    {
                        FSO.NH.bb.FNegocio<Mesa> F = new FSO.NH.bb.FNegocio<Mesa>();
                        return (Parametro)F.GetById(id, shouldLock);
                    }
                    break;
                default: return base.GetById(id, shouldLock); 
               
            }                           
        }
        public override void Guardar(Parametro dominio)
        {
            BBDetalleExportacion BBDEx = new BBDetalleExportacion();
            dominio.FechaGrabacion = DateTime.Now;
            switch (SubTipo)
            {
  
                case "TipoDeDoc":
                    
                    BBDEx.MarcarParaReexportar(dominio);
                    base.Guardar(dominio); 
                    break;

                case "ListaPrecio":
                    BBListaDePrecio BBLP = new BBListaDePrecio();
                    BBLP.Guardar((ListaDePrecio)dominio);
                    break;

                case "GrupoArticulo":
                    BBDEx.MarcarParaReexportar(dominio);
                    BBGrupoArticulo BBMA = new BBGrupoArticulo();
                    BBMA.Guardar((GrupoArticulo)dominio);
                    break;
                case "Mesa":
                    BBDEx.MarcarParaReexportar(dominio);
                    BBMesa BBMe = new BBMesa();
                    BBMe.Guardar((Mesa)dominio);
                    break;
                default: base.Guardar(dominio);  break;
            }

        }
        public List<Parametro> GetObjetosAExportar(Exportacion MyObject)
        {
            return this.GetAll();
        }
 
    }
}
