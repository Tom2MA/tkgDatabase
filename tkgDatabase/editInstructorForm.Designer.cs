namespace tkgDatabase
{
    partial class editInstructorForm
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
            this.editInstructorText = new System.Windows.Forms.TextBox();
            this.instructorPanel = new System.Windows.Forms.Panel();
            this.gymLocCombo = new System.Windows.Forms.ComboBox();
            this.gymLocText = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.editInstructorFormPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.instructorPanel.SuspendLayout();
            this.editInstructorFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // editInstructorText
            // 
            this.editInstructorText.BackColor = System.Drawing.Color.Gold;
            this.editInstructorText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editInstructorText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editInstructorText.Location = new System.Drawing.Point(33, 26);
            this.editInstructorText.Name = "editInstructorText";
            this.editInstructorText.ReadOnly = true;
            this.editInstructorText.Size = new System.Drawing.Size(130, 20);
            this.editInstructorText.TabIndex = 0;
            this.editInstructorText.TabStop = false;
            this.editInstructorText.Text = "Edit Instructor";
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
            // editInstructorFormPanel
            // 
            this.editInstructorFormPanel.BackColor = System.Drawing.Color.Gold;
            this.editInstructorFormPanel.Controls.Add(this.editInstructorText);
            this.editInstructorFormPanel.Controls.Add(this.instructorPanel);
            this.editInstructorFormPanel.Location = new System.Drawing.Point(-5, -3);
            this.editInstructorFormPanel.Name = "editInstructorFormPanel";
            this.editInstructorFormPanel.Size = new System.Drawing.Size(474, 250);
            this.editInstructorFormPanel.TabIndex = 13;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.backButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(221, 267);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(194, 54);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(28, 267);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(181, 54);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // editInstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 344);
            this.ControlBox = false;
            this.Controls.Add(this.editInstructorFormPanel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editInstructorForm";
            this.Text = "editInstructorForm";
            this.instructorPanel.ResumeLayout(false);
            this.instructorPanel.PerformLayout();
            this.editInstructorFormPanel.ResumeLayout(false);
            this.editInstructorFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox editInstructorText;
        private System.Windows.Forms.Panel instructorPanel;
        private System.Windows.Forms.ComboBox gymLocCombo;
        private System.Windows.Forms.TextBox gymLocText;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Panel editInstructorFormPanel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
    }
}