using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FSO_NH.Core;
using System.Reflection;
using System.Collections;
using FSO_NH.bb;
using FSO_NH.UserInterfaz;

namespace Controles
{
    public delegate void SeleccionDeObjeto (Object ObjetoSeleccionado);
    public enum ModoControl{DESCRIPCION, COMBO}
    public partial class FSOCombo : UserControl
    {
        private ModoControl _ModoActual;
        private IFSOComboDataSource _DS;
        private DomainObject _ObjetoActual;
        public event SeleccionDeObjeto ObjetoSeleccionado;
        private ArrayList _LocalDataSet;
        public FSOCombo()
        {
            _FiltrosCampos = "";
            _FiltrosValores = "";
            InitializeComponent();
            ModoActual = ModoControl.DESCRIPCION;
            _AnchoLabel = 190;
            _AnchoTxtCod = 100;
            _AnchoBoton = 20;
            AjustarTamano();
            if (DesignMode)
            {
                txtCod.Enabled = false;
            }
            
        }
        ~FSOCombo()
        {
            txtCod.Dispose();
            cbo.Dispose();
            this.Dispose();                
        }

        #region PropiedadesPublicas
                    private string _FiltrosValores;

                    public string FiltrosValores
                    {
                        get { return _FiltrosValores; }
                        set {
                            if (value == null)
                                _FiltrosValores = value;
                            else
                                _FiltrosValores = "";

                            ObjetoActual = null;
                            if (ModoActual == ModoControl.COMBO)
                                RefreshDataSource(false );
                        }
                    }

                    private string _FiltrosCampos;
                    public string FiltrosCampos
                    {
                        set
                        {
                            if (value == null)
                                _FiltrosCampos = "";
                            else
                                _FiltrosCampos = value;

                            ObjetoActual = null;
                            if (ModoActual == ModoControl.COMBO)
                                RefreshDataSource(false);
                        }
                        get { return _FiltrosCampos; }
                    }

                    private int _AnchoLabel;
                    public int AnchoLabel
                    {
                        get { return _AnchoLabel; }
                        set
                        {
                            _AnchoLabel = value;
                            AjustarTamano();
                        }
                    }

                    private int _AnchoBoton;
                    public int AnchoBoton
                    {
                        get { return _AnchoBoton; }
                        set
                        {
                            _AnchoBoton = value;
                            AjustarTamano();
                        }
                    }

                    private int _AnchoTxtCod;
                    public int AnchoTxtCod
                    {
                        get { return _AnchoTxtCod; }
                        set
                        {
                            _AnchoTxtCod = value;
                            AjustarTamano();
                        }
                    }

                    public string Texto
                    {
                        set { lblCaption.Text = value; Invalidate(); }
                        get { return lblCaption.Text; }
                    }

                    public Int32 IdSelected
                    {
                        get
                        {
                            if (ObjetoActual != null)
                            {
                                return ((DomainObject)ObjetoActual).ID;
                            }
                            else
                            {
                                return -1;
                            }
                        }
                        set
                        {
                            if (_DS != null)                               
                                ObjetoActual = GetByIdentificador(value);
                            else
                                ObjetoActual = null;
                        }
                    }

                    private ModoControl ModoActual
                    {
                        set
                        {
                            _ModoActual = value;
                            if (ModoActual == ModoControl.DESCRIPCION)
                            {
                                cbo.Visible = false;
                                lblDesc.Visible = true;
                                btnSearch.Visible = true;
                            }
                            else
                            {
                                
                                RefreshDataSource(false);
                                 
                                cbo.Visible = true;
                                lblDesc.Visible = false;
                                btnSearch.Visible = false;
                                cbo.Focus();
                                //if (ObjetoActual == null)
                                //{
                                //    cbo.SelectedIndex = -1;  
                                //    SelectedIndex = 0;
                                //}
                                if (txtCod.Text.Trim() != "")
                                {
                                    DomainObject DO=GetByCodigo(txtCod.Text);
                                    if(DO!=null)
                                        cbo.SelectedValue = GetByCodigo(txtCod.Text).ID;
                                }
                                else {
                                    if (cbo.Items.Count > 0)
                                    {
                                        cbo.SelectedIndex = -1;
                                        SelectedIndex = 0;
                                    }
                                    else {
                                        ModoActual = ModoControl.DESCRIPCION;                                       
                                    }
                                    
                                }
                            }
                        }
                        get { return _ModoActual; }
                    }

                    public IList DataSource
                    {
                        set {
                            _FiltrosCampos = "";
                            _FiltrosValores = "";
                            ObjetoActual = null;
                            cbo.DataSource = value;
                            cbo.DisplayMember = "MiDescripcion";
                            cbo.ValueMember = "ID";
                            _LocalDataSet = null;
                        }
                    }
                    public Int32 SelectedIndex
                    {
                        set { 
                            RefreshDataSource(false); 
                            cbo.SelectedIndex = value; 
                        }
                    }
                    public ComboBoxStyle DropDownStyle
                    {
                        get { return cbo.DropDownStyle; }
                        set { cbo.DropDownStyle = value; }
                    }

                    private string _CodigoActual;

                    public string CodigoActual
                    {
                        get { return txtCod.Text ; }
                        set { 
                                _CodigoActual = value;
                                txtCod.Text = _CodigoActual;
                                
                            }
                    }

                    public Object ObjetoActual
                    {
                        get { return _ObjetoActual; }
                        set
                        {
                            if (_ObjetoActual != null && value != null)
                            {
                         
                                if (_ObjetoActual.ID != ((DomainObject)value).ID)
                                {
                                    
                                    _ObjetoActual = ((DomainObject)value);
                                    SetObjectSelectedDescription();
                                    txtCod.Text = ((DomainObject)value).MiCodigo;

                                    DispararEventoSeleccion();
                                }
                            }
                            else {
                                    _ObjetoActual = ((DomainObject)value);
                                    if (_ObjetoActual != null)
                                        txtCod.Text = _ObjetoActual.MiCodigo;
                                    else
                                        txtCod.Text = "";
                                    SetObjectSelectedDescription();
                                    DispararEventoSeleccion();
                               
                            }
                        }
                    }

     
        #endregion
        public void RefreshDataSource(bool ForzarResetDS)
        {

            if (cbo.DataSource == null || ForzarResetDS)
            {
                if (_DS != null)
                {
                    cbo.DataSource = _DS.GetDataSource(GetFiltros());
                    cbo.DisplayMember = "MiDescripcion";
                    cbo.ValueMember = "ID";
                }
            }
        }


        private void ObtenerDataSet()
        {
            RefreshDataSource(false);
            

            if (cbo.DataSource != null)
            {
                if (_LocalDataSet == null)
                {
                    _LocalDataSet = new ArrayList();
                    foreach (Object o in ((IList)cbo.DataSource))
                    {
                        _LocalDataSet.Add((DomainObject)o);
                    }
                }
            }
       
        }
    

        public void SetComboBinding(IFSOComboDataSource DS, string FiltrosCampos, string FiltrosValores)
        {
            try
            {
                _DS = DS;
                _FiltrosCampos = FiltrosCampos;
                _FiltrosValores = FiltrosValores;
                _LocalDataSet = null;
                 cbo.DataSource=null;
            }
            catch (Exception ex)
            { 

            }
        }
        
        public void ItemsClear()
        {
            cbo.DataSource = null;
            _LocalDataSet = null;
            cbo.Items.Clear();
            cbo.Refresh();
        }

        private string GetFiltros()
        {
            _FiltrosCampos = FiltrosCampos.Replace(',',';');
            _FiltrosValores = FiltrosValores.Replace(',', ';');
            string[] f = FiltrosCampos.Split(';');
            string[] v = FiltrosValores.Split(';');
            string FiltroFinal = "";
            if (_FiltrosCampos == "" || _FiltrosValores == "")
                return "";
            int i = 0;
            foreach (string s in f)
            {
                FiltroFinal = s + "=@p" + i.ToString() + ";";
            }
            i=0;
            foreach (string t in v)
            {
                FiltroFinal = FiltroFinal.Replace("@p" + i.ToString(), t );
            }
            if (FiltroFinal.Trim() != "=;")
                return  FiltroFinal.Substring(0, FiltroFinal.Length - 1);
            else
                return "";
        }
        private void DispararEventoSeleccion()
        {
            if (ObjetoSeleccionado != null)
                ObjetoSeleccionado(_ObjetoActual);
        }
        private void SetObjectSelectedDescription()
        {
            if (_ObjetoActual != null)
                {
                lblDesc.ForeColor = Color.Navy;
                lblDesc.Text = _ObjetoActual.MiDescripcion;
            }
            else {
                lblDesc.Text = "[Sin Selección]";
                lblDesc.ForeColor = Color.Maroon;
            }
        }
        private void AjustarTamano()
        {
            int Espacio = 5;
            lblCaption.Left = 0;
            lblCaption.Width = _AnchoLabel;

            txtCod.Left = lblCaption.Width + Espacio;
            txtCod.Width = _AnchoTxtCod;

            btnSearch.Left = txtCod.Left + txtCod.Width + Espacio;
            btnSearch.Width = _AnchoBoton;

            cbo.Left =txtCod.Left+txtCod.Width + Espacio;
            cbo.Width = this.Width - (cbo.Left);//(txtCod.Left + txtCod.Width + Espacio + 1); ;

            lblDesc.Left = btnSearch.Left + btnSearch.Width + Espacio;
            lblDesc.Width = this.Width - (btnSearch.Width + btnSearch.Left + Espacio);

            Invalidate();

        }

        #region Eventos
            private void cbo_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (cbo.SelectedIndex >= 0)
                {
                    Int32 Id;
                    try
                    {
                        Id = Convert.ToInt32(cbo.SelectedValue);
                    }
                    catch
                    {
                        Id = ((DomainObject)cbo.SelectedValue).ID;
                    }
                    
                    ObjetoActual = GetByIdentificador(Id);
                }
                else
                {
                    ObjetoActual = null;

                }
            }

            private void cbo_Leave(object sender, EventArgs e)
            {
                ModoActual = ModoControl.DESCRIPCION;
            }
            private void btnSearch_Click(object sender, EventArgs e)
            {
                
                ModoActual = ModoControl.COMBO;
            }

            public void txtCod_Leave(object sender, EventArgs e)
            {
                if (_DS != null)
                {                                 
                    ObjetoActual = GetByCodigo(txtCod.Text);
                }
                if (ObjetoActual == null)
                {
                    txtCod.Text = "";
                }
            }
            private void FSOCombo_Resize(object sender, EventArgs e)
            {
                AjustarTamano();
            }

            private void FSOCombo_SizeChanged(object sender, EventArgs e)
            {
                AjustarTamano();
            }

            private void FSOCombo_Enter(object sender, EventArgs e)
            {
                ModoActual = ModoControl.DESCRIPCION;
                txtCod.Focus();
            }

        #endregion


        private DomainObject GetByIdentificador(Int32 ID)
        {
            if (ID > 0)
            {
                ObtenerDataSet();
                if (_LocalDataSet != null)
                {
                    foreach (DomainObject d in _LocalDataSet)
                    {
                        if (d.ID == ID)
                        {
                            return d;
                        }
                    }
                }
            }
            return null;
        }
        private DomainObject GetByCodigo(String Codigo)
        {

            if (Codigo.Trim() != "")
            {
                ObtenerDataSet();
                if (_LocalDataSet != null)
                {                    
                    foreach (DomainObject d in _LocalDataSet)
                    {
                        if (d.MiCodigo.ToUpper().Trim() == Codigo.ToUpper().Trim())
                        {
                            return d;
                        }
                    }
                }
            }
            return null;
        }

        private void txtCod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 || e.KeyCode == Keys.F4)
            {
                ModoActual = ModoControl.COMBO;
            }
            if (e.KeyCode == Keys.Enter)
            {
                ModoActual = ModoControl.DESCRIPCION;
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void cbo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

    }
 
}
