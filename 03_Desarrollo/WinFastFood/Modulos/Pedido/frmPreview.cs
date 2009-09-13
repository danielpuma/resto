using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FastFood.BB.CoreExtension;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace WinFastFood.Modulos.Pedido
{
    public partial class frmPreview : Form
    {
        public int IdPedido; 
        public frmPreview()
        {
            InitializeComponent();
        }

        private void frmPreview_Load(object sender, EventArgs e)
        {
            BBPedido BT = new BBPedido();
            Cursor.Current = Cursors.WaitCursor;
            ReportDocument rptComp = new ReportDocument(); //(ReportDocument)crv.ReportSource;
            rptComp.Load(Environment.CurrentDirectory + "\\Modulos\\Pedido\\rptPedido.rpt");
            rptComp.DataSourceConnections[0].SetConnection(BT.GetServerName(), BT.GetDataBaseName(), BT.GetUserName(), BT.GetDBPassWord());
            ParameterFieldDefinitions crParameterFieldDefinitions = rptComp.DataDefinition.ParameterFields;
            ParameterFieldDefinition crParameter1 = crParameterFieldDefinitions["IdPedido"];
            ParameterValues crParameter1Values = crParameter1.CurrentValues;
            ParameterDiscreteValue crDiscrete1Value = new ParameterDiscreteValue();
            crDiscrete1Value.Value = IdPedido;
            crParameter1Values.Add(crDiscrete1Value);
            crParameter1.ApplyCurrentValues(crParameter1Values);

            crv.ReportSource = rptComp;
            crv.Refresh();
            Cursor.Current = Cursors.Default;
        }
    }
}