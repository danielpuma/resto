using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FSO.NH.Seguridad.BB;
using FSO.NH.Auditoria;
using FSO.NH.Core;

namespace FastFood.BASE
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }
        protected void ControlDeSeguridad(string PermisoSolicitado, Button _cmdGuardar, Button _CmdDelete)
        {

            BBUsuario BBU = new BBUsuario();
            if (!BBU.TienePermiso(Win32Session.UsuarioActual, PermisoSolicitado + "Admin"))
            {
                if(_cmdGuardar!=null)
                    _cmdGuardar.Enabled = false;
                if(_CmdDelete !=null)
                    _CmdDelete.Enabled = false;
            }
            

        }

    }
}