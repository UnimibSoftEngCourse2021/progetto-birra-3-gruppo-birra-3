
namespace ProgettoBirra
{
    partial class FormAggiungiRic
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxAttrezzi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.buttonAggiungiBirra = new System.Windows.Forms.Button();
            this.textBoxPreparazione = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCapacitaAtt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME RICETTA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ATTREZZATURA:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(172, 34);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(270, 20);
            this.textBoxNome.TabIndex = 3;
            // 
            // textBoxAttrezzi
            // 
            this.textBoxAttrezzi.Location = new System.Drawing.Point(499, 96);
            this.textBoxAttrezzi.Multiline = true;
            this.textBoxAttrezzi.Name = "textBoxAttrezzi";
            this.textBoxAttrezzi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAttrezzi.Size = new System.Drawing.Size(192, 140);
            this.textBoxAttrezzi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "NOTE:";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(59, 404);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNote.Size = new System.Drawing.Size(349, 102);
            this.textBoxNote.TabIndex = 7;
            // 
            // buttonAggiungiBirra
            // 
            this.buttonAggiungiBirra.Location = new System.Drawing.Point(569, 431);
            this.buttonAggiungiBirra.Name = "buttonAggiungiBirra";
            this.buttonAggiungiBirra.Size = new System.Drawing.Size(94, 75);
            this.buttonAggiungiBirra.TabIndex = 9;
            this.buttonAggiungiBirra.Text = "CONTINUA";
            this.buttonAggiungiBirra.UseVisualStyleBackColor = true;
            this.buttonAggiungiBirra.Click += new System.EventHandler(this.buttonAggiungiBirra_Click);
            // 
            // textBoxPreparazione
            // 
            this.textBoxPreparazione.Location = new System.Drawing.Point(59, 96);
            this.textBoxPreparazione.Multiline = true;
            this.textBoxPreparazione.Name = "textBoxPreparazione";
            this.textBoxPreparazione.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPreparazione.Size = new System.Drawing.Size(349, 246);
            this.textBoxPreparazione.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "PREPARAZIONE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Inserire gli attrezzi uno per riga andando a capo";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelCapacitaAtt
            // 
            this.labelCapacitaAtt.AutoSize = true;
            this.labelCapacitaAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelCapacitaAtt.Location = new System.Drawing.Point(480, 398);
            this.labelCapacitaAtt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCapacitaAtt.Name = "labelCapacitaAtt";
            this.labelCapacitaAtt.Size = new System.Drawing.Size(270, 25);
            this.labelCapacitaAtt.TabIndex = 15;
            this.labelCapacitaAtt.Text = "Continua per inserire i prodotti";
            // 
            // FormAggiungiRic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(786, 575);
            this.Controls.Add(this.labelCapacitaAtt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPreparazione);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAggiungiBirra);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAttrezzi);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAggiungiRic";
            this.Text = "NUOVA RICETTA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxAttrezzi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Button buttonAggiungiBirra;
        private System.Windows.Forms.TextBox textBoxPreparazione;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCapacitaAtt;
    }
}