
namespace ProgettoBirra
{
    partial class FormRicetta
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.textBoxPreparazione = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProdotti = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAttrezzi = new System.Windows.Forms.TextBox();
            this.buttonModificaRic = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME RICETTA:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(280, 28);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.ReadOnly = true;
            this.textBoxNome.Size = new System.Drawing.Size(234, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 358);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOTE:";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(59, 374);
            this.textBoxNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNote.Size = new System.Drawing.Size(349, 102);
            this.textBoxNote.TabIndex = 3;
            // 
            // textBoxPreparazione
            // 
            this.textBoxPreparazione.Location = new System.Drawing.Point(59, 76);
            this.textBoxPreparazione.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPreparazione.Multiline = true;
            this.textBoxPreparazione.Name = "textBoxPreparazione";
            this.textBoxPreparazione.ReadOnly = true;
            this.textBoxPreparazione.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPreparazione.Size = new System.Drawing.Size(349, 246);
            this.textBoxPreparazione.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "PREPARAZIONE:";
            // 
            // textBoxProdotti
            // 
            this.textBoxProdotti.Location = new System.Drawing.Point(489, 76);
            this.textBoxProdotti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxProdotti.Multiline = true;
            this.textBoxProdotti.Name = "textBoxProdotti";
            this.textBoxProdotti.ReadOnly = true;
            this.textBoxProdotti.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxProdotti.Size = new System.Drawing.Size(192, 220);
            this.textBoxProdotti.TabIndex = 6;
            this.textBoxProdotti.TextChanged += new System.EventHandler(this.textBoxProdotti_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "PRODOTTI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 320);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ATTREZZATURA:";
            // 
            // textBoxAttrezzi
            // 
            this.textBoxAttrezzi.Location = new System.Drawing.Point(489, 336);
            this.textBoxAttrezzi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAttrezzi.Multiline = true;
            this.textBoxAttrezzi.Name = "textBoxAttrezzi";
            this.textBoxAttrezzi.ReadOnly = true;
            this.textBoxAttrezzi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxAttrezzi.Size = new System.Drawing.Size(192, 140);
            this.textBoxAttrezzi.TabIndex = 9;
            // 
            // buttonModificaRic
            // 
            this.buttonModificaRic.Location = new System.Drawing.Point(59, 516);
            this.buttonModificaRic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonModificaRic.Name = "buttonModificaRic";
            this.buttonModificaRic.Size = new System.Drawing.Size(126, 51);
            this.buttonModificaRic.TabIndex = 10;
            this.buttonModificaRic.Text = "SALVA MODIFICHE";
            this.buttonModificaRic.UseVisualStyleBackColor = true;
            this.buttonModificaRic.Click += new System.EventHandler(this.buttonModificaRic_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 516);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 51);
            this.button2.TabIndex = 11;
            this.button2.Text = "ELIMINA RICETTA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonElimina_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 616);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 51);
            this.button1.TabIndex = 12;
            this.button1.Text = "PREPARA QUESTA BIRRA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonPrepara);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 635);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Inserisci quanti litri di birra vuoi fare";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(254, 633);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormRicetta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(756, 682);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonModificaRic);
            this.Controls.Add(this.textBoxAttrezzi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxProdotti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPreparazione);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormRicetta";
            this.Text = "MODIFICA RICETTA";

            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.TextBox textBoxPreparazione;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxProdotti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAttrezzi;
        private System.Windows.Forms.Button buttonModificaRic;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}