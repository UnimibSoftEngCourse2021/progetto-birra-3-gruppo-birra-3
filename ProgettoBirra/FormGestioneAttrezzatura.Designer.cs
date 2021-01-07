
namespace ProgettoBirra
{
    partial class FormGestioneAttrezzatura
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
            this.buttonAggiungiAtt = new System.Windows.Forms.Button();
            this.buttonModificaAtt = new System.Windows.Forms.Button();
            this.buttonEliminaAtt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAggiungiAtt
            // 
            this.buttonAggiungiAtt.Location = new System.Drawing.Point(582, 30);
            this.buttonAggiungiAtt.Name = "buttonAggiungiAtt";
            this.buttonAggiungiAtt.Size = new System.Drawing.Size(183, 96);
            this.buttonAggiungiAtt.TabIndex = 0;
            this.buttonAggiungiAtt.Text = "Aggiungi";
            this.buttonAggiungiAtt.UseVisualStyleBackColor = true;
            this.buttonAggiungiAtt.Click += new System.EventHandler(this.buttonAggiungiAtt_Click);
            // 
            // buttonModificaAtt
            // 
            this.buttonModificaAtt.Location = new System.Drawing.Point(582, 170);
            this.buttonModificaAtt.Name = "buttonModificaAtt";
            this.buttonModificaAtt.Size = new System.Drawing.Size(183, 94);
            this.buttonModificaAtt.TabIndex = 1;
            this.buttonModificaAtt.Text = "Modifica";
            this.buttonModificaAtt.UseVisualStyleBackColor = true;
            this.buttonModificaAtt.Click += new System.EventHandler(this.buttonModificaAtt_Click);
            // 
            // buttonEliminaAtt
            // 
            this.buttonEliminaAtt.Location = new System.Drawing.Point(582, 326);
            this.buttonEliminaAtt.Name = "buttonEliminaAtt";
            this.buttonEliminaAtt.Size = new System.Drawing.Size(183, 95);
            this.buttonEliminaAtt.TabIndex = 2;
            this.buttonEliminaAtt.Text = "Elimina";
            this.buttonEliminaAtt.UseVisualStyleBackColor = true;
            this.buttonEliminaAtt.Click += new System.EventHandler(this.buttonEliminaAtt_Click);
            // 
            // FormGestioneAttrezzatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEliminaAtt);
            this.Controls.Add(this.buttonModificaAtt);
            this.Controls.Add(this.buttonAggiungiAtt);
            this.Name = "FormGestioneAttrezzatura";
            this.Text = "Gestione Attrezzatura";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAggiungiAtt;
        private System.Windows.Forms.Button buttonModificaAtt;
        private System.Windows.Forms.Button buttonEliminaAtt;
    }
}