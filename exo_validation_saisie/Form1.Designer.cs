namespace exo_validation_saisie
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Valider_bouton = new System.Windows.Forms.Button();
            this.effacer_bouton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.nom_label = new System.Windows.Forms.Label();
            this.Date_label = new System.Windows.Forms.Label();
            this.montant_label = new System.Windows.Forms.Label();
            this.code_postal_label = new System.Windows.Forms.Label();
            this.format_date_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Valider_bouton
            // 
            this.Valider_bouton.Location = new System.Drawing.Point(516, 312);
            this.Valider_bouton.Name = "Valider_bouton";
            this.Valider_bouton.Size = new System.Drawing.Size(75, 23);
            this.Valider_bouton.TabIndex = 0;
            this.Valider_bouton.Text = "valider";
            this.Valider_bouton.UseVisualStyleBackColor = true;
            this.Valider_bouton.Click += new System.EventHandler(this.Valider_bouton_Click);
            // 
            // effacer_bouton
            // 
            this.effacer_bouton.Location = new System.Drawing.Point(516, 350);
            this.effacer_bouton.Name = "effacer_bouton";
            this.effacer_bouton.Size = new System.Drawing.Size(75, 23);
            this.effacer_bouton.TabIndex = 1;
            this.effacer_bouton.Text = "effacer";
            this.effacer_bouton.UseVisualStyleBackColor = true;
            this.effacer_bouton.Click += new System.EventHandler(this.effacer_bouton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(201, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(201, 235);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(201, 175);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(201, 122);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // nom_label
            // 
            this.nom_label.AutoSize = true;
            this.nom_label.Location = new System.Drawing.Point(133, 67);
            this.nom_label.Name = "nom_label";
            this.nom_label.Size = new System.Drawing.Size(27, 13);
            this.nom_label.TabIndex = 6;
            this.nom_label.Text = "nom";
            this.nom_label.Click += new System.EventHandler(this.nom_label_Click);
            // 
            // Date_label
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.Location = new System.Drawing.Point(133, 125);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(28, 13);
            this.Date_label.TabIndex = 7;
            this.Date_label.Text = "date";
            // 
            // montant_label
            // 
            this.montant_label.AutoSize = true;
            this.montant_label.Location = new System.Drawing.Point(133, 182);
            this.montant_label.Name = "montant_label";
            this.montant_label.Size = new System.Drawing.Size(45, 13);
            this.montant_label.TabIndex = 8;
            this.montant_label.Text = "montant";
            // 
            // code_postal_label
            // 
            this.code_postal_label.AutoSize = true;
            this.code_postal_label.Location = new System.Drawing.Point(133, 242);
            this.code_postal_label.Name = "code_postal_label";
            this.code_postal_label.Size = new System.Drawing.Size(62, 13);
            this.code_postal_label.TabIndex = 9;
            this.code_postal_label.Text = "code postal";
            // 
            // format_date_label
            // 
            this.format_date_label.AutoSize = true;
            this.format_date_label.Location = new System.Drawing.Point(307, 129);
            this.format_date_label.Name = "format_date_label";
            this.format_date_label.Size = new System.Drawing.Size(79, 13);
            this.format_date_label.TabIndex = 10;
            this.format_date_label.Text = "(JJ/MM/AAAA)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 458);
            this.Controls.Add(this.format_date_label);
            this.Controls.Add(this.code_postal_label);
            this.Controls.Add(this.montant_label);
            this.Controls.Add(this.Date_label);
            this.Controls.Add(this.nom_label);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.effacer_bouton);
            this.Controls.Add(this.Valider_bouton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Valider_bouton;
        private System.Windows.Forms.Button effacer_bouton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label nom_label;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.Label montant_label;
        private System.Windows.Forms.Label code_postal_label;
        private System.Windows.Forms.Label format_date_label;
    }
}

