﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _123
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

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                //MessageBox.Show($"Казино взломано на {x} %", x.ToString());
                //x++;
                progressBar1.Value++;
                Thread.Sleep(100);

                if (progressBar1.Value == 14)
                {
                    MessageBox.Show("Казино взломано на 14%, выведено 6000000$. Продолжить? ");
          
                }

                if (progressBar1.Value == progressBar1.Maximum)
                  break;

                
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Step = 50;

        
            
        }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      
    }

    private void textBox1_TextChanged_1(object sender, EventArgs e)
    {

    }
  }
}
