using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1_G3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            if (int.TryParse(textBox1.Text, out n)) 
            for (int i = 1; i <= 10; i++) 
            {
                listBox1.Items.Add(n + " * " + i + "" + n + i);

            }
            else
            {
                MessageBox.Show("Intre un número en la tabla");
            }
        }
    }
}
