using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FSO_NH.Core;
using FSO_NH.UserInterfaz;
using System.Collections;

namespace Controles
{
    public delegate void _EliminarRegistro(Int32 ID, ref bool RefrescarGrilla);
    public delegate void _EditarRegistro(Int32 ID, ref bool RefrescarGrilla);
    public delegate void _SeleccionarRegistro(Int32 ID);
    public delegate void _AgregarRegistro(ref bool RefrescarGrilla);

    public partial class FSOSimpleParameterABMList : UserControl
    {
        public event _EliminarRegistro EliminarRegistro;
        public event _EditarRegistro EditarRegistro;
        public event _SeleccionarRegistro SeleccionarRegistro;
        public event _AgregarRegistro AgregarRegistro;
        public event _ActualizacionDeDatosRequerida ActualizacionDeDatosRequerida;
        private IList Lista;
        private IFSOComboDataSource _DS;

        public bool UsarFormularioDeABMSimpre = true;
        public IFSOComboDataSource DS
        {
            get { return _DS; }
            set { _DS = value;
                  InicializarControl();
                }
        }
        private string _PreFiltroCampos = "";

        public string PreFiltroCampos
        {
            get { return _PreFiltroCampos; }
            set { _PreFiltroCampos = value;}
        }
        private string _PreFiltroValores = "";

        public string PreFiltroValores
        {
            get { return _PreFiltroValores; }
            set { _PreFiltroValores = value;}
        }

        private string Filtro;


        public FSOSimpleParameterABMList()
        {
            InitializeComponent();
            
        }
        public string Titulo
        {
            get { return lblTitulo.Text; }
            set { 
                    lblTitulo.Text = value;
                    this.Invalidate();
                }
        }

