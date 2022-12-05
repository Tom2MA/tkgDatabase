
namespace tkgDatabase
{
    partial class memberForm
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
            this.memberFormPanel = new System.Windows.Forms.Panel();
            this.yourClassLocBox = new System.Windows.Forms.TextBox();
            this.yourClassLocText = new System.Windows.Forms.TextBox();
            this.idText = new System.Windows.Forms.TextBox();
            this.yourClassesList = new System.Windows.Forms.ListBox();
            this.instructorText = new System.Windows.Forms.TextBox();
            this.dayText = new System.Windows.Forms.TextBox();
            this.yourClassesText = new System.Windows.Forms.TextBox();
            this.yourAccountText = new System.Windows.Forms.TextBox();
            this.membersPanel = new System.Windows.Forms.Panel();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.membershipBox = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.membershipText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.startText = new System.Windows.Forms.TextBox();
            this.endText = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.instructorBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.dayBox = new System.Windows.Forms.TextBox();
            this.endBox = new System.Windows.Forms.TextBox();
            this.startBox = new System.Windows.Forms.TextBox();
            this.memberFormPanel.SuspendLayout();
            this.membersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // memberFormPanel
            // 
            this.memberFormPanel.BackColor = System.Drawing.Color.Gold;
            this.memberFormPanel.Controls.Add(this.yourClassLocBox);
            this.memberFormPanel.Controls.Add(this.yourClassLocText);
            this.memberFormPanel.Controls.Add(this.idText);
            this.memberFormPanel.Controls.Add(this.yourClassesList);
            this.memberFormPanel.Controls.Add(this.instructorText);
            this.memberFormPanel.Controls.Add(this.dayText);
            this.memberFormPanel.Controls.Add(this.yourClassesText);
            this.memberFormPanel.Controls.Add(this.yourAccountText);
            this.memberFormPanel.Controls.Add(this.membersPanel);
            this.memberFormPanel.Controls.Add(this.startText);
            this.memberFormPanel.Controls.Add(this.endText);
            this.memberFormPanel.Location = new System.Drawing.Point(-9, -7);
            this.memberFormPanel.Name = "memberFormPanel";
            this.memberFormPanel.Size = new System.Drawing.Size(834, 284);
            this.memberFormPanel.TabIndex = 3;
            // 
            // yourClassLocBox
            // 
            this.yourClassLocBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.yourClassLocBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yourClassLocBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.yourClassLocBox.Location = new System.Drawing.Point(417, 224);
            this.yourClassLocBox.Name = "yourClassLocBox";
            this.yourClassLocBox.ReadOnly = true;
            this.yourClassLocBox.Size = new System.Drawing.Size(363, 27);
            this.yourClassLocBox.TabIndex = 37;
            this.yourClassLocBox.TabStop = false;
            // 
            // yourClassLocText
            // 
            this.yourClassLocText.BackColor = System.Drawing.Color.Gold;
            this.yourClassLocText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yourClassLocText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourClassLocText.Location = new System.Drawing.Point(417, 198);
            this.yourClassLocText.Name = "yourClassLocText";
            this.yourClassLocText.ReadOnly = true;
            this.yourClassLocText.Size = new System.Drawing.Size(152, 20);
            this.yourClassLocText.TabIndex = 38;
            this.yourClassLocText.TabStop = false;
            this.yourClassLocText.Text = "Class Location";
            // 
            // idText
            // 
            this.idText.BackColor = System.Drawing.Color.Gold;
            this.idText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idText.Location = new System.Drawing.Point(33, 264);
            this.idText.Name = "idText";
            this.idText.ReadOnly = true;
            this.idText.Size = new System.Drawing.Size(103, 20);
            this.idText.TabIndex = 0;
            this.idText.TabStop = false;
            this.idText.Text = "Account ID";
            // 
            // yourClassesList
            // 
            this.yourClassesList.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.yourClassesList.FormattingEnabled = true;
            this.yourClassesList.ItemHeight = 22;
            this.yourClassesList.Location = new System.Drawing.Point(417, 50);
            this.yourClassesList.Name = "yourClassesList";
            this.yourClassesList.Size = new System.Drawing.Size(363, 136);
            this.yourClassesList.TabIndex = 21;
            this.yourClassesList.TabStop = false;
            this.yourClassesList.SelectedIndexChanged += new System.EventHandler(this.yourClassesList_SelectedIndexChanged);
            // 
            // instructorText
            // 
            this.instructorText.BackColor = System.Drawing.Color.Gold;
            this.instructorText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructorText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorText.Location = new System.Drawing.Point(150, 264);
            this.instructorText.Name = "instructorText";
            this.instructorText.ReadOnly = true;
            this.instructorText.Size = new System.Drawing.Size(152, 20);
            this.instructorText.TabIndex = 0;
            this.instructorText.TabStop = false;
            this.instructorText.Text = "Instructor";
            // 
            // dayText
            // 
            this.dayText.BackColor = System.Drawing.Color.Gold;
            this.dayText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dayText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayText.Location = new System.Drawing.Point(647, 264);
            this.dayText.Name = "dayText";
            this.dayText.ReadOnly = true;
            this.dayText.Size = new System.Drawing.Size(45, 20);
            this.dayText.TabIndex = 37;
            this.dayText.TabStop = false;
            this.dayText.Text = "Days";
            // 
            // yourClassesText
            // 
            this.yourClassesText.BackColor = System.Drawing.Color.Gold;
            this.yourClassesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yourClassesText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourClassesText.Location = new System.Drawing.Point(417, 24);
            this.yourClassesText.Name = "yourClassesText";
            this.yourClassesText.ReadOnly = true;
            this.yourClassesText.Size = new System.Drawing.Size(113, 20);
            this.yourClassesText.TabIndex = 0;
            this.yourClassesText.TabStop = false;
            this.yourClassesText.Text = "Your Classes";
            // 
            // yourAccountText
            // 
            this.yourAccountText.BackColor = System.Drawing.Color.Gold;
            this.yourAccountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yourAccountText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourAccountText.Location = new System.Drawing.Point(33, 24);
            this.yourAccountText.Name = "yourAccountText";
            this.yourAccountText.ReadOnly = true;
            this.yourAccountText.Size = new System.Drawing.Size(113, 20);
            this.yourAccountText.TabIndex = 0;
            this.yourAccountText.TabStop = false;
            this.yourAccountText.Text = "Your Account";
            // 
            // membersPanel
            // 
            this.membersPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.membersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.membersPanel.Controls.Add(this.phoneBox);
            this.membersPanel.Controls.Add(this.phoneText);
            this.membersPanel.Controls.Add(this.addressBox);
            this.membersPanel.Controls.Add(this.lastNameBox);
            this.membersPanel.Controls.Add(this.firstNameBox);
            this.membersPanel.Controls.Add(this.membershipBox);
            this.membersPanel.Controls.Add(this.addressText);
            this.membersPanel.Controls.Add(this.membershipText);
            this.membersPanel.Controls.Add(this.lastNameText);
            this.membersPanel.Controls.Add(this.firstNameText);
            this.membersPanel.Location = new System.Drawing.Point(33, 49);
            this.membersPanel.Name = "membersPanel";
            this.membersPanel.Size = new System.Drawing.Size(358, 202);
            this.membersPanel.TabIndex = 5;
            // 
            // phoneBox
            // 
            this.phoneBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.phoneBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.phoneBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.phoneBox.Location = new System.Drawing.Point(95, 123);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.ReadOnly = true;
            this.phoneBox.Size = new System.Drawing.Size(248, 27);
            this.phoneBox.TabIndex = 17;
            this.phoneBox.TabStop = false;
            // 
            // phoneText
            // 
            this.phoneText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.phoneText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneText.Location = new System.Drawing.Point(13, 125);
            this.phoneText.Name = "phoneText";
            this.phoneText.ReadOnly = true;
            this.phoneText.Size = new System.Drawing.Size(76, 20);
            this.phoneText.TabIndex = 0;
            this.phoneText.TabStop = false;
            this.phoneText.Text = "Phone #:";
            // 
            // addressBox
            // 
            this.addressBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.addressBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.addressBox.Location = new System.Drawing.Point(95, 89);
            this.addressBox.Name = "addressBox";
            this.addressBox.ReadOnly = true;
            this.addressBox.Size = new System.Drawing.Size(248, 24);
            this.addressBox.TabIndex = 14;
            this.addressBox.TabStop = false;
            // 
            // lastNameBox
            // 
            this.lastNameBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lastNameBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lastNameBox.Location = new System.Drawing.Point(116, 49);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.ReadOnly = true;
            this.lastNameBox.Size = new System.Drawing.Size(227, 27);
            this.lastNameBox.TabIndex = 13;
            this.lastNameBox.TabStop = false;
            // 
            // firstNameBox
            // 
            this.firstNameBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.firstNameBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.firstNameBox.Location = new System.Drawing.Point(116, 13);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.ReadOnly = true;
            this.firstNameBox.Size = new System.Drawing.Size(227, 27);
            this.firstNameBox.TabIndex = 12;
            this.firstNameBox.TabStop = false;
            // 
            // membershipBox
            // 
            this.membershipBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.membershipBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.membershipBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.membershipBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.membershipBox.Location = new System.Drawing.Point(163, 158);
            this.membershipBox.Name = "membershipBox";
            this.membershipBox.ReadOnly = true;
            this.membershipBox.Size = new System.Drawing.Size(180, 27);
            this.membershipBox.TabIndex = 11;
            this.membershipBox.TabStop = false;
            // 
            // addressText
            // 
            this.addressText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addressText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressText.Location = new System.Drawing.Point(13, 89);
            this.addressText.Name = "addressText";
            this.addressText.ReadOnly = true;
            this.addressText.Size = new System.Drawing.Size(76, 20);
            this.addressText.TabIndex = 9;
            this.addressText.TabStop = false;
            this.addressText.Text = "Address:";
            // 
            // membershipText
            // 
            this.membershipText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.membershipText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.membershipText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membershipText.Location = new System.Drawing.Point(9, 161);
            this.membershipText.Name = "membershipText";
            this.membershipText.ReadOnly = true;
            this.membershipText.Size = new System.Drawing.Size(148, 20);
            this.membershipText.TabIndex = 8;
            this.membershipText.TabStop = false;
            this.membershipText.Text = "Gym Membership:";
            // 
            // lastNameText
            // 
            this.lastNameText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lastNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameText.Location = new System.Drawing.Point(13, 52);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.ReadOnly = true;
            this.lastNameText.Size = new System.Drawing.Size(99, 20);
            this.lastNameText.TabIndex = 7;
            this.lastNameText.TabStop = false;
            this.lastNameText.Text = "Last Name:";
            // 
            // firstNameText
            // 
            this.firstNameText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameText.Location = new System.Drawing.Point(13, 16);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.ReadOnly = true;
            this.firstNameText.Size = new System.Drawing.Size(91, 20);
            this.firstNameText.TabIndex = 6;
            this.firstNameText.TabStop = false;
            this.firstNameText.Text = "First Name:";
            // 
            // startText
            // 
            this.startText.BackColor = System.Drawing.Color.Gold;
            this.startText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startText.Location = new System.Drawing.Point(358, 264);
            this.startText.Name = "startText";
            this.startText.ReadOnly = true;
            this.startText.Size = new System.Drawing.Size(84, 20);
            this.startText.TabIndex = 33;
            this.startText.TabStop = false;
            this.startText.Text = "Start Time";
            // 
            // endText
            // 
            this.endText.BackColor = System.Drawing.Color.Gold;
            this.endText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.endText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endText.Location = new System.Drawing.Point(504, 264);
            this.endText.Name = "endText";
            this.endText.ReadOnly = true;
            this.endText.Size = new System.Drawing.Size(75, 20);
            this.endText.TabIndex = 35;
            this.endText.TabStop = false;
            this.endText.Text = "End Time";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.registerButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(24, 329);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(224, 49);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Register For Classes";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.exitButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(547, 329);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(224, 49);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.logoutButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(281, 329);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(231, 49);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // instructorBox
            // 
            this.instructorBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.instructorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instructorBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.instructorBox.Location = new System.Drawing.Point(141, 283);
            this.instructorBox.Name = "instructorBox";
            this.instructorBox.ReadOnly = true;
            this.instructorBox.Size = new System.Drawing.Size(188, 27);
            this.instructorBox.TabIndex = 31;
            this.instructorBox.TabStop = false;
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.idBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.idBox.Location = new System.Drawing.Point(24, 283);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(95, 27);
            this.idBox.TabIndex = 0;
            this.idBox.TabStop = false;
            // 
            // dayBox
            // 
            this.dayBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dayBox.Location = new System.Drawing.Point(638, 283);
            this.dayBox.Name = "dayBox";
            this.dayBox.ReadOnly = true;
            this.dayBox.Size = new System.Drawing.Size(124, 27);
            this.dayBox.TabIndex = 36;
            this.dayBox.TabStop = false;
            // 
            // endBox
            // 
            this.endBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.endBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.endBox.Location = new System.Drawing.Point(495, 283);
            this.endBox.Name = "endBox";
            this.endBox.ReadOnly = true;
            this.endBox.Size = new System.Drawing.Size(124, 27);
            this.endBox.TabIndex = 34;
            this.endBox.TabStop = false;
            // 
            // startBox
            // 
            this.startBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.startBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.startBox.Location = new System.Drawing.Point(349, 283);
            this.startBox.Name = "startBox";
            this.startBox.ReadOnly = true;
            this.startBox.Size = new System.Drawing.Size(124, 27);
            this.startBox.TabIndex = 32;
            this.startBox.TabStop = false;
            // 
            // memberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 399);
            this.ControlBox = false;
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.instructorBox);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.endBox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.memberFormPanel);
            this.Controls.Add(this.startBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "memberForm";
            this.ShowIcon = false;
            this.Text = "TKGym";
            this.memberFormPanel.ResumeLayout(false);
            this.memberFormPanel.PerformLayout();
            this.membersPanel.ResumeLayout(false);
            this.membersPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel memberFormPanel;
        private System.Windows.Forms.TextBox yourAccountText;
        private System.Windows.Forms.Panel membersPanel;
        private System.Windows.Forms.TextBox membershipText;
        private System.Windows.Forms.TextBox yourClassesText;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox membershipBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ListBox yourClassesList;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox instructorText;
        private System.Windows.Forms.TextBox instructorBox;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox dayBox;
        private System.Windows.Forms.TextBox dayText;
        private System.Windows.Forms.TextBox endBox;
        private System.Windows.Forms.TextBox endText;
        private System.Windows.Forms.TextBox startBox;
        private System.Windows.Forms.TextBox startText;
        private System.Windows.Forms.TextBox yourClassLocBox;
        private System.Windows.Forms.TextBox yourClassLocText;
    }
}