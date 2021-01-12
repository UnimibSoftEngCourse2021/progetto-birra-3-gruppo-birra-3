
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(743, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ATTREZZI:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(245, 44);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(280, 22);
            this.textBoxNome.TabIndex = 3;
            // 
            // textBoxAttrezzi
            // 
            this.textBoxAttrezzi.Location = new System.Drawing.Point(932, 97);
            this.textBoxAttrezzi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAttrezzi.Multiline = true;
            this.textBoxAttrezzi.Name = "textBoxAttrezzi";
            this.textBoxAttrezzi.Size = new System.Drawing.Size(280, 216);
            this.textBoxAttrezzi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 398);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "NOTE:";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(245, 394);
            this.textBoxNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(280, 88);
            this.textBoxNote.TabIndex = 7;
            // 
            // buttonAggiungiBirra
            // 
            this.buttonAggiungiBirra.Location = new System.Drawing.Point(694, 540);
            this.buttonAggiungiBirra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAggiungiBirra.Name = "buttonAggiungiBirra";
            this.buttonAggiungiBirra.Size = new System.Drawing.Size(125, 92);
            this.buttonAggiungiBirra.TabIndex = 9;
            this.buttonAggiungiBirra.Text = "Continua";
            this.buttonAggiungiBirra.UseVisualStyleBackColor = true;
            this.buttonAggiungiBirra.Click += new System.EventHandler(this.buttonAggiungiBirra_Click);
            // 
            // textBoxPreparazione
            // 
            this.textBoxPreparazione.Location = new System.Drawing.Point(245, 138);
            this.textBoxPreparazione.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPreparazione.Multiline = true;
            this.textBoxPreparazione.Name = "textBoxPreparazione";
            this.textBoxPreparazione.Size = new System.Drawing.Size(280, 224);
            this.textBoxPreparazione.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "PREPARAZIONE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(928, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Inserire i seguenti parametri divisi da un a capo:";
            // 
            // FormAggiungiRic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 795);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAggiungiRic";
            this.Text = "FormAggiungiRic";
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
    }
}