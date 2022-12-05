namespace tkgDatabase
{
    partial class addGymForm
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
            this.gymText = new System.Windows.Forms.TextBox();
            this.gymFormPanel = new System.Windows.Forms.Panel();
            this.gymsPanel = new System.Windows.Forms.Panel();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.locationText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.gymFormPanel.SuspendLayout();
            this.gymsPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.gymText.Text = "Add Gym";
            // 
            // gymFormPanel
            // 
            this.gymFormPanel.BackColor = System.Drawing.Color.Gold;
            this.gymFormPanel.Controls.Add(this.gymText);
            this.gymFormPanel.Controls.Add(this.gymsPanel);
            this.gymFormPanel.Location = new System.Drawing.Point(-7, 0);
            this.gymFormPanel.Name = "gymFormPanel";
            this.gymFormPanel.Size = new System.Drawing.Size(479, 256);
            this.gymFormPanel.TabIndex = 13;
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
            this.locationBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.locationBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.locationBox.Location = new System.Drawing.Point(118, 64);
            this.locationBox.MaxLength = 45;
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(246, 30);
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
            this.locationText.Location = new System.Drawing.Point(22, 67);
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
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.cancelButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(219, 282);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(195, 49);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(26, 282);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(182, 49);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addGymForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 353);
            this.ControlBox = false;
            this.Controls.Add(this.gymFormPanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addGymForm";
            this.Text = "TKGym";
            this.gymFormPanel.ResumeLayout(false);
            this.gymFormPanel.PerformLayout();
            this.gymsPanel.ResumeLayout(false);
            this.gymsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox gymText;
        private System.Windows.Forms.Panel gymFormPanel;
        private System.Windows.Forms.Panel gymsPanel;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox locationText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
    }
}