using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4_G1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(txtCant.Text);
            double prec = Convert.ToDouble(txtePrec.Text);
            string Titulo = cmbTitulo.Text;
            double subtotal = 0;
            switch (Titulo)
            {
                case "Júpiter":
                    subtotal = cantidad * prec;
                    break;
                case "La última Guinda":
                    subtotal = cantidad * prec;
                    break;
                case "El Gato negro":
                    subtotal = cantidad * prec;
                    break;
                case "Harry Potter":
                    subtotal = cantidad * prec;
                    break;
                case "El principito":
                    subtotal = cantidad * prec;
                    break;
            }
            txteSubtotal.Text = (cantidad * prec).ToString();
            txtImpuesto.Text = (subtotal * .013).ToString();
            txtPagar.Text = (subtotal + ((cantidad * prec) * 0.13)).ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
