using AccountToReprocess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTestApp
{
    public partial class FrmPrincTestLog : Form
    {
        public FrmPrincTestLog()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            try
            {
                txtFileOrigen.Text = System.Configuration.ConfigurationManager.AppSettings["defFname"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void butDo_Click(object sender, EventArgs e)
        {
            CuentasAReprocesar ctasErr = new CuentasAReprocesar(txtFileOrigen.Text);
            try
            {
                // ProcessFile(txtFileOrigen.Text, out lstCtas);
                foreach (var item in ctasErr.LstCtaCte)
                {
                    txtSalida.Text += (item.CodClienteN.ToString() + " - " + item.CodCuentaN.ToString()+ "\n");
                    // Console.WriteLine(item.CodClienteN.ToString() + " - " + item.CodCuentaN.ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       
    }
}
