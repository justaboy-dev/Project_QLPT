namespace Project_QLPT
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChangepass = new System.Windows.Forms.Button();
            this.btnStatis = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMiniMize = new System.Windows.Forms.Button();
            this.btnMinium = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 57);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ PHÒNG TRỌ";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.btnChangepass);
            this.pnlMenu.Controls.Add(this.btnStatis);
            this.pnlMenu.Controls.Add(this.btnRoom);
            this.pnlMenu.Controls.Add(this.btnCustomer);
            this.pnlMenu.Controls.Add(this.btnRent);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 85);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 641);
            this.pnlMenu.TabIndex = 1;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(220, 85);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(980, 641);
            this.pnlDesktop.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btnMiniMize);
            this.panel2.Controls.Add(this.btnMinium);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 28);
            this.panel2.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Image = global::Project_QLPT.Properties.Resources.arrow_button_navigation_circle_left_44449;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 354);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnExit.Size = new System.Drawing.Size(220, 59);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "THOÁT";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChangepass
            // 
            this.btnChangepass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChangepass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangepass.FlatAppearance.BorderSize = 0;
            this.btnChangepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangepass.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnChangepass.Image = global::Project_QLPT.Properties.Resources.expeditedssl_platform_secure_safe_ssl_44645;
            this.btnChangepass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangepass.Location = new System.Drawing.Point(0, 295);
            this.btnChangepass.Name = "btnChangepass";
            this.btnChangepass.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnChangepass.Size = new System.Drawing.Size(220, 59);
            this.btnChangepass.TabIndex = 0;
            this.btnChangepass.Text = "ĐỔI MẬT KHẨU";
            this.btnChangepass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangepass.UseVisualStyleBackColor = false;
            this.btnChangepass.Click += new System.EventHandler(this.btnChangepass_Click);
            // 
            // btnStatis
            // 
            this.btnStatis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnStatis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatis.FlatAppearance.BorderSize = 0;
            this.btnStatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatis.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStatis.Image = global::Project_QLPT.Properties.Resources.calendar_o_time_date_schedule_manage_month_year_reminder_44535;
            this.btnStatis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatis.Location = new System.Drawing.Point(0, 236);
            this.btnStatis.Name = "btnStatis";
            this.btnStatis.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnStatis.Size = new System.Drawing.Size(220, 59);
            this.btnStatis.TabIndex = 0;
            this.btnStatis.Text = "THỐNG KÊ";
            this.btnStatis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatis.UseVisualStyleBackColor = false;
            this.btnStatis.Click += new System.EventHandler(this.btnStatis_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoom.FlatAppearance.BorderSize = 0;
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRoom.Image = global::Project_QLPT.Properties.Resources.building_o_town_highrise_home_flat_apartment_house_44554;
            this.btnRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoom.Location = new System.Drawing.Point(0, 177);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnRoom.Size = new System.Drawing.Size(220, 59);
            this.btnRoom.TabIndex = 0;
            this.btnRoom.Text = "PHÒNG";
            this.btnRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoom.UseVisualStyleBackColor = false;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCustomer.Image = global::Project_QLPT.Properties.Resources.group_team_communication_compney_employee_community_46244;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(0, 118);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnCustomer.Size = new System.Drawing.Size(220, 59);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "KHÁCH THUÊ";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRent.FlatAppearance.BorderSize = 0;
            this.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRent.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRent.Image = global::Project_QLPT.Properties.Resources.hotel_bed_rest_room_person_46269;
            this.btnRent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRent.Location = new System.Drawing.Point(0, 59);
            this.btnRent.Name = "btnRent";
            this.btnRent.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnRent.Size = new System.Drawing.Size(220, 59);
            this.btnRent.TabIndex = 0;
            this.btnRent.Text = "THUÊ PHÒNG";
            this.btnRent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHome.Image = global::Project_QLPT.Properties.Resources.home_house_building_page_city_casa_old_vintage_46266;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnHome.Size = new System.Drawing.Size(220, 59);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "TRANG CHỦ";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(70, 57);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMiniMize
            // 
            this.btnMiniMize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMiniMize.BackgroundImage = global::Project_QLPT.Properties.Resources.bar;
            this.btnMiniMize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMiniMize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMiniMize.FlatAppearance.BorderSize = 0;
            this.btnMiniMize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiniMize.Location = new System.Drawing.Point(1101, 0);
            this.btnMiniMize.Name = "btnMiniMize";
            this.btnMiniMize.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMiniMize.Size = new System.Drawing.Size(33, 28);
            this.btnMiniMize.TabIndex = 2;
            this.btnMiniMize.UseVisualStyleBackColor = false;
            this.btnMiniMize.Click += new System.EventHandler(this.btnMiniMize_Click);
            // 
            // btnMinium
            // 
            this.btnMinium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMinium.BackgroundImage = global::Project_QLPT.Properties.Resources.clone_copy_duplicate_file_44586;
            this.btnMinium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinium.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinium.FlatAppearance.BorderSize = 0;
            this.btnMinium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinium.Location = new System.Drawing.Point(1134, 0);
            this.btnMinium.Name = "btnMinium";
            this.btnMinium.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMinium.Size = new System.Drawing.Size(33, 28);
            this.btnMinium.TabIndex = 1;
            this.btnMinium.UseVisualStyleBackColor = false;
            this.btnMinium.Click += new System.EventHandler(this.btnMinium_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.BackgroundImage = global::Project_QLPT.Properties.Resources.close_remove_cross_multiply_44583;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1167, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnClose.Size = new System.Drawing.Size(33, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 726);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(1200, 726);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng trọ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChangepass;
        private System.Windows.Forms.Button btnStatis;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMiniMize;
        private System.Windows.Forms.Button btnMinium;
        private System.Windows.Forms.Button btnClose;
    }
}