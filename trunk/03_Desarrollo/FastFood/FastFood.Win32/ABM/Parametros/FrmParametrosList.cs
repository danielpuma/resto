using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FastFood.Core;

namespace FastFood.Win32.ABM.Mesas
{
    public partial class FrmParametrosList : Form
    {

        private ParametrosSoportados MyType;
        public FrmParametrosList(ParametrosSoportados pParametroClase)
        {
            InitializeComponent();
            MyType = pParametroClase;
            switch (MyType)
            { 
                case ParametrosSoportados.eMesas:
                    this.fsoSimpleParameterABMList1.DS = Mesa.GetFSODataSource();
                    this.fsoSimpleParameterABMList1.Titulo = "Administración de Mesas";
                    break;
                case ParametrosSoportados.sPersonal:
                    this.fsoSimpleParameterABMList1.DS = Personal.GetFSODataSource();
                    this.fsoSimpleParameterABMList1.Titulo = "Administración de Personal";
                    break;
            }            
        }

        private void FrmParametrosList_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmParametrosList_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                this.fsoSimpleParameterABMList1.Buscar();
            }
            if (e.KeyCode == Keys.Insert)
            {
                this.fsoSimpleParameterABMList1.AgregarNuevo();
            }
        }

        private void fsoSimpleParameterABMList1_ActualizacionDeDatosRequerida(Controles.SimpleABMStruct DatosFinales)
        {
            try
            {
                switch (MyType)
                {
                    case ParametrosSoportados.eMesas:
                        {
                            Mesa Obj = new Mesa();
                            if (DatosFinales.ID == 0)
                            {
                                Obj.ID = DatosFinales.ID;
                                Obj.Codigo = DatosFinales.Codigo;
                                Obj.Descripcion = DatosFinales.Descripcion;
                                Obj.Baja = DatosFinales.Baja;
                            }
                            else
                            {
                                Obj = Mesa.GetById(DatosFinales.ID);
                                Obj.Codigo = DatosFinales.Codigo;
                                Obj.Descripcion = DatosFinales.Descripcion;
                                Obj.Baja = DatosFinales.Baja;
                            }
                            Obj.Guardar();
                            break;
                        }
                    case ParametrosSoportados.sPersonal:
                        {
                            Personal Obj = new Personal();
                            if (DatosFinales.ID == 0)
                            {
                                Obj.ID = DatosFinales.ID;
                                Obj.Codigo = DatosFinales.Codigo;
                                Obj.Descripcion = DatosFinales.Descripcion;
                                Obj.Baja = DatosFinales.Baja;
                            }
                            else
                            {
                                Obj = Personal.GetById(DatosFinales.ID);
                                Obj.Codigo = DatosFinales.Codigo;
                                Obj.Descripcion = DatosFinales.Descripcion;
                                Obj.Baja = DatosFinales.Baja;
                            }
                            Obj.Guardar();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fsoSimpleParameterABMList1_EliminarRegistro(int ID, ref bool RefrescarGrilla)
        {
            try
            {
                switch (MyType)
                {
                    case ParametrosSoportados.eMesas:
                        Mesa.DeleteByID(ID);
                        break;
                    case ParametrosSoportados.sPersonal:
                        Personal.DeleteByID(ID);
                        break;
                }
                RefrescarGrilla = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    public enum ParametrosSoportados{eMesas, sPersonal}
}