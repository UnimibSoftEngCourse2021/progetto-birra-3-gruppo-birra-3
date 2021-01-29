
namespace ProgettoBirra
{
    partial class FormListaSpesa
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
            this.textBoxListaSpesa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSpesa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxListaSpesa
            // 
            this.textBoxListaSpesa.Enabled = false;
            this.textBoxListaSpesa.Location = new System.Drawing.Point(62, 62);
            this.textBoxListaSpesa.Multiline = true;
            this.textBoxListaSpesa.Name = "textBoxListaSpesa";
            this.textBoxListaSpesa.Size = new System.Drawing.Size(588, 363);
            this.textBoxListaSpesa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista della spesa";
            // 
            // buttonSpesa
            // 
            this.buttonSpesa.Location = new System.Drawing.Point(724, 145);
            this.buttonSpesa.Name = "buttonSpesa";
            this.buttonSpesa.Size = new System.Drawing.Size(223, 113);
            this.buttonSpesa.TabIndex = 2;
            this.buttonSpesa.Text = "Ho fatto la spesa";
            this.buttonSpesa.UseVisualStyleBackColor = true;
            this.buttonSpesa.Click += new System.EventHandler(this.buttonSpesa_Click);
            // 
            // FormListaSpesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 450);
            this.Controls.Add(this.buttonSpesa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxListaSpesa);
            this.Name = "FormListaSpesa";
            this.Text = "FormListaSpesa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxListaSpesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSpesa;
    }
}