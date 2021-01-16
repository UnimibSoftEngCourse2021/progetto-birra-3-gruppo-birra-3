
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelCapacitaAtt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSalvaModifiche
            // 
            this.buttonSalvaModifiche.Location = new System.Drawing.Point(93, 278);
            this.buttonSalvaModifiche.Name = "buttonSalvaModifiche";
            this.buttonSalvaModifiche.Size = new System.Drawing.Size(249, 97);
            this.buttonSalvaModifiche.TabIndex = 0;
            this.buttonSalvaModifiche.Text = "SALVA MODIFICHE";
            this.buttonSalvaModifiche.UseVisualStyleBackColor = true;
            this.buttonSalvaModifiche.Click += new System.EventHandler(this.buttonSalvaModifiche_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(284, 100);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(298, 26);
            this.textBoxNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOME PRODOTTO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "QUANTITA\':";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 278);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 97);
            this.button1.TabIndex = 5;
            this.button1.Text = "ELIMINA PRODOTTO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_elimina);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(284, 186);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(300, 26);
            this.numericUpDown1.TabIndex = 6;
            // 
            // labelCapacitaAtt
            // 
            this.labelCapacitaAtt.AutoSize = true;
            this.labelCapacitaAtt.Location = new System.Drawing.Point(591, 192);
            this.labelCapacitaAtt.Name = "labelCapacitaAtt";
            this.labelCapacitaAtt.Size = new System.Drawing.Size(28, 20);
            this.labelCapacitaAtt.TabIndex = 7;
            this.labelCapacitaAtt.Text = "Kg";
            // 
            // FormModificaProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 467);
            this.Controls.Add(this.labelCapacitaAtt);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonSalvaModifiche);
            this.Name = "FormModificaProd";
            this.Text = "MODIFICA PRODOTTO";
            this.Load += new System.EventHandler(this.FormModificaProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalvaModifiche;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelCapacitaAtt;
    }
}