
namespace ProgettoBirra
{
    partial class FormEliminaRic
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
            this.textBoxNomeRic = new System.Windows.Forms.TextBox();
            this.buttonElimina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME:";
            // 
            // textBoxNomeRic
            // 
            this.textBoxNomeRic.Location = new System.Drawing.Point(274, 72);
            this.textBoxNomeRic.Name = "textBoxNomeRic";
            this.textBoxNomeRic.Size = new System.Drawing.Size(182, 20);
            this.textBoxNomeRic.TabIndex = 1;
            // 
            // buttonElimina
            // 
            this.buttonElimina.Location = new System.Drawing.Point(345, 179);
            this.buttonElimina.Name = "buttonElimina";
            this.buttonElimina.Size = new System.Drawing.Size(111, 68);
            this.buttonElimina.TabIndex = 2;
            this.buttonElimina.Text = "ELIMINA";
            this.buttonElimina.UseVisualStyleBackColor = true;
            this.buttonElimina.Click += new System.EventHandler(this.buttonElimina_Click);
            // 
            // FormEliminaRic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 317);
            this.Controls.Add(this.buttonElimina);
            this.Controls.Add(this.textBoxNomeRic);
            this.Controls.Add(this.label1);
            this.Name = "FormEliminaRic";
            this.Text = "FormEliminaRic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomeRic;
        private System.Windows.Forms.Button buttonElimina;
    }
}