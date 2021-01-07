
namespace ProgettoBirra
{
    partial class FormModificaProd
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
            this.buttonSalvaModifiche = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxNuovaQT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSalvaModifiche
            // 
            this.buttonSalvaModifiche.Location = new System.Drawing.Point(200, 317);
            this.buttonSalvaModifiche.Name = "buttonSalvaModifiche";
            this.buttonSalvaModifiche.Size = new System.Drawing.Size(221, 78);
            this.buttonSalvaModifiche.TabIndex = 0;
            this.buttonSalvaModifiche.Text = "Salva Modifiche";
            this.buttonSalvaModifiche.UseVisualStyleBackColor = true;
            this.buttonSalvaModifiche.Click += new System.EventHandler(this.buttonSalvaModifiche_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(316, 102);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(266, 22);
            this.textBoxNome.TabIndex = 1;
            // 
            // textBoxNuovaQT
            // 
            this.textBoxNuovaQT.Location = new System.Drawing.Point(316, 176);
            this.textBoxNuovaQT.Name = "textBoxNuovaQT";
            this.textBoxNuovaQT.Size = new System.Drawing.Size(266, 22);
            this.textBoxNuovaQT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome prodotto da modificare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nuova quantita in kg";
            // 
            // FormModificaProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 488);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNuovaQT);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonSalvaModifiche);
            this.Name = "FormModificaProd";
            this.Text = "FormModificaProd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalvaModifiche;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxNuovaQT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}