
namespace WH40app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UserText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.UserNamelabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.Infotext = new System.Windows.Forms.Label();
            this.HelperGrid = new System.Windows.Forms.DataGridView();
            this.Infotext2 = new System.Windows.Forms.Label();
            this.Registration = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HelperGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UserText
            // 
            this.UserText.BackColor = System.Drawing.SystemColors.Desktop;
            this.UserText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserText.ForeColor = System.Drawing.Color.Green;
            this.UserText.Location = new System.Drawing.Point(244, 107);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(216, 23);
            this.UserText.TabIndex = 0;
            // 
            // PasswordText
            // 
            this.PasswordText.BackColor = System.Drawing.SystemColors.Desktop;
            this.PasswordText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordText.ForeColor = System.Drawing.Color.Green;
            this.PasswordText.Location = new System.Drawing.Point(244, 149);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(216, 23);
            this.PasswordText.TabIndex = 1;
            // 
            // UserNamelabel
            // 
            this.UserNamelabel.AutoSize = true;
            this.UserNamelabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.UserNamelabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNamelabel.ForeColor = System.Drawing.Color.Green;
            this.UserNamelabel.Location = new System.Drawing.Point(102, 107);
            this.UserNamelabel.Name = "UserNamelabel";
            this.UserNamelabel.Size = new System.Drawing.Size(131, 21);
            this.UserNamelabel.TabIndex = 2;
            this.UserNamelabel.Text = "> Username:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.PasswordLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.ForeColor = System.Drawing.Color.Green;
            this.PasswordLabel.Location = new System.Drawing.Point(102, 146);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(136, 21);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "> Password:";
            // 
            // Infotext
            // 
            this.Infotext.AutoSize = true;
            this.Infotext.BackColor = System.Drawing.SystemColors.Desktop;
            this.Infotext.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Infotext.ForeColor = System.Drawing.Color.Green;
            this.Infotext.Location = new System.Drawing.Point(102, 70);
            this.Infotext.Name = "Infotext";
            this.Infotext.Size = new System.Drawing.Size(486, 21);
            this.Infotext.TabIndex = 4;
            this.Infotext.Text = "> Press the ENTER key after filling login Info";
            // 
            // HelperGrid
            // 
            this.HelperGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HelperGrid.Location = new System.Drawing.Point(102, 530);
            this.HelperGrid.Name = "HelperGrid";
            this.HelperGrid.RowTemplate.Height = 25;
            this.HelperGrid.Size = new System.Drawing.Size(341, 126);
            this.HelperGrid.TabIndex = 5;
            // 
            // Infotext2
            // 
            this.Infotext2.AutoSize = true;
            this.Infotext2.BackColor = System.Drawing.SystemColors.Desktop;
            this.Infotext2.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Infotext2.ForeColor = System.Drawing.Color.Green;
            this.Infotext2.Location = new System.Drawing.Point(102, 796);
            this.Infotext2.Name = "Infotext2";
            this.Infotext2.Size = new System.Drawing.Size(211, 21);
            this.Infotext2.TabIndex = 6;
            this.Infotext2.Text = "> Press ESC to Exit";
            // 
            // Registration
            // 
            this.Registration.BackColor = System.Drawing.Color.Transparent;
            this.Registration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Registration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registration.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Registration.ForeColor = System.Drawing.Color.Green;
            this.Registration.Location = new System.Drawing.Point(102, 204);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(162, 32);
            this.Registration.TabIndex = 8;
            this.Registration.Text = "Registration";
            this.Registration.UseVisualStyleBackColor = false;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(709, 984);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.Infotext2);
            this.Controls.Add(this.HelperGrid);
            this.Controls.Add(this.Infotext);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNamelabel);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.UserText);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Login form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enterpress);
            ((System.ComponentModel.ISupportInitialize)(this.HelperGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label UserNamelabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label Infotext;
        private System.Windows.Forms.DataGridView HelperGrid;
        private System.Windows.Forms.Label Infotext2;
        private System.Windows.Forms.Button Registration;
    }
}

