using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2_G2
{
    public partial class Form1 : Form
    {
        private object ex;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double r = 0.0;
                int cant = Convert.ToInt32(txtPrec.Text);
                double prec = Convert.ToDouble(txtPrec.Text);
                if (rdb0.Checked == true)
                {
                    r = cant * prec * 0.0;
                }
                if (radio5.Checked == true)
                {
                    r = cant * prec * 0.5;
                }
                if (radio10.Checked == true)
                {
                    r = cant * prec * 0.10;
                }
                if (radio15.Checked == true)
                {
                    r = cant * prec * 0.15;
                }
                if (radio20.Checked == true)
                {
                    r = cant * prec * 0.20;
                }
                txtDescuento.Text = r.ToString("N2");
                txtTotal.Text = ((cant * prec)).ToString("N2");
            }
            catch (Exception)
            {
                MessageBox.Show(Message);
                throw;
            }
        
        }

         
    }
}



