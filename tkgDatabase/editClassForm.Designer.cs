
namespace tkgDatabase
{
    partial class editClassForm
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
            this.editClassPanel = new System.Windows.Forms.Panel();
            this.dayBox = new System.Windows.Forms.TextBox();
            this.endBox = new System.Windows.Forms.TextBox();
            this.startBox = new System.Windows.Forms.TextBox();
            this.dayText = new System.Windows.Forms.TextBox();
            this.startText = new System.Windows.Forms.TextBox();
            this.endText = new System.Windows.Forms.TextBox();
            this.classBox = new System.Windows.Forms.TextBox();
            this.classText = new System.Windows.Forms.TextBox();
            this.instructorText = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.instructorsList = new System.Windows.Forms.ListBox();
            this.editClassPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // editClassPanel
            // 
            this.editClassPanel.BackColor = System.Drawing.Color.Gold;
            this.editClassPanel.Controls.Add(this.instructorsList);
            this.editClassPanel.Controls.Add(this.classBox);
            this.editClassPanel.Controls.Add(this.classText);
            this.editClassPanel.Controls.Add(this.instructorText);
            this.editClassPanel.Location = new System.Drawing.Point(-186, -6);
            this.editClassPanel.Name = "editClassPanel";
            this.editClassPanel.Size = new System.Drawing.Size(846, 289);
            this.editClassPanel.TabIndex = 3;
            // 
            // dayBox
            // 
            this.dayBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.dayBox.Location = new System.Drawing.Point(318, 328);
            this.dayBox.Name = "dayBox";
            this.dayBox.ReadOnly = true;
            this.dayBox.Size = new System.Drawing.Size(117, 30);
            this.dayBox.TabIndex = 42;
            this.dayBox.TabStop = false;
            // 
            // endBox
            // 
            this.endBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.endBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.endBox.Location = new System.Drawing.Point(182, 328);
            this.endBox.Name = "endBox";
            this.endBox.ReadOnly = true;
            this.endBox.Size = new System.Drawing.Size(117, 30);
            this.endBox.TabIndex = 40;
            this.endBox.TabStop = false;
            // 
            // startBox
            // 
            this.startBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.startBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.startBox.Location = new System.Drawing.Point(43, 328);
            this.startBox.Name = "startBox";
            this.startBox.ReadOnly = true;
            this.startBox.Size = new System.Drawing.Size(117, 30);
            this.startBox.TabIndex = 38;
            this.startBox.TabStop = false;
            // 
            // dayText
            // 
            this.dayText.BackColor = System.Drawing.SystemColors.Control;
            this.dayText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dayText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayText.Location = new System.Drawing.Point(318, 302);
            this.dayText.Name = "dayText";
            this.dayText.ReadOnly = true;
            this.dayText.Size = new System.Drawing.Size(45, 20);
            this.dayText.TabIndex = 43;
            this.dayText.TabStop = false;
            this.dayText.Text = "Days";
            // 
            // startText
            // 
            this.startText.BackColor = System.Drawing.SystemColors.Control;
            this.startText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startText.Location = new System.Drawing.Point(44, 302);
            this.startText.Name = "startText";
            this.startText.ReadOnly = true;
            this.startText.Size = new System.Drawing.Size(84, 20);
            this.startText.TabIndex = 39;
            this.startText.TabStop = false;
            this.startText.Text = "Start Time";
            // 
            // endText
            // 
            this.endText.BackColor = System.Drawing.SystemColors.Control;
            this.endText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.endText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endText.Location = new System.Drawing.Point(182, 302);
            this.endText.Name = "endText";
            this.endText.ReadOnly = true;
            this.endText.Size = new System.Drawing.Size(75, 20);
            this.endText.TabIndex = 41;
            this.endText.TabStop = false;
            this.endText.Text = "End Time";
            // 
            // classBox
            // 
            this.classBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.classBox.Location = new System.Drawing.Point(220, 49);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(401, 30);
            this.classBox.TabIndex = 25;
            this.classBox.TabStop = false;
            // 
            // classText
            // 
            this.classText.BackColor = System.Drawing.Color.Gold;
            this.classText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classText.Location = new System.Drawing.Point(223, 23);
            this.classText.Name = "classText";
            this.classText.ReadOnly = true;
            this.classText.Size = new System.Drawing.Size(72, 20);
            this.classText.TabIndex = 0;
            this.classText.TabStop = false;
            this.classText.Text = "Class";
            // 
            // instructorText
            // 
            this.instructorText.BackColor = System.Drawing.Color.Gold;
            this.instructorText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructorText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorText.Location = new System.Drawing.Point(220, 102);
            this.instructorText.Name = "instructorText";
            this.instructorText.ReadOnly = true;
            this.instructorText.Size = new System.Drawing.Size(83, 20);
            this.instructorText.TabIndex = 0;
            this.instructorText.TabStop = false;
            this.instructorText.Text = "Instructor";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(56, 461);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(170, 49);
            this.saveButton.TabIndex = 25;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.backButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(252, 461);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(170, 49);
            this.backButton.TabIndex = 26;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // instructorsList
            // 
            this.instructorsList.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.instructorsList.FormattingEnabled = true;
            this.instructorsList.ItemHeight = 22;
            this.instructorsList.Location = new System.Drawing.Point(220, 128);
            this.instructorsList.Name = "instructorsList";
            this.instructorsList.Size = new System.Drawing.Size(401, 136);
            this.instructorsList.TabIndex = 26;
            // 
            // editClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 541);
            this.ControlBox = false;
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.endBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.startBox);
            this.Controls.Add(this.editClassPanel);
            this.Controls.Add(this.dayText);
            this.Controls.Add(this.startText);
            this.Controls.Add(this.endText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editClassForm";
            this.Text = "TKGym";
            this.editClassPanel.ResumeLayout(false);
            this.editClassPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel editClassPanel;
        private System.Windows.Forms.TextBox classText;
        private System.Windows.Forms.TextBox instructorText;
        private System.Windows.Forms.TextBox classBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox dayBox;
        private System.Windows.Forms.TextBox endBox;
        private System.Windows.Forms.TextBox startBox;
        private System.Windows.Forms.TextBox dayText;
        private System.Windows.Forms.TextBox startText;
        private System.Windows.Forms.TextBox endText;
        private System.Windows.Forms.ListBox instructorsList;
    }
}