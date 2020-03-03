using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2_G1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cant = Convert.ToInt32(txtCant.Text);
            double prec = Convert.ToDouble(txtPrec.Text);
            double n = 0.0;
            try
            {
                if (rdb1.Checked==true)
                {
                    n= prec * cant*0.0;
                }
                else if (rdb2.Checked==true)
                {
                    n= prec *cant *0.5;
                }
                else if (rdb3.Checked==true)
                {
                    n = prec*cant *0.10;
                }
                else if (rdb4.Checked==true)
                {
                     n= prec*cant * 0.15;
                }
                else if (rdb5.Checked==true)
                {
                     n= prec*cant *0.20;
                }
                txtDesc.Text = n.ToString("N2");
                txtTotal.Text =((cant*prec)).ToString("N2");

            }
            catch(Exception)
            {
                MessageBox.Show("Seleccione una cantidad de descuento");
            }
        }

    }
}
