
namespace ProgettoBirra
{
    partial class FormGestioneUtente
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
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.checkBoxEmail = new System.Windows.Forms.CheckBox();
            this.buttonSalva = new System.Windows.Forms.Button();
            this.buttonEliminaUtente = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Location = new System.Drawing.Point(118, 101);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(212, 24);
            this.checkBoxPassword.TabIndex = 0;
            this.checkBoxPassword.Text = "MODIFICA PASSWORD";
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.CheckedChanged += new System.EventHandler(this.checkBoxPassword_CheckedChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Enabled = false;
            this.textBoxPassword.Location = new System.Drawing.Point(361, 99);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(331, 26);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "COSA DESIDERI?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Enabled = false;
            this.textBoxEmail.Location = new System.Drawing.Point(361, 184);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(331, 26);
            this.textBoxEmail.TabIndex = 4;
            // 
            // checkBoxEmail
            // 
            this.checkBoxEmail.AutoSize = true;
            this.checkBoxEmail.Location = new System.Drawing.Point(118, 184);
            this.checkBoxEmail.Name = "checkBoxEmail";
            this.checkBoxEmail.Size = new System.Drawing.Size(167, 24);
            this.checkBoxEmail.TabIndex = 3;
            this.checkBoxEmail.Text = "MODIFICA EMAIL";
            this.checkBoxEmail.UseVisualStyleBackColor = true;
            this.checkBoxEmail.CheckedChanged += new System.EventHandler(this.checkBoxEmail_CheckedChanged);
            // 
            // buttonSalva
            // 
            this.buttonSalva.Location = new System.Drawing.Point(482, 240);
            this.buttonSalva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSalva.Name = "buttonSalva";
            this.buttonSalva.Size = new System.Drawing.Size(210, 83);
            this.buttonSalva.TabIndex = 5;
            this.buttonSalva.Text = "SALVA MODIFICHE";
            this.buttonSalva.UseVisualStyleBackColor = true;
            this.buttonSalva.Click += new System.EventHandler(this.buttonSalva_Click);
            // 
            // buttonEliminaUtente
            // 
            this.buttonEliminaUtente.Location = new System.Drawing.Point(181, 419);
            this.buttonEliminaUtente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEliminaUtente.Name = "buttonEliminaUtente";
            this.buttonEliminaUtente.Size = new System.Drawing.Size(339, 92);
            this.buttonEliminaUtente.TabIndex = 6;
            this.buttonEliminaUtente.Text = "ELIMINA ACCOUNT";
            this.buttonEliminaUtente.UseVisualStyleBackColor = true;
            this.buttonEliminaUtente.Click += new System.EventHandler(this.buttonEliminaUtente_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(181, 384);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(244, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "CONFERMA ELIMINAZIONE";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormGestioneUtente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 563);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonEliminaUtente);
            this.Controls.Add(this.buttonSalva);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.checkBoxEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.checkBoxPassword);
            this.Name = "FormGestioneUtente";
            this.Text = "MODIFICA ACCOUNT";
            this.Load += new System.EventHandler(this.formGestioneUt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.CheckBox checkBoxEmail;
        private System.Windows.Forms.Button buttonSalva;
        private System.Windows.Forms.Button buttonEliminaUtente;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}