namespace tkgDatabase
{
    partial class addInstructorForm
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
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.instructorPanel = new System.Windows.Forms.Panel();
            this.gymLocCombo = new System.Windows.Forms.ComboBox();
            this.gymLocText = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.addInstructorFormPanel = new System.Windows.Forms.Panel();
            this.addInstructorText = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.instructorPanel.SuspendLayout();
            this.addInstructorFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameBox
            // 
            this.firstNameBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.firstNameBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.firstNameBox.Location = new System.Drawing.Point(118, 20);
            this.firstNameBox.MaxLength = 45;
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(246, 30);
            this.firstNameBox.TabIndex = 12;
            this.firstNameBox.TabStop = false;
            // 
            // firstNameText
            // 
            this.firstNameText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameText.Location = new System.Drawing.Point(13, 23);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.ReadOnly = true;
            this.firstNameText.Size = new System.Drawing.Size(91, 20);
            this.firstNameText.TabIndex = 6;
            this.firstNameText.TabStop = false;
            this.firstNameText.Text = "First Name:";
            // 
            // instructorPanel
            // 
            this.instructorPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.instructorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instructorPanel.Controls.Add(this.gymLocCombo);
            this.instructorPanel.Controls.Add(this.gymLocText);
            this.instructorPanel.Controls.Add(this.lastNameBox);
            this.instructorPanel.Controls.Add(this.firstNameBox);
            this.instructorPanel.Controls.Add(this.lastNameText);
            this.instructorPanel.Controls.Add(this.firstNameText);
            this.instructorPanel.Location = new System.Drawing.Point(33, 52);
            this.instructorPanel.Name = "instructorPanel";
            this.instructorPanel.Size = new System.Drawing.Size(381, 155);
            this.instructorPanel.TabIndex = 5;
            // 
            // gymLocCombo
            // 
            this.gymLocCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gymLocCombo.FormattingEnabled = true;
            this.gymLocCombo.Location = new System.Drawing.Point(151, 106);
            this.gymLocCombo.Name = "gymLocCombo";
            this.gymLocCombo.Size = new System.Drawing.Size(213, 21);
            this.gymLocCombo.TabIndex = 22;
            this.gymLocCombo.SelectedIndexChanged += new System.EventHandler(this.gymLocCombo_SelectedIndexChanged);
            // 
            // gymLocText
            // 
            this.gymLocText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gymLocText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gymLocText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gymLocText.Location = new System.Drawing.Point(13, 107);
            this.gymLocText.Name = "gymLocText";
            this.gymLocText.ReadOnly = true;
            this.gymLocText.Size = new System.Drawing.Size(116, 20);
            this.gymLocText.TabIndex = 21;
            this.gymLocText.TabStop = false;
            this.gymLocText.Text = "Gym Location:";
            // 
            // lastNameBox
            // 
            this.lastNameBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lastNameBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lastNameBox.Location = new System.Drawing.Point(118, 59);
            this.lastNameBox.MaxLength = 45;
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(246, 30);
            this.lastNameBox.TabIndex = 13;
            this.lastNameBox.TabStop = false;
            // 
            // lastNameText
            // 
            this.lastNameText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lastNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameText.Location = new System.Drawing.Point(13, 62);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.ReadOnly = true;
            this.lastNameText.Size = new System.Drawing.Size(99, 20);
            this.lastNameText.TabIndex = 7;
            this.lastNameText.TabStop = false;
            this.lastNameText.Text = "Last Name:";
            // 
            // addInstructorFormPanel
            // 
            this.addInstructorFormPanel.BackColor = System.Drawing.Color.Gold;
            this.addInstructorFormPanel.Controls.Add(this.addInstructorText);
            this.addInstructorFormPanel.Controls.Add(this.instructorPanel);
            this.addInstructorFormPanel.Location = new System.Drawing.Point(1, 0);
            this.addInstructorFormPanel.Name = "addInstructorFormPanel";
            this.addInstructorFormPanel.Size = new System.Drawing.Size(468, 245);
            this.addInstructorFormPanel.TabIndex = 10;
            // 
            // addInstructorText
            // 
            this.addInstructorText.BackColor = System.Drawing.Color.Gold;
            this.addInstructorText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addInstructorText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInstructorText.Location = new System.Drawing.Point(33, 26);
            this.addInstructorText.Name = "addInstructorText";
            this.addInstructorText.ReadOnly = true;
            this.addInstructorText.Size = new System.Drawing.Size(141, 20);
            this.addInstructorText.TabIndex = 0;
            this.addInstructorText.TabStop = false;
            this.addInstructorText.Text = "Add Instructor";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.cancelButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(227, 270);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(188, 49);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(34, 270);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(175, 49);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addInstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 344);
            this.ControlBox = false;
            this.Controls.Add(this.addInstructorFormPanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addInstructorForm";
            this.ShowIcon = false;
            this.Text = "TKGym";
            this.instructorPanel.ResumeLayout(false);
            this.instructorPanel.PerformLayout();
            this.addInstructorFormPanel.ResumeLayout(false);
            this.addInstructorFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Panel instructorPanel;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Panel addInstructorFormPanel;
        private System.Windows.Forms.TextBox addInstructorText;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox gymLocCombo;
        private System.Windows.Forms.TextBox gymLocText;
    }
}