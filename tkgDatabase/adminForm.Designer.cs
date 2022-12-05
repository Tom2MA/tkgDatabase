
namespace tkgDatabase
{
    partial class adminForm
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
            this.adminPanel = new System.Windows.Forms.Panel();
            this.instructorsList = new System.Windows.Forms.ListBox();
            this.instructorsText = new System.Windows.Forms.TextBox();
            this.vendorsList = new System.Windows.Forms.ListBox();
            this.vendorsText = new System.Windows.Forms.TextBox();
            this.membersList = new System.Windows.Forms.ListBox();
            this.classesList = new System.Windows.Forms.ListBox();
            this.classesText = new System.Windows.Forms.TextBox();
            this.membersText = new System.Windows.Forms.TextBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.addClassButton = new System.Windows.Forms.Button();
            this.addVendorButton = new System.Windows.Forms.Button();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.removeClassButton = new System.Windows.Forms.Button();
            this.removeVendorButton = new System.Windows.Forms.Button();
            this.removeMemberButton = new System.Windows.Forms.Button();
            this.removeInstructorButton = new System.Windows.Forms.Button();
            this.addInstructorButton = new System.Windows.Forms.Button();
            this.filterText = new System.Windows.Forms.TextBox();
            this.locationCombo = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.gymsList = new System.Windows.Forms.ListBox();
            this.gymsText = new System.Windows.Forms.TextBox();
            this.addGymButton = new System.Windows.Forms.Button();
            this.removeGymButton = new System.Windows.Forms.Button();
            this.adminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.Color.Gold;
            this.adminPanel.Controls.Add(this.gymsText);
            this.adminPanel.Controls.Add(this.gymsList);
            this.adminPanel.Controls.Add(this.instructorsList);
            this.adminPanel.Controls.Add(this.instructorsText);
            this.adminPanel.Controls.Add(this.vendorsList);
            this.adminPanel.Controls.Add(this.vendorsText);
            this.adminPanel.Controls.Add(this.membersList);
            this.adminPanel.Controls.Add(this.classesList);
            this.adminPanel.Controls.Add(this.classesText);
            this.adminPanel.Controls.Add(this.membersText);
            this.adminPanel.Location = new System.Drawing.Point(-9, -9);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(1352, 287);
            this.adminPanel.TabIndex = 4;
            // 
            // instructorsList
            // 
            this.instructorsList.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.instructorsList.FormattingEnabled = true;
            this.instructorsList.ItemHeight = 22;
            this.instructorsList.Location = new System.Drawing.Point(557, 50);
            this.instructorsList.Name = "instructorsList";
            this.instructorsList.Size = new System.Drawing.Size(227, 202);
            this.instructorsList.TabIndex = 26;
            this.instructorsList.SelectedIndexChanged += new System.EventHandler(this.instructorsList_SelectedIndexChanged);
            // 
            // instructorsText
            // 
            this.instructorsText.BackColor = System.Drawing.Color.Gold;
            this.instructorsText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructorsText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorsText.Location = new System.Drawing.Point(557, 24);
            this.instructorsText.Name = "instructorsText";
            this.instructorsText.ReadOnly = true;
            this.instructorsText.Size = new System.Drawing.Size(113, 20);
            this.instructorsText.TabIndex = 25;
            this.instructorsText.TabStop = false;
            this.instructorsText.Text = "Instructors";
            // 
            // vendorsList
            // 
            this.vendorsList.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.vendorsList.FormattingEnabled = true;
            this.vendorsList.ItemHeight = 22;
            this.vendorsList.Location = new System.Drawing.Point(826, 50);
            this.vendorsList.Name = "vendorsList";
            this.vendorsList.Size = new System.Drawing.Size(227, 202);
            this.vendorsList.TabIndex = 24;
            this.vendorsList.SelectedIndexChanged += new System.EventHandler(this.vendorsList_SelectedIndexChanged);
            // 
            // vendorsText
            // 
            this.vendorsText.BackColor = System.Drawing.Color.Gold;
            this.vendorsText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vendorsText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorsText.Location = new System.Drawing.Point(826, 24);
            this.vendorsText.Name = "vendorsText";
            this.vendorsText.ReadOnly = true;
            this.vendorsText.Size = new System.Drawing.Size(113, 20);
            this.vendorsText.TabIndex = 23;
            this.vendorsText.TabStop = false;
            this.vendorsText.Text = "Vendors";
            // 
            // membersList
            // 
            this.membersList.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.membersList.FormattingEnabled = true;
            this.membersList.ItemHeight = 22;
            this.membersList.Location = new System.Drawing.Point(33, 50);
            this.membersList.Name = "membersList";
            this.membersList.Size = new System.Drawing.Size(227, 202);
            this.membersList.TabIndex = 22;
            this.membersList.SelectedIndexChanged += new System.EventHandler(this.membersList_SelectedIndexChanged);
            // 
            // classesList
            // 
            this.classesList.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.classesList.FormattingEnabled = true;
            this.classesList.ItemHeight = 22;
            this.classesList.Location = new System.Drawing.Point(292, 50);
            this.classesList.Name = "classesList";
            this.classesList.Size = new System.Drawing.Size(227, 202);
            this.classesList.TabIndex = 21;
            this.classesList.SelectedIndexChanged += new System.EventHandler(this.classesList_SelectedIndexChanged);
            // 
            // classesText
            // 
            this.classesText.BackColor = System.Drawing.Color.Gold;
            this.classesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classesText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classesText.Location = new System.Drawing.Point(295, 24);
            this.classesText.Name = "classesText";
            this.classesText.ReadOnly = true;
            this.classesText.Size = new System.Drawing.Size(113, 20);
            this.classesText.TabIndex = 17;
            this.classesText.TabStop = false;
            this.classesText.Text = "Classes";
            // 
            // membersText
            // 
            this.membersText.BackColor = System.Drawing.Color.Gold;
            this.membersText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.membersText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersText.Location = new System.Drawing.Point(33, 24);
            this.membersText.Name = "membersText";
            this.membersText.ReadOnly = true;
            this.membersText.Size = new System.Drawing.Size(113, 20);
            this.membersText.TabIndex = 4;
            this.membersText.TabStop = false;
            this.membersText.Text = "Members";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.logoutButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(548, 435);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(227, 49);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.exitButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(817, 435);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(227, 49);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.viewButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.viewButton.ForeColor = System.Drawing.Color.White;
            this.viewButton.Location = new System.Drawing.Point(283, 435);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(227, 49);
            this.viewButton.TabIndex = 7;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // addClassButton
            // 
            this.addClassButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addClassButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.addClassButton.ForeColor = System.Drawing.Color.White;
            this.addClassButton.Location = new System.Drawing.Point(283, 296);
            this.addClassButton.Name = "addClassButton";
            this.addClassButton.Size = new System.Drawing.Size(227, 49);
            this.addClassButton.TabIndex = 12;
            this.addClassButton.Text = "Add Class";
            this.addClassButton.UseVisualStyleBackColor = false;
            this.addClassButton.Click += new System.EventHandler(this.addClassButton_Click);
            // 
            // addVendorButton
            // 
            this.addVendorButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addVendorButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.addVendorButton.ForeColor = System.Drawing.Color.White;
            this.addVendorButton.Location = new System.Drawing.Point(817, 296);
            this.addVendorButton.Name = "addVendorButton";
            this.addVendorButton.Size = new System.Drawing.Size(227, 49);
            this.addVendorButton.TabIndex = 11;
            this.addVendorButton.Text = "Add Vendor";
            this.addVendorButton.UseVisualStyleBackColor = false;
            this.addVendorButton.Click += new System.EventHandler(this.addVendorButton_Click);
            // 
            // addMemberButton
            // 
            this.addMemberButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addMemberButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.addMemberButton.ForeColor = System.Drawing.Color.White;
            this.addMemberButton.Location = new System.Drawing.Point(24, 296);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(227, 49);
            this.addMemberButton.TabIndex = 10;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = false;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // removeClassButton
            // 
            this.removeClassButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.removeClassButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.removeClassButton.ForeColor = System.Drawing.Color.White;
            this.removeClassButton.Location = new System.Drawing.Point(283, 365);
            this.removeClassButton.Name = "removeClassButton";
            this.removeClassButton.Size = new System.Drawing.Size(227, 49);
            this.removeClassButton.TabIndex = 15;
            this.removeClassButton.Text = "Remove Class";
            this.removeClassButton.UseVisualStyleBackColor = false;
            this.removeClassButton.Click += new System.EventHandler(this.removeClassButton_Click);
            // 
            // removeVendorButton
            // 
            this.removeVendorButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.removeVendorButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.removeVendorButton.ForeColor = System.Drawing.Color.White;
            this.removeVendorButton.Location = new System.Drawing.Point(817, 365);
            this.removeVendorButton.Name = "removeVendorButton";
            this.removeVendorButton.Size = new System.Drawing.Size(227, 49);
            this.removeVendorButton.TabIndex = 14;
            this.removeVendorButton.Text = "Remove Vendor";
            this.removeVendorButton.UseVisualStyleBackColor = false;
            this.removeVendorButton.Click += new System.EventHandler(this.removeVendorButton_Click);
            // 
            // removeMemberButton
            // 
            this.removeMemberButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.removeMemberButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.removeMemberButton.ForeColor = System.Drawing.Color.White;
            this.removeMemberButton.Location = new System.Drawing.Point(24, 365);
            this.removeMemberButton.Name = "removeMemberButton";
            this.removeMemberButton.Size = new System.Drawing.Size(227, 49);
            this.removeMemberButton.TabIndex = 13;
            this.removeMemberButton.Text = "Remove Member";
            this.removeMemberButton.UseVisualStyleBackColor = false;
            this.removeMemberButton.Click += new System.EventHandler(this.removeMemberButton_Click);
            // 
            // removeInstructorButton
            // 
            this.removeInstructorButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.removeInstructorButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.removeInstructorButton.ForeColor = System.Drawing.Color.White;
            this.removeInstructorButton.Location = new System.Drawing.Point(548, 365);
            this.removeInstructorButton.Name = "removeInstructorButton";
            this.removeInstructorButton.Size = new System.Drawing.Size(227, 49);
            this.removeInstructorButton.TabIndex = 17;
            this.removeInstructorButton.Text = "Remove Instructor";
            this.removeInstructorButton.UseVisualStyleBackColor = false;
            this.removeInstructorButton.Click += new System.EventHandler(this.removeInstructorButton_Click);
            // 
            // addInstructorButton
            // 
            this.addInstructorButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addInstructorButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.addInstructorButton.ForeColor = System.Drawing.Color.White;
            this.addInstructorButton.Location = new System.Drawing.Point(548, 296);
            this.addInstructorButton.Name = "addInstructorButton";
            this.addInstructorButton.Size = new System.Drawing.Size(227, 49);
            this.addInstructorButton.TabIndex = 16;
            this.addInstructorButton.Text = "Add Instructor";
            this.addInstructorButton.UseVisualStyleBackColor = false;
            this.addInstructorButton.Click += new System.EventHandler(this.addInstructorButton_Click);
            // 
            // filterText
            // 
            this.filterText.BackColor = System.Drawing.SystemColors.Control;
            this.filterText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filterText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterText.Location = new System.Drawing.Point(24, 435);
            this.filterText.Name = "filterText";
            this.filterText.ReadOnly = true;
            this.filterText.Size = new System.Drawing.Size(144, 20);
            this.filterText.TabIndex = 27;
            this.filterText.TabStop = false;
            this.filterText.Text = "Filter By Location";
            // 
            // locationCombo
            // 
            this.locationCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationCombo.FormattingEnabled = true;
            this.locationCombo.Location = new System.Drawing.Point(24, 463);
            this.locationCombo.Name = "locationCombo";
            this.locationCombo.Size = new System.Drawing.Size(227, 21);
            this.locationCombo.TabIndex = 28;
            this.locationCombo.SelectedIndexChanged += new System.EventHandler(this.locationCombo_SelectedIndexChanged);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.clearButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 10F);
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(166, 435);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(85, 22);
            this.clearButton.TabIndex = 29;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // gymsList
            // 
            this.gymsList.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.gymsList.FormattingEnabled = true;
            this.gymsList.ItemHeight = 22;
            this.gymsList.Location = new System.Drawing.Point(1094, 50);
            this.gymsList.Name = "gymsList";
            this.gymsList.Size = new System.Drawing.Size(227, 202);
            this.gymsList.TabIndex = 27;
            this.gymsList.SelectedIndexChanged += new System.EventHandler(this.gymsList_SelectedIndexChanged);
            // 
            // gymsText
            // 
            this.gymsText.BackColor = System.Drawing.Color.Gold;
            this.gymsText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gymsText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gymsText.Location = new System.Drawing.Point(1094, 24);
            this.gymsText.Name = "gymsText";
            this.gymsText.ReadOnly = true;
            this.gymsText.Size = new System.Drawing.Size(113, 20);
            this.gymsText.TabIndex = 28;
            this.gymsText.TabStop = false;
            this.gymsText.Text = "Gyms";
            // 
            // addGymButton
            // 
            this.addGymButton.BackColor = System.Drawing.Color.LimeGreen;
            this.addGymButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.addGymButton.ForeColor = System.Drawing.Color.Black;
            this.addGymButton.Location = new System.Drawing.Point(1085, 296);
            this.addGymButton.Name = "addGymButton";
            this.addGymButton.Size = new System.Drawing.Size(227, 49);
            this.addGymButton.TabIndex = 30;
            this.addGymButton.Text = "Add Gym";
            this.addGymButton.UseVisualStyleBackColor = false;
            this.addGymButton.Click += new System.EventHandler(this.addGymButton_Click);
            // 
            // removeGymButton
            // 
            this.removeGymButton.BackColor = System.Drawing.Color.OrangeRed;
            this.removeGymButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.removeGymButton.ForeColor = System.Drawing.Color.White;
            this.removeGymButton.Location = new System.Drawing.Point(1085, 365);
            this.removeGymButton.Name = "removeGymButton";
            this.removeGymButton.Size = new System.Drawing.Size(227, 49);
            this.removeGymButton.TabIndex = 31;
            this.removeGymButton.Text = "Remove Gym";
            this.removeGymButton.UseVisualStyleBackColor = false;
            this.removeGymButton.Click += new System.EventHandler(this.removeGymButton_Click);
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 515);
            this.ControlBox = false;
            this.Controls.Add(this.removeGymButton);
            this.Controls.Add(this.addGymButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.locationCombo);
            this.Controls.Add(this.filterText);
            this.Controls.Add(this.removeInstructorButton);
            this.Controls.Add(this.addInstructorButton);
            this.Controls.Add(this.removeClassButton);
            this.Controls.Add(this.removeVendorButton);
            this.Controls.Add(this.removeMemberButton);
            this.Controls.Add(this.addClassButton);
            this.Controls.Add(this.addVendorButton);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.adminPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "adminForm";
            this.Text = "TKGym";
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.ListBox classesList;
        private System.Windows.Forms.TextBox classesText;
        private System.Windows.Forms.TextBox membersText;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.ListBox membersList;
        private System.Windows.Forms.ListBox vendorsList;
        private System.Windows.Forms.TextBox vendorsText;
        private System.Windows.Forms.Button addClassButton;
        private System.Windows.Forms.Button addVendorButton;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Button removeClassButton;
        private System.Windows.Forms.Button removeVendorButton;
        private System.Windows.Forms.Button removeMemberButton;
        private System.Windows.Forms.ListBox instructorsList;
        private System.Windows.Forms.TextBox instructorsText;
        private System.Windows.Forms.Button removeInstructorButton;
        private System.Windows.Forms.Button addInstructorButton;
        private System.Windows.Forms.TextBox filterText;
        private System.Windows.Forms.ComboBox locationCombo;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox gymsText;
        private System.Windows.Forms.ListBox gymsList;
        private System.Windows.Forms.Button addGymButton;
        private System.Windows.Forms.Button removeGymButton;
    }
}