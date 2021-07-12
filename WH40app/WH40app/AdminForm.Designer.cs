
namespace WH40app
{
    partial class AdminForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Button_ProdLoad = new System.Windows.Forms.Button();
            this.Button_UserLoad = new System.Windows.Forms.Button();
            this.Del_ID_label = new System.Windows.Forms.Label();
            this.Text_DelID = new System.Windows.Forms.TextBox();
            this.Button_Del = new System.Windows.Forms.Button();
            this.Picture_label = new System.Windows.Forms.Label();
            this.Faction_label = new System.Windows.Forms.Label();
            this.ProdMainData = new System.Windows.Forms.Label();
            this.Picture = new System.Windows.Forms.TextBox();
            this.Faction = new System.Windows.Forms.TextBox();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.ProdQuantity = new System.Windows.Forms.TextBox();
            this.ProdRole = new System.Windows.Forms.TextBox();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.Admin_label = new System.Windows.Forms.Label();
            this.MaindataUser = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Admin = new System.Windows.Forms.TextBox();
            this.Button_Useradd = new System.Windows.Forms.Button();
            this.Button_productAdd = new System.Windows.Forms.Button();
            this.Button_loadOrders = new System.Windows.Forms.Button();
            this.OrdersList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Green;
            this.dataGridView1.Location = new System.Drawing.Point(124, 67);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Copperplate Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(775, 492);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Button_ProdLoad
            // 
            this.Button_ProdLoad.BackColor = System.Drawing.Color.Transparent;
            this.Button_ProdLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Button_ProdLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_ProdLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ProdLoad.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_ProdLoad.ForeColor = System.Drawing.Color.Green;
            this.Button_ProdLoad.Location = new System.Drawing.Point(124, 565);
            this.Button_ProdLoad.Name = "Button_ProdLoad";
            this.Button_ProdLoad.Size = new System.Drawing.Size(248, 32);
            this.Button_ProdLoad.TabIndex = 1;
            this.Button_ProdLoad.Text = "Load Products";
            this.Button_ProdLoad.UseVisualStyleBackColor = false;
            this.Button_ProdLoad.Click += new System.EventHandler(this.Button_ProdLoad_Click);
            // 
            // Button_UserLoad
            // 
            this.Button_UserLoad.BackColor = System.Drawing.Color.Transparent;
            this.Button_UserLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Button_UserLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_UserLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_UserLoad.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_UserLoad.ForeColor = System.Drawing.Color.Green;
            this.Button_UserLoad.Location = new System.Drawing.Point(661, 565);
            this.Button_UserLoad.Name = "Button_UserLoad";
            this.Button_UserLoad.Size = new System.Drawing.Size(238, 32);
            this.Button_UserLoad.TabIndex = 2;
            this.Button_UserLoad.Text = "Load Users";
            this.Button_UserLoad.UseVisualStyleBackColor = false;
            this.Button_UserLoad.Click += new System.EventHandler(this.Button_UserLoad_Click);
            // 
            // Del_ID_label
            // 
            this.Del_ID_label.AutoSize = true;
            this.Del_ID_label.BackColor = System.Drawing.SystemColors.Desktop;
            this.Del_ID_label.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Del_ID_label.ForeColor = System.Drawing.Color.Green;
            this.Del_ID_label.Location = new System.Drawing.Point(124, 639);
            this.Del_ID_label.Name = "Del_ID_label";
            this.Del_ID_label.Size = new System.Drawing.Size(51, 21);
            this.Del_ID_label.TabIndex = 4;
            this.Del_ID_label.Text = "> ID:";
            // 
            // Text_DelID
            // 
            this.Text_DelID.BackColor = System.Drawing.SystemColors.Desktop;
            this.Text_DelID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Text_DelID.ForeColor = System.Drawing.Color.Green;
            this.Text_DelID.Location = new System.Drawing.Point(181, 642);
            this.Text_DelID.Name = "Text_DelID";
            this.Text_DelID.Size = new System.Drawing.Size(51, 23);
            this.Text_DelID.TabIndex = 5;
            // 
            // Button_Del
            // 
            this.Button_Del.BackColor = System.Drawing.Color.Transparent;
            this.Button_Del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Button_Del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Del.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Del.ForeColor = System.Drawing.Color.Green;
            this.Button_Del.Location = new System.Drawing.Point(124, 680);
            this.Button_Del.Name = "Button_Del";
            this.Button_Del.Size = new System.Drawing.Size(108, 32);
            this.Button_Del.TabIndex = 6;
            this.Button_Del.Text = "Delete";
            this.Button_Del.UseVisualStyleBackColor = false;
            this.Button_Del.Click += new System.EventHandler(this.Button_Del_Click);
            // 
            // Picture_label
            // 
            this.Picture_label.AutoSize = true;
            this.Picture_label.BackColor = System.Drawing.SystemColors.Desktop;
            this.Picture_label.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Picture_label.ForeColor = System.Drawing.Color.Green;
            this.Picture_label.Location = new System.Drawing.Point(393, 818);
            this.Picture_label.Name = "Picture_label";
            this.Picture_label.Size = new System.Drawing.Size(108, 21);
            this.Picture_label.TabIndex = 25;
            this.Picture_label.Text = "> Picture:";
            // 
            // Faction_label
            // 
            this.Faction_label.AutoSize = true;
            this.Faction_label.BackColor = System.Drawing.SystemColors.Desktop;
            this.Faction_label.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Faction_label.ForeColor = System.Drawing.Color.Green;
            this.Faction_label.Location = new System.Drawing.Point(389, 789);
            this.Faction_label.Name = "Faction_label";
            this.Faction_label.Size = new System.Drawing.Size(112, 21);
            this.Faction_label.TabIndex = 24;
            this.Faction_label.Text = "> Faction:";
            // 
            // ProdMainData
            // 
            this.ProdMainData.AutoSize = true;
            this.ProdMainData.BackColor = System.Drawing.SystemColors.Desktop;
            this.ProdMainData.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProdMainData.ForeColor = System.Drawing.Color.Green;
            this.ProdMainData.Location = new System.Drawing.Point(265, 753);
            this.ProdMainData.Name = "ProdMainData";
            this.ProdMainData.Size = new System.Drawing.Size(236, 21);
            this.ProdMainData.TabIndex = 23;
            this.ProdMainData.Text = "> Data Prod.Na.-Price:";
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.SystemColors.Desktop;
            this.Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Picture.ForeColor = System.Drawing.Color.Green;
            this.Picture.Location = new System.Drawing.Point(507, 818);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(170, 23);
            this.Picture.TabIndex = 22;
            // 
            // Faction
            // 
            this.Faction.BackColor = System.Drawing.SystemColors.Desktop;
            this.Faction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Faction.ForeColor = System.Drawing.Color.Green;
            this.Faction.Location = new System.Drawing.Point(508, 789);
            this.Faction.Name = "Faction";
            this.Faction.Size = new System.Drawing.Size(169, 23);
            this.Faction.TabIndex = 21;
            // 
            // ProdPrice
            // 
            this.ProdPrice.BackColor = System.Drawing.SystemColors.Desktop;
            this.ProdPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProdPrice.ForeColor = System.Drawing.Color.Green;
            this.ProdPrice.Location = new System.Drawing.Point(847, 751);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(51, 23);
            this.ProdPrice.TabIndex = 20;
            // 
            // ProdQuantity
            // 
            this.ProdQuantity.BackColor = System.Drawing.SystemColors.Desktop;
            this.ProdQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProdQuantity.ForeColor = System.Drawing.Color.Green;
            this.ProdQuantity.Location = new System.Drawing.Point(792, 750);
            this.ProdQuantity.Name = "ProdQuantity";
            this.ProdQuantity.Size = new System.Drawing.Size(51, 23);
            this.ProdQuantity.TabIndex = 19;
            // 
            // ProdRole
            // 
            this.ProdRole.BackColor = System.Drawing.SystemColors.Desktop;
            this.ProdRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProdRole.ForeColor = System.Drawing.Color.Green;
            this.ProdRole.Location = new System.Drawing.Point(678, 750);
            this.ProdRole.Name = "ProdRole";
            this.ProdRole.Size = new System.Drawing.Size(108, 23);
            this.ProdRole.TabIndex = 18;
            // 
            // ProdName
            // 
            this.ProdName.BackColor = System.Drawing.SystemColors.Desktop;
            this.ProdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProdName.ForeColor = System.Drawing.Color.Green;
            this.ProdName.Location = new System.Drawing.Point(507, 750);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(170, 23);
            this.ProdName.TabIndex = 17;
            // 
            // Admin_label
            // 
            this.Admin_label.AutoSize = true;
            this.Admin_label.BackColor = System.Drawing.SystemColors.Desktop;
            this.Admin_label.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Admin_label.ForeColor = System.Drawing.Color.Green;
            this.Admin_label.Location = new System.Drawing.Point(355, 711);
            this.Admin_label.Name = "Admin_label";
            this.Admin_label.Size = new System.Drawing.Size(316, 21);
            this.Admin_label.TabIndex = 32;
            this.Admin_label.Text = "> Data Adm. (0=false 1=true):";
            // 
            // MaindataUser
            // 
            this.MaindataUser.AutoSize = true;
            this.MaindataUser.BackColor = System.Drawing.SystemColors.Desktop;
            this.MaindataUser.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaindataUser.ForeColor = System.Drawing.Color.Green;
            this.MaindataUser.Location = new System.Drawing.Point(355, 677);
            this.MaindataUser.Name = "MaindataUser";
            this.MaindataUser.Size = new System.Drawing.Size(248, 21);
            this.MaindataUser.TabIndex = 31;
            this.MaindataUser.Text = "> Data Username-Email:";
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.SystemColors.Desktop;
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username.ForeColor = System.Drawing.Color.Green;
            this.Username.Location = new System.Drawing.Point(609, 680);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(90, 23);
            this.Username.TabIndex = 29;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.Desktop;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.ForeColor = System.Drawing.Color.Green;
            this.Password.Location = new System.Drawing.Point(706, 682);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(66, 23);
            this.Password.TabIndex = 28;
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.SystemColors.Desktop;
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email.ForeColor = System.Drawing.Color.Green;
            this.Email.Location = new System.Drawing.Point(778, 682);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(120, 23);
            this.Email.TabIndex = 27;
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.SystemColors.Desktop;
            this.Admin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Admin.ForeColor = System.Drawing.Color.Green;
            this.Admin.Location = new System.Drawing.Point(702, 709);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(49, 23);
            this.Admin.TabIndex = 26;
            // 
            // Button_Useradd
            // 
            this.Button_Useradd.BackColor = System.Drawing.Color.Transparent;
            this.Button_Useradd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Button_Useradd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Useradd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Useradd.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Useradd.ForeColor = System.Drawing.Color.Green;
            this.Button_Useradd.Location = new System.Drawing.Point(757, 711);
            this.Button_Useradd.Name = "Button_Useradd";
            this.Button_Useradd.Size = new System.Drawing.Size(141, 21);
            this.Button_Useradd.TabIndex = 33;
            this.Button_Useradd.Text = "Add";
            this.Button_Useradd.UseVisualStyleBackColor = false;
            this.Button_Useradd.Click += new System.EventHandler(this.Button_Useradd_Click);
            // 
            // Button_productAdd
            // 
            this.Button_productAdd.BackColor = System.Drawing.Color.Transparent;
            this.Button_productAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Button_productAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_productAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_productAdd.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_productAdd.ForeColor = System.Drawing.Color.Green;
            this.Button_productAdd.Location = new System.Drawing.Point(683, 791);
            this.Button_productAdd.Name = "Button_productAdd";
            this.Button_productAdd.Size = new System.Drawing.Size(215, 48);
            this.Button_productAdd.TabIndex = 34;
            this.Button_productAdd.Text = "Add";
            this.Button_productAdd.UseVisualStyleBackColor = false;
            this.Button_productAdd.Click += new System.EventHandler(this.Button_productAdd_Click);
            // 
            // Button_loadOrders
            // 
            this.Button_loadOrders.BackColor = System.Drawing.Color.Transparent;
            this.Button_loadOrders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Button_loadOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_loadOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_loadOrders.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_loadOrders.ForeColor = System.Drawing.Color.Green;
            this.Button_loadOrders.Location = new System.Drawing.Point(393, 565);
            this.Button_loadOrders.Name = "Button_loadOrders";
            this.Button_loadOrders.Size = new System.Drawing.Size(248, 62);
            this.Button_loadOrders.TabIndex = 35;
            this.Button_loadOrders.Text = "Load orders";
            this.Button_loadOrders.UseVisualStyleBackColor = false;
            this.Button_loadOrders.Click += new System.EventHandler(this.Button_loadOrders_Click);
            // 
            // OrdersList
            // 
            this.OrdersList.BackColor = System.Drawing.Color.Black;
            this.OrdersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrdersList.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrdersList.ForeColor = System.Drawing.Color.Green;
            this.OrdersList.FormattingEnabled = true;
            this.OrdersList.ItemHeight = 21;
            this.OrdersList.Location = new System.Drawing.Point(398, 645);
            this.OrdersList.Name = "OrdersList";
            this.OrdersList.Size = new System.Drawing.Size(251, 231);
            this.OrdersList.TabIndex = 36;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 1061);
            this.Controls.Add(this.OrdersList);
            this.Controls.Add(this.Button_loadOrders);
            this.Controls.Add(this.Button_productAdd);
            this.Controls.Add(this.Button_Useradd);
            this.Controls.Add(this.Admin_label);
            this.Controls.Add(this.MaindataUser);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.Picture_label);
            this.Controls.Add(this.Faction_label);
            this.Controls.Add(this.ProdMainData);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.Faction);
            this.Controls.Add(this.ProdPrice);
            this.Controls.Add(this.ProdQuantity);
            this.Controls.Add(this.ProdRole);
            this.Controls.Add(this.ProdName);
            this.Controls.Add(this.Button_Del);
            this.Controls.Add(this.Text_DelID);
            this.Controls.Add(this.Del_ID_label);
            this.Controls.Add(this.Button_UserLoad);
            this.Controls.Add(this.Button_ProdLoad);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Button_ProdLoad;
        private System.Windows.Forms.Button Button_UserLoad;
        private System.Windows.Forms.Label Del_ID_label;
        private System.Windows.Forms.TextBox Text_DelID;
        private System.Windows.Forms.Button Button_Del;
        private System.Windows.Forms.Label Picture_label;
        private System.Windows.Forms.Label Faction_label;
        private System.Windows.Forms.Label ProdMainData;
        private System.Windows.Forms.TextBox Picture;
        private System.Windows.Forms.TextBox Faction;
        private System.Windows.Forms.TextBox ProdPrice;
        private System.Windows.Forms.TextBox ProdQuantity;
        private System.Windows.Forms.TextBox ProdRole;
        private System.Windows.Forms.TextBox ProdName;
        private System.Windows.Forms.Label Admin_label;
        private System.Windows.Forms.Label MaindataUser;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Admin;
        private System.Windows.Forms.Button Button_Useradd;
        private System.Windows.Forms.Button Button_productAdd;
        private System.Windows.Forms.Button Button_loadOrders;
        private System.Windows.Forms.ListBox OrdersList;
    }
}