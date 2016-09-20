using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exo_3_differents_objets_graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saisie_texte_TextChanged(object sender, EventArgs e)
        {
            label_saisie.Text = saisie_texte.Text;
            if (saisie_texte.Text == "")
                Choix.Enabled = false;

            else
                Choix.Enabled = true;

        }

       

        private void Couleur_du_fond_CheckedChanged(object sender, EventArgs e)
        {
            if (Couleur_du_fond.Checked == true)
            {
                Fond.Visible = true;
            }
            else
                Fond.Visible = false;
        }

        private void Couleur_des_caracteres_CheckedChanged(object sender, EventArgs e)
        {
            if (Couleur_des_caracteres.Checked == true)
            {
                Caractères.Visible = true;
            }
            else
                Caractères.Visible = false;
        }

        private void Casse_CheckedChanged(object sender, EventArgs e)
        {
            if (Casse.Checked == true)
            {
                min_maj.Visible = true;
            }
            else
                min_maj.Visible = false;
        }

        private void label_saisie_Click(object sender, EventArgs e)
        {

        }

        private void Fond_Enter(object sender, EventArgs e)
        {

        }

        private void Fond_rouge_bouton_CheckedChanged(object sender, EventArgs e)
        {
         
            if (Fond_rouge_bouton.Checked == true)
            {
                label_saisie.BackColor = Color.Red;
            }
        }

        private void Fond_vert_bouton_CheckedChanged(object sender, EventArgs e)
        {
           
            if (Fond_vert_bouton.Checked == true)
            {
                label_saisie.BackColor = Color.Green;
            }
        }

        private void Fond_Bleu_bouton_CheckedChanged(object sender, EventArgs e)
        {
            if (Fond_Bleu_bouton.Checked == true)
            {
                label_saisie.BackColor = Color.Blue;
            }

        }

        private void Caractères_Enter(object sender, EventArgs e)
        {

        }

        private void caractere_rouge_bouton_CheckedChanged(object sender, EventArgs e)
        {
            if (caractere_rouge_bouton.Checked == true)
            {
                label_saisie.ForeColor = Color.Red;
            }
        }

        private void Caractere_Blanc_bouton_CheckedChanged(object sender, EventArgs e)
        {
            if (Caractere_Blanc_bouton.Checked == true)
            {
                label_saisie.ForeColor = Color.White;
            }
        }

        private void caractere_noir_bouton_CheckedChanged(object sender, EventArgs e)
        {
            if (caractere_noir_bouton.Checked == true)
            {
                label_saisie.ForeColor = Color.Black;
            }
        }

        private void min_maj_Enter(object sender, EventArgs e)
        {

        }

        private void Casse_minuscule_bouton_CheckedChanged(object sender, EventArgs e)
        {
            
            if (Casse_minuscule_bouton.Checked == true)
            {
                label_saisie.Text = label_saisie.Text.ToLower();
            }
        }

        private void Casse_majuscules_bouton_CheckedChanged(object sender, EventArgs e)
        {
            if (Casse_majuscules_bouton.Checked == true)
            {
                label_saisie.Text = label_saisie.Text.ToUpper();
            }
        }

        private void Choix_Enter(object sender, EventArgs e)
        {
                    }

        /* private void Tapez_votre_texte_Click(object sender, EventArgs e)
         {

         }

         private void saisie_texte_KeyPress(object sender, KeyPressEventArgs e)
         {
             //if (e.KeyChar == '$')
             // {
             //     //saisie_texte.Text = "";
             //     e.Handled = true;
             // }
             Console.WriteLine("KeyPress");
         }

         private void saisie_texte_KeyDown(object sender, KeyEventArgs e)
         {
             Console.WriteLine("KeyDown");

         }

         private void saisie_texte_KeyUp(object sender, KeyEventArgs e)
         {
             Console.WriteLine("KeyUp");
             if (e.KeyCode == Keys.F2)
             {
                 this.Close();
             }
             */

    }
}
