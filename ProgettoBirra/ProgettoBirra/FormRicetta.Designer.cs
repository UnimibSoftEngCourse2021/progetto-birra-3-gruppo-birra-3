﻿
namespace ProgettoBirra
{
    partial class FormRicetta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.textBoxPreparazione = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProdotti = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAttrezzi = new System.Windows.Forms.TextBox();
            this.buttonModificaRic = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(184, 46);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.ReadOnly = true;
            this.textBoxNome.Size = new System.Drawing.Size(112, 26);
            this.textBoxNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Note";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(184, 110);
            this.textBoxNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(112, 26);
            this.textBoxNote.TabIndex = 3;
            // 
            // textBoxPreparazione
            // 
            this.textBoxPreparazione.Location = new System.Drawing.Point(184, 180);
            this.textBoxPreparazione.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPreparazione.Name = "textBoxPreparazione";
            this.textBoxPreparazione.ReadOnly = true;
            this.textBoxPreparazione.Size = new System.Drawing.Size(284, 26);
            this.textBoxPreparazione.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Preparazione";
            // 
            // textBoxProdotti
            // 
            this.textBoxProdotti.Location = new System.Drawing.Point(184, 315);
            this.textBoxProdotti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxProdotti.Multiline = true;
            this.textBoxProdotti.Name = "textBoxProdotti";
            this.textBoxProdotti.ReadOnly = true;
            this.textBoxProdotti.Size = new System.Drawing.Size(284, 177);
            this.textBoxProdotti.TabIndex = 6;
            this.textBoxProdotti.TextChanged += new System.EventHandler(this.textBoxProdotti_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prodotti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Attrezzi";
            // 
            // textBoxAttrezzi
            // 
            this.textBoxAttrezzi.Location = new System.Drawing.Point(577, 244);
            this.textBoxAttrezzi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAttrezzi.Multiline = true;
            this.textBoxAttrezzi.Name = "textBoxAttrezzi";
            this.textBoxAttrezzi.ReadOnly = true;
            this.textBoxAttrezzi.Size = new System.Drawing.Size(253, 248);
            this.textBoxAttrezzi.TabIndex = 9;
            // 
            // buttonModificaRic
            // 
            this.buttonModificaRic.Location = new System.Drawing.Point(184, 560);
            this.buttonModificaRic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonModificaRic.Name = "buttonModificaRic";
            this.buttonModificaRic.Size = new System.Drawing.Size(84, 29);
            this.buttonModificaRic.TabIndex = 10;
            this.buttonModificaRic.Text = "Modifica";
            this.buttonModificaRic.UseVisualStyleBackColor = true;
            this.buttonModificaRic.Click += new System.EventHandler(this.buttonModificaRic_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(577, 560);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Elimina";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonElimina_Click);
            // 
            // FormRicetta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 652);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonModificaRic);
            this.Controls.Add(this.textBoxAttrezzi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxProdotti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPreparazione);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRicetta";
            this.Text = "FormRicettacs";
            this.Load += new System.EventHandler(this.FormRicetta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.TextBox textBoxPreparazione;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxProdotti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAttrezzi;
        private System.Windows.Forms.Button buttonModificaRic;
        private System.Windows.Forms.Button button2;
    }
}