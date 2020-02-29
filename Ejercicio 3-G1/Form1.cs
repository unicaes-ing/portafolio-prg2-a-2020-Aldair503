using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3_G1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Inver1, Inver2, Inver3, labe5, Label;
            Inver1 = Convert.ToDouble(TexBox1.Text);
            Inver2 = Convert.ToDouble(TexBox2.Text);
            Inver3 = Convert.ToDouble(TexBox3.Text);
            labe5 = (Inver1 + Inver2 + Inver3);
            Suma.Text = string.Format("{0:N1}", labe5);
            Label = (Inver1 / 100);
            Texbox.Text = string.Format("{0:N1}",Label);
            Label = (Inver2 / 100);
            textBox3.Text= string.Format("{0:N1}", Label);
            Label = (Inver3 / 100);
            textBox2.Text=string.Format("{0:N1}", Label);





        }

        private void Total1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            TexBox1.Clear();
            TexBox2.Clear();
            TexBox3.Clear();
            Suma.Clear();
            Texbox.Clear();
            textBox3.Clear();
            textBox2.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
