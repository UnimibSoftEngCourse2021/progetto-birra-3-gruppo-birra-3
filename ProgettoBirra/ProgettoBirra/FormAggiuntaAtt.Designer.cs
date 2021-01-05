
namespace ProgettoBirra
{
    partial class FormAggiuntaAtt
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
            this.textBoxNomeAtt = new System.Windows.Forms.TextBox();
            this.textBoxCapacita = new System.Windows.Forms.TextBox();
            this.labelNomeAtt = new System.Windows.Forms.Label();
            this.labelCapacitaAtt = new System.Windows.Forms.Label();
            this.buttonCreaAtt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNomeAtt
            // 
            this.textBoxNomeAtt.Location = new System.Drawing.Point(266, 99);
            this.textBoxNomeAtt.Name = "textBoxNomeAtt";
            this.textBoxNomeAtt.Size = new System.Drawing.Size(282, 26);
            this.textBoxNomeAtt.TabIndex = 0;
            // 
            // textBoxCapacita
            // 
            this.textBoxCapacita.Location = new System.Drawing.Point(266, 205);
            this.textBoxCapacita.Name = "textBoxCapacita";
            this.textBoxCapacita.Size = new System.Drawing.Size(282, 26);
            this.textBoxCapacita.TabIndex = 1;
            // 
            // labelNomeAtt
            // 
            this.labelNomeAtt.AutoSize = true;
            this.labelNomeAtt.Location = new System.Drawing.Point(107, 105);
            this.labelNomeAtt.Name = "labelNomeAtt";
            this.labelNomeAtt.Size = new System.Drawing.Size(115, 20);
            this.labelNomeAtt.TabIndex = 2;
            this.labelNomeAtt.Text = "Nome Attrezzo";
            // 
            // labelCapacitaAtt
            // 
            this.labelCapacitaAtt.AutoSize = true;
            this.labelCapacitaAtt.Location = new System.Drawing.Point(107, 211);
            this.labelCapacitaAtt.Name = "labelCapacitaAtt";
            this.labelCapacitaAtt.Size = new System.Drawing.Size(72, 20);
            this.labelCapacitaAtt.TabIndex = 3;
            this.labelCapacitaAtt.Text = "Capacità";
            // 
            // buttonCreaAtt
            // 
            this.buttonCreaAtt.Location = new System.Drawing.Point(376, 334);
            this.buttonCreaAtt.Name = "buttonCreaAtt";
            this.buttonCreaAtt.Size = new System.Drawing.Size(172, 64);
            this.buttonCreaAtt.TabIndex = 4;
            this.buttonCreaAtt.Text = "Aggiungi";
            this.buttonCreaAtt.UseVisualStyleBackColor = true;
            this.buttonCreaAtt.Click += new System.EventHandler(this.buttonCreaAtt_Click);
            // 
            // FormAggiuntaAtt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreaAtt);
            this.Controls.Add(this.labelCapacitaAtt);
            this.Controls.Add(this.labelNomeAtt);
            this.Controls.Add(this.textBoxCapacita);
            this.Controls.Add(this.textBoxNomeAtt);
            this.Name = "FormAggiuntaAtt";
            this.Text = "Aggiunta Attrezzo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNomeAtt;
        private System.Windows.Forms.TextBox textBoxCapacita;
        private System.Windows.Forms.Label labelNomeAtt;
        private System.Windows.Forms.Label labelCapacitaAtt;
        private System.Windows.Forms.Button buttonCreaAtt;
    }
}