
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
            this.saveButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.editClassText = new System.Windows.Forms.TextBox();
            this.editClassPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.instructorCombo = new System.Windows.Forms.ComboBox();
            this.gymLocCombo = new System.Windows.Forms.ComboBox();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.classNameText = new System.Windows.Forms.TextBox();
            this.gymLocText = new System.Windows.Forms.TextBox();
            this.classNameBox = new System.Windows.Forms.TextBox();
            this.classStartText = new System.Windows.Forms.TextBox();
            this.instructorBox = new System.Windows.Forms.TextBox();
            this.classDaysBox = new System.Windows.Forms.TextBox();
            this.instructorText = new System.Windows.Forms.TextBox();
            this.classDaysText = new System.Windows.Forms.TextBox();
            this.classEndText = new System.Windows.Forms.TextBox();
            this.editClassFormPanel = new System.Windows.Forms.Panel();
            this.editClassPanel.SuspendLayout();
            this.editClassFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(27, 356);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(178, 49);
            this.saveButton.TabIndex = 25;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.backButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(230, 356);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(178, 49);
            this.backButton.TabIndex = 26;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // editClassText
            // 
            this.editClassText.BackColor = System.Drawing.Color.Gold;
            this.editClassText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editClassText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editClassText.Location = new System.Drawing.Point(33, 20);
            this.editClassText.Name = "editClassText";
            this.editClassText.ReadOnly = true;
            this.editClassText.Size = new System.Drawing.Size(87, 20);
            this.editClassText.TabIndex = 0;
            this.editClassText.TabStop = false;
            this.editClassText.Text = "Edit Class";
            // 
            // editClassPanel
            // 
            this.editClassPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.editClassPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editClassPanel.Controls.Add(this.textBox1);
            this.editClassPanel.Controls.Add(this.instructorCombo);
            this.editClassPanel.Controls.Add(this.gymLocCombo);
            this.editClassPanel.Controls.Add(this.endTimePicker);
            this.editClassPanel.Controls.Add(this.startTimePicker);
            this.editClassPanel.Controls.Add(this.classNameText);
            this.editClassPanel.Controls.Add(this.gymLocText);
            this.editClassPanel.Controls.Add(this.classNameBox);
            this.editClassPanel.Controls.Add(this.classStartText);
            this.editClassPanel.Controls.Add(this.instructorBox);
            this.editClassPanel.Controls.Add(this.classDaysBox);
            this.editClassPanel.Controls.Add(this.instructorText);
            this.editClassPanel.Controls.Add(this.classDaysText);
            this.editClassPanel.Controls.Add(this.classEndText);
            this.editClassPanel.Location = new System.Drawing.Point(33, 46);
            this.editClassPanel.Name = "editClassPanel";
            this.editClassPanel.Size = new System.Drawing.Size(381, 248);
            this.editClassPanel.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 7.5F);
            this.textBox1.Location = new System.Drawing.Point(13, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(116, 13);
            this.textBox1.TabIndex = 22;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "(+ Instructor Location)";
            // 
            // instructorCombo
            // 
            this.instructorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instructorCombo.FormattingEnabled = true;
            this.instructorCombo.Location = new System.Drawing.Point(118, 166);
            this.instructorCombo.Name = "instructorCombo";
            this.instructorCombo.Size = new System.Drawing.Size(139, 21);
            this.instructorCombo.TabIndex = 21;
            this.instructorCombo.SelectedIndexChanged += new System.EventHandler(this.instructorCombo_SelectedIndexChanged);
            // 
            // gymLocCombo
            // 
            this.gymLocCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gymLocCombo.FormattingEnabled = true;
            this.gymLocCombo.Location = new System.Drawing.Point(151, 207);
            this.gymLocCombo.Name = "gymLocCombo";
            this.gymLocCombo.Size = new System.Drawing.Size(213, 21);
            this.gymLocCombo.TabIndex = 20;
            this.gymLocCombo.SelectedIndexChanged += new System.EventHandler(this.gymLocCombo_SelectedIndexChanged);
            // 
            // endTimePicker
            // 
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTimePicker.Location = new System.Drawing.Point(192, 85);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(84, 20);
            this.endTimePicker.TabIndex = 19;
            this.endTimePicker.Value = new System.DateTime(2022, 11, 25, 9, 0, 0, 0);
            // 
            // startTimePicker
            // 
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTimePicker.Location = new System.Drawing.Point(192, 46);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(84, 20);
            this.startTimePicker.TabIndex = 18;
            this.startTimePicker.Value = new System.DateTime(2022, 11, 25, 8, 0, 0, 0);
            // 
            // classNameText
            // 
            this.classNameText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.classNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classNameText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classNameText.Location = new System.Drawing.Point(13, 10);
            this.classNameText.Name = "classNameText";
            this.classNameText.ReadOnly = true;
            this.classNameText.Size = new System.Drawing.Size(99, 20);
            this.classNameText.TabIndex = 10;
            this.classNameText.TabStop = false;
            this.classNameText.Text = "Class Name:";
            // 
            // gymLocText
            // 
            this.gymLocText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gymLocText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gymLocText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gymLocText.Location = new System.Drawing.Point(13, 208);
            this.gymLocText.Name = "gymLocText";
            this.gymLocText.ReadOnly = true;
            this.gymLocText.Size = new System.Drawing.Size(116, 20);
            this.gymLocText.TabIndex = 0;
            this.gymLocText.TabStop = false;
            this.gymLocText.Text = "Gym Location:";
            // 
            // classNameBox
            // 
            this.classNameBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.classNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classNameBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.classNameBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.classNameBox.Location = new System.Drawing.Point(118, 7);
            this.classNameBox.MaxLength = 45;
            this.classNameBox.Name = "classNameBox";
            this.classNameBox.Size = new System.Drawing.Size(246, 30);
            this.classNameBox.TabIndex = 15;
            this.classNameBox.TabStop = false;
            // 
            // classStartText
            // 
            this.classStartText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.classStartText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classStartText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classStartText.Location = new System.Drawing.Point(13, 46);
            this.classStartText.Name = "classStartText";
            this.classStartText.ReadOnly = true;
            this.classStartText.Size = new System.Drawing.Size(99, 20);
            this.classStartText.TabIndex = 8;
            this.classStartText.TabStop = false;
            this.classStartText.Text = "Class Start:";
            // 
            // instructorBox
            // 
            this.instructorBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.instructorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instructorBox.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.instructorBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.instructorBox.Location = new System.Drawing.Point(263, 166);
            this.instructorBox.MaxLength = 45;
            this.instructorBox.Name = "instructorBox";
            this.instructorBox.ReadOnly = true;
            this.instructorBox.Size = new System.Drawing.Size(101, 21);
            this.instructorBox.TabIndex = 14;
            this.instructorBox.TabStop = false;
            // 
            // classDaysBox
            // 
            this.classDaysBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.classDaysBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classDaysBox.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.classDaysBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.classDaysBox.Location = new System.Drawing.Point(118, 121);
            this.classDaysBox.MaxLength = 45;
            this.classDaysBox.Name = "classDaysBox";
            this.classDaysBox.Size = new System.Drawing.Size(246, 30);
            this.classDaysBox.TabIndex = 13;
            this.classDaysBox.TabStop = false;
            // 
            // instructorText
            // 
            this.instructorText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.instructorText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructorText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorText.Location = new System.Drawing.Point(13, 167);
            this.instructorText.Name = "instructorText";
            this.instructorText.ReadOnly = true;
            this.instructorText.Size = new System.Drawing.Size(85, 20);
            this.instructorText.TabIndex = 9;
            this.instructorText.TabStop = false;
            this.instructorText.Text = "Instructor:";
            // 
            // classDaysText
            // 
            this.classDaysText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.classDaysText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classDaysText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classDaysText.Location = new System.Drawing.Point(13, 124);
            this.classDaysText.Name = "classDaysText";
            this.classDaysText.ReadOnly = true;
            this.classDaysText.Size = new System.Drawing.Size(99, 20);
            this.classDaysText.TabIndex = 7;
            this.classDaysText.TabStop = false;
            this.classDaysText.Text = "Class Days:";
            // 
            // classEndText
            // 
            this.classEndText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.classEndText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classEndText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classEndText.Location = new System.Drawing.Point(13, 85);
            this.classEndText.Name = "classEndText";
            this.classEndText.ReadOnly = true;
            this.classEndText.Size = new System.Drawing.Size(91, 20);
            this.classEndText.TabIndex = 6;
            this.classEndText.TabStop = false;
            this.classEndText.Text = "Class End:";
            // 
            // editClassFormPanel
            // 
            this.editClassFormPanel.BackColor = System.Drawing.Color.Gold;
            this.editClassFormPanel.Controls.Add(this.editClassText);
            this.editClassFormPanel.Controls.Add(this.editClassPanel);
            this.editClassFormPanel.Location = new System.Drawing.Point(-6, -7);
            this.editClassFormPanel.Name = "editClassFormPanel";
            this.editClassFormPanel.Size = new System.Drawing.Size(486, 334);
            this.editClassFormPanel.TabIndex = 27;
            // 
            // editClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 437);
            this.ControlBox = false;
            this.Controls.Add(this.editClassFormPanel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editClassForm";
            this.Text = "TKGym";
            this.editClassPanel.ResumeLayout(false);
            this.editClassPanel.PerformLayout();
            this.editClassFormPanel.ResumeLayout(false);
            this.editClassFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox editClassText;
        private System.Windows.Forms.Panel editClassPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox instructorCombo;
        private System.Windows.Forms.ComboBox gymLocCombo;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.TextBox classNameText;
        private System.Windows.Forms.TextBox gymLocText;
        private System.Windows.Forms.TextBox classNameBox;
        private System.Windows.Forms.TextBox classStartText;
        private System.Windows.Forms.TextBox instructorBox;
        private System.Windows.Forms.TextBox classDaysBox;
        private System.Windows.Forms.TextBox instructorText;
        private System.Windows.Forms.TextBox classDaysText;
        private System.Windows.Forms.TextBox classEndText;
        private System.Windows.Forms.Panel editClassFormPanel;
    }
}