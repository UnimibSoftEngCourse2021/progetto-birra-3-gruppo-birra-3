
namespace ProgettoBirra
{
    partial class FormModificaAtt
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
            this.labelNomeAtt = new System.Windows.Forms.Label();
            this.labelNuovaCp = new System.Windows.Forms.Label();
            this.textBoxNomeAtt = new System.Windows.Forms.TextBox();
            this.textBoxNuovaCP = new System.Windows.Forms.TextBox();
            this.buttonSalvaModifiche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNomeAtt
            // 
            this.labelNomeAtt.AutoSize = true;
            this.labelNomeAtt.Location = new System.Drawing.Point(107, 93);
            this.labelNomeAtt.Name = "labelNomeAtt";
            this.labelNomeAtt.Size = new System.Drawing.Size(212, 20);
            this.labelNomeAtt.TabIndex = 0;
            this.labelNomeAtt.Text = "Nome attrezzo da modificare";
            // 
            // labelNuovaCp
            // 
            this.labelNuovaCp.AutoSize = true;
            this.labelNuovaCp.Location = new System.Drawing.Point(107, 196);
            this.labelNuovaCp.Name = "labelNuovaCp";
            this.labelNuovaCp.Size = new System.Drawing.Size(118, 20);
            this.labelNuovaCp.TabIndex = 1;
            this.labelNuovaCp.Text = "Nuova capacità";
            // 
            // textBoxNomeAtt
            // 
            this.textBoxNomeAtt.Location = new System.Drawing.Point(377, 90);
            this.textBoxNomeAtt.Name = "textBoxNomeAtt";
            this.textBoxNomeAtt.Size = new System.Drawing.Size(259, 26);
            this.textBoxNomeAtt.TabIndex = 2;
            // 
            // textBoxNuovaCP
            // 
            this.textBoxNuovaCP.Location = new System.Drawing.Point(377, 193);
            this.textBoxNuovaCP.Name = "textBoxNuovaCP";
            this.textBoxNuovaCP.Size = new System.Drawing.Size(259, 26);
            this.textBoxNuovaCP.TabIndex = 3;
            // 
            // buttonSalvaModifiche
            // 
            this.buttonSalvaModifiche.Location = new System.Drawing.Point(453, 314);
            this.buttonSalvaModifiche.Name = "buttonSalvaModifiche";
            this.buttonSalvaModifiche.Size = new System.Drawing.Size(183, 89);
            this.buttonSalvaModifiche.TabIndex = 4;
            this.buttonSalvaModifiche.Text = "Salva Modifiche";
            this.buttonSalvaModifiche.UseVisualStyleBackColor = true;
            this.buttonSalvaModifiche.Click += new System.EventHandler(this.buttonSalvaModifiche_Click);
            // 
            // FormModificaAtt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSalvaModifiche);
            this.Controls.Add(this.textBoxNuovaCP);
            this.Controls.Add(this.textBoxNomeAtt);
            this.Controls.Add(this.labelNuovaCp);
            this.Controls.Add(this.labelNomeAtt);
            this.Name = "FormModificaAtt";
            this.Text = "Modifica attrezzo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeAtt;
        private System.Windows.Forms.Label labelNuovaCp;
        private System.Windows.Forms.TextBox textBoxNomeAtt;
        private System.Windows.Forms.TextBox textBoxNuovaCP;
        private System.Windows.Forms.Button buttonSalvaModifiche;
    }
}