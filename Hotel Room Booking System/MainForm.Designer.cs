using System.Drawing;
using System.Windows.Forms;

namespace Hotel_Room_Booking_System
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel NavigationBar;
        private Panel SideBar;
        private FlowLayoutPanel SideMenuPanel;
        private Panel MainContentPanel;
        private Panel MainPanel;
        private Label lblHotelName;
        private Label lblWelcomeUser;
        private PictureBox picUserAvatar;
        private Button btnBooking;
        private Button btnCheckIn;
        private Button btnCheckOut;
        private Button btnGuests;
        private Button btnPayments;
        private Button btnReports;
        private Button btnSettings;
        private Panel panelLogo;
        private PictureBox picLogo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.NavigationBar = new System.Windows.Forms.Panel();
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.picUserAvatar = new System.Windows.Forms.PictureBox();
            this.lblHotelName = new System.Windows.Forms.Label();
            this.SideBar = new System.Windows.Forms.Panel();
            this.SideMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnGuests = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.MainContentPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.NavigationBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).BeginInit();
            this.SideBar.SuspendLayout();
            this.SideMenuPanel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.MainContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigationBar
            // 
            this.NavigationBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(114)))));
            this.NavigationBar.Controls.Add(this.lblWelcomeUser);
            this.NavigationBar.Controls.Add(this.picUserAvatar);
            this.NavigationBar.Controls.Add(this.lblHotelName);
            this.NavigationBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigationBar.Location = new System.Drawing.Point(0, 0);
            this.NavigationBar.Name = "NavigationBar";
            this.NavigationBar.Size = new System.Drawing.Size(1280, 80);
            this.NavigationBar.TabIndex = 0;
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcomeUser.AutoSize = true;
            this.lblWelcomeUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblWelcomeUser.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeUser.Location = new System.Drawing.Point(1040, 30);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(120, 19);
            this.lblWelcomeUser.TabIndex = 2;
            this.lblWelcomeUser.Text = "Welcome, Admin!";
            // 
            // picUserAvatar
            // 
            this.picUserAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picUserAvatar.Location = new System.Drawing.Point(1180, 15);
            this.picUserAvatar.Name = "picUserAvatar";
            this.picUserAvatar.Size = new System.Drawing.Size(50, 50);
            this.picUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserAvatar.TabIndex = 1;
            this.picUserAvatar.TabStop = false;
            // 
            // lblHotelName
            // 
            this.lblHotelName.AutoSize = true;
            this.lblHotelName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotelName.ForeColor = System.Drawing.Color.White;
            this.lblHotelName.Location = new System.Drawing.Point(20, 20);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(249, 32);
            this.lblHotelName.TabIndex = 0;
            this.lblHotelName.Text = "Gadz Hotel Booking ";
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(122)))));
            this.SideBar.Controls.Add(this.SideMenuPanel);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 80);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(250, 700);
            this.SideBar.TabIndex = 1;
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.SideMenuPanel.Controls.Add(this.panelLogo);
            this.SideMenuPanel.Controls.Add(this.btnBooking);
            this.SideMenuPanel.Controls.Add(this.btnCheckIn);
            this.SideMenuPanel.Controls.Add(this.btnCheckOut);
            this.SideMenuPanel.Controls.Add(this.btnGuests);
            this.SideMenuPanel.Controls.Add(this.btnPayments);
            this.SideMenuPanel.Controls.Add(this.btnReports);
            this.SideMenuPanel.Controls.Add(this.btnSettings);
            this.SideMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SideMenuPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.SideMenuPanel.Size = new System.Drawing.Size(250, 700);
            this.SideMenuPanel.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.picLogo);
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(244, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(50, 10);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(150, 80);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.Transparent;
            this.btnBooking.FlatAppearance.BorderSize = 0;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooking.Location = new System.Drawing.Point(3, 109);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(244, 50);
            this.btnBooking.TabIndex = 1;
            this.btnBooking.Text = "   Room Booking";
            this.btnBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBooking.UseVisualStyleBackColor = false;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckIn.Location = new System.Drawing.Point(3, 165);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(244, 50);
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.Text = "   Guest Check-In";
            this.btnCheckIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckIn.UseVisualStyleBackColor = false;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckOut.Location = new System.Drawing.Point(3, 221);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(244, 50);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "   Guest Check-Out";
            this.btnCheckOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // btnGuests
            // 
            this.btnGuests.BackColor = System.Drawing.Color.Transparent;
            this.btnGuests.FlatAppearance.BorderSize = 0;
            this.btnGuests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuests.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnGuests.ForeColor = System.Drawing.Color.White;
            this.btnGuests.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuests.Location = new System.Drawing.Point(3, 277);
            this.btnGuests.Name = "btnGuests";
            this.btnGuests.Size = new System.Drawing.Size(244, 50);
            this.btnGuests.TabIndex = 4;
            this.btnGuests.Text = "   Guest Management";
            this.btnGuests.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuests.UseVisualStyleBackColor = false;
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.Color.Transparent;
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayments.Location = new System.Drawing.Point(3, 333);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(244, 50);
            this.btnPayments.TabIndex = 5;
            this.btnPayments.Text = "   Payments";
            this.btnPayments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayments.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(3, 389);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(244, 50);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "   Reports";
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(3, 445);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(244, 50);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "   Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // MainContentPanel
            // 
            this.MainContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.MainContentPanel.Controls.Add(this.MainPanel);
            this.MainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContentPanel.Location = new System.Drawing.Point(250, 80);
            this.MainContentPanel.Name = "MainContentPanel";
            this.MainContentPanel.Padding = new System.Windows.Forms.Padding(20);
            this.MainContentPanel.Size = new System.Drawing.Size(1030, 700);
            this.MainContentPanel.TabIndex = 2;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(20, 20);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(990, 660);
            this.MainPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 780);
            this.Controls.Add(this.MainContentPanel);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.NavigationBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grand Horizon Resort - Booking System";
            this.NavigationBar.ResumeLayout(false);
            this.NavigationBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).EndInit();
            this.SideBar.ResumeLayout(false);
            this.SideMenuPanel.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.MainContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}