﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_G1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1Cal_Click(object sender, EventArgs e)
        {
            double exa1, exa2, exa3, promedio;
            exa1 = Convert.ToDouble(textBox1.Text);
            exa2 = Convert.ToDouble(textBox2.Text);
            exa3 = Convert.ToDouble(textBox3.Text);
           promedio = (exa1 + exa2 + exa3) / 3;
            textBox4.Text = string.Format("{0:N}", promedio);



        }

        private void btn2Lim_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn3Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
