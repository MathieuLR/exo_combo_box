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

namespace exo_winform_synthese
{
    public partial class Form1 : Form
    {
        int nbmens = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_nom_TextChanged(object sender, EventArgs e)
        {
            string lettres_ok = "^[A-Za-z]+$";
            if (!Regex.IsMatch(textBox1_nom.Text, @lettres_ok))
            {
                textBox1_nom.BackColor = Color.Red;
                MessageBox.Show("Valeur d'entrée non valide [A-Z]", "Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                textBox1_nom.BackColor = Color.GreenYellow;
        }

        private void textBox2_capital_emprunte_TextChanged(object sender, EventArgs e)
        {
            string montant = @"^[0-9]{0,10}$";
            if (!Regex.IsMatch(textBox2_capital_emprunte.Text, montant))
            {
                textBox2_capital_emprunte.BackColor = Color.Red;

            }
            else
            {
                textBox2_capital_emprunte.BackColor = Color.GreenYellow;
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Mensuelle");
            listBox1.Items.Add("Bimestrielle");
            listBox1.Items.Add("Trimestrielle");
            listBox1.Items.Add("Semestrielle");
            listBox1.Items.Add("Annuelle");

            listBox1.SetSelected(0, true);
            textBox1_nom.Focus();
            // bouton_7_pourcent.Select();
            label9.Text = "1";
            label6.ForeColor = Color.Red;


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (listBox1.SelectedItem.ToString() == "Mensuelle")
            {

                hScrollBar1.Minimum = 1;
                hScrollBar1.LargeChange = 1;
                hScrollBar1.SmallChange = 1;
                //label6.Text = "1";
                //label9.Text = "1";
                hScrollBar1.Value = 1;
                nbmens = 12;


            }

            if (listBox1.SelectedItem.ToString() == "Bimestrielle")
            {

                hScrollBar1.Minimum = 2;
                hScrollBar1.Maximum = 301;
                hScrollBar1.LargeChange = 2;
                hScrollBar1.SmallChange = 2;
                //label6.Text = "1";
                // label9.Text = "2";
                hScrollBar1.Value = 2;
                nbmens = 6;

            }

            if (listBox1.SelectedItem.ToString() == "Trimestrielle")
            {


                hScrollBar1.Minimum = 3;
                hScrollBar1.Maximum = 302;
                hScrollBar1.LargeChange = 3;
                hScrollBar1.SmallChange = 3;
                //label6.Text = "1";
                //label9.Text = "3";
                hScrollBar1.Value = 3;
                nbmens = 4;

            }

            if (listBox1.SelectedItem.ToString() == "Semestrielle")
            {


                hScrollBar1.Minimum = 6;
                hScrollBar1.Maximum = 306;
                hScrollBar1.LargeChange = 6;
                hScrollBar1.SmallChange = 6;
                // label6.Text = "1";
                //label9.Text = "6";
                hScrollBar1.Value = 6;
                nbmens = 2;

            }

            if (listBox1.SelectedItem.ToString() == "Annuelle")
            {


                hScrollBar1.Minimum = 12;
                hScrollBar1.Maximum = 312;
                hScrollBar1.LargeChange = 12;
                hScrollBar1.SmallChange = 12;
                //label6.Text = "1";
                //label9.Text = "12";
                hScrollBar1.Value = 12;
                nbmens = 1;


            }




        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            bool septpourcent = false;
            bool huitpourcent = false;
            bool neufpourcent = false;

            Console.WriteLine(hScrollBar1.Value);
            Console.WriteLine(hScrollBar1.SmallChange);
            hScrollBar1.Value = (hScrollBar1.Value / hScrollBar1.SmallChange) * hScrollBar1.SmallChange;
            label6.Text = (hScrollBar1.Value / hScrollBar1.SmallChange).ToString();
            label9.Text = hScrollBar1.Value.ToString();

            if (bouton_7_pourcent.Checked)
            {
                septpourcent = true;

                if (septpourcent == true)
                {
                    double nbre = Convert.ToDouble(label6.Text);
                    Double pourcent7 = ((0.07 / nbmens) / (1 - (Math.Pow((1 + (0.07 / nbmens)), -nbre))));
                    int montant = Convert.ToInt32(textBox2_capital_emprunte.Text);
                    Double resultat = pourcent7 * montant;
                    label8.Text = resultat.ToString();
                }
            }
            if (bouton_8_pourcent.Checked)
            {
                huitpourcent = true;
            }
            if (huitpourcent == true)
            {
                double nbre = Convert.ToDouble(label6.Text);
                Double pourcent7 = ((0.08 / nbmens) / (1 - (Math.Pow((1 + (0.08 / nbmens)), -nbre))));
                int montant = Convert.ToInt32(textBox2_capital_emprunte.Text);
                Double resultat = pourcent7 * montant;
                label8.Text = resultat.ToString();
            }
            if (bouton_9_pourcent.Checked)
            {
                neufpourcent = true;
            }
            if (neufpourcent == true)
            {
                double nbre = Convert.ToDouble(label6.Text);
                Double pourcent7 = ((0.09 / nbmens) / (1 - (Math.Pow((1 + (0.09 / nbmens)), -nbre))));
                int montant = Convert.ToInt32(textBox2_capital_emprunte.Text);
                Double resultat = pourcent7 * montant;
                label8.Text = resultat.ToString();
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            bool septpourcent = false;
            bool huitpourcent = false;
            bool neufpourcent = false;

            Console.WriteLine(hScrollBar1.Value);
            Console.WriteLine(hScrollBar1.SmallChange);
            hScrollBar1.Value = (hScrollBar1.Value / hScrollBar1.SmallChange) * hScrollBar1.SmallChange;
            label6.Text = (hScrollBar1.Value / hScrollBar1.SmallChange).ToString();
            label9.Text = hScrollBar1.Value.ToString();

            // int montant = Convert.ToInt32(textBox2_capital_emprunte.Text) / Convert.ToInt32(label6.Text);
            // label8.Text = montant.ToString();
            if (bouton_7_pourcent.Checked)
            {
                septpourcent = true;

                if (septpourcent == true)
                {
                    double nbre = Convert.ToDouble(label6.Text);
                    Double pourcent7 = ((0.07 / nbmens) / (1 - (Math.Pow((1 + (0.08 / nbmens)), -nbre))));
                    int montant = Convert.ToInt32(textBox2_capital_emprunte.Text);
                    Double resultat = pourcent7 * montant;
                    label8.Text = resultat.ToString();
                }
            }
            if (bouton_8_pourcent.Checked)
            {
                huitpourcent = true;
            }
            if (huitpourcent == true)
            {
                double nbre = Convert.ToDouble(label6.Text);
                Double pourcent7 = ((0.08 / nbmens) / (1 - (Math.Pow((1 + (0.08 / nbmens)), -nbre))));
                int montant = Convert.ToInt32(textBox2_capital_emprunte.Text);
                Double resultat = pourcent7 * montant;
                label8.Text = resultat.ToString();
            }
            if (bouton_9_pourcent.Checked)
            {
                neufpourcent = true;
            }
            if (neufpourcent == true)
            {
                double nbre = Convert.ToDouble(label6.Text);
                Double pourcent7 = ((0.09 / nbmens) / (1 - (Math.Pow((1 + (0.08 / nbmens)), -nbre))));
                int montant = Convert.ToInt32(textBox2_capital_emprunte.Text);
                Double resultat = pourcent7 * montant;
                label8.Text = resultat.ToString();
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bouton_7_pourcent_Click(object sender, EventArgs e)
        {

        }

        private void bouton_8_pourcent_Click(object sender, EventArgs e)
        {

        }

        private void bouton_9_pourcent_Click(object sender, EventArgs e)
        {

        }

        private void bouton_annuler_Click(object sender, EventArgs e)
        {
            textBox1_nom.Clear();
            textBox2_capital_emprunte.Clear();
            label6.Text.Remove(0);
            label9.Text.Remove(1);
            label8.Text.Remove(0);

        }

        private void bouton_ok_Click(object sender, EventArgs e)
        {
            if (textBox1_nom.BackColor == Color.GreenYellow && textBox2_capital_emprunte.BackColor == Color.GreenYellow)
            {
                MessageBox.Show("Nom : " + textBox1_nom.Text + "\n" + "Capitale Emprunté : " + textBox2_capital_emprunte.Text + "\n" + "Durée en mois du remboursement : " + label9.Text + "\n" + "Mensualités : " + label6.Text + "\n" + "Remboursements : " + label8.Text, "Validation effectuée", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
                MessageBox.Show("Tous les champs doivent être renseignés", "Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
       
       }

        private void bouton_7_pourcent_CheckedChanged(object sender, EventArgs e)
        {
            bool septpourcent = false;
            bool huitpourcent = false;
            bool neufpourcent = false;

            Console.WriteLine(hScrollBar1.Value);
            Console.WriteLine(hScrollBar1.SmallChange);
            hScrollBar1.Value = (hScrollBar1.Value / hScrollBar1.SmallChange) * hScrollBar1.SmallChange;
            label6.Text = (hScrollBar1.Value / hScrollBar1.SmallChange).ToString();
            label9.Text = hScrollBar1.Value.ToString();

            if (bouton_7_pourcent.Checked)
            {
                septpourcent = true;

                if (septpourcent == true)
                {
                    double nbre = Convert.ToDouble(label6.Text);
                    Double pourcent7 = ((0.07 / nbmens) / (1 - (Math.Pow((1 + (0.07 / nbmens)), -nbre))));
                    int montant = Convert.ToInt32(textBox2_capital_emprunte.Text);
                    Double resultat = pourcent7 * montant;
                    label8.Text = resultat.ToString();
                }
            }
            if (bouton_8_pourcent.Checked)
            {
                huitpourcent = true;
            }
            if (huitpourcent == true)
            {
                double nbre = Convert.ToDouble(label6.Text);
                Double pourcent7 = ((0.08 / nbmens) / (1 - (Math.Pow((1 + (0.08 / nbmens)), -nbre))));
                int montant = Convert.ToInt32(textBox2_capital_emprunte.Text);
                Double resultat = pourcent7 * montant;
                label8.Text = resultat.ToString();
            }
            if (bouton_9_pourcent.Checked)
            {
                neufpourcent = true;
            }
            if (neufpourcent == true)
            {
                double nbre = Convert.ToDouble(label6.Text);
                Double pourcent7 = ((0.09 / nbmens) / (1 - (Math.Pow((1 + (0.09 / nbmens)), -nbre))));
                int montant = Convert.ToInt32(textBox2_capital_emprunte.Text);
                Double resultat = pourcent7 * montant;
                label8.Text = resultat.ToString();
            }
        }

        private void bouton_8_pourcent_CheckedChanged(object sender, EventArgs e)
        {
            bool septpourcent = false;
            bool huitpourcent = false;
            bool neufpourcent = false;

            Console.WriteLine(hScrollBar1.Value);
            Console.WriteLine(hScrollBar1.SmallChange);
            hScrollBar1.Value = (hScrollBar1.Value / hScrollBar1.SmallChange) * hScrollBar1.SmallChange;
            label6.Text = (hScrollBar1.Value / hScrollBar1.SmallChange).ToString();
            label9.Text = hScrollBar1.Value.ToString();

            if (bouton_7_pourcent.Checked)
            {
                septpourcent = true;

                if (septpourcent == true)
                {
                    double nbre = Convert.ToDouble(label6.Text);
                    Double pourcent7 = ((0.07 / nbmens) / (1 - (Math.Pow((1 + (0.08 / nbmens)), -nbre))));
                    int montant = Convert.ToInt32(textBox2_capital_emprunte.Text);
                    Double resultat = pourcent7 * montant;
                    label8.Text = resultat.ToString();
                }
            }
            if (bouton_8_pourcent.Checked)
            {
                huitpourcent = true;
            }
            if (huitpourcent == true)
            {
                double nbre = Convert.ToDouble(label6.Text);
                Double pourcent7 = ((0.08 / nbmens) / (1 - (Math.Pow((1 + (0.08 / nbmens)), -nbre))));
                int montant = Convert.ToInt32(textBox2_capital_emprunte.Text);
                Double resultat = pourcent7 * montant;
                label8.Text = resultat.ToString();
            }
            if (bouton_9_pourcent.Checked)
            {
                neufpourcent = true;
            }
            if (neufpourcent == true)
            {
                double nbre = Convert.ToDouble(label6.Text);
                Double pourcent7 = ((0.09 / nbmens) / (1 - (Math.Pow((1 + (0.08 / nbmens)), -nbre))));
                int montant = Convert.ToInt32(textBox2_capital_emprunte.Text);
                Double resultat = pourcent7 * montant;
                label8.Text = resultat.ToString();
            }
        }

        private void bouton_9_pourcent_CheckedChanged(object sender, EventArgs e)
        {
            bool septpourcent = false;
            bool huitpourcent = false;
            bool neufpourcent = false;

            Console.WriteLine(hScrollBar1.Value);
            Console.WriteLine(hScrollBar1.SmallChange);
            hScrollBar1.Value = (hScrollBar1.Value / hScrollBar1.SmallChange) * hScrollBar1.SmallChange;
            label6.Text = (hScrollBar1.Value / hScrollBar1.SmallChange).ToString();
            label9.Text = hScrollBar1.Value.ToString();

            if (bouton_7_pourcent.Checked)
            {
                septpourcent = true;

                if (septpourcent == true)
                {
                    double nbre = Convert.ToDouble(label6.Text);
                    Double pourcent7 = ((0.07 / nbmens) / (1 - (Math.Pow((1 + (0.08 / nbmens)), -nbre))));
                    int montant = Convert.ToInt32(textBox2_capital_emprunte.Text);
                    Double resultat = pourcent7 * montant;
                    label8.Text = resultat.ToString();
                }
            }
            if (bouton_8_pourcent.Checked)
            {
                huitpourcent = true;
            }
            if (huitpourcent == true)
            {
                double nbre = Convert.ToDouble(label6.Text);
                Double pourcent7 = ((0.08 / nbmens) / (1 - (Math.Pow((1 + (0.08 / nbmens)), -nbre))));
                int montant = Convert.ToInt32(textBox2_capital_emprunte.Text);
                Double resultat = pourcent7 * montant;
                label8.Text = resultat.ToString();
            }
            if (bouton_9_pourcent.Checked)
            {
                neufpourcent = true;
            }
            if (neufpourcent == true)
            {
                double nbre = Convert.ToDouble(label6.Text);
                Double pourcent7 = ((0.09 / nbmens) / (1 - (Math.Pow((1 + (0.08 / nbmens)), -nbre))));
                int montant = Convert.ToInt32(textBox2_capital_emprunte.Text);
                Double resultat = pourcent7 * montant;
                label8.Text = resultat.ToString();
            }
        }
    }
}
