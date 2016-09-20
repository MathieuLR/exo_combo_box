namespace Exo_listbox
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
            this.label_nouvel_element = new System.Windows.Forms.Label();
            this.label_index_element = new System.Windows.Forms.Label();
            this.label_liste = new System.Windows.Forms.Label();
            this.label_propriete = new System.Windows.Forms.Label();
            this.textBox_nouvel_element = new System.Windows.Forms.TextBox();
            this.textBox_index = new System.Windows.Forms.TextBox();
            this.label_items_count = new System.Windows.Forms.Label();
            this.label_selected_index = new System.Windows.Forms.Label();
            this.label_text = new System.Windows.Forms.Label();
            this.bouton_selectionner = new System.Windows.Forms.Button();
            this.bouton_vider_la_liste = new System.Windows.Forms.Button();
            this.bouton_ajout_liste = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.textBox_text = new System.Windows.Forms.TextBox();
            this.textBox_items_count = new System.Windows.Forms.TextBox();
            this.textBox_selected_index = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_nouvel_element
            // 
            this.label_nouvel_element.AutoSize = true;
            this.label_nouvel_element.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nouvel_element.Location = new System.Drawing.Point(56, 41);
            this.label_nouvel_element.Name = "label_nouvel_element";
            this.label_nouvel_element.Size = new System.Drawing.Size(96, 13);
            this.label_nouvel_element.TabIndex = 0;
            this.label_nouvel_element.Text = "Nouvel Elément";
            // 
            // label_index_element
            // 
            this.label_index_element.AutoSize = true;
            this.label_index_element.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_index_element.Location = new System.Drawing.Point(228, 41);
            this.label_index_element.Name = "label_index_element";
            this.label_index_element.Size = new System.Drawing.Size(87, 13);
            this.label_index_element.TabIndex = 1;
            this.label_index_element.Text = "Index Elément";
            // 
            // label_liste
            // 
            this.label_liste.AutoSize = true;
            this.label_liste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_liste.Location = new System.Drawing.Point(56, 215);
            this.label_liste.Name = "label_liste";
            this.label_liste.Size = new System.Drawing.Size(34, 13);
            this.label_liste.TabIndex = 2;
            this.label_liste.Text = "Liste";
            // 
            // label_propriete
            // 
            this.label_propriete.AutoSize = true;
            this.label_propriete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_propriete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_propriete.Location = new System.Drawing.Point(249, 215);
            this.label_propriete.Name = "label_propriete";
            this.label_propriete.Size = new System.Drawing.Size(66, 15);
            this.label_propriete.TabIndex = 3;
            this.label_propriete.Text = "Propriétés";
            // 
            // textBox_nouvel_element
            // 
            this.textBox_nouvel_element.Location = new System.Drawing.Point(59, 66);
            this.textBox_nouvel_element.Name = "textBox_nouvel_element";
            this.textBox_nouvel_element.Size = new System.Drawing.Size(100, 20);
            this.textBox_nouvel_element.TabIndex = 4;
            // 
            // textBox_index
            // 
            this.textBox_index.Location = new System.Drawing.Point(231, 66);
            this.textBox_index.Name = "textBox_index";
            this.textBox_index.Size = new System.Drawing.Size(38, 20);
            this.textBox_index.TabIndex = 5;
            // 
            // label_items_count
            // 
            this.label_items_count.AutoSize = true;
            this.label_items_count.Location = new System.Drawing.Point(249, 243);
            this.label_items_count.Name = "label_items_count";
            this.label_items_count.Size = new System.Drawing.Size(63, 13);
            this.label_items_count.TabIndex = 7;
            this.label_items_count.Text = "Items.Count";
            // 
            // label_selected_index
            // 
            this.label_selected_index.AutoSize = true;
            this.label_selected_index.Location = new System.Drawing.Point(249, 279);
            this.label_selected_index.Name = "label_selected_index";
            this.label_selected_index.Size = new System.Drawing.Size(78, 13);
            this.label_selected_index.TabIndex = 8;
            this.label_selected_index.Text = "Selected Index";
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Location = new System.Drawing.Point(249, 313);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(28, 13);
            this.label_text.TabIndex = 9;
            this.label_text.Text = "Text";
            // 
            // bouton_selectionner
            // 
            this.bouton_selectionner.Location = new System.Drawing.Point(337, 66);
            this.bouton_selectionner.Name = "bouton_selectionner";
            this.bouton_selectionner.Size = new System.Drawing.Size(75, 23);
            this.bouton_selectionner.TabIndex = 13;
            this.bouton_selectionner.Text = "Sélectionner";
            this.bouton_selectionner.UseVisualStyleBackColor = true;
            this.bouton_selectionner.Click += new System.EventHandler(this.bouton_selectionner_Click);
            // 
            // bouton_vider_la_liste
            // 
            this.bouton_vider_la_liste.Location = new System.Drawing.Point(337, 125);
            this.bouton_vider_la_liste.Name = "bouton_vider_la_liste";
            this.bouton_vider_la_liste.Size = new System.Drawing.Size(75, 23);
            this.bouton_vider_la_liste.TabIndex = 14;
            this.bouton_vider_la_liste.Text = "Vider la Liste";
            this.bouton_vider_la_liste.UseVisualStyleBackColor = true;
            this.bouton_vider_la_liste.Click += new System.EventHandler(this.bouton_vider_la_liste_Click);
            // 
            // bouton_ajout_liste
            // 
            this.bouton_ajout_liste.Location = new System.Drawing.Point(59, 154);
            this.bouton_ajout_liste.Name = "bouton_ajout_liste";
            this.bouton_ajout_liste.Size = new System.Drawing.Size(75, 23);
            this.bouton_ajout_liste.TabIndex = 16;
            this.bouton_ajout_liste.Text = "Ajout Liste";
            this.bouton_ajout_liste.UseVisualStyleBackColor = true;
            this.bouton_ajout_liste.Click += new System.EventHandler(this.bouton_ajout_liste_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(59, 231);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(149, 134);
            this.listBox.TabIndex = 17;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // textBox_text
            // 
            this.textBox_text.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_text.Location = new System.Drawing.Point(333, 306);
            this.textBox_text.Name = "textBox_text";
            this.textBox_text.Size = new System.Drawing.Size(57, 20);
            this.textBox_text.TabIndex = 18;
            // 
            // textBox_items_count
            // 
            this.textBox_items_count.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_items_count.Location = new System.Drawing.Point(333, 236);
            this.textBox_items_count.Name = "textBox_items_count";
            this.textBox_items_count.Size = new System.Drawing.Size(57, 20);
            this.textBox_items_count.TabIndex = 19;
            // 
            // textBox_selected_index
            // 
            this.textBox_selected_index.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_selected_index.Location = new System.Drawing.Point(333, 272);
            this.textBox_selected_index.Name = "textBox_selected_index";
            this.textBox_selected_index.Size = new System.Drawing.Size(57, 20);
            this.textBox_selected_index.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 411);
            this.Controls.Add(this.textBox_selected_index);
            this.Controls.Add(this.textBox_items_count);
            this.Controls.Add(this.textBox_text);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.bouton_ajout_liste);
            this.Controls.Add(this.bouton_vider_la_liste);
            this.Controls.Add(this.bouton_selectionner);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.label_selected_index);
            this.Controls.Add(this.label_items_count);
            this.Controls.Add(this.textBox_index);
            this.Controls.Add(this.textBox_nouvel_element);
            this.Controls.Add(this.label_propriete);
            this.Controls.Add(this.label_liste);
            this.Controls.Add(this.label_index_element);
            this.Controls.Add(this.label_nouvel_element);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nouvel_element;
        private System.Windows.Forms.Label label_index_element;
        private System.Windows.Forms.Label label_liste;
        private System.Windows.Forms.Label label_propriete;
        private System.Windows.Forms.TextBox textBox_nouvel_element;
        private System.Windows.Forms.TextBox textBox_index;
        private System.Windows.Forms.Label label_items_count;
        private System.Windows.Forms.Label label_selected_index;
        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.Button bouton_selectionner;
        private System.Windows.Forms.Button bouton_vider_la_liste;
        private System.Windows.Forms.Button bouton_ajout_liste;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox textBox_text;
        private System.Windows.Forms.TextBox textBox_items_count;
        private System.Windows.Forms.TextBox textBox_selected_index;
    }
}

