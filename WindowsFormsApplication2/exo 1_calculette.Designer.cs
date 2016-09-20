namespace WindowsFormsApplication2
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
            this.nombre0 = new System.Windows.Forms.Button();
            this.nombre2 = new System.Windows.Forms.Button();
            this.nombre7 = new System.Windows.Forms.Button();
            this.nombre6 = new System.Windows.Forms.Button();
            this.nombre5 = new System.Windows.Forms.Button();
            this.nombre1 = new System.Windows.Forms.Button();
            this.nombre3 = new System.Windows.Forms.Button();
            this.nombre8 = new System.Windows.Forms.Button();
            this.nombre9 = new System.Windows.Forms.Button();
            this.nombre4 = new System.Windows.Forms.Button();
            this.vider = new System.Windows.Forms.Button();
            this.calculer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nombre0
            // 
            this.nombre0.Location = new System.Drawing.Point(58, 172);
            this.nombre0.Name = "nombre0";
            this.nombre0.Size = new System.Drawing.Size(45, 37);
            this.nombre0.TabIndex = 1;
            this.nombre0.Text = "0";
            this.nombre0.UseVisualStyleBackColor = true;
            this.nombre0.Click += new System.EventHandler(this.nombre_0_Click);
            // 
            // nombre2
            // 
            this.nombre2.Location = new System.Drawing.Point(160, 172);
            this.nombre2.Name = "nombre2";
            this.nombre2.Size = new System.Drawing.Size(45, 37);
            this.nombre2.TabIndex = 2;
            this.nombre2.Text = "2";
            this.nombre2.UseVisualStyleBackColor = true;
            this.nombre2.Click += new System.EventHandler(this.nombre_2_Click);
            // 
            // nombre7
            // 
            this.nombre7.Location = new System.Drawing.Point(160, 227);
            this.nombre7.Name = "nombre7";
            this.nombre7.Size = new System.Drawing.Size(45, 37);
            this.nombre7.TabIndex = 3;
            this.nombre7.Text = "7";
            this.nombre7.UseVisualStyleBackColor = true;
            this.nombre7.Click += new System.EventHandler(this.nombre_7_Click);
            // 
            // nombre6
            // 
            this.nombre6.Location = new System.Drawing.Point(109, 227);
            this.nombre6.Name = "nombre6";
            this.nombre6.Size = new System.Drawing.Size(45, 37);
            this.nombre6.TabIndex = 4;
            this.nombre6.Text = "6";
            this.nombre6.UseVisualStyleBackColor = true;
            this.nombre6.Click += new System.EventHandler(this.nombre_6_Click);
            // 
            // nombre5
            // 
            this.nombre5.Location = new System.Drawing.Point(58, 227);
            this.nombre5.Name = "nombre5";
            this.nombre5.Size = new System.Drawing.Size(45, 37);
            this.nombre5.TabIndex = 5;
            this.nombre5.Text = "5";
            this.nombre5.UseVisualStyleBackColor = true;
            this.nombre5.Click += new System.EventHandler(this.nombre_5_Click);
            // 
            // nombre1
            // 
            this.nombre1.Location = new System.Drawing.Point(109, 172);
            this.nombre1.Name = "nombre1";
            this.nombre1.Size = new System.Drawing.Size(45, 37);
            this.nombre1.TabIndex = 6;
            this.nombre1.Text = "1";
            this.nombre1.UseVisualStyleBackColor = true;
            this.nombre1.Click += new System.EventHandler(this.nombre_1_Click);
            // 
            // nombre3
            // 
            this.nombre3.Location = new System.Drawing.Point(211, 172);
            this.nombre3.Name = "nombre3";
            this.nombre3.Size = new System.Drawing.Size(45, 37);
            this.nombre3.TabIndex = 7;
            this.nombre3.Text = "3";
            this.nombre3.UseVisualStyleBackColor = true;
            this.nombre3.Click += new System.EventHandler(this.nombre_3_Click);
            // 
            // nombre8
            // 
            this.nombre8.Location = new System.Drawing.Point(211, 227);
            this.nombre8.Name = "nombre8";
            this.nombre8.Size = new System.Drawing.Size(45, 37);
            this.nombre8.TabIndex = 8;
            this.nombre8.Text = "8";
            this.nombre8.UseVisualStyleBackColor = true;
            this.nombre8.Click += new System.EventHandler(this.nombre_8_Click);
            // 
            // nombre9
            // 
            this.nombre9.Location = new System.Drawing.Point(262, 227);
            this.nombre9.Name = "nombre9";
            this.nombre9.Size = new System.Drawing.Size(45, 37);
            this.nombre9.TabIndex = 9;
            this.nombre9.Text = "9";
            this.nombre9.UseVisualStyleBackColor = true;
            this.nombre9.Click += new System.EventHandler(this.nombre_9_Click);
            // 
            // nombre4
            // 
            this.nombre4.Location = new System.Drawing.Point(262, 172);
            this.nombre4.Name = "nombre4";
            this.nombre4.Size = new System.Drawing.Size(45, 37);
            this.nombre4.TabIndex = 10;
            this.nombre4.Text = "4";
            this.nombre4.UseVisualStyleBackColor = true;
            this.nombre4.Click += new System.EventHandler(this.nombre_4_Click);
            // 
            // vider
            // 
            this.vider.Location = new System.Drawing.Point(58, 317);
            this.vider.Name = "vider";
            this.vider.Size = new System.Drawing.Size(96, 23);
            this.vider.TabIndex = 11;
            this.vider.Text = "vider";
            this.vider.UseVisualStyleBackColor = true;
            this.vider.Click += new System.EventHandler(this.vider_Click);
            // 
            // calculer
            // 
            this.calculer.Location = new System.Drawing.Point(211, 317);
            this.calculer.Name = "calculer";
            this.calculer.Size = new System.Drawing.Size(96, 23);
            this.calculer.TabIndex = 12;
            this.calculer.Text = "calculer";
            this.calculer.UseVisualStyleBackColor = true;
            this.calculer.Click += new System.EventHandler(this.calculer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 123);
            this.textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 367);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.calculer);
            this.Controls.Add(this.vider);
            this.Controls.Add(this.nombre4);
            this.Controls.Add(this.nombre9);
            this.Controls.Add(this.nombre8);
            this.Controls.Add(this.nombre3);
            this.Controls.Add(this.nombre1);
            this.Controls.Add(this.nombre5);
            this.Controls.Add(this.nombre6);
            this.Controls.Add(this.nombre7);
            this.Controls.Add(this.nombre2);
            this.Controls.Add(this.nombre0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button nombre0;
        private System.Windows.Forms.Button nombre2;
        private System.Windows.Forms.Button nombre7;
        private System.Windows.Forms.Button nombre6;
        private System.Windows.Forms.Button nombre5;
        private System.Windows.Forms.Button nombre1;
        private System.Windows.Forms.Button nombre3;
        private System.Windows.Forms.Button nombre8;
        private System.Windows.Forms.Button nombre9;
        private System.Windows.Forms.Button nombre4;
        private System.Windows.Forms.Button vider;
        private System.Windows.Forms.Button calculer;
        private System.Windows.Forms.TextBox textBox1;
    }
}

