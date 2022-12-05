
namespace tkgDatabase
{
    partial class availiableClassesForm
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
            this.availiableClassesFormPanel = new System.Windows.Forms.Panel();
            this.classLocBox = new System.Windows.Forms.TextBox();
            this.availClassLocText = new System.Windows.Forms.TextBox();
            this.availiableClassesList = new System.Windows.Forms.ListBox();
            this.availiableClassesText = new System.Windows.Forms.TextBox();
            this.instructorBox = new System.Windows.Forms.TextBox();
            this.instructorText = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.unregisterButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.startBox = new System.Windows.Forms.TextBox();
            this.startText = new System.Windows.Forms.TextBox();
            this.endBox = new System.Windows.Forms.TextBox();
            this.endText = new System.Windows.Forms.TextBox();
            this.daysBox = new System.Windows.Forms.TextBox();
            this.dayText = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.locationCombo = new System.Windows.Forms.ComboBox();
            this.filterText = new System.Windows.Forms.TextBox();
            this.availiableClassesFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // availiableClassesFormPanel
            // 
            this.availiableClassesFormPanel.BackColor = System.Drawing.Color.Gold;
            this.availiableClassesFormPanel.Controls.Add(this.classLocBox);
            this.availiableClassesFormPanel.Controls.Add(this.availClassLocText);
            this.availiableClassesFormPanel.Controls.Add(this.availiableClassesList);
            this.availiableClassesFormPanel.Controls.Add(this.availiableClassesText);
            this.availiableClassesFormPanel.Location = new System.Drawing.Point(-195, -8);
            this.availiableClassesFormPanel.Name = "availiableClassesFormPanel";
            this.availiableClassesFormPanel.Size = new System.Drawing.Size(846, 287);
            this.availiableClassesFormPanel.TabIndex = 3;
            // 
            // classLocBox
            // 
            this.classLocBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.classLocBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classLocBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.classLocBox.Location = new System.Drawing.Point(218, 245);
            this.classLocBox.Name = "classLocBox";
            this.classLocBox.ReadOnly = true;
            this.classLocBox.Size = new System.Drawing.Size(411, 30);
            this.classLocBox.TabIndex = 39;
            this.classLocBox.TabStop = false;
            // 
            // availClassLocText
            // 
            this.availClassLocText.BackColor = System.Drawing.Color.Gold;
            this.availClassLocText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.availClassLocText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availClassLocText.Location = new System.Drawing.Point(218, 219);
            this.availClassLocText.Name = "availClassLocText";
            this.availClassLocText.ReadOnly = true;
            this.availClassLocText.Size = new System.Drawing.Size(152, 20);
            this.availClassLocText.TabIndex = 40;
            this.availClassLocText.TabStop = false;
            this.availClassLocText.Text = "Class Location";
            // 
            // availiableClassesList
            // 
            this.availiableClassesList.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.availiableClassesList.FormattingEnabled = true;
            this.availiableClassesList.ItemHeight = 22;
            this.availiableClassesList.Location = new System.Drawing.Point(218, 46);
            this.availiableClassesList.Name = "availiableClassesList";
            this.availiableClassesList.Size = new System.Drawing.Size(411, 158);
            this.availiableClassesList.TabIndex = 20;
            this.availiableClassesList.SelectedIndexChanged += new System.EventHandler(this.availiableClassesList_SelectedIndexChanged);
            // 
            // availiableClassesText
            // 
            this.availiableClassesText.BackColor = System.Drawing.Color.Gold;
            this.availiableClassesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.availiableClassesText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availiableClassesText.Location = new System.Drawing.Point(218, 20);
            this.availiableClassesText.Name = "availiableClassesText";
            this.availiableClassesText.ReadOnly = true;
            this.availiableClassesText.Size = new System.Drawing.Size(142, 20);
            this.availiableClassesText.TabIndex = 0;
            this.availiableClassesText.TabStop = false;
            this.availiableClassesText.Text = "Availiable Classes";
            // 
            // instructorBox
            // 
            this.instructorBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.instructorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instructorBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.instructorBox.Location = new System.Drawing.Point(24, 311);
            this.instructorBox.Name = "instructorBox";
            this.instructorBox.ReadOnly = true;
            this.instructorBox.Size = new System.Drawing.Size(411, 30);
            this.instructorBox.TabIndex = 0;
            this.instructorBox.TabStop = false;
            // 
            // instructorText
            // 
            this.instructorText.BackColor = System.Drawing.SystemColors.Control;
            this.instructorText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructorText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorText.Location = new System.Drawing.Point(24, 285);
            this.instructorText.Name = "instructorText";
            this.instructorText.ReadOnly = true;
            this.instructorText.Size = new System.Drawing.Size(84, 20);
            this.instructorText.TabIndex = 0;
            this.instructorText.TabStop = false;
            this.instructorText.Text = "Instructor";
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.registerButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(295, 366);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(139, 49);
            this.registerButton.TabIndex = 18;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // unregisterButton
            // 
            this.unregisterButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.unregisterButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.unregisterButton.ForeColor = System.Drawing.Color.White;
            this.unregisterButton.Location = new System.Drawing.Point(295, 428);
            this.unregisterButton.Name = "unregisterButton";
            this.unregisterButton.Size = new System.Drawing.Size(139, 49);
            this.unregisterButton.TabIndex = 19;
            this.unregisterButton.Text = "Unregister";
            this.unregisterButton.UseVisualStyleBackColor = false;
            this.unregisterButton.Click += new System.EventHandler(this.unregisterButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.backButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(295, 489);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(139, 49);
            this.backButton.TabIndex = 23;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // startBox
            // 
            this.startBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.startBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.startBox.Location = new System.Drawing.Point(23, 382);
            this.startBox.Name = "startBox";
            this.startBox.ReadOnly = true;
            this.startBox.Size = new System.Drawing.Size(117, 30);
            this.startBox.TabIndex = 21;
            this.startBox.TabStop = false;
            // 
            // startText
            // 
            this.startText.BackColor = System.Drawing.SystemColors.Control;
            this.startText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startText.Location = new System.Drawing.Point(23, 356);
            this.startText.Name = "startText";
            this.startText.ReadOnly = true;
            this.startText.Size = new System.Drawing.Size(84, 20);
            this.startText.TabIndex = 22;
            this.startText.TabStop = false;
            this.startText.Text = "Start Time";
            // 
            // endBox
            // 
            this.endBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.endBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.endBox.Location = new System.Drawing.Point(166, 382);
            this.endBox.Name = "endBox";
            this.endBox.ReadOnly = true;
            this.endBox.Size = new System.Drawing.Size(117, 30);
            this.endBox.TabIndex = 24;
            this.endBox.TabStop = false;
            // 
            // endText
            // 
            this.endText.BackColor = System.Drawing.SystemColors.Control;
            this.endText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.endText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endText.Location = new System.Drawing.Point(166, 356);
            this.endText.Name = "endText";
            this.endText.ReadOnly = true;
            this.endText.Size = new System.Drawing.Size(84, 20);
            this.endText.TabIndex = 25;
            this.endText.TabStop = false;
            this.endText.Text = "End Time";
            // 
            // daysBox
            // 
            this.daysBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.daysBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.daysBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.daysBox.Location = new System.Drawing.Point(24, 444);
            this.daysBox.Name = "daysBox";
            this.daysBox.ReadOnly = true;
            this.daysBox.Size = new System.Drawing.Size(117, 30);
            this.daysBox.TabIndex = 26;
            this.daysBox.TabStop = false;
            // 
            // dayText
            // 
            this.dayText.BackColor = System.Drawing.SystemColors.Control;
            this.dayText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dayText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayText.Location = new System.Drawing.Point(24, 418);
            this.dayText.Name = "dayText";
            this.dayText.ReadOnly = true;
            this.dayText.Size = new System.Drawing.Size(84, 20);
            this.dayText.TabIndex = 27;
            this.dayText.TabStop = false;
            this.dayText.Text = "Days";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.clearButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 10F);
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(198, 491);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(85, 22);
            this.clearButton.TabIndex = 32;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // locationCombo
            // 
            this.locationCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationCombo.FormattingEnabled = true;
            this.locationCombo.Location = new System.Drawing.Point(21, 517);
            this.locationCombo.Name = "locationCombo";
            this.locationCombo.Size = new System.Drawing.Size(262, 21);
            this.locationCombo.TabIndex = 31;
            this.locationCombo.SelectedIndexChanged += new System.EventHandler(this.locationCombo_SelectedIndexChanged);
            // 
            // filterText
            // 
            this.filterText.BackColor = System.Drawing.SystemColors.Control;
            this.filterText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filterText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterText.Location = new System.Drawing.Point(21, 489);
            this.filterText.Name = "filterText";
            this.filterText.ReadOnly = true;
            this.filterText.Size = new System.Drawing.Size(144, 20);
            this.filterText.TabIndex = 30;
            this.filterText.TabStop = false;
            this.filterText.Text = "Filter By Location";
            // 
            // availiableClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 556);
            this.ControlBox = false;
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.locationCombo);
            this.Controls.Add(this.filterText);
            this.Controls.Add(this.daysBox);
            this.Controls.Add(this.instructorBox);
            this.Controls.Add(this.dayText);
            this.Controls.Add(this.endBox);
            this.Controls.Add(this.instructorText);
            this.Controls.Add(this.endText);
            this.Controls.Add(this.startBox);
            this.Controls.Add(this.startText);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.unregisterButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.availiableClassesFormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "availiableClassesForm";
            this.ShowIcon = false;
            this.Text = "TKGym";
            this.availiableClassesFormPanel.ResumeLayout(false);
            this.availiableClassesFormPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel availiableClassesFormPanel;
        private System.Windows.Forms.TextBox availiableClassesText;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button unregisterButton;
        private System.Windows.Forms.ListBox availiableClassesList;
        private System.Windows.Forms.TextBox instructorText;
        private System.Windows.Forms.TextBox instructorBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox startBox;
        private System.Windows.Forms.TextBox startText;
        private System.Windows.Forms.TextBox endBox;
        private System.Windows.Forms.TextBox endText;
        private System.Windows.Forms.TextBox daysBox;
        private System.Windows.Forms.TextBox dayText;
        private System.Windows.Forms.TextBox classLocBox;
        private System.Windows.Forms.TextBox availClassLocText;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ComboBox locationCombo;
        private System.Windows.Forms.TextBox filterText;
    }
}