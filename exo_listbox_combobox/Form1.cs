using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace exo_listbox_combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {


            bool drapeau = true;

            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                string ligne = (string)comboBox1.Items[i];
                if (ligne.ToLower() == comboBox1.Text.ToLower())
                {
                    drapeau = false;

                }


            }
            if (drapeau && comboBox1.Text != "")

            //if (comboBox1.Items.Contains(comboBox1.Text) == false && comboBox1.Text != "")
            {
                string lettres_ok = "^[A-Za-z]+$";
                if (Regex.IsMatch(comboBox1.Text, @lettres_ok))

                {
                    comboBox1.Items.Add(comboBox1.Text);
                }
                else
                    MessageBox.Show("Valeur d'entrée non valide [A-Z]", "Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("France");
            comboBox1.Items.Add("Belgique");
            comboBox1.Items.Add("Allemagne");
            comboBox1.Items.Add("Japon");
            comboBox1.Items.Add("Portugal");
            comboBox1.Items.Add("Grece");
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {


            listBox1.Items.Add(comboBox1.SelectedItem);
            comboBox1.Items.Remove(comboBox1.SelectedItem);
            button1.Enabled = false;
            button4.Enabled = true;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                button3.Enabled = true;
                button4.Enabled = true;
            }
            if (listBox1.SelectedIndex <= 0)
                button5.Enabled = false;
            else
                button5.Enabled = true;

            if (listBox1.SelectedIndex >= listBox1.Items.Count -1)
                button6.Enabled = false;
            else
                button6.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                string liste = comboBox1.Items[i] as string;
                listBox1.Items.Add(liste);
            }
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            button3.Enabled = false;
            button4.Enabled = true;

          

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string liste = listBox1.Items[i] as string;
                comboBox1.Items.Add(liste);
            }
            listBox1.Items.Clear();
            listBox1.Text = "";
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count != 0)
            {
                button1.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0 )
            {
                int LIndex = listBox1.SelectedIndex;
                object UTemp = listBox1.SelectedItem;
                listBox1.Items.RemoveAt(LIndex);
                listBox1.Items.Insert(LIndex - 1, UTemp);
                listBox1.SelectedIndex = LIndex - 1;
            }

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
            {
                int LIndex = listBox1.SelectedIndex;
                object UTemp = listBox1.SelectedItem;
                listBox1.Items.RemoveAt(LIndex);
                listBox1.Items.Insert(LIndex + 1, UTemp);
                listBox1.SelectedIndex = LIndex + 1;
            }
        
     }
    }
}
