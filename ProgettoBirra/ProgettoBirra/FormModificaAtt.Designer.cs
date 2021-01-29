
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
            this.labelCapacitaAtt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomeAtt
            // 
            this.labelNomeAtt.AutoSize = true;
            this.labelNomeAtt.Location = new System.Drawing.Point(111, 85);
            this.labelNomeAtt.Name = "labelNomeAtt";
            this.labelNomeAtt.Size = new System.Drawing.Size(148, 20);
            this.labelNomeAtt.TabIndex = 0;
            this.labelNomeAtt.Text = "NOME ATTREZZO:";
            // 
            // labelNuovaCp
            // 
            this.labelNuovaCp.AutoSize = true;
            this.labelNuovaCp.Location = new System.Drawing.Point(111, 179);
            this.labelNuovaCp.Name = "labelNuovaCp";
            this.labelNuovaCp.Size = new System.Drawing.Size(95, 20);
            this.labelNuovaCp.TabIndex = 1;
            this.labelNuovaCp.Text = "CAPACITA\':";
            // 
            // textBoxNomeAtt
            // 
            this.textBoxNomeAtt.Enabled = false;
            this.textBoxNomeAtt.Location = new System.Drawing.Point(285, 79);
            this.textBoxNomeAtt.Name = "textBoxNomeAtt";
            this.textBoxNomeAtt.Size = new System.Drawing.Size(299, 26);
            this.textBoxNomeAtt.TabIndex = 2;
            // 
            // buttonSalvaModifiche
            // 
            this.buttonSalvaModifiche.Location = new System.Drawing.Point(104, 265);
            this.buttonSalvaModifiche.Name = "buttonSalvaModifiche";
            this.buttonSalvaModifiche.Size = new System.Drawing.Size(239, 100);
            this.buttonSalvaModifiche.TabIndex = 4;
            this.buttonSalvaModifiche.Text = "SALVA MODIFICHE";
            this.buttonSalvaModifiche.UseVisualStyleBackColor = true;
            this.buttonSalvaModifiche.Click += new System.EventHandler(this.buttonSalvaModifiche_Click);
            // 
            // buttonElimina
            // 
            this.buttonElimina.Location = new System.Drawing.Point(418, 265);
            this.buttonElimina.Name = "buttonElimina";
            this.buttonElimina.Size = new System.Drawing.Size(224, 100);
            this.buttonElimina.TabIndex = 5;
            this.buttonElimina.Text = "ELIMINA ATTREZZO";
            this.buttonElimina.UseVisualStyleBackColor = true;
            this.buttonElimina.Click += new System.EventHandler(this.buttonElimina_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(285, 177);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(299, 26);
            this.numericUpDown1.TabIndex = 7;
            // 
            // labelCapacitaAtt
            // 
            this.labelCapacitaAtt.AutoSize = true;
            this.labelCapacitaAtt.Location = new System.Drawing.Point(590, 179);
            this.labelCapacitaAtt.Name = "labelCapacitaAtt";
            this.labelCapacitaAtt.Size = new System.Drawing.Size(18, 20);
            this.labelCapacitaAtt.TabIndex = 8;
            this.labelCapacitaAtt.Text = "L";
            // 
            // FormModificaAtt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.labelCapacitaAtt);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonElimina);
            this.Controls.Add(this.buttonSalvaModifiche);
            this.Controls.Add(this.textBoxNomeAtt);
            this.Controls.Add(this.labelNuovaCp);
            this.Controls.Add(this.labelNomeAtt);
            this.Name = "FormModificaAtt";
            this.Text = "MODIFICA ATTREZZO";
            this.Load += new System.EventHandler(this.FormModificaAtt_Load);
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
        private System.Windows.Forms.Label labelCapacitaAtt;
    }
}