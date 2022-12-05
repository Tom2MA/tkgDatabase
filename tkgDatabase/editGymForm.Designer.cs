namespace tkgDatabase
{
    partial class editGymForm
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
            this.gymFormPanel = new System.Windows.Forms.Panel();
            this.gymText = new System.Windows.Forms.TextBox();
            this.gymsPanel = new System.Windows.Forms.Panel();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.locationText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.gymFormPanel.SuspendLayout();
            this.gymsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gymFormPanel
            // 
            this.gymFormPanel.BackColor = System.Drawing.Color.Gold;
            this.gymFormPanel.Controls.Add(this.gymText);
            this.gymFormPanel.Controls.Add(this.gymsPanel);
            this.gymFormPanel.Location = new System.Drawing.Point(-3, -2);
            this.gymFormPanel.Name = "gymFormPanel";
            this.gymFormPanel.Size = new System.Drawing.Size(482, 254);
            this.gymFormPanel.TabIndex = 16;
            // 
            // gymText
            // 
            this.gymText.BackColor = System.Drawing.Color.Gold;
            this.gymText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gymText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gymText.Location = new System.Drawing.Point(33, 20);
            this.gymText.Name = "gymText";
            this.gymText.ReadOnly = true;
            this.gymText.Size = new System.Drawing.Size(105, 20);
            this.gymText.TabIndex = 0;
            this.gymText.TabStop = false;
            this.gymText.Text = "Edit Gym";
            // 
            // gymsPanel
            // 
            this.gymsPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gymsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gymsPanel.Controls.Add(this.phoneBox);
            this.gymsPanel.Controls.Add(this.phoneText);
            this.gymsPanel.Controls.Add(this.locationBox);
            this.gymsPanel.Controls.Add(this.nameBox);
            this.gymsPanel.Controls.Add(this.locationText);
            this.gymsPanel.Controls.Add(this.nameText);
            this.gymsPanel.Location = new System.Drawing.Point(33, 46);
            this.gymsPanel.Name = "gymsPanel";
            this.gymsPanel.Size = new System.Drawing.Size(381, 171);
            this.gymsPanel.TabIndex = 5;
            // 
            // phoneBox
            // 
            this.phoneBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.phoneBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.phoneBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.phoneBox.Location = new System.Drawing.Point(118, 114);
            this.phoneBox.MaxLength = 10;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(246, 30);
            this.phoneBox.TabIndex = 17;
            this.phoneBox.TabStop = false;
            this.phoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneBox_KeyPress);
            // 
            // phoneText
            // 
            this.phoneText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.phoneText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneText.Location = new System.Drawing.Point(22, 117);
            this.phoneText.Name = "phoneText";
            this.phoneText.ReadOnly = true;
            this.phoneText.Size = new System.Drawing.Size(82, 20);
            this.phoneText.TabIndex = 0;
            this.phoneText.TabStop = false;
            this.phoneText.Text = "Phone #:";
            // 
            // locationBox
            // 
            this.locationBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.locationBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.locationBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.locationBox.Location = new System.Drawing.Point(118, 69);
            this.locationBox.MaxLength = 45;
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(246, 27);
            this.locationBox.TabIndex = 14;
            this.locationBox.TabStop = false;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.nameBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.nameBox.Location = new System.Drawing.Point(118, 18);
            this.nameBox.MaxLength = 45;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(246, 30);
            this.nameBox.TabIndex = 13;
            this.nameBox.TabStop = false;
            // 
            // locationText
            // 
            this.locationText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.locationText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.locationText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationText.Location = new System.Drawing.Point(22, 71);
            this.locationText.Name = "locationText";
            this.locationText.ReadOnly = true;
            this.locationText.Size = new System.Drawing.Size(76, 20);
            this.locationText.TabIndex = 9;
            this.locationText.TabStop = false;
            this.locationText.Text = "Location:";
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(15, 21);
            this.nameText.Name = "nameText";
            this.nameText.ReadOnly = true;
            this.nameText.Size = new System.Drawing.Size(89, 20);
            this.nameText.TabIndex = 7;
            this.nameText.TabStop = false;
            this.nameText.Text = "City Name:";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.backButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(229, 274);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(182, 49);
            this.backButton.TabIndex = 18;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(30, 274);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(182, 49);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // editGymForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 343);
            this.ControlBox = false;
            this.Controls.Add(this.gymFormPanel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editGymForm";
            this.Text = "TKGym";
            this.gymFormPanel.ResumeLayout(false);
            this.gymFormPanel.PerformLayout();
            this.gymsPanel.ResumeLayout(false);
            this.gymsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gymFormPanel;
        private System.Windows.Forms.TextBox gymText;
        private System.Windows.Forms.Panel gymsPanel;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox locationText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
    }
}