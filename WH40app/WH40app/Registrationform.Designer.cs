
namespace WH40app
{
    partial class Registrationform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrationform));
            this.Registration = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNamelabel = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.UserText = new System.Windows.Forms.TextBox();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.Emailtext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Registration
            // 
            this.Registration.BackColor = System.Drawing.Color.Transparent;
            this.Registration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Registration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registration.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Registration.ForeColor = System.Drawing.Color.Green;
            this.Registration.Location = new System.Drawing.Point(174, 237);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(176, 48);
            this.Registration.TabIndex = 13;
            this.Registration.Text = "Registration";
            this.Registration.UseVisualStyleBackColor = false;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.PasswordLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.ForeColor = System.Drawing.Color.Green;
            this.PasswordLabel.Location = new System.Drawing.Point(82, 147);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(136, 21);
            this.PasswordLabel.TabIndex = 12;
            this.PasswordLabel.Text = "> Password:";
            // 
            // UserNamelabel
            // 
            this.UserNamelabel.AutoSize = true;
            this.UserNamelabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.UserNamelabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNamelabel.ForeColor = System.Drawing.Color.Green;
            this.UserNamelabel.Location = new System.Drawing.Point(82, 59);
            this.UserNamelabel.Name = "UserNamelabel";
            this.UserNamelabel.Size = new System.Drawing.Size(131, 21);
            this.UserNamelabel.TabIndex = 11;
            this.UserNamelabel.Text = "> Username:";
            // 
            // PasswordText
            // 
            this.PasswordText.BackColor = System.Drawing.SystemColors.Desktop;
            this.PasswordText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordText.ForeColor = System.Drawing.Color.Green;
            this.PasswordText.Location = new System.Drawing.Point(229, 147);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(216, 23);
            this.PasswordText.TabIndex = 10;
            // 
            // UserText
            // 
            this.UserText.BackColor = System.Drawing.SystemColors.Desktop;
            this.UserText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserText.ForeColor = System.Drawing.Color.Green;
            this.UserText.Location = new System.Drawing.Point(229, 59);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(216, 23);
            this.UserText.TabIndex = 9;
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.Emaillabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Emaillabel.ForeColor = System.Drawing.Color.Green;
            this.Emaillabel.Location = new System.Drawing.Point(82, 102);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(87, 21);
            this.Emaillabel.TabIndex = 14;
            this.Emaillabel.Text = "> Email:";
            // 
            // Emailtext
            // 
            this.Emailtext.BackColor = System.Drawing.SystemColors.Desktop;
            this.Emailtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Emailtext.ForeColor = System.Drawing.Color.Green;
            this.Emailtext.Location = new System.Drawing.Point(229, 102);
            this.Emailtext.Name = "Emailtext";
            this.Emailtext.Size = new System.Drawing.Size(216, 23);
            this.Emailtext.TabIndex = 15;
            // 
            // Registrationform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(515, 629);
            this.Controls.Add(this.Emailtext);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNamelabel);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.UserText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registrationform";
            this.Text = "Registrationform";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registrationform_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserNamelabel;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.TextBox Emailtext;
    }
}