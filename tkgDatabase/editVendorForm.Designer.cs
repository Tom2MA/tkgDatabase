
namespace tkgDatabase
{
    partial class editVendorForm
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
            this.editVendorPanel = new System.Windows.Forms.Panel();
            this.editVendorText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.locationCombo = new System.Windows.Forms.ComboBox();
            this.filterText = new System.Windows.Forms.TextBox();
            this.vendorSupplyList = new System.Windows.Forms.ListBox();
            this.vendorEquipmentList = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.vendorEquipmentText = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.editVendorPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editVendorPanel
            // 
            this.editVendorPanel.BackColor = System.Drawing.Color.Gold;
            this.editVendorPanel.Controls.Add(this.editVendorText);
            this.editVendorPanel.Controls.Add(this.filterText);
            this.editVendorPanel.Controls.Add(this.panel1);
            this.editVendorPanel.Location = new System.Drawing.Point(-211, -7);
            this.editVendorPanel.Name = "editVendorPanel";
            this.editVendorPanel.Size = new System.Drawing.Size(846, 262);
            this.editVendorPanel.TabIndex = 27;
            // 
            // editVendorText
            // 
            this.editVendorText.BackColor = System.Drawing.Color.Gold;
            this.editVendorText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editVendorText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editVendorText.Location = new System.Drawing.Point(235, 24);
            this.editVendorText.Name = "editVendorText";
            this.editVendorText.ReadOnly = true;
            this.editVendorText.Size = new System.Drawing.Size(105, 20);
            this.editVendorText.TabIndex = 32;
            this.editVendorText.TabStop = false;
            this.editVendorText.Text = "Edit Vendor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.phoneBox);
            this.panel1.Controls.Add(this.phoneText);
            this.panel1.Controls.Add(this.addressBox);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.addressText);
            this.panel1.Controls.Add(this.nameText);
            this.panel1.Location = new System.Drawing.Point(235, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 171);
            this.panel1.TabIndex = 33;
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
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.backButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(230, 478);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(175, 49);
            this.backButton.TabIndex = 33;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(24, 478);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(175, 49);
            this.saveButton.TabIndex = 32;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // locationCombo
            // 
            this.locationCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationCombo.FormattingEnabled = true;
            this.locationCombo.Location = new System.Drawing.Point(95, 261);
            this.locationCombo.Name = "locationCombo";
            this.locationCombo.Size = new System.Drawing.Size(227, 21);
            this.locationCombo.TabIndex = 35;
            this.locationCombo.SelectedIndexChanged += new System.EventHandler(this.locationCombo_SelectedIndexChanged);
            // 
            // filterText
            // 
            this.filterText.BackColor = System.Drawing.Color.Gold;
            this.filterText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filterText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterText.Location = new System.Drawing.Point(306, 239);
            this.filterText.Name = "filterText";
            this.filterText.ReadOnly = true;
            this.filterText.Size = new System.Drawing.Size(196, 20);
            this.filterText.TabIndex = 34;
            this.filterText.TabStop = false;
            this.filterText.Text = "Filter Supply To Location";
            // 
            // vendorSupplyList
            // 
            this.vendorSupplyList.FormattingEnabled = true;
            this.vendorSupplyList.Location = new System.Drawing.Point(24, 321);
            this.vendorSupplyList.Name = "vendorSupplyList";
            this.vendorSupplyList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.vendorSupplyList.Size = new System.Drawing.Size(175, 134);
            this.vendorSupplyList.TabIndex = 36;
            // 
            // vendorEquipmentList
            // 
            this.vendorEquipmentList.FormattingEnabled = true;
            this.vendorEquipmentList.Location = new System.Drawing.Point(230, 321);
            this.vendorEquipmentList.Name = "vendorEquipmentList";
            this.vendorEquipmentList.Size = new System.Drawing.Size(175, 108);
            this.vendorEquipmentList.TabIndex = 37;
            this.vendorEquipmentList.SelectedIndexChanged += new System.EventHandler(this.vendorEquipmentList_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Underline);
            this.textBox1.Location = new System.Drawing.Point(24, 297);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(144, 18);
            this.textBox1.TabIndex = 35;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Vendor Supplies";
            // 
            // vendorEquipmentText
            // 
            this.vendorEquipmentText.BackColor = System.Drawing.SystemColors.Control;
            this.vendorEquipmentText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vendorEquipmentText.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Underline);
            this.vendorEquipmentText.Location = new System.Drawing.Point(230, 297);
            this.vendorEquipmentText.Name = "vendorEquipmentText";
            this.vendorEquipmentText.ReadOnly = true;
            this.vendorEquipmentText.Size = new System.Drawing.Size(144, 18);
            this.vendorEquipmentText.TabIndex = 38;
            this.vendorEquipmentText.TabStop = false;
            this.vendorEquipmentText.Text = "Vendor Equipment";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(230, 435);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(79, 25);
            this.addButton.TabIndex = 39;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.removeButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(315, 435);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(90, 25);
            this.removeButton.TabIndex = 40;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editVendorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 549);
            this.ControlBox = false;
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.vendorEquipmentText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.vendorEquipmentList);
            this.Controls.Add(this.vendorSupplyList);
            this.Controls.Add(this.locationCombo);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.editVendorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editVendorForm";
            this.ShowIcon = false;
            this.Text = "TKGym";
            this.editVendorPanel.ResumeLayout(false);
            this.editVendorPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel editVendorPanel;
        private System.Windows.Forms.TextBox editVendorText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox filterText;
        private System.Windows.Forms.ComboBox locationCombo;
        private System.Windows.Forms.ListBox vendorSupplyList;
        private System.Windows.Forms.ListBox vendorEquipmentList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox vendorEquipmentText;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
    }
}