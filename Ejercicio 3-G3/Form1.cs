﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3_G3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int c = 0;
            listBox1.Items.Clear();
            for (int i = 1; i <= 5000; i++) ;
            {
                int num = r.Next(1, 7);
                listBox1.Items.Add(num);
                if (num == 6) c++;
            }
            MessageBox.Show("Se obtuvo " + c + "veces el 6");
        }
    }
}
