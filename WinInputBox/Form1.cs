using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinInputBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Monto a Segregar", "Title", "0.00");

            decimal valor = Convert.ToDecimal(input);

            MessageBox.Show(input + " Valor Convertido: " +  valor.ToString()); ;
        }

        private void butFormatDec_Click(object sender, EventArgs e)
        {
            decimal valor = Convert.ToDecimal(100.4343);

            string res = string.Format("{0:0.00000}", valor);

            txtOutput.Text = res;
        }
    }
}
