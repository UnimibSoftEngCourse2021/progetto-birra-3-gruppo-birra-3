
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonAggiungiAtt
            // 
            this.buttonAggiungiAtt.Location = new System.Drawing.Point(562, 107);
            this.buttonAggiungiAtt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAggiungiAtt.Name = "buttonAggiungiAtt";
            this.buttonAggiungiAtt.Size = new System.Drawing.Size(183, 153);
            this.buttonAggiungiAtt.TabIndex = 0;
            this.buttonAggiungiAtt.Text = "AGGIUNGI NUOVO ATTREZZO";
            this.buttonAggiungiAtt.UseVisualStyleBackColor = true;
            this.buttonAggiungiAtt.Click += new System.EventHandler(this.buttonAggiungiAtt_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(38, 50);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(476, 304);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // FormGestioneAttrezzatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonAggiungiAtt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGestioneAttrezzatura";
            this.Text = "MAGAZZINO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAggiungiAtt;
        private System.Windows.Forms.ListBox listBox1;
    }
}