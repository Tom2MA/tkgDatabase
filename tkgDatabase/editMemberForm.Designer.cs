
namespace tkgDatabase
{
    partial class editMemberForm
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
            this.premiumBox = new System.Windows.Forms.CheckBox();
            this.standardBox = new System.Windows.Forms.CheckBox();
            this.registerFormPanel = new System.Windows.Forms.Panel();
            this.showPasswordBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.accountText = new System.Windows.Forms.TextBox();
            this.membersPanel = new System.Windows.Forms.Panel();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.registerFormPanel.SuspendLayout();
            this.membersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // premiumBox
            // 
            this.premiumBox.AutoSize = true;
            this.premiumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.premiumBox.Location = new System.Drawing.Point(123, 333);
            this.premiumBox.Name = "premiumBox";
            this.premiumBox.Size = new System.Drawing.Size(87, 22);
            this.premiumBox.TabIndex = 14;
            this.premiumBox.Text = "Premium";
            this.premiumBox.UseVisualStyleBackColor = true;
            this.premiumBox.Click += new System.EventHandler(this.premiumBox_Click);
            // 
            // standardBox
            // 
            this.standardBox.AutoSize = true;
            this.standardBox.Checked = true;
            this.standardBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.standardBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.standardBox.Location = new System.Drawing.Point(31, 333);
            this.standardBox.Name = "standardBox";
            this.standardBox.Size = new System.Drawing.Size(86, 22);
            this.standardBox.TabIndex = 13;
            this.standardBox.Text = "Standard";
            this.standardBox.UseVisualStyleBackColor = true;
            this.standardBox.Click += new System.EventHandler(this.standardBox_Click);
            // 
            // registerFormPanel
            // 
            this.registerFormPanel.BackColor = System.Drawing.Color.Gold;
            this.registerFormPanel.Controls.Add(this.showPasswordBox);
            this.registerFormPanel.Controls.Add(this.textBox1);
            this.registerFormPanel.Controls.Add(this.accountText);
            this.registerFormPanel.Controls.Add(this.membersPanel);
            this.registerFormPanel.Location = new System.Drawing.Point(-2, -6);
            this.registerFormPanel.Name = "registerFormPanel";
            this.registerFormPanel.Size = new System.Drawing.Size(469, 333);
            this.registerFormPanel.TabIndex = 12;
            // 
            // showPasswordBox
            // 
            this.showPasswordBox.AutoSize = true;
            this.showPasswordBox.Location = new System.Drawing.Point(312, 300);
            this.showPasswordBox.Name = "showPasswordBox";
            this.showPasswordBox.Size = new System.Drawing.Size(102, 17);
            this.showPasswordBox.TabIndex = 7;
            this.showPasswordBox.Text = "Show Password";
            this.showPasswordBox.UseVisualStyleBackColor = true;
            this.showPasswordBox.CheckedChanged += new System.EventHandler(this.showPasswordBox_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gold;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(33, 313);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(105, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Membership";
            // 
            // accountText
            // 
            this.accountText.BackColor = System.Drawing.Color.Gold;
            this.accountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountText.Location = new System.Drawing.Point(33, 20);
            this.accountText.Name = "accountText";
            this.accountText.ReadOnly = true;
            this.accountText.Size = new System.Drawing.Size(147, 20);
            this.accountText.TabIndex = 0;
            this.accountText.TabStop = false;
            this.accountText.Text = "Register Account";
            // 
            // membersPanel
            // 
            this.membersPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.membersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.membersPanel.Controls.Add(this.phoneBox);
            this.membersPanel.Controls.Add(this.usernameText);
            this.membersPanel.Controls.Add(this.phoneText);
            this.membersPanel.Controls.Add(this.usernameBox);
            this.membersPanel.Controls.Add(this.passwordText);
            this.membersPanel.Controls.Add(this.addressBox);
            this.membersPanel.Controls.Add(this.passwordBox);
            this.membersPanel.Controls.Add(this.lastNameBox);
            this.membersPanel.Controls.Add(this.firstNameBox);
            this.membersPanel.Controls.Add(this.addressText);
            this.membersPanel.Controls.Add(this.lastNameText);
            this.membersPanel.Controls.Add(this.firstNameText);
            this.membersPanel.Location = new System.Drawing.Point(33, 46);
            this.membersPanel.Name = "membersPanel";
            this.membersPanel.Size = new System.Drawing.Size(381, 248);
            this.membersPanel.TabIndex = 5;
            // 
            // phoneBox
            // 
            this.phoneBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.phoneBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.phoneBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.phoneBox.Location = new System.Drawing.Point(118, 205);
            this.phoneBox.MaxLength = 10;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(246, 30);
            this.phoneBox.TabIndex = 17;
            this.phoneBox.TabStop = false;
            this.phoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneBox_KeyPress);
            // 
            // usernameText
            // 
            this.usernameText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.usernameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.Location = new System.Drawing.Point(13, 10);
            this.usernameText.Name = "usernameText";
            this.usernameText.ReadOnly = true;
            this.usernameText.Size = new System.Drawing.Size(99, 20);
            this.usernameText.TabIndex = 10;
            this.usernameText.TabStop = false;
            this.usernameText.Text = "Username:";
            // 
            // phoneText
            // 
            this.phoneText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.phoneText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneText.Location = new System.Drawing.Point(22, 208);
            this.phoneText.Name = "phoneText";
            this.phoneText.ReadOnly = true;
            this.phoneText.Size = new System.Drawing.Size(82, 20);
            this.phoneText.TabIndex = 0;
            this.phoneText.TabStop = false;
            this.phoneText.Text = "Phone #:";
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameBox.Enabled = false;
            this.usernameBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.usernameBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.usernameBox.Location = new System.Drawing.Point(118, 7);
            this.usernameBox.MaxLength = 45;
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(246, 30);
            this.usernameBox.TabIndex = 15;
            this.usernameBox.TabStop = false;
            // 
            // passwordText
            // 
            this.passwordText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.Location = new System.Drawing.Point(13, 46);
            this.passwordText.Name = "passwordText";
            this.passwordText.ReadOnly = true;
            this.passwordText.Size = new System.Drawing.Size(99, 20);
            this.passwordText.TabIndex = 8;
            this.passwordText.TabStop = false;
            this.passwordText.Text = "Password:";
            // 
            // addressBox
            // 
            this.addressBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.addressBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.addressBox.Location = new System.Drawing.Point(118, 164);
            this.addressBox.MaxLength = 45;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(246, 30);
            this.addressBox.TabIndex = 14;
            this.addressBox.TabStop = false;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.passwordBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.passwordBox.Location = new System.Drawing.Point(118, 43);
            this.passwordBox.MaxLength = 45;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(246, 30);
            this.passwordBox.TabIndex = 11;
            this.passwordBox.TabStop = false;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // lastNameBox
            // 
            this.lastNameBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lastNameBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lastNameBox.Location = new System.Drawing.Point(118, 121);
            this.lastNameBox.MaxLength = 45;
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(246, 30);
            this.lastNameBox.TabIndex = 13;
            this.lastNameBox.TabStop = false;
            // 
            // firstNameBox
            // 
            this.firstNameBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.firstNameBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.firstNameBox.Location = new System.Drawing.Point(118, 82);
            this.firstNameBox.MaxLength = 45;
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(246, 30);
            this.firstNameBox.TabIndex = 12;
            this.firstNameBox.TabStop = false;
            // 
            // addressText
            // 
            this.addressText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addressText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressText.Location = new System.Drawing.Point(22, 167);
            this.addressText.Name = "addressText";
            this.addressText.ReadOnly = true;
            this.addressText.Size = new System.Drawing.Size(76, 20);
            this.addressText.TabIndex = 9;
            this.addressText.TabStop = false;
            this.addressText.Text = "Address:";
            // 
            // lastNameText
            // 
            this.lastNameText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lastNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameText.Location = new System.Drawing.Point(13, 124);
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
            this.firstNameText.Location = new System.Drawing.Point(13, 85);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.ReadOnly = true;
            this.firstNameText.Size = new System.Drawing.Size(91, 20);
            this.firstNameText.TabIndex = 6;
            this.firstNameText.TabStop = false;
            this.firstNameText.Text = "First Name:";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.backButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(224, 374);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(188, 49);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(31, 374);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(175, 49);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // editMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.ControlBox = false;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.premiumBox);
            this.Controls.Add(this.standardBox);
            this.Controls.Add(this.registerFormPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editMemberForm";
            this.ShowIcon = false;
            this.Text = "TKGym";
            this.registerFormPanel.ResumeLayout(false);
            this.registerFormPanel.PerformLayout();
            this.membersPanel.ResumeLayout(false);
            this.membersPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox premiumBox;
        private System.Windows.Forms.CheckBox standardBox;
        private System.Windows.Forms.Panel registerFormPanel;
        private System.Windows.Forms.CheckBox showPasswordBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox accountText;
        private System.Windows.Forms.Panel membersPanel;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
    }
}