
namespace ProgettoBirra
{
    partial class FormGestioneRicette
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
            this.buttonAggiungi = new System.Windows.Forms.Button();
            this.buttonModifica = new System.Windows.Forms.Button();
            this.buttonElimina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAggiungi
            // 
            this.buttonAggiungi.Location = new System.Drawing.Point(422, 66);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(116, 58);
            this.buttonAggiungi.TabIndex = 0;
            this.buttonAggiungi.Text = "AGGIUNGI";
            this.buttonAggiungi.UseVisualStyleBackColor = true;
            this.buttonAggiungi.Click += new System.EventHandler(this.buttonAggiungi_Click);
            // 
            // buttonModifica
            // 
            this.buttonModifica.Location = new System.Drawing.Point(422, 159);
            this.buttonModifica.Name = "buttonModifica";
            this.buttonModifica.Size = new System.Drawing.Size(112, 58);
            this.buttonModifica.TabIndex = 1;
            this.buttonModifica.Text = "MODIFICA";
            this.buttonModifica.UseVisualStyleBackColor = true;
            // 
            // buttonElimina
            // 
            this.buttonElimina.Location = new System.Drawing.Point(422, 265);
            this.buttonElimina.Name = "buttonElimina";
            this.buttonElimina.Size = new System.Drawing.Size(112, 60);
            this.buttonElimina.TabIndex = 2;
            this.buttonElimina.Text = "ELIMINA";
            this.buttonElimina.UseVisualStyleBackColor = true;
            // 
            // FormGesioneRicette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 434);
            this.Controls.Add(this.buttonElimina);
            this.Controls.Add(this.buttonModifica);
            this.Controls.Add(this.buttonAggiungi);
            this.Name = "FormGesioneRicette";
            this.Text = "FormGesioneRicette";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAggiungi;
        private System.Windows.Forms.Button buttonModifica;
        private System.Windows.Forms.Button buttonElimina;
    }
}