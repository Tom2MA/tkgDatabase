namespace tkgDatabase
{
    partial class addVendorForm
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
            this.vendorText = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.vendorFormPanel = new System.Windows.Forms.Panel();
            this.addVendorText = new System.Windows.Forms.TextBox();
            this.addVendorPanel = new System.Windows.Forms.Panel();
            this.vendorPhoneBox = new System.Windows.Forms.TextBox();
            this.vendorPhoneText = new System.Windows.Forms.TextBox();
            this.vendorAddressBox = new System.Windows.Forms.TextBox();
            this.vendorNameBox = new System.Windows.Forms.TextBox();
            this.vendorAddressText = new System.Windows.Forms.TextBox();
            this.vendorNameText = new System.Windows.Forms.TextBox();
            this.vendorsPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.vendorFormPanel.SuspendLayout();
            this.addVendorPanel.SuspendLayout();
            this.vendorsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // vendorText
            // 
            this.vendorText.BackColor = System.Drawing.Color.Gold;
            this.vendorText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vendorText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorText.Location = new System.Drawing.Point(33, 20);
            this.vendorText.Name = "vendorText";
            this.vendorText.ReadOnly = true;
            this.vendorText.Size = new System.Drawing.Size(105, 20);
            this.vendorText.TabIndex = 0;
            this.vendorText.TabStop = false;
            this.vendorText.Text = "Add Vendor";
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(0, 0);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(100, 20);
            this.phoneBox.TabIndex = 0;
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
            // addressBox
            // 
            this.addressBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.addressBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.addressBox.Location = new System.Drawing.Point(118, 64);
            this.addressBox.MaxLength = 45;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(246, 30);
            this.addressBox.TabIndex = 14;
            this.addressBox.TabStop = false;
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
            // addressText
            // 
            this.addressText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addressText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressText.Location = new System.Drawing.Point(22, 67);
            this.addressText.Name = "addressText";
            this.addressText.ReadOnly = true;
            this.addressText.Size = new System.Drawing.Size(76, 20);
            this.addressText.TabIndex = 9;
            this.addressText.TabStop = false;
            this.addressText.Text = "Address:";
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(32, 21);
            this.nameText.Name = "nameText";
            this.nameText.ReadOnly = true;
            this.nameText.Size = new System.Drawing.Size(66, 20);
            this.nameText.TabIndex = 7;
            this.nameText.TabStop = false;
            this.nameText.Text = "Name:";
            // 
            // vendorFormPanel
            // 
            this.vendorFormPanel.BackColor = System.Drawing.Color.Gold;
            this.vendorFormPanel.Controls.Add(this.addVendorText);
            this.vendorFormPanel.Controls.Add(this.vendorText);
            this.vendorFormPanel.Controls.Add(this.addVendorPanel);
            this.vendorFormPanel.Controls.Add(this.vendorsPanel);
            this.vendorFormPanel.Location = new System.Drawing.Point(-3, -4);
            this.vendorFormPanel.Name = "vendorFormPanel";
            this.vendorFormPanel.Size = new System.Drawing.Size(472, 256);
            this.vendorFormPanel.TabIndex = 10;
            // 
            // addVendorText
            // 
            this.addVendorText.BackColor = System.Drawing.Color.Gold;
            this.addVendorText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addVendorText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVendorText.Location = new System.Drawing.Point(33, 20);
            this.addVendorText.Name = "addVendorText";
            this.addVendorText.ReadOnly = true;
            this.addVendorText.Size = new System.Drawing.Size(105, 20);
            this.addVendorText.TabIndex = 0;
            this.addVendorText.TabStop = false;
            this.addVendorText.Text = "Add Vendor";
            // 
            // addVendorPanel
            // 
            this.addVendorPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addVendorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addVendorPanel.Controls.Add(this.vendorPhoneBox);
            this.addVendorPanel.Controls.Add(this.vendorPhoneText);
            this.addVendorPanel.Controls.Add(this.vendorAddressBox);
            this.addVendorPanel.Controls.Add(this.vendorNameBox);
            this.addVendorPanel.Controls.Add(this.vendorAddressText);
            this.addVendorPanel.Controls.Add(this.vendorNameText);
            this.addVendorPanel.Location = new System.Drawing.Point(33, 46);
            this.addVendorPanel.Name = "addVendorPanel";
            this.addVendorPanel.Size = new System.Drawing.Size(381, 171);
            this.addVendorPanel.TabIndex = 5;
            // 
            // vendorPhoneBox
            // 
            this.vendorPhoneBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.vendorPhoneBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vendorPhoneBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.vendorPhoneBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.vendorPhoneBox.Location = new System.Drawing.Point(118, 114);
            this.vendorPhoneBox.MaxLength = 10;
            this.vendorPhoneBox.Name = "vendorPhoneBox";
            this.vendorPhoneBox.Size = new System.Drawing.Size(246, 30);
            this.vendorPhoneBox.TabIndex = 15;
            this.vendorPhoneBox.TabStop = false;
            this.vendorPhoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vendorPhoneBox_KeyPress);
            // 
            // vendorPhoneText
            // 
            this.vendorPhoneText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.vendorPhoneText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vendorPhoneText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorPhoneText.Location = new System.Drawing.Point(22, 117);
            this.vendorPhoneText.Name = "vendorPhoneText";
            this.vendorPhoneText.ReadOnly = true;
            this.vendorPhoneText.Size = new System.Drawing.Size(82, 20);
            this.vendorPhoneText.TabIndex = 0;
            this.vendorPhoneText.TabStop = false;
            this.vendorPhoneText.Text = "Phone #:";
            // 
            // vendorAddressBox
            // 
            this.vendorAddressBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.vendorAddressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vendorAddressBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.vendorAddressBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.vendorAddressBox.Location = new System.Drawing.Point(118, 64);
            this.vendorAddressBox.MaxLength = 45;
            this.vendorAddressBox.Name = "vendorAddressBox";
            this.vendorAddressBox.Size = new System.Drawing.Size(246, 30);
            this.vendorAddressBox.TabIndex = 14;
            this.vendorAddressBox.TabStop = false;
            // 
            // vendorNameBox
            // 
            this.vendorNameBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.vendorNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vendorNameBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.vendorNameBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.vendorNameBox.Location = new System.Drawing.Point(118, 18);
            this.vendorNameBox.MaxLength = 45;
            this.vendorNameBox.Name = "vendorNameBox";
            this.vendorNameBox.Size = new System.Drawing.Size(246, 30);
            this.vendorNameBox.TabIndex = 13;
            this.vendorNameBox.TabStop = false;
            // 
            // vendorAddressText
            // 
            this.vendorAddressText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.vendorAddressText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vendorAddressText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorAddressText.Location = new System.Drawing.Point(22, 67);
            this.vendorAddressText.Name = "vendorAddressText";
            this.vendorAddressText.ReadOnly = true;
            this.vendorAddressText.Size = new System.Drawing.Size(76, 20);
            this.vendorAddressText.TabIndex = 9;
            this.vendorAddressText.TabStop = false;
            this.vendorAddressText.Text = "Address:";
            // 
            // vendorNameText
            // 
            this.vendorNameText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.vendorNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vendorNameText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorNameText.Location = new System.Drawing.Point(32, 21);
            this.vendorNameText.Name = "vendorNameText";
            this.vendorNameText.ReadOnly = true;
            this.vendorNameText.Size = new System.Drawing.Size(66, 20);
            this.vendorNameText.TabIndex = 7;
            this.vendorNameText.TabStop = false;
            this.vendorNameText.Text = "Name:";
            // 
            // vendorsPanel
            // 
            this.vendorsPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.vendorsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vendorsPanel.Controls.Add(this.phoneBox);
            this.vendorsPanel.Controls.Add(this.phoneText);
            this.vendorsPanel.Controls.Add(this.addressBox);
            this.vendorsPanel.Controls.Add(this.nameBox);
            this.vendorsPanel.Controls.Add(this.addressText);
            this.vendorsPanel.Controls.Add(this.nameText);
            this.vendorsPanel.Location = new System.Drawing.Point(33, 46);
            this.vendorsPanel.Name = "vendorsPanel";
            this.vendorsPanel.Size = new System.Drawing.Size(381, 171);
            this.vendorsPanel.TabIndex = 5;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.cancelButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(223, 278);
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
            this.addButton.Location = new System.Drawing.Point(30, 278);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(175, 49);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addVendorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 353);
            this.ControlBox = false;
            this.Controls.Add(this.vendorFormPanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addVendorForm";
            this.Text = "TKGym";
            this.vendorFormPanel.ResumeLayout(false);
            this.vendorFormPanel.PerformLayout();
            this.addVendorPanel.ResumeLayout(false);
            this.addVendorPanel.PerformLayout();
            this.vendorsPanel.ResumeLayout(false);
            this.vendorsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox vendorText;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Panel vendorFormPanel;
        private System.Windows.Forms.Panel vendorsPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addVendorText;
        private System.Windows.Forms.Panel addVendorPanel;
        private System.Windows.Forms.TextBox vendorPhoneText;
        private System.Windows.Forms.TextBox vendorAddressBox;
        private System.Windows.Forms.TextBox vendorNameBox;
        private System.Windows.Forms.TextBox vendorAddressText;
        private System.Windows.Forms.TextBox vendorNameText;
        private System.Windows.Forms.TextBox vendorPhoneBox;
    }
}