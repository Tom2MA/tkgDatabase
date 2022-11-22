
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
            this.saveButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.editMemberPanel = new System.Windows.Forms.Panel();
            this.editMemberText = new System.Windows.Forms.TextBox();
            this.memberPanel = new System.Windows.Forms.Panel();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.membershipBox = new System.Windows.Forms.TextBox();
            this.locationText = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.membershipText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.editMemberPanel.SuspendLayout();
            this.memberPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(40, 340);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(170, 49);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.backButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(245, 340);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(170, 49);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // editMemberPanel
            // 
            this.editMemberPanel.BackColor = System.Drawing.Color.Gold;
            this.editMemberPanel.Controls.Add(this.editMemberText);
            this.editMemberPanel.Controls.Add(this.memberPanel);
            this.editMemberPanel.Location = new System.Drawing.Point(-195, -3);
            this.editMemberPanel.Name = "editMemberPanel";
            this.editMemberPanel.Size = new System.Drawing.Size(846, 281);
            this.editMemberPanel.TabIndex = 3;
            // 
            // editMemberText
            // 
            this.editMemberText.BackColor = System.Drawing.Color.Gold;
            this.editMemberText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editMemberText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMemberText.Location = new System.Drawing.Point(235, 15);
            this.editMemberText.Name = "editMemberText";
            this.editMemberText.ReadOnly = true;
            this.editMemberText.Size = new System.Drawing.Size(113, 20);
            this.editMemberText.TabIndex = 0;
            this.editMemberText.TabStop = false;
            this.editMemberText.Text = "Edit Member";
            // 
            // memberPanel
            // 
            this.memberPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.memberPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.memberPanel.Controls.Add(this.locationBox);
            this.memberPanel.Controls.Add(this.addressBox);
            this.memberPanel.Controls.Add(this.lastNameBox);
            this.memberPanel.Controls.Add(this.firstNameBox);
            this.memberPanel.Controls.Add(this.membershipBox);
            this.memberPanel.Controls.Add(this.locationText);
            this.memberPanel.Controls.Add(this.textBox6);
            this.memberPanel.Controls.Add(this.addressText);
            this.memberPanel.Controls.Add(this.textBox5);
            this.memberPanel.Controls.Add(this.membershipText);
            this.memberPanel.Controls.Add(this.lastNameText);
            this.memberPanel.Controls.Add(this.textBox3);
            this.memberPanel.Controls.Add(this.firstNameText);
            this.memberPanel.Controls.Add(this.textBox2);
            this.memberPanel.Location = new System.Drawing.Point(235, 41);
            this.memberPanel.Name = "memberPanel";
            this.memberPanel.Size = new System.Drawing.Size(358, 208);
            this.memberPanel.TabIndex = 6;
            // 
            // locationBox
            // 
            this.locationBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.locationBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.locationBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.locationBox.Location = new System.Drawing.Point(142, 124);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(192, 30);
            this.locationBox.TabIndex = 15;
            // 
            // addressBox
            // 
            this.addressBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.addressBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.addressBox.Location = new System.Drawing.Point(95, 88);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(239, 30);
            this.addressBox.TabIndex = 14;
            // 
            // lastNameBox
            // 
            this.lastNameBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lastNameBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lastNameBox.Location = new System.Drawing.Point(110, 50);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(224, 30);
            this.lastNameBox.TabIndex = 13;
            // 
            // firstNameBox
            // 
            this.firstNameBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.firstNameBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.firstNameBox.Location = new System.Drawing.Point(110, 13);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(224, 30);
            this.firstNameBox.TabIndex = 12;
            // 
            // membershipBox
            // 
            this.membershipBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.membershipBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.membershipBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.membershipBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.membershipBox.Location = new System.Drawing.Point(167, 161);
            this.membershipBox.Name = "membershipBox";
            this.membershipBox.Size = new System.Drawing.Size(167, 30);
            this.membershipBox.TabIndex = 11;
            // 
            // locationText
            // 
            this.locationText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.locationText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.locationText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationText.Location = new System.Drawing.Point(13, 125);
            this.locationText.Name = "locationText";
            this.locationText.ReadOnly = true;
            this.locationText.Size = new System.Drawing.Size(113, 20);
            this.locationText.TabIndex = 10;
            this.locationText.TabStop = false;
            this.locationText.Text = "Gym Location:";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(13, 125);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(113, 20);
            this.textBox6.TabIndex = 10;
            this.textBox6.Text = "Gym Location:";
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
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(13, 89);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(113, 20);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "Address:";
            // 
            // membershipText
            // 
            this.membershipText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.membershipText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.membershipText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membershipText.Location = new System.Drawing.Point(13, 161);
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
            this.lastNameText.Location = new System.Drawing.Point(13, 51);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.ReadOnly = true;
            this.lastNameText.Size = new System.Drawing.Size(91, 20);
            this.lastNameText.TabIndex = 7;
            this.lastNameText.TabStop = false;
            this.lastNameText.Text = "Last Name:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(13, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Last Name:";
            // 
            // firstNameText
            // 
            this.firstNameText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameText.Location = new System.Drawing.Point(13, 14);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.ReadOnly = true;
            this.firstNameText.Size = new System.Drawing.Size(91, 20);
            this.firstNameText.TabIndex = 6;
            this.firstNameText.TabStop = false;
            this.firstNameText.Text = "First Name:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(13, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "First Name:";
            // 
            // editMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.ControlBox = false;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.editMemberPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editMemberForm";
            this.ShowIcon = false;
            this.Text = "TKGym";
            this.editMemberPanel.ResumeLayout(false);
            this.editMemberPanel.PerformLayout();
            this.memberPanel.ResumeLayout(false);
            this.memberPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel editMemberPanel;
        private System.Windows.Forms.Panel memberPanel;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox membershipBox;
        private System.Windows.Forms.TextBox locationText;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox membershipText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox editMemberText;
    }
}