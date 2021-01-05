
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
            this.SuspendLayout();
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Location = new System.Drawing.Point(71, 67);
            this.checkBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(114, 17);
            this.checkBoxPassword.TabIndex = 0;
            this.checkBoxPassword.Text = "Modifica password";
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.CheckedChanged += new System.EventHandler(this.checkBoxPassword_CheckedChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Enabled = false;
            this.textBoxPassword.Location = new System.Drawing.Point(330, 65);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(200, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cosa vuoi fare?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Enabled = false;
            this.textBoxEmail.Location = new System.Drawing.Point(330, 121);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 20);
            this.textBoxEmail.TabIndex = 4;
            // 
            // checkBoxEmail
            // 
            this.checkBoxEmail.AutoSize = true;
            this.checkBoxEmail.Location = new System.Drawing.Point(71, 121);
            this.checkBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEmail.Name = "checkBoxEmail";
            this.checkBoxEmail.Size = new System.Drawing.Size(93, 17);
            this.checkBoxEmail.TabIndex = 3;
            this.checkBoxEmail.Text = "Modifica email";
            this.checkBoxEmail.UseVisualStyleBackColor = true;
            this.checkBoxEmail.CheckedChanged += new System.EventHandler(this.checkBoxEmail_CheckedChanged);
            // 
            // buttonSalva
            // 
            this.buttonSalva.Location = new System.Drawing.Point(390, 159);
            this.buttonSalva.Name = "buttonSalva";
            this.buttonSalva.Size = new System.Drawing.Size(140, 54);
            this.buttonSalva.TabIndex = 5;
            this.buttonSalva.Text = "SALVA";
            this.buttonSalva.UseVisualStyleBackColor = true;
            this.buttonSalva.Click += new System.EventHandler(this.buttonSalva_Click);
            // 
            // buttonEliminaUtente
            // 
            this.buttonEliminaUtente.Location = new System.Drawing.Point(157, 250);
            this.buttonEliminaUtente.Name = "buttonEliminaUtente";
            this.buttonEliminaUtente.Size = new System.Drawing.Size(226, 60);
            this.buttonEliminaUtente.TabIndex = 6;
            this.buttonEliminaUtente.Text = "ELIMINA ACCOUNT";
            this.buttonEliminaUtente.UseVisualStyleBackColor = true;
            this.buttonEliminaUtente.Click += new System.EventHandler(this.buttonEliminaUtente_Click);
            // 
            // FormGestioneUtente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonEliminaUtente);
            this.Controls.Add(this.buttonSalva);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.checkBoxEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.checkBoxPassword);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}