using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int somme;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nombre_1_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox1.Text = " + 1 ";
            somme += 1;
            
        }

        private void nombre_0_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox1.Text = " + 0 ";
            somme += 0;
        }

        private void nombre_2_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox1.Text = " + 2 ";
            somme += 2 ;
        }

        private void nombre_4_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox1.Text = " + 4 ";
            somme += 4;
        }

        private void nombre_3_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox1.Text = " + 3 ";
            somme += 3;
        }

        private void nombre_5_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox1.Text = " + 5 ";
            somme += 5;
        }

        private void nombre_6_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox1.Text = " + 6 ";
            somme += 6;
            
        }

        private void nombre_7_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox1.Text = " + 7 ";
            somme += 7;
            
        }

        private void nombre_8_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox1.Text = " + 8 ";
            somme += 8;
        }

        private void nombre_9_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox1.Text = " + 9 ";
            somme += 9;
        }

        private void vider_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text = " ";
            somme = 0;
        }

        private void calculer_Click(object sender, EventArgs e)
        {
            textBox1.Text += textBox1.Text = " = " + somme;
        }
    }
}
