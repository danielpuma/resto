using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using FSO.NH.Core;
using FastFood.BB.CoreExtension;

namespace WinFastFood.Reportes
{
    public partial class frmReporteListaPrecio : Form
    {
        public frmReporteListaPrecio()
        {
            InitializeComponent();
        }

        private void cboLDP_ObjetoSeleccionado(object ObjetoSeleccionado)
        {
            if (ObjetoSeleccionado != null)
            {
                BBPedido BT = new BBPedido();
                Cursor.Current = Cursors.WaitCursor;
                ReportDocument rptComp = new ReportDocument(); //(ReportDocument)crv.ReportSource;
                rptComp.Load(Environment.CurrentDirectory + "\\Reportes\\ListaDePrecios.rpt");
                rptComp.DataSourceConnections[0].SetConnection(BT.GetServerName(), BT.GetDataBaseName(), BT.GetUserName(), BT.GetDBPassWord());
                ParameterFieldDefinitions crParameterFieldDefinitions = rptComp.DataDefinition.ParameterFields;
                ParameterFieldDefinition crParameter1 = crParameterFieldDefinitions["IdListaDePrecio"];
                ParameterValues crParameter1Values = crParameter1.CurrentValues;
                ParameterDiscreteValue crDiscrete1Value = new ParameterDiscreteValue();
                crDiscrete1Value.Value = ((DomainObject)ObjetoSeleccionado).ID;
                crParameter1Values.Add(crDiscrete1Value);
                crParameter1.ApplyCurrentValues(crParameter1Values);

                crv.ReportSource = rptComp;
                crv.Refresh();
                Cursor.Current = Cursors.Default;
            }
        }

        private void frmReporteListaPrecio_Load(object sender, EventArgs e)
        {
            cboLDP.SetComboBinding(new BBListaDePrecio(), "", "");
        }
    }
}