namespace exo_winform_synthese
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_nom = new System.Windows.Forms.TextBox();
            this.textBox2_capital_emprunte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.bouton_ok = new System.Windows.Forms.Button();
            this.bouton_annuler = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bouton_9_pourcent = new System.Windows.Forms.RadioButton();
            this.bouton_8_pourcent = new System.Windows.Forms.RadioButton();
            this.bouton_7_pourcent = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capital Emprunté";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Durée en mois du";
            // 
            // textBox1_nom
            // 
            this.textBox1_nom.Location = new System.Drawing.Point(176, 42);
            this.textBox1_nom.Name = "textBox1_nom";
            this.textBox1_nom.Size = new System.Drawing.Size(100, 20);
            this.textBox1_nom.TabIndex = 3;
            this.textBox1_nom.TextChanged += new System.EventHandler(this.textBox1_nom_TextChanged);
            // 
            // textBox2_capital_emprunte
            // 
            this.textBox2_capital_emprunte.Location = new System.Drawing.Point(176, 107);
            this.textBox2_capital_emprunte.Name = "textBox2_capital_emprunte";
            this.textBox2_capital_emprunte.Size = new System.Drawing.Size(100, 20);
            this.textBox2_capital_emprunte.TabIndex = 4;
            this.textBox2_capital_emprunte.TextChanged += new System.EventHandler(this.textBox2_capital_emprunte_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "remboursement";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(248, 168);
            this.hScrollBar1.Maximum = 300;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(144, 17);
            this.hScrollBar1.TabIndex = 6;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // bouton_ok
            // 
            this.bouton_ok.Location = new System.Drawing.Point(594, 44);
            this.bouton_ok.Name = "bouton_ok";
            this.bouton_ok.Size = new System.Drawing.Size(75, 23);
            this.bouton_ok.TabIndex = 7;
            this.bouton_ok.Text = "OK";
            this.bouton_ok.UseVisualStyleBackColor = true;
            this.bouton_ok.Click += new System.EventHandler(this.bouton_ok_Click);
            // 
            // bouton_annuler
            // 
            this.bouton_annuler.Location = new System.Drawing.Point(594, 95);
            this.bouton_annuler.Name = "bouton_annuler";
            this.bouton_annuler.Size = new System.Drawing.Size(75, 23);
            this.bouton_annuler.TabIndex = 8;
            this.bouton_annuler.Text = "Annuler";
            this.bouton_annuler.UseVisualStyleBackColor = true;
            this.bouton_annuler.Click += new System.EventHandler(this.bouton_annuler_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Périodicité de remboursement";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 11;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(519, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Remboursements";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(519, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "label8";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bouton_9_pourcent);
            this.groupBox1.Controls.Add(this.bouton_8_pourcent);
            this.groupBox1.Controls.Add(this.bouton_7_pourcent);
            this.groupBox1.Location = new System.Drawing.Point(446, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 158);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Taux d\'intérêt";
            // 
            // bouton_9_pourcent
            // 
            this.bouton_9_pourcent.AutoSize = true;
            this.bouton_9_pourcent.Location = new System.Drawing.Point(35, 114);
            this.bouton_9_pourcent.Name = "bouton_9_pourcent";
            this.bouton_9_pourcent.Size = new System.Drawing.Size(39, 17);
            this.bouton_9_pourcent.TabIndex = 2;
            this.bouton_9_pourcent.TabStop = true;
            this.bouton_9_pourcent.Text = "9%";
            this.bouton_9_pourcent.UseVisualStyleBackColor = true;
            this.bouton_9_pourcent.CheckedChanged += new System.EventHandler(this.bouton_9_pourcent_CheckedChanged);
            this.bouton_9_pourcent.Click += new System.EventHandler(this.bouton_9_pourcent_Click);
            // 
            // bouton_8_pourcent
            // 
            this.bouton_8_pourcent.AutoSize = true;
            this.bouton_8_pourcent.Location = new System.Drawing.Point(35, 72);
            this.bouton_8_pourcent.Name = "bouton_8_pourcent";
            this.bouton_8_pourcent.Size = new System.Drawing.Size(39, 17);
            this.bouton_8_pourcent.TabIndex = 1;
            this.bouton_8_pourcent.TabStop = true;
            this.bouton_8_pourcent.Text = "8%";
            this.bouton_8_pourcent.UseVisualStyleBackColor = true;
            this.bouton_8_pourcent.CheckedChanged += new System.EventHandler(this.bouton_8_pourcent_CheckedChanged);
            this.bouton_8_pourcent.Click += new System.EventHandler(this.bouton_8_pourcent_Click);
            // 
            // bouton_7_pourcent
            // 
            this.bouton_7_pourcent.AutoSize = true;
            this.bouton_7_pourcent.Location = new System.Drawing.Point(35, 32);
            this.bouton_7_pourcent.Name = "bouton_7_pourcent";
            this.bouton_7_pourcent.Size = new System.Drawing.Size(39, 17);
            this.bouton_7_pourcent.TabIndex = 0;
            this.bouton_7_pourcent.TabStop = true;
            this.bouton_7_pourcent.Text = "7%";
            this.bouton_7_pourcent.UseVisualStyleBackColor = true;
            this.bouton_7_pourcent.CheckedChanged += new System.EventHandler(this.bouton_7_pourcent_CheckedChanged);
            this.bouton_7_pourcent.Click += new System.EventHandler(this.bouton_7_pourcent_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(198, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 15;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(73, 249);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 121);
            this.listBox1.TabIndex = 16;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 416);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bouton_annuler);
            this.Controls.Add(this.bouton_ok);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2_capital_emprunte);
            this.Controls.Add(this.textBox1_nom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1_nom;
        private System.Windows.Forms.TextBox textBox2_capital_emprunte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bouton_ok;
        private System.Windows.Forms.Button bouton_annuler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton bouton_9_pourcent;
        private System.Windows.Forms.RadioButton bouton_8_pourcent;
        private System.Windows.Forms.RadioButton bouton_7_pourcent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}

