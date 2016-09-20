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

namespace Exo_listbox
{

   
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
        }

      

        private void bouton_selectionner_Click(object sender, EventArgs e)
        {
            
            listBox.SelectedIndex = Convert.ToInt32(textBox_index.Text);
            textBox_index.Text = textBox_selected_index.Text;
            textBox_text.Text = Convert.ToString(listBox.SelectedItem);

        }

        private void bouton_vider_la_liste_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            textBox_index.Clear();
            textBox_text.Clear();
            textBox_items_count.Clear();
            textBox_selected_index.Clear();
            
         }

        private void textBox_liste_TextChanged(object sender, EventArgs e)
        {

        }

        private void bouton_ajout_liste_Click(object sender, EventArgs e)
        {
            bool drapeau = true;

            for (int i = 0; i < listBox.Items.Count; i++)
            {
                if ((string)listBox.Items[i] == textBox_nouvel_element.Text)
                {
                    drapeau = false;
                    
                }
            }
            if (drapeau)
            { 
           
                string lettres_ok = "^[A-Za-z]+$";
                if (Regex.IsMatch(textBox_nouvel_element.Text, @lettres_ok))
                {
                    listBox.Items.Add(textBox_nouvel_element.Text);

                }
                else
                    MessageBox.Show("Valeur d'entrée non valide [A-Z]", "Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MessageBox.Show("Cet élément existe déja dans la liste", "Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);


            int index =listBox.FindString(textBox_nouvel_element.Text);
            listBox.SelectedIndex = index;
            textBox_nouvel_element.Clear();
            textBox_nouvel_element.Focus();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBox_items_count.Text = listBox.Items.Count.ToString();
            textBox_selected_index.Text = listBox.SelectedIndex.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
