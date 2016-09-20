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

namespace exo_validation_saisie
{
    public partial class Form1 : Form
        

    {
       
        
        public Form1()
        {
            InitializeComponent();
           


        }
  
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       
            textBox1.MaxLength = 30;
            string lettres_ok = "^[A-Za-z]+$";
            if (!Regex.IsMatch(textBox1.Text , @lettres_ok))
                {
                 textBox1.BackColor = Color.Red;
                MessageBox.Show("Valeur d'entrée non valide [A-Z]", "Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                              }
            else
            {
                textBox1.BackColor = Color.GreenYellow;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
                string Date = @"^[0-9]{2}\/[0-9]{2}\/[0-9]{4}$";
            if(!Regex.IsMatch(textBox4.Text, @Date))
            {
                 textBox4.BackColor = Color.Red;
                 
            }
            else
            {
                textBox4.BackColor = Color.GreenYellow;
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string montant = @"^[0-9]{0,10}[,][0-9]{2}$";
            if (!Regex.IsMatch(textBox3.Text, montant))
            {
                textBox3.BackColor = Color.Red;

            }
            else
            {
                textBox3.BackColor = Color.GreenYellow;
            }

        }

    

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string code_postal = @"^[0-9]{5}$";
            if (!Regex.IsMatch(textBox2.Text, code_postal))
            {
                textBox2.BackColor = Color.Red;
                
            }
            else
            {
                textBox2.BackColor = Color.GreenYellow;
            }
        }
        
        private void Valider_bouton_Click(object sender, EventArgs e)
        {
          if(textBox1.BackColor == Color.GreenYellow && textBox2.BackColor == Color.GreenYellow && textBox3.BackColor == Color.GreenYellow && textBox4.BackColor == Color.GreenYellow)
            {
                MessageBox.Show("Nom : "+textBox1.Text +"\n"+"Date : "+ textBox4.Text +"\n" +"Montant : "+ textBox3.Text+"\n" +"Code Postal : "+ textBox2.Text +"\n", "Validation effectuée", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                
            }
          else
                MessageBox.Show("Tous les champs doivent être renseignés", "Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void effacer_bouton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text = "";
            textBox1.BackColor = Color.WhiteSmoke;
            textBox2.Text = textBox2.Text = "";
            textBox2.BackColor = Color.WhiteSmoke;
            textBox3.Text = textBox3.Text = "";
            textBox3.BackColor = Color.WhiteSmoke;
            textBox4.Text = textBox4.Text = "";
            textBox4.BackColor = Color.WhiteSmoke;

        }

        private void nom_label_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