        private void FSOSimpleParameterABMList_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                InicializarControl();
            }
        }
        public void InicializarControl()
        {
            Filtro = GetFiltros();
            GrillaDatos.Rows.Clear();
            if(Lista!=null)
                Lista.Clear();
            if (_DS != null)
            {
                Lista = _DS.GetDataSource(Filtro);                
            }
            BindearColeccion();
            GrillaDatos.Focus();
        }
        private void BindearColeccion()
        {
            if (Lista != null)
            {

                if (Lista.Count >= 50)
                    GrillaDatos.RowCount = 50;
                else
                    GrillaDatos.RowCount = Lista.Count;
            
            }
            GrillaDatos.Refresh();

        }

        private string GetFiltros()
        {
            string _FiltrosCampos = PreFiltroCampos.Replace(',', ';');
            string _FiltrosValores = PreFiltroValores.Replace(',', ';');
            string[] f = _FiltrosCampos.Split(';');
            string[] v = _FiltrosValores.Split(';');
            string FiltroFinal = "";
            if (_FiltrosCampos == "" || _FiltrosValores == "")
                return "";
            int i = 0;
            foreach (string s in f)
            {
                FiltroFinal = s + "=@p" + i.ToString() + ";";
            }
            i = 0;
            foreach (string t in v)
            {
                FiltroFinal = FiltroFinal.Replace("@p" + i.ToString(), t);
            }
            if (FiltroFinal.Trim() != "=;")
                return FiltroFinal.Substring(0, FiltroFinal.Length - 1);
            else
                return "";
        }

        private void GrillaDatos_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            DomainObject Obj = (DomainObject)Lista[e.RowIndex];
            string valor = "";
            switch(e.ColumnIndex)
            {
                case 0: valor = Obj.ID.ToString(); break;
                case 1: valor = Obj.MiCodigo; break;
                case 2: valor = Obj.MiDescripcion; break;
                case 3: 
                        valor = Obj.Baja?"Inactivo":"Activo";
                        if (Obj.Baja)
                        {
                            PintarGrilla(GrillaDatos, e.RowIndex);
                        }
                        break;
            }

            e.Value = valor;
        }

        private void PintarGrilla(DataGridView dgDatos, Int32 IdRow)
        {
            foreach (DataGridViewCell DG in dgDatos.Rows[IdRow].Cells)
            {
                DG.Style.ForeColor = Color.Red;
                DG.Style.Font = new Font(dgDatos.Font, FontStyle.Bold);
            }
        }


        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        public void Buscar()
        {
            _PreFiltroCampos = "";
            _PreFiltroValores = "";
            string fCodigo = txtCodigo.Text.Trim();
            string fDescripcion = txtDescripcion.Text.Trim();
            if (fCodigo != "")
            {
                _PreFiltroCampos = "Codigo;";
                _PreFiltroValores = fCodigo + ";";
            }
            if (fDescripcion != "")
            {
                _PreFiltroCampos += "Descripcion;";
                _PreFiltroValores += fDescripcion + ";";
            }
            if (_PreFiltroValores.Length > 0)
            {
                _PreFiltroCampos = _PreFiltroCampos.Substring(0, _PreFiltroCampos.Length - 1);
                _PreFiltroValores = _PreFiltroValores.Substring(0, _PreFiltroValores.Length - 1);
            }
            else {
                _PreFiltroCampos = "";
                _PreFiltroValores = "";
            }
            InicializarControl();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 || e.KeyCode == Keys.F4)
            {
                Buscar();
            }
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 || e.KeyCode == Keys.F4)
            {
                Buscar();
            }
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (GrillaDatos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Está a punto de eliminar un registro, ¿Esta Ud. seguro de continuar con la operación?", "Advertencia de Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    if (EliminarRegistro != null)
                    { 
                        bool Refresh=true;
                        EliminarRegistro(GetSelectedID(),ref Refresh);
                        if (Refresh)
                        {
                            Buscar();
                        }
                    }
                }
            }
        }
        private Int32 GetSelectedID()
        {
            Int32 ID;
            try
            {
                ID = Convert.ToInt32(GrillaDatos.SelectedRows[0].Cells[0].Value);
                return ID;
            }
            catch {
                return -1;
            }
        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            EditarSeleccion();
        }
        public void EditarSeleccion()
        {
            if (GrillaDatos.SelectedRows.Count > 0)
            {


                if (UsarFormularioDeABMSimpre)
                {
                    frmSimpleABMUpdate frmABM = new frmSimpleABMUpdate(ReadDataToEdit());
                    frmABM.ActualizacionDeDatosRequerida += new _ActualizacionDeDatosRequerida(frmABM_ActualizacionDeDatosRequerida);
                    
                    frmABM.ShowDialog(this);
                    Buscar();
                }
                else
                {
                    if (EditarRegistro != null)
                    {
                        bool Refresh = true;
                        EditarRegistro(GetSelectedID(), ref Refresh);
                        if (Refresh)
                        {
                            Buscar();
                        }
                    }
                }
            }
        }
        private SimpleABMStruct ReadDataToEdit()
        {
            SimpleABMStruct data = new SimpleABMStruct();
            if (GrillaDatos.SelectedRows.Count > 0)
            {
                
                data.ID = Convert.ToInt32(GrillaDatos.SelectedRows[0].Cells[0].Value);
                data.Codigo = GrillaDatos.SelectedRows[0].Cells[1].Value.ToString();
                data.Descripcion = GrillaDatos.SelectedRows[0].Cells[2].Value.ToString();
                string baja = GrillaDatos.SelectedRows[0].Cells[3].Value.ToString();
                data.Baja = baja == "Inactivo" ? true : false;
               
            }
            return data;
        }
        private void cmdNuevo_Click(object sender, EventArgs e)
        {

            AgregarNuevo();
   
        }
        public void AgregarNuevo()
        {
            if (UsarFormularioDeABMSimpre)
            {
                frmSimpleABMUpdate frmABM = new frmSimpleABMUpdate(new SimpleABMStruct());
                frmABM.ActualizacionDeDatosRequerida += new _ActualizacionDeDatosRequerida(frmABM_ActualizacionDeDatosRequerida);
                frmABM.ShowDialog(this);
                Buscar();
            }
            else
            {
                if (AgregarRegistro != null)
                {
                    bool Refresh = true;
                    AgregarRegistro(ref Refresh);
                    if (Refresh)
                    {
                        Buscar();
                    }
                }
            }
        }
        void frmABM_ActualizacionDeDatosRequerida(SimpleABMStruct DatosFinales)
        {
            if (ActualizacionDeDatosRequerida != null)
                ActualizacionDeDatosRequerida(DatosFinales);
        }

        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {
            if (GrillaDatos.SelectedRows.Count > 0)
            {
                if (SeleccionarRegistro != null)
                {
                    SeleccionarRegistro(GetSelectedID());
                }
            }
        }

        private void GrillaDatos_DoubleClick(object sender, EventArgs e)
        {
            EditarSeleccion();
        }

        private void GrillaDatos_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                if (GrillaDatos.Rows.Count < Lista.Count)
                {
                    Int32 RowsAdded = 50;
                    if (GrillaDatos.Rows.Count + RowsAdded > Lista.Count)
                        RowsAdded = Lista.Count - GrillaDatos.Rows.Count;
                    GrillaDatos.RowCount += RowsAdded;
                }

            }
        }

    }
}
