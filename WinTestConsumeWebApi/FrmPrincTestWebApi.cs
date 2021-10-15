using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestWebApi.BE;
using TestWebApi.BL;

namespace WinTestConsumeWebApi
{
    public partial class FrmPrincTestWebApi : Form
    {
        private TestApiBL testApiBL;
        public FrmPrincTestWebApi()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            this.Text = ConfigurationManager.AppSettings["captionForm"];
            this.StartPosition = FormStartPosition.CenterScreen;
            string urlBase = ConfigurationManager.AppSettings["urlConn"];
            string uriWapi = ConfigurationManager.AppSettings["uriWapi"];
            this.testApiBL = new TestApiBL(urlBase, uriWapi);
        }

        private void tlsStrButExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tlsStrButTest_Click(object sender, EventArgs e)
        {
            
           GeneralResponseBE<string> generalResponseBE =  this.testApiBL.TestFunc("Hola My Friend");

            if (generalResponseBE.StatusResponseCode == System.Net.HttpStatusCode.OK )
            {
                MessageBox.Show(generalResponseBE.Data);
            }
            else
            {
                MessageBox.Show(generalResponseBE.Mensaje);
            }

        }
    }
}
