
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
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.locationText = new System.Windows.Forms.TextBox();
            this.editVendorPanel = new System.Windows.Forms.Panel();
            this.suppliesList = new System.Windows.Forms.ListBox();
            this.suppliesText = new System.Windows.Forms.TextBox();
            this.vendorBox = new System.Windows.Forms.TextBox();
            this.vendorText = new System.Windows.Forms.TextBox();
            this.editVendorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.backButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(224, 377);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(170, 49);
            this.backButton.TabIndex = 31;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(28, 377);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(170, 49);
            this.saveButton.TabIndex = 30;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // locationBox
            // 
            this.locationBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.locationBox.Location = new System.Drawing.Point(28, 329);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(366, 30);
            this.locationBox.TabIndex = 29;
            // 
            // locationText
            // 
            this.locationText.BackColor = System.Drawing.SystemColors.Control;
            this.locationText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.locationText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationText.Location = new System.Drawing.Point(28, 303);
            this.locationText.Name = "locationText";
            this.locationText.ReadOnly = true;
            this.locationText.Size = new System.Drawing.Size(152, 20);
            this.locationText.TabIndex = 0;
            this.locationText.TabStop = false;
            this.locationText.Text = "Location";
            // 
            // editVendorPanel
            // 
            this.editVendorPanel.BackColor = System.Drawing.Color.Gold;
            this.editVendorPanel.Controls.Add(this.suppliesList);
            this.editVendorPanel.Controls.Add(this.suppliesText);
            this.editVendorPanel.Controls.Add(this.vendorBox);
            this.editVendorPanel.Controls.Add(this.vendorText);
            this.editVendorPanel.Location = new System.Drawing.Point(-211, -7);
            this.editVendorPanel.Name = "editVendorPanel";
            this.editVendorPanel.Size = new System.Drawing.Size(846, 292);
            this.editVendorPanel.TabIndex = 27;
            // 
            // suppliesList
            // 
            this.suppliesList.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.suppliesList.FormattingEnabled = true;
            this.suppliesList.ItemHeight = 22;
            this.suppliesList.Location = new System.Drawing.Point(239, 127);
            this.suppliesList.Name = "suppliesList";
            this.suppliesList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.suppliesList.Size = new System.Drawing.Size(366, 136);
            this.suppliesList.TabIndex = 28;
            // 
            // suppliesText
            // 
            this.suppliesText.BackColor = System.Drawing.Color.Gold;
            this.suppliesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.suppliesText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliesText.Location = new System.Drawing.Point(239, 101);
            this.suppliesText.Name = "suppliesText";
            this.suppliesText.ReadOnly = true;
            this.suppliesText.Size = new System.Drawing.Size(95, 20);
            this.suppliesText.TabIndex = 0;
            this.suppliesText.TabStop = false;
            this.suppliesText.Text = "Supplies";
            // 
            // vendorBox
            // 
            this.vendorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vendorBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.vendorBox.Location = new System.Drawing.Point(239, 49);
            this.vendorBox.Name = "vendorBox";
            this.vendorBox.Size = new System.Drawing.Size(366, 30);
            this.vendorBox.TabIndex = 25;
            // 
            // vendorText
            // 
            this.vendorText.BackColor = System.Drawing.Color.Gold;
            this.vendorText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vendorText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorText.Location = new System.Drawing.Point(239, 23);
            this.vendorText.Name = "vendorText";
            this.vendorText.ReadOnly = true;
            this.vendorText.Size = new System.Drawing.Size(72, 20);
            this.vendorText.TabIndex = 0;
            this.vendorText.TabStop = false;
            this.vendorText.Text = "Vendor";
            // 
            // editVendorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 450);
            this.ControlBox = false;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.locationText);
            this.Controls.Add(this.editVendorPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editVendorForm";
            this.ShowIcon = false;
            this.Text = "TKGym";
            this.editVendorPanel.ResumeLayout(false);
            this.editVendorPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.TextBox locationText;
        private System.Windows.Forms.Panel editVendorPanel;
        private System.Windows.Forms.TextBox suppliesText;
        private System.Windows.Forms.TextBox vendorBox;
        private System.Windows.Forms.TextBox vendorText;
        private System.Windows.Forms.ListBox suppliesList;
    }
}