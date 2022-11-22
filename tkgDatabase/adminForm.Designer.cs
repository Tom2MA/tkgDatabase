
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
            this.instructorsList = new System.Windows.Forms.ListBox();
            this.instructorsText = new System.Windows.Forms.TextBox();
            this.removeInstructorButton = new System.Windows.Forms.Button();
            this.addInstructorButton = new System.Windows.Forms.Button();
            this.adminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.Color.Gold;
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
            this.adminPanel.Size = new System.Drawing.Size(1145, 287);
            this.adminPanel.TabIndex = 4;
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
            this.logoutButton.Location = new System.Drawing.Point(430, 444);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(224, 49);
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
            this.exitButton.Location = new System.Drawing.Point(692, 444);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(224, 49);
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
            this.viewButton.Location = new System.Drawing.Point(175, 444);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(224, 49);
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
            this.addClassButton.Location = new System.Drawing.Point(298, 308);
            this.addClassButton.Name = "addClassButton";
            this.addClassButton.Size = new System.Drawing.Size(224, 49);
            this.addClassButton.TabIndex = 12;
            this.addClassButton.Text = "Add Class";
            this.addClassButton.UseVisualStyleBackColor = false;
            // 
            // addVendorButton
            // 
            this.addVendorButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addVendorButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.addVendorButton.ForeColor = System.Drawing.Color.White;
            this.addVendorButton.Location = new System.Drawing.Point(820, 308);
            this.addVendorButton.Name = "addVendorButton";
            this.addVendorButton.Size = new System.Drawing.Size(224, 49);
            this.addVendorButton.TabIndex = 11;
            this.addVendorButton.Text = "Add Vendor";
            this.addVendorButton.UseVisualStyleBackColor = false;
            // 
            // addMemberButton
            // 
            this.addMemberButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addMemberButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.addMemberButton.ForeColor = System.Drawing.Color.White;
            this.addMemberButton.Location = new System.Drawing.Point(51, 308);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(224, 49);
            this.addMemberButton.TabIndex = 10;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = false;
            // 
            // removeClassButton
            // 
            this.removeClassButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.removeClassButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.removeClassButton.ForeColor = System.Drawing.Color.White;
            this.removeClassButton.Location = new System.Drawing.Point(298, 376);
            this.removeClassButton.Name = "removeClassButton";
            this.removeClassButton.Size = new System.Drawing.Size(224, 49);
            this.removeClassButton.TabIndex = 15;
            this.removeClassButton.Text = "Remove Class";
            this.removeClassButton.UseVisualStyleBackColor = false;
            // 
            // removeVendorButton
            // 
            this.removeVendorButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.removeVendorButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.removeVendorButton.ForeColor = System.Drawing.Color.White;
            this.removeVendorButton.Location = new System.Drawing.Point(820, 376);
            this.removeVendorButton.Name = "removeVendorButton";
            this.removeVendorButton.Size = new System.Drawing.Size(224, 49);
            this.removeVendorButton.TabIndex = 14;
            this.removeVendorButton.Text = "Remove Vendor";
            this.removeVendorButton.UseVisualStyleBackColor = false;
            // 
            // removeMemberButton
            // 
            this.removeMemberButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.removeMemberButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.removeMemberButton.ForeColor = System.Drawing.Color.White;
            this.removeMemberButton.Location = new System.Drawing.Point(51, 376);
            this.removeMemberButton.Name = "removeMemberButton";
            this.removeMemberButton.Size = new System.Drawing.Size(224, 49);
            this.removeMemberButton.TabIndex = 13;
            this.removeMemberButton.Text = "Remove Member";
            this.removeMemberButton.UseVisualStyleBackColor = false;
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
            // removeInstructorButton
            // 
            this.removeInstructorButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.removeInstructorButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.removeInstructorButton.ForeColor = System.Drawing.Color.White;
            this.removeInstructorButton.Location = new System.Drawing.Point(551, 376);
            this.removeInstructorButton.Name = "removeInstructorButton";
            this.removeInstructorButton.Size = new System.Drawing.Size(224, 49);
            this.removeInstructorButton.TabIndex = 17;
            this.removeInstructorButton.Text = "Remove Instructor";
            this.removeInstructorButton.UseVisualStyleBackColor = false;
            // 
            // addInstructorButton
            // 
            this.addInstructorButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addInstructorButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.addInstructorButton.ForeColor = System.Drawing.Color.White;
            this.addInstructorButton.Location = new System.Drawing.Point(551, 308);
            this.addInstructorButton.Name = "addInstructorButton";
            this.addInstructorButton.Size = new System.Drawing.Size(224, 49);
            this.addInstructorButton.TabIndex = 16;
            this.addInstructorButton.Text = "Add Instructor";
            this.addInstructorButton.UseVisualStyleBackColor = false;
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 515);
            this.ControlBox = false;
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
    }
}