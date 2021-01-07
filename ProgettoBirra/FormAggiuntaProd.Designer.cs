
namespace ProgettoBirra
{
    partial class FormAggiuntaProd
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNomeProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuantita = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 346);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "AGGIUNGI!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSalvaProd);
            // 
            // textBoxNomeProd
            // 
            this.textBoxNomeProd.Location = new System.Drawing.Point(208, 117);
            this.textBoxNomeProd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNomeProd.Name = "textBoxNomeProd";
            this.textBoxNomeProd.Size = new System.Drawing.Size(279, 22);
            this.textBoxNomeProd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "QUANTITA\':";
            // 
            // textBoxQuantita
            // 
            this.textBoxQuantita.Location = new System.Drawing.Point(208, 216);
            this.textBoxQuantita.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuantita.Name = "textBoxQuantita";
            this.textBoxQuantita.Size = new System.Drawing.Size(279, 22);
            this.textBoxQuantita.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "kg";
            // 
            // FormAggiuntaProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 443);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxQuantita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNomeProd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAggiuntaProd";
            this.Text = "Aggiungi Prodotto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNomeProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuantita;
        private System.Windows.Forms.Label label3;
    }
}