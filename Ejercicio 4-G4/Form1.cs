using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4_G4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private static int FuncionFibonacci(int n)

        {
            if (n < 2)
                return n;
            else
                return FuncionFibonacci(n - 1) + FuncionFibonacci(n - 2);
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            int Fibo = FuncionFibonacci(num);
            textBox2.Text=String.Format("{0}", Fibo);
        }

    }
}
