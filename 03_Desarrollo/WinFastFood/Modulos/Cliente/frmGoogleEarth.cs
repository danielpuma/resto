using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using WinFastFood.Addins;
using mshtml;
using System.Web;
namespace WinFastFood.Modulos.Cliente
{
    public partial class frmGoogleEarth : Form
    {
        AxSHDocVw.AxWebBrowser ws = new AxSHDocVw.AxWebBrowser();
        //ApplicationGEClass googleEarth;
        //IntPtr GEHrender;
        //IntPtr GEParentHrender;
        public string Desde;
        public string Hasta;
        public frmGoogleEarth()
        {
            InitializeComponent();
            
        }

        private void frmGoogleEarth_Load(object sender, EventArgs e)
        {

            ws.Parent = this;

            if (ws.Offline)
            {
                panel1.Visible = true;
                return;
            }
            else
            {

                
                ws.Top = 0;
                ws.Left = 0;
                ws.Height = this.Height;
                ws.Width = this.Width;
                panel1.Visible = false;
                Object nulo = null;
                string url = "http://www.enlace-informatico.com.ar/googlemap.htm?from=@@@Desde@@@&to=@@@Hasta@@@&submit=Calcular+Viaje&locale=es";
                url = url.Replace("@@@Desde@@@", HttpUtility.UrlEncodeUnicode(Desde));
                url = url.Replace("@@@Hasta@@@", HttpUtility.UrlEncodeUnicode(Hasta));
                try
                {
                    ws.Navigate(url, ref nulo, ref nulo, ref nulo, ref nulo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
            //webBrowser1.Document.ExecCommand ("createMapMarker('31.05173494','-122.03160858', 'test')",false,null);
            //if (this.DesignMode == false)
            //{
            //    googleEarth = new ApplicationGEClass();

            //    GEHrender = (IntPtr)googleEarth.GetRenderHwnd();
            //    GEParentHrender = GoogleEarthClassManager.GetParent(GEHrender);

                
            //    GoogleEarthClassManager.MoveWindow(GEHrender, splitContainer1.Panel2.Top, splitContainer1.Panel2.Left, splitContainer1.Panel2.Width, splitContainer1.Panel2.Height, true);
            //    GoogleEarthClassManager.SetParent(GEHrender, splitContainer1.Panel2.Handle);
            //}
        }



        private void splitContainer1_Panel2_Resize(object sender, EventArgs e)
        {
            //GoogleEarthClassManager.MoveWindow(GEHrender, splitContainer1.Panel2.Top, splitContainer1.Panel2.Left, splitContainer1.Panel2.Width, splitContainer1.Panel2.Height, true);
            //GoogleEarthClassManager.SetParent(GEHrender, splitContainer1.Panel2.Handle);
        }

        private void frmGoogleEarth_Resize(object sender, EventArgs e)
        {
            ws.Top = 0;
            ws.Left = 0;
            ws.Height = this.Height;
            ws.Width = this.Width;
        }
    }
}