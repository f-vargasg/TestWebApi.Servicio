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

namespace WinTestConsumeWebApi
{
    public partial class FrmPrincTestWebApi : Form
    {
        public FrmPrincTestWebApi()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            this.Text = ConfigurationManager.AppSettings["captionForm"];
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void tlsStrButExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
