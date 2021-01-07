
namespace ProgettoBirra
{
    partial class FormEliminaProd
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
            this.buttonEliminaProd = new System.Windows.Forms.Button();
            this.textBoxNomeProd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODOTTO DA ELIMINARE:";
            // 
            // buttonEliminaProd
            // 
            this.buttonEliminaProd.Location = new System.Drawing.Point(334, 184);
            this.buttonEliminaProd.Name = "buttonEliminaProd";
            this.buttonEliminaProd.Size = new System.Drawing.Size(87, 71);
            this.buttonEliminaProd.TabIndex = 1;
            this.buttonEliminaProd.Text = "ELIMINA";
            this.buttonEliminaProd.UseVisualStyleBackColor = true;
            this.buttonEliminaProd.Click += new System.EventHandler(this.buttonEliminaProd_Click);
            // 
            // textBoxNomeProd
            // 
            this.textBoxNomeProd.Location = new System.Drawing.Point(239, 96);
            this.textBoxNomeProd.Name = "textBoxNomeProd";
            this.textBoxNomeProd.Size = new System.Drawing.Size(182, 20);
            this.textBoxNomeProd.TabIndex = 2;
            // 
            // FormEliminaProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 364);
            this.Controls.Add(this.textBoxNomeProd);
            this.Controls.Add(this.buttonEliminaProd);
            this.Controls.Add(this.label1);
            this.Name = "FormEliminaProd";
            this.Text = "FormEliminaProd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEliminaProd;
        private System.Windows.Forms.TextBox textBoxNomeProd;
    }
}