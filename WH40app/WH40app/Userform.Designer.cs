
namespace WH40app
{
    partial class Userform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Userform));
            this.Welcome_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reload = new System.Windows.Forms.Button();
            this.Orders_label = new System.Windows.Forms.Label();
            this.Info_label = new System.Windows.Forms.Label();
            this.Info_label2 = new System.Windows.Forms.Label();
            this.Contact_label = new System.Windows.Forms.Label();
            this.Det_label = new System.Windows.Forms.Label();
            this.Detach_explain1 = new System.Windows.Forms.Label();
            this.Detach_explain2 = new System.Windows.Forms.Label();
            this.Detach_explain3 = new System.Windows.Forms.Label();
            this.Detachments_list = new System.Windows.Forms.ListBox();
            this.Requirements = new System.Windows.Forms.ListBox();
            this.Units = new System.Windows.Forms.ListBox();
            this.Yourlist = new System.Windows.Forms.ListBox();
            this.Button_Export = new System.Windows.Forms.Button();
            this.Helpergrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Helpergrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.BackColor = System.Drawing.SystemColors.Desktop;
            this.Welcome_label.Font = new System.Drawing.Font("Copperplate Gothic Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Welcome_label.ForeColor = System.Drawing.Color.Green;
            this.Welcome_label.Location = new System.Drawing.Point(140, 81);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(223, 26);
            this.Welcome_label.TabIndex = 5;
            this.Welcome_label.Text = "> Welcome_text:";
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
            this.dataGridView1.Location = new System.Drawing.Point(125, 187);
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
            this.dataGridView1.Size = new System.Drawing.Size(775, 213);
            this.dataGridView1.TabIndex = 6;
            // 
            // reload
            // 
            this.reload.BackColor = System.Drawing.Color.Transparent;
            this.reload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.reload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reload.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reload.ForeColor = System.Drawing.Color.Green;
            this.reload.Location = new System.Drawing.Point(379, 406);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(248, 32);
            this.reload.TabIndex = 7;
            this.reload.Text = "Refresh";
            this.reload.UseVisualStyleBackColor = false;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // Orders_label
            // 
            this.Orders_label.AutoSize = true;
            this.Orders_label.BackColor = System.Drawing.SystemColors.Desktop;
            this.Orders_label.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Orders_label.ForeColor = System.Drawing.Color.Green;
            this.Orders_label.Location = new System.Drawing.Point(140, 163);
            this.Orders_label.Name = "Orders_label";
            this.Orders_label.Size = new System.Drawing.Size(162, 21);
            this.Orders_label.TabIndex = 8;
            this.Orders_label.Text = "> Your Orders:";
            // 
            // Info_label
            // 
            this.Info_label.AutoSize = true;
            this.Info_label.BackColor = System.Drawing.SystemColors.Desktop;
            this.Info_label.Font = new System.Drawing.Font("Copperplate Gothic Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Info_label.ForeColor = System.Drawing.Color.Green;
            this.Info_label.Location = new System.Drawing.Point(140, 459);
            this.Info_label.Name = "Info_label";
            this.Info_label.Size = new System.Drawing.Size(374, 12);
            this.Info_label.TabIndex = 9;
            this.Info_label.Text = "> If you can\'t see your order here  it means it\'s completed";
            // 
            // Info_label2
            // 
            this.Info_label2.AutoSize = true;
            this.Info_label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.Info_label2.Font = new System.Drawing.Font("Copperplate Gothic Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Info_label2.ForeColor = System.Drawing.Color.Green;
            this.Info_label2.Location = new System.Drawing.Point(140, 484);
            this.Info_label2.Name = "Info_label2";
            this.Info_label2.Size = new System.Drawing.Size(464, 12);
            this.Info_label2.TabIndex = 9;
            this.Info_label2.Text = "> if you didn\'t received your order and you can\'t see it here contact us.";
            // 
            // Contact_label
            // 
            this.Contact_label.AutoSize = true;
            this.Contact_label.BackColor = System.Drawing.SystemColors.Desktop;
            this.Contact_label.Font = new System.Drawing.Font("Copperplate Gothic Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Contact_label.ForeColor = System.Drawing.Color.Green;
            this.Contact_label.Location = new System.Drawing.Point(140, 508);
            this.Contact_label.Name = "Contact_label";
            this.Contact_label.Size = new System.Drawing.Size(358, 12);
            this.Contact_label.TabIndex = 10;
            this.Contact_label.Text = "> Email: wh40@shops.com Location: Szeged, Király u. 4.";
            // 
            // Det_label
            // 
            this.Det_label.AutoSize = true;
            this.Det_label.BackColor = System.Drawing.SystemColors.Desktop;
            this.Det_label.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Det_label.ForeColor = System.Drawing.Color.Green;
            this.Det_label.Location = new System.Drawing.Point(140, 552);
            this.Det_label.Name = "Det_label";
            this.Det_label.Size = new System.Drawing.Size(287, 21);
            this.Det_label.TabIndex = 11;
            this.Det_label.Text = "> Create your Detachment:";
            // 
            // Detach_explain1
            // 
            this.Detach_explain1.AutoSize = true;
            this.Detach_explain1.BackColor = System.Drawing.SystemColors.Desktop;
            this.Detach_explain1.Font = new System.Drawing.Font("Copperplate Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Detach_explain1.ForeColor = System.Drawing.Color.Green;
            this.Detach_explain1.Location = new System.Drawing.Point(140, 585);
            this.Detach_explain1.Name = "Detach_explain1";
            this.Detach_explain1.Size = new System.Drawing.Size(666, 16);
            this.Detach_explain1.TabIndex = 12;
            this.Detach_explain1.Text = "> It is benefical to organize your models into detachments to get extra bonuses.";
            // 
            // Detach_explain2
            // 
            this.Detach_explain2.AutoSize = true;
            this.Detach_explain2.BackColor = System.Drawing.SystemColors.Desktop;
            this.Detach_explain2.Font = new System.Drawing.Font("Copperplate Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Detach_explain2.ForeColor = System.Drawing.Color.Green;
            this.Detach_explain2.Location = new System.Drawing.Point(140, 612);
            this.Detach_explain2.Name = "Detach_explain2";
            this.Detach_explain2.Size = new System.Drawing.Size(334, 16);
            this.Detach_explain2.TabIndex = 13;
            this.Detach_explain2.Text = "> Each unit has a role in the battlefield.";
            // 
            // Detach_explain3
            // 
            this.Detach_explain3.AutoSize = true;
            this.Detach_explain3.BackColor = System.Drawing.SystemColors.Desktop;
            this.Detach_explain3.Font = new System.Drawing.Font("Copperplate Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Detach_explain3.ForeColor = System.Drawing.Color.Green;
            this.Detach_explain3.Location = new System.Drawing.Point(140, 628);
            this.Detach_explain3.Name = "Detach_explain3";
            this.Detach_explain3.Size = new System.Drawing.Size(439, 16);
            this.Detach_explain3.TabIndex = 14;
            this.Detach_explain3.Text = "> And each detachment have different requirements.";
            // 
            // Detachments_list
            // 
            this.Detachments_list.BackColor = System.Drawing.Color.Black;
            this.Detachments_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Detachments_list.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Detachments_list.ForeColor = System.Drawing.Color.Green;
            this.Detachments_list.FormattingEnabled = true;
            this.Detachments_list.ItemHeight = 21;
            this.Detachments_list.Location = new System.Drawing.Point(140, 660);
            this.Detachments_list.Name = "Detachments_list";
            this.Detachments_list.Size = new System.Drawing.Size(199, 105);
            this.Detachments_list.TabIndex = 37;
            this.Detachments_list.SelectedValueChanged += new System.EventHandler(this.Detachments_list_SelectedValueChanged);
            // 
            // Requirements
            // 
            this.Requirements.BackColor = System.Drawing.Color.Black;
            this.Requirements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Requirements.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Requirements.ForeColor = System.Drawing.Color.Green;
            this.Requirements.FormattingEnabled = true;
            this.Requirements.ItemHeight = 21;
            this.Requirements.Location = new System.Drawing.Point(140, 771);
            this.Requirements.Name = "Requirements";
            this.Requirements.Size = new System.Drawing.Size(199, 105);
            this.Requirements.TabIndex = 38;
            this.Requirements.SelectedValueChanged += new System.EventHandler(this.Requirements_SelectedValueChanged);
            // 
            // Units
            // 
            this.Units.BackColor = System.Drawing.Color.Black;
            this.Units.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Units.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Units.ForeColor = System.Drawing.Color.Green;
            this.Units.FormattingEnabled = true;
            this.Units.ItemHeight = 21;
            this.Units.Location = new System.Drawing.Point(345, 660);
            this.Units.Name = "Units";
            this.Units.Size = new System.Drawing.Size(523, 105);
            this.Units.TabIndex = 39;
            this.Units.SelectedIndexChanged += new System.EventHandler(this.Units_SelectedIndexChanged);
            // 
            // Yourlist
            // 
            this.Yourlist.BackColor = System.Drawing.Color.Black;
            this.Yourlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Yourlist.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Yourlist.ForeColor = System.Drawing.Color.Green;
            this.Yourlist.FormattingEnabled = true;
            this.Yourlist.ItemHeight = 21;
            this.Yourlist.Location = new System.Drawing.Point(345, 771);
            this.Yourlist.Name = "Yourlist";
            this.Yourlist.Size = new System.Drawing.Size(424, 105);
            this.Yourlist.TabIndex = 40;
            this.Yourlist.SelectedIndexChanged += new System.EventHandler(this.Yourlist_SelectedIndexChanged);
            // 
            // Button_Export
            // 
            this.Button_Export.BackColor = System.Drawing.Color.Transparent;
            this.Button_Export.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Button_Export.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Export.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Export.ForeColor = System.Drawing.Color.Green;
            this.Button_Export.Location = new System.Drawing.Point(775, 771);
            this.Button_Export.Name = "Button_Export";
            this.Button_Export.Size = new System.Drawing.Size(93, 105);
            this.Button_Export.TabIndex = 41;
            this.Button_Export.Text = "Export";
            this.Button_Export.UseVisualStyleBackColor = false;
            this.Button_Export.Click += new System.EventHandler(this.Button_Export_Click);
            // 
            // Helpergrid
            // 
            this.Helpergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Helpergrid.Location = new System.Drawing.Point(856, 150);
            this.Helpergrid.Name = "Helpergrid";
            this.Helpergrid.RowTemplate.Height = 25;
            this.Helpergrid.Size = new System.Drawing.Size(34, 34);
            this.Helpergrid.TabIndex = 42;
            // 
            // Userform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 1061);
            this.Controls.Add(this.Helpergrid);
            this.Controls.Add(this.Button_Export);
            this.Controls.Add(this.Yourlist);
            this.Controls.Add(this.Units);
            this.Controls.Add(this.Requirements);
            this.Controls.Add(this.Detachments_list);
            this.Controls.Add(this.Detach_explain3);
            this.Controls.Add(this.Detach_explain2);
            this.Controls.Add(this.Detach_explain1);
            this.Controls.Add(this.Det_label);
            this.Controls.Add(this.Contact_label);
            this.Controls.Add(this.Info_label2);
            this.Controls.Add(this.Info_label);
            this.Controls.Add(this.Orders_label);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Welcome_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Userform";
            this.Text = "Userform";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Userform_FormClosed);
            this.Load += new System.EventHandler(this.Userform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Helpergrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Button_Refresh;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.Label Orders_label;
        private System.Windows.Forms.Label Info_label;
        private System.Windows.Forms.Label Info_label2;
        private System.Windows.Forms.Label Contact_label;
        private System.Windows.Forms.Label Det_label;
        private System.Windows.Forms.Label Detach_explain1;
        private System.Windows.Forms.Label Detach_explain2;
        private System.Windows.Forms.Label Detach_explain3;
        private System.Windows.Forms.ListBox Detachments_list;
        private System.Windows.Forms.ListBox Requirements;
        private System.Windows.Forms.ListBox Units;
        private System.Windows.Forms.ListBox Yourlist;
        private System.Windows.Forms.Button Button_Export;
        private System.Windows.Forms.DataGridView Helpergrid;
    }
}