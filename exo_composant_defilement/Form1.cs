using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exo_composant_defilement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
           // numericUpDown1.Text =  e.NewValue.ToString();
          
            numericUpDown1.Value = hScrollBar1.Value;
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
        
          //  numericUpDown2.Text = e.NewValue.ToString();
            numericUpDown2.Value = hScrollBar2.Value;
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            
            //numericUpDown3.Text = e.NewValue.ToString();
            numericUpDown3.Value = hScrollBar3.Value;
     
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            hScrollBar1.Value = (int)numericUpDown1.Value;
           
            
            label7.BackColor = Color.FromArgb((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            hScrollBar2.Value = (int)numericUpDown2.Value;
            
      
            label7.BackColor = Color.FromArgb((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            hScrollBar3.Value = (int)numericUpDown3.Value;
            
         
            label7.BackColor = Color.FromArgb((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
