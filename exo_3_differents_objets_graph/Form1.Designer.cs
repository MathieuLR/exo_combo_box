namespace exo_3_differents_objets_graph
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
            this.saisie_texte = new System.Windows.Forms.TextBox();
            this.Tapez_votre_texte = new System.Windows.Forms.Label();
            this.Choix = new System.Windows.Forms.GroupBox();
            this.Casse = new System.Windows.Forms.CheckBox();
            this.Couleur_des_caracteres = new System.Windows.Forms.CheckBox();
            this.Couleur_du_fond = new System.Windows.Forms.CheckBox();
            this.Fond = new System.Windows.Forms.GroupBox();
            this.Fond_Bleu_bouton = new System.Windows.Forms.RadioButton();
            this.Fond_vert_bouton = new System.Windows.Forms.RadioButton();
            this.Fond_rouge_bouton = new System.Windows.Forms.RadioButton();
            this.Caractères = new System.Windows.Forms.GroupBox();
            this.caractere_noir_bouton = new System.Windows.Forms.RadioButton();
            this.caractere_rouge_bouton = new System.Windows.Forms.RadioButton();
            this.Caractere_Blanc_bouton = new System.Windows.Forms.RadioButton();
            this.min_maj = new System.Windows.Forms.GroupBox();
            this.Casse_minuscule_bouton = new System.Windows.Forms.RadioButton();
            this.Casse_majuscules_bouton = new System.Windows.Forms.RadioButton();
            this.label_saisie = new System.Windows.Forms.Label();
            this.Choix.SuspendLayout();
            this.Fond.SuspendLayout();
            this.Caractères.SuspendLayout();
            this.min_maj.SuspendLayout();
            this.SuspendLayout();
            // 
            // saisie_texte
            // 
            this.saisie_texte.Location = new System.Drawing.Point(57, 67);
            this.saisie_texte.Name = "saisie_texte";
            this.saisie_texte.Size = new System.Drawing.Size(279, 20);
            this.saisie_texte.TabIndex = 0;
            this.saisie_texte.TextChanged += new System.EventHandler(this.saisie_texte_TextChanged);
            // 
            // Tapez_votre_texte
            // 
            this.Tapez_votre_texte.AccessibleName = "Tapez votre texte";
            this.Tapez_votre_texte.AutoSize = true;
            this.Tapez_votre_texte.Location = new System.Drawing.Point(54, 30);
            this.Tapez_votre_texte.Name = "Tapez_votre_texte";
            this.Tapez_votre_texte.Size = new System.Drawing.Size(90, 13);
            this.Tapez_votre_texte.TabIndex = 1;
            this.Tapez_votre_texte.Text = "Tapez votre texte";
            // 
            // Choix
            // 
            this.Choix.Controls.Add(this.Casse);
            this.Choix.Controls.Add(this.Couleur_des_caracteres);
            this.Choix.Controls.Add(this.Couleur_du_fond);
            this.Choix.Enabled = false;
            this.Choix.Location = new System.Drawing.Point(389, 30);
            this.Choix.Name = "Choix";
            this.Choix.Size = new System.Drawing.Size(200, 100);
            this.Choix.TabIndex = 3;
            this.Choix.TabStop = false;
            this.Choix.Text = "Choix";
            this.Choix.Enter += new System.EventHandler(this.Choix_Enter);
            // 
            // Casse
            // 
            this.Casse.AutoSize = true;
            this.Casse.Location = new System.Drawing.Point(6, 65);
            this.Casse.Name = "Casse";
            this.Casse.Size = new System.Drawing.Size(55, 17);
            this.Casse.TabIndex = 2;
            this.Casse.Text = "Casse";
            this.Casse.UseVisualStyleBackColor = true;
            this.Casse.CheckedChanged += new System.EventHandler(this.Casse_CheckedChanged);
            // 
            // Couleur_des_caracteres
            // 
            this.Couleur_des_caracteres.AutoSize = true;
            this.Couleur_des_caracteres.Location = new System.Drawing.Point(6, 42);
            this.Couleur_des_caracteres.Name = "Couleur_des_caracteres";
            this.Couleur_des_caracteres.Size = new System.Drawing.Size(135, 17);
            this.Couleur_des_caracteres.TabIndex = 1;
            this.Couleur_des_caracteres.Text = "Couleur des caractères";
            this.Couleur_des_caracteres.UseVisualStyleBackColor = true;
            this.Couleur_des_caracteres.CheckedChanged += new System.EventHandler(this.Couleur_des_caracteres_CheckedChanged);
            // 
            // Couleur_du_fond
            // 
            this.Couleur_du_fond.AutoSize = true;
            this.Couleur_du_fond.Location = new System.Drawing.Point(6, 19);
            this.Couleur_du_fond.Name = "Couleur_du_fond";
            this.Couleur_du_fond.Size = new System.Drawing.Size(101, 17);
            this.Couleur_du_fond.TabIndex = 0;
            this.Couleur_du_fond.Text = "Couleur du fond";
            this.Couleur_du_fond.UseVisualStyleBackColor = true;
            this.Couleur_du_fond.CheckedChanged += new System.EventHandler(this.Couleur_du_fond_CheckedChanged);
            // 
            // Fond
            // 
            this.Fond.Controls.Add(this.Fond_Bleu_bouton);
            this.Fond.Controls.Add(this.Fond_vert_bouton);
            this.Fond.Controls.Add(this.Fond_rouge_bouton);
            this.Fond.Location = new System.Drawing.Point(57, 284);
            this.Fond.Name = "Fond";
            this.Fond.Size = new System.Drawing.Size(138, 143);
            this.Fond.TabIndex = 4;
            this.Fond.TabStop = false;
            this.Fond.Text = "Fond";
            this.Fond.Visible = false;
            this.Fond.Enter += new System.EventHandler(this.Fond_Enter);
            // 
            // Fond_Bleu_bouton
            // 
            this.Fond_Bleu_bouton.AutoSize = true;
            this.Fond_Bleu_bouton.Location = new System.Drawing.Point(6, 95);
            this.Fond_Bleu_bouton.Name = "Fond_Bleu_bouton";
            this.Fond_Bleu_bouton.Size = new System.Drawing.Size(46, 17);
            this.Fond_Bleu_bouton.TabIndex = 2;
            this.Fond_Bleu_bouton.TabStop = true;
            this.Fond_Bleu_bouton.Text = "Bleu";
            this.Fond_Bleu_bouton.UseVisualStyleBackColor = true;
            this.Fond_Bleu_bouton.CheckedChanged += new System.EventHandler(this.Fond_Bleu_bouton_CheckedChanged);
            // 
            // Fond_vert_bouton
            // 
            this.Fond_vert_bouton.AutoSize = true;
            this.Fond_vert_bouton.Location = new System.Drawing.Point(6, 63);
            this.Fond_vert_bouton.Name = "Fond_vert_bouton";
            this.Fond_vert_bouton.Size = new System.Drawing.Size(44, 17);
            this.Fond_vert_bouton.TabIndex = 1;
            this.Fond_vert_bouton.TabStop = true;
            this.Fond_vert_bouton.Text = "Vert";
            this.Fond_vert_bouton.UseVisualStyleBackColor = true;
            this.Fond_vert_bouton.CheckedChanged += new System.EventHandler(this.Fond_vert_bouton_CheckedChanged);
            // 
            // Fond_rouge_bouton
            // 
            this.Fond_rouge_bouton.AutoSize = true;
            this.Fond_rouge_bouton.Location = new System.Drawing.Point(6, 34);
            this.Fond_rouge_bouton.Name = "Fond_rouge_bouton";
            this.Fond_rouge_bouton.Size = new System.Drawing.Size(57, 17);
            this.Fond_rouge_bouton.TabIndex = 0;
            this.Fond_rouge_bouton.TabStop = true;
            this.Fond_rouge_bouton.Text = "Rouge";
            this.Fond_rouge_bouton.UseVisualStyleBackColor = true;
            this.Fond_rouge_bouton.CheckedChanged += new System.EventHandler(this.Fond_rouge_bouton_CheckedChanged);
            // 
            // Caractères
            // 
            this.Caractères.Controls.Add(this.caractere_noir_bouton);
            this.Caractères.Controls.Add(this.caractere_rouge_bouton);
            this.Caractères.Controls.Add(this.Caractere_Blanc_bouton);
            this.Caractères.Location = new System.Drawing.Point(203, 284);
            this.Caractères.Name = "Caractères";
            this.Caractères.Size = new System.Drawing.Size(133, 143);
            this.Caractères.TabIndex = 5;
            this.Caractères.TabStop = false;
            this.Caractères.Text = "Caractères";
            this.Caractères.Visible = false;
            this.Caractères.Enter += new System.EventHandler(this.Caractères_Enter);
            // 
            // caractere_noir_bouton
            // 
            this.caractere_noir_bouton.AutoSize = true;
            this.caractere_noir_bouton.Location = new System.Drawing.Point(6, 95);
            this.caractere_noir_bouton.Name = "caractere_noir_bouton";
            this.caractere_noir_bouton.Size = new System.Drawing.Size(44, 17);
            this.caractere_noir_bouton.TabIndex = 5;
            this.caractere_noir_bouton.TabStop = true;
            this.caractere_noir_bouton.Text = "Noir";
            this.caractere_noir_bouton.UseVisualStyleBackColor = true;
            this.caractere_noir_bouton.CheckedChanged += new System.EventHandler(this.caractere_noir_bouton_CheckedChanged);
            // 
            // caractere_rouge_bouton
            // 
            this.caractere_rouge_bouton.AutoSize = true;
            this.caractere_rouge_bouton.Location = new System.Drawing.Point(6, 34);
            this.caractere_rouge_bouton.Name = "caractere_rouge_bouton";
            this.caractere_rouge_bouton.Size = new System.Drawing.Size(57, 17);
            this.caractere_rouge_bouton.TabIndex = 3;
            this.caractere_rouge_bouton.TabStop = true;
            this.caractere_rouge_bouton.Text = "Rouge";
            this.caractere_rouge_bouton.UseVisualStyleBackColor = true;
            this.caractere_rouge_bouton.CheckedChanged += new System.EventHandler(this.caractere_rouge_bouton_CheckedChanged);
            // 
            // Caractere_Blanc_bouton
            // 
            this.Caractere_Blanc_bouton.AutoSize = true;
            this.Caractere_Blanc_bouton.Location = new System.Drawing.Point(6, 63);
            this.Caractere_Blanc_bouton.Name = "Caractere_Blanc_bouton";
            this.Caractere_Blanc_bouton.Size = new System.Drawing.Size(52, 17);
            this.Caractere_Blanc_bouton.TabIndex = 4;
            this.Caractere_Blanc_bouton.TabStop = true;
            this.Caractere_Blanc_bouton.Text = "Blanc";
            this.Caractere_Blanc_bouton.UseVisualStyleBackColor = true;
            this.Caractere_Blanc_bouton.CheckedChanged += new System.EventHandler(this.Caractere_Blanc_bouton_CheckedChanged);
            // 
            // min_maj
            // 
            this.min_maj.Controls.Add(this.Casse_minuscule_bouton);
            this.min_maj.Controls.Add(this.Casse_majuscules_bouton);
            this.min_maj.Location = new System.Drawing.Point(342, 327);
            this.min_maj.Name = "min_maj";
            this.min_maj.Size = new System.Drawing.Size(154, 100);
            this.min_maj.TabIndex = 5;
            this.min_maj.TabStop = false;
            this.min_maj.Text = "Casse";
            this.min_maj.Visible = false;
            this.min_maj.Enter += new System.EventHandler(this.min_maj_Enter);
            // 
            // Casse_minuscule_bouton
            // 
            this.Casse_minuscule_bouton.AutoSize = true;
            this.Casse_minuscule_bouton.Location = new System.Drawing.Point(6, 20);
            this.Casse_minuscule_bouton.Name = "Casse_minuscule_bouton";
            this.Casse_minuscule_bouton.Size = new System.Drawing.Size(78, 17);
            this.Casse_minuscule_bouton.TabIndex = 6;
            this.Casse_minuscule_bouton.TabStop = true;
            this.Casse_minuscule_bouton.Text = "Minuscules";
            this.Casse_minuscule_bouton.UseVisualStyleBackColor = true;
            this.Casse_minuscule_bouton.CheckedChanged += new System.EventHandler(this.Casse_minuscule_bouton_CheckedChanged);
            // 
            // Casse_majuscules_bouton
            // 
            this.Casse_majuscules_bouton.AutoSize = true;
            this.Casse_majuscules_bouton.Location = new System.Drawing.Point(6, 52);
            this.Casse_majuscules_bouton.Name = "Casse_majuscules_bouton";
            this.Casse_majuscules_bouton.Size = new System.Drawing.Size(78, 17);
            this.Casse_majuscules_bouton.TabIndex = 7;
            this.Casse_majuscules_bouton.TabStop = true;
            this.Casse_majuscules_bouton.Text = "Majuscules";
            this.Casse_majuscules_bouton.UseVisualStyleBackColor = true;
            this.Casse_majuscules_bouton.CheckedChanged += new System.EventHandler(this.Casse_majuscules_bouton_CheckedChanged);
            // 
            // label_saisie
            // 
            this.label_saisie.AutoSize = true;
            this.label_saisie.Location = new System.Drawing.Point(60, 160);
            this.label_saisie.Name = "label_saisie";
            this.label_saisie.Size = new System.Drawing.Size(0, 13);
            this.label_saisie.TabIndex = 6;
            this.label_saisie.Click += new System.EventHandler(this.label_saisie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 439);
            this.Controls.Add(this.label_saisie);
            this.Controls.Add(this.Caractères);
            this.Controls.Add(this.min_maj);
            this.Controls.Add(this.Fond);
            this.Controls.Add(this.Choix);
            this.Controls.Add(this.Tapez_votre_texte);
            this.Controls.Add(this.saisie_texte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Choix.ResumeLayout(false);
            this.Choix.PerformLayout();
            this.Fond.ResumeLayout(false);
            this.Fond.PerformLayout();
            this.Caractères.ResumeLayout(false);
            this.Caractères.PerformLayout();
            this.min_maj.ResumeLayout(false);
            this.min_maj.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox saisie_texte;
        private System.Windows.Forms.Label Tapez_votre_texte;
        private System.Windows.Forms.GroupBox Choix;
        private System.Windows.Forms.CheckBox Casse;
        private System.Windows.Forms.CheckBox Couleur_des_caracteres;
        private System.Windows.Forms.CheckBox Couleur_du_fond;
        private System.Windows.Forms.GroupBox Fond;
        private System.Windows.Forms.RadioButton Fond_Bleu_bouton;
        private System.Windows.Forms.RadioButton Fond_vert_bouton;
        private System.Windows.Forms.RadioButton Fond_rouge_bouton;
        private System.Windows.Forms.GroupBox Caractères;
        private System.Windows.Forms.RadioButton caractere_noir_bouton;
        private System.Windows.Forms.RadioButton caractere_rouge_bouton;
        private System.Windows.Forms.RadioButton Caractere_Blanc_bouton;
        private System.Windows.Forms.GroupBox min_maj;
        private System.Windows.Forms.RadioButton Casse_minuscule_bouton;
        private System.Windows.Forms.RadioButton Casse_majuscules_bouton;
        private System.Windows.Forms.Label label_saisie;
    }
}

