using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4_G2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }
       
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            bool validar = true;
            ErrorProvider.Clear();
            if (txtContraseña.Text == txtrecontra.Text)
            {
                validar = true;
            }
            else
            {
                validar = false;
                ErrorProvider.SetError(txtrecontra, "La contraseña no son iguales");
            }
            if (validar)
            {
                MessageBox.Show("Los datos han sido guardados");
            }
        }
    }
}
