using System.Drawing;
using System.Windows.Forms;

namespace Hotel_Room_Booking_System
{
    partial class MainForm
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
            this.NavigationBar = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SideBar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.AssetAssignmentBtn = new System.Windows.Forms.Button();
            this.AssetReturnBtn = new System.Windows.Forms.Button();
            this.UserManagementBtn = new System.Windows.Forms.Button();
            this.AssetManagementBtn = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.NavigationBar.SuspendLayout();
            this.SideBar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigationBar
            // 
            this.NavigationBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(129)))));
            this.NavigationBar.Controls.Add(this.button6);
            this.NavigationBar.Controls.Add(this.User);
            this.NavigationBar.Controls.Add(this.button2);
            this.NavigationBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigationBar.Location = new System.Drawing.Point(0, 0);
            this.NavigationBar.Name = "NavigationBar";
            this.NavigationBar.Size = new System.Drawing.Size(1278, 82);
            this.NavigationBar.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(22, 8);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 63);
            this.button6.TabIndex = 3;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // User
            // 
            this.User.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.User.BackColor = System.Drawing.Color.Transparent;
            this.User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.User.Cursor = System.Windows.Forms.Cursors.Hand;
            this.User.FlatAppearance.BorderSize = 0;
            this.User.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.User.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User.Location = new System.Drawing.Point(1206, 12);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(60, 56);
            this.User.TabIndex = 2;
            this.User.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(98, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(386, 67);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.SideBar.Controls.Add(this.flowLayoutPanel1);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 82);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(231, 647);
            this.SideBar.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(220)))));
            this.flowLayoutPanel1.Controls.Add(this.DashboardBtn);
            this.flowLayoutPanel1.Controls.Add(this.AssetAssignmentBtn);
            this.flowLayoutPanel1.Controls.Add(this.AssetReturnBtn);
            this.flowLayoutPanel1.Controls.Add(this.UserManagementBtn);
            this.flowLayoutPanel1.Controls.Add(this.AssetManagementBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(231, 647);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.BackColor = System.Drawing.Color.Transparent;
            this.DashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(129)))));
            this.DashboardBtn.FlatAppearance.BorderSize = 0;
            this.DashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardBtn.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold);
            this.DashboardBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(129)))));
            this.DashboardBtn.Location = new System.Drawing.Point(15, 15);
            this.DashboardBtn.Margin = new System.Windows.Forms.Padding(15);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Size = new System.Drawing.Size(207, 62);
            this.DashboardBtn.TabIndex = 2;
            this.DashboardBtn.Text = "Booking";
            this.DashboardBtn.UseVisualStyleBackColor = false;
            // 
            // AssetAssignmentBtn
            // 
            this.AssetAssignmentBtn.BackColor = System.Drawing.Color.Transparent;
            this.AssetAssignmentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AssetAssignmentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AssetAssignmentBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(129)))));
            this.AssetAssignmentBtn.FlatAppearance.BorderSize = 0;
            this.AssetAssignmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssetAssignmentBtn.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold);
            this.AssetAssignmentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(129)))));
            this.AssetAssignmentBtn.Location = new System.Drawing.Point(15, 107);
            this.AssetAssignmentBtn.Margin = new System.Windows.Forms.Padding(15);
            this.AssetAssignmentBtn.Name = "AssetAssignmentBtn";
            this.AssetAssignmentBtn.Size = new System.Drawing.Size(207, 62);
            this.AssetAssignmentBtn.TabIndex = 0;
            this.AssetAssignmentBtn.Text = "Check-In";
            this.AssetAssignmentBtn.UseVisualStyleBackColor = false;
            // 
            // AssetReturnBtn
            // 
            this.AssetReturnBtn.BackColor = System.Drawing.Color.Transparent;
            this.AssetReturnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AssetReturnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AssetReturnBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(129)))));
            this.AssetReturnBtn.FlatAppearance.BorderSize = 0;
            this.AssetReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssetReturnBtn.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold);
            this.AssetReturnBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(129)))));
            this.AssetReturnBtn.Location = new System.Drawing.Point(15, 199);
            this.AssetReturnBtn.Margin = new System.Windows.Forms.Padding(15);
            this.AssetReturnBtn.Name = "AssetReturnBtn";
            this.AssetReturnBtn.Size = new System.Drawing.Size(207, 62);
            this.AssetReturnBtn.TabIndex = 5;
            this.AssetReturnBtn.Text = "Check-Out";
            this.AssetReturnBtn.UseVisualStyleBackColor = false;
            // 
            // UserManagementBtn
            // 
            this.UserManagementBtn.BackColor = System.Drawing.Color.Transparent;
            this.UserManagementBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserManagementBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserManagementBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(129)))));
            this.UserManagementBtn.FlatAppearance.BorderSize = 0;
            this.UserManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserManagementBtn.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold);
            this.UserManagementBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(129)))));
            this.UserManagementBtn.Location = new System.Drawing.Point(15, 291);
            this.UserManagementBtn.Margin = new System.Windows.Forms.Padding(15);
            this.UserManagementBtn.Name = "UserManagementBtn";
            this.UserManagementBtn.Size = new System.Drawing.Size(207, 62);
            this.UserManagementBtn.TabIndex = 4;
            this.UserManagementBtn.Text = "Guests";
            this.UserManagementBtn.UseVisualStyleBackColor = false;
            // 
            // AssetManagementBtn
            // 
            this.AssetManagementBtn.BackColor = System.Drawing.Color.Transparent;
            this.AssetManagementBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AssetManagementBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AssetManagementBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(129)))));
            this.AssetManagementBtn.FlatAppearance.BorderSize = 0;
            this.AssetManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssetManagementBtn.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold);
            this.AssetManagementBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(129)))));
            this.AssetManagementBtn.Location = new System.Drawing.Point(15, 383);
            this.AssetManagementBtn.Margin = new System.Windows.Forms.Padding(15);
            this.AssetManagementBtn.Name = "AssetManagementBtn";
            this.AssetManagementBtn.Size = new System.Drawing.Size(207, 62);
            this.AssetManagementBtn.TabIndex = 1;
            this.AssetManagementBtn.Text = "Payments";
            this.AssetManagementBtn.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(220)))));
            this.panel8.Controls.Add(this.MainPanel);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(231, 82);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1047, 647);
            this.panel8.TabIndex = 3;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1047, 647);
            this.MainPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1278, 729);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.NavigationBar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainForm";
            this.Text = "Office Asset Management";
            this.NavigationBar.ResumeLayout(false);
            this.SideBar.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel NavigationBar;
        private Panel SideBar;
        private Button DashboardBtn;
        private Button button2;
        private Button AssetAssignmentBtn;
        private Button AssetManagementBtn;
        private Button User;
        private Button UserManagementBtn;
        private Button button6;
        private Panel panel8;
        private Panel MainPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button AssetReturnBtn;
    }
}

