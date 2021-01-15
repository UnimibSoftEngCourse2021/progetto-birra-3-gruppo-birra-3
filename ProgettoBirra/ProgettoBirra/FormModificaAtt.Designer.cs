
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
            this.buttonSalvaModifiche = new System.Windows.Forms.Button();
            this.buttonElimina = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomeAtt
            // 
            this.labelNomeAtt.AutoSize = true;
            this.labelNomeAtt.Location = new System.Drawing.Point(34, 40);
            this.labelNomeAtt.Name = "labelNomeAtt";
            this.labelNomeAtt.Size = new System.Drawing.Size(94, 16);
            this.labelNomeAtt.TabIndex = 0;
            this.labelNomeAtt.Text = "Nome attrezzo";
            // 
            // labelNuovaCp
            // 
            this.labelNuovaCp.AutoSize = true;
            this.labelNuovaCp.Location = new System.Drawing.Point(34, 142);
            this.labelNuovaCp.Name = "labelNuovaCp";
            this.labelNuovaCp.Size = new System.Drawing.Size(62, 16);
            this.labelNuovaCp.TabIndex = 1;
            this.labelNuovaCp.Text = "Capacità";
            // 
            // textBoxNomeAtt
            // 
            this.textBoxNomeAtt.Enabled = false;
            this.textBoxNomeAtt.Location = new System.Drawing.Point(253, 40);
            this.textBoxNomeAtt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNomeAtt.Name = "textBoxNomeAtt";
            this.textBoxNomeAtt.Size = new System.Drawing.Size(231, 22);
            this.textBoxNomeAtt.TabIndex = 2;
            // 
            // buttonSalvaModifiche
            // 
            this.buttonSalvaModifiche.Location = new System.Drawing.Point(64, 251);
            this.buttonSalvaModifiche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvaModifiche.Name = "buttonSalvaModifiche";
            this.buttonSalvaModifiche.Size = new System.Drawing.Size(163, 71);
            this.buttonSalvaModifiche.TabIndex = 4;
            this.buttonSalvaModifiche.Text = "Salva Modifiche";
            this.buttonSalvaModifiche.UseVisualStyleBackColor = true;
            this.buttonSalvaModifiche.Click += new System.EventHandler(this.buttonSalvaModifiche_Click);
            // 
            // buttonElimina
            // 
            this.buttonElimina.Location = new System.Drawing.Point(363, 251);
            this.buttonElimina.Name = "buttonElimina";
            this.buttonElimina.Size = new System.Drawing.Size(199, 71);
            this.buttonElimina.TabIndex = 5;
            this.buttonElimina.Text = "Elimina";
            this.buttonElimina.UseVisualStyleBackColor = true;
            this.buttonElimina.Click += new System.EventHandler(this.buttonElimina_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(253, 142);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(231, 22);
            this.numericUpDown1.TabIndex = 7;
            // 
            // FormModificaAtt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonElimina);
            this.Controls.Add(this.buttonSalvaModifiche);
            this.Controls.Add(this.textBoxNomeAtt);
            this.Controls.Add(this.labelNuovaCp);
            this.Controls.Add(this.labelNomeAtt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormModificaAtt";
            this.Text = "Modifica attrezzo";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeAtt;
        private System.Windows.Forms.Label labelNuovaCp;
        private System.Windows.Forms.TextBox textBoxNomeAtt;
        private System.Windows.Forms.Button buttonSalvaModifiche;
        private System.Windows.Forms.Button buttonElimina;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}