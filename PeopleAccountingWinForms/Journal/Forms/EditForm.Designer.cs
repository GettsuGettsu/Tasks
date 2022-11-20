namespace PeopleAccountingWinForms.Journal.StudentsButtonForms
{
    partial class EditForm
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
            this.buttons_panel = new System.Windows.Forms.Panel();
            this.isFormalForm_checkBox = new System.Windows.Forms.CheckBox();
            this.isTeacher_checkBox = new System.Windows.Forms.CheckBox();
            this.optionalClasses_textBox = new System.Windows.Forms.TextBox();
            this.salary_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cancel_button = new System.Windows.Forms.Button();
            this.isOnVacation_checkBox = new System.Windows.Forms.CheckBox();
            this.optionalClasses_label = new System.Windows.Forms.Label();
            this.isTeacher_label = new System.Windows.Forms.Label();
            this.salary_label = new System.Windows.Forms.Label();
            this.isOnVacation_label = new System.Windows.Forms.Label();
            this.isFormalForm_label = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.dateOfBirth_label = new System.Windows.Forms.Label();
            this.lastName_textBox = new System.Windows.Forms.TextBox();
            this.lastName_label = new System.Windows.Forms.Label();
            this.firstName_label = new System.Windows.Forms.Label();
            this.firstName_textBox = new System.Windows.Forms.TextBox();
            this.dateOfBirth_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.names_panel = new System.Windows.Forms.Panel();
            this.dateOfBirth_panel = new System.Windows.Forms.Panel();
            this.salary_panel = new System.Windows.Forms.Panel();
            this.vacationForm_panel = new System.Windows.Forms.Panel();
            this.teacherPanel_panel = new System.Windows.Forms.Panel();
            this.optionalClasses_panel = new System.Windows.Forms.Panel();
            this.buttons_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salary_numericUpDown)).BeginInit();
            this.names_panel.SuspendLayout();
            this.dateOfBirth_panel.SuspendLayout();
            this.salary_panel.SuspendLayout();
            this.vacationForm_panel.SuspendLayout();
            this.teacherPanel_panel.SuspendLayout();
            this.optionalClasses_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttons_panel
            // 
            this.buttons_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buttons_panel.Controls.Add(this.cancel_button);
            this.buttons_panel.Controls.Add(this.ok_button);
            this.buttons_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttons_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttons_panel.Location = new System.Drawing.Point(0, 373);
            this.buttons_panel.Name = "buttons_panel";
            this.buttons_panel.Size = new System.Drawing.Size(516, 91);
            this.buttons_panel.TabIndex = 0;
            // 
            // isFormalForm_checkBox
            // 
            this.isFormalForm_checkBox.AutoSize = true;
            this.isFormalForm_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.isFormalForm_checkBox.ForeColor = System.Drawing.Color.White;
            this.isFormalForm_checkBox.Location = new System.Drawing.Point(260, 50);
            this.isFormalForm_checkBox.Name = "isFormalForm_checkBox";
            this.isFormalForm_checkBox.Size = new System.Drawing.Size(43, 29);
            this.isFormalForm_checkBox.TabIndex = 11;
            this.isFormalForm_checkBox.Text = " ";
            this.isFormalForm_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isFormalForm_checkBox.UseVisualStyleBackColor = true;
            // 
            // isTeacher_checkBox
            // 
            this.isTeacher_checkBox.AutoSize = true;
            this.isTeacher_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.isTeacher_checkBox.ForeColor = System.Drawing.Color.White;
            this.isTeacher_checkBox.Location = new System.Drawing.Point(260, 7);
            this.isTeacher_checkBox.Name = "isTeacher_checkBox";
            this.isTeacher_checkBox.Size = new System.Drawing.Size(43, 29);
            this.isTeacher_checkBox.TabIndex = 13;
            this.isTeacher_checkBox.Text = " ";
            this.isTeacher_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isTeacher_checkBox.UseVisualStyleBackColor = true;
            this.isTeacher_checkBox.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // optionalClasses_textBox
            // 
            this.optionalClasses_textBox.AllowDrop = true;
            this.optionalClasses_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.optionalClasses_textBox.Location = new System.Drawing.Point(260, 7);
            this.optionalClasses_textBox.Name = "optionalClasses_textBox";
            this.optionalClasses_textBox.Size = new System.Drawing.Size(244, 30);
            this.optionalClasses_textBox.TabIndex = 15;
            // 
            // salary_numericUpDown
            // 
            this.salary_numericUpDown.AllowDrop = true;
            this.salary_numericUpDown.DecimalPlaces = 2;
            this.salary_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.salary_numericUpDown.Location = new System.Drawing.Point(260, 7);
            this.salary_numericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.salary_numericUpDown.Name = "salary_numericUpDown";
            this.salary_numericUpDown.Size = new System.Drawing.Size(244, 30);
            this.salary_numericUpDown.TabIndex = 7;
            this.salary_numericUpDown.ThousandsSeparator = true;
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.Gray;
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.FlatAppearance.BorderSize = 0;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancel_button.Location = new System.Drawing.Point(387, 44);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(118, 40);
            this.cancel_button.TabIndex = 0;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            // 
            // isOnVacation_checkBox
            // 
            this.isOnVacation_checkBox.AutoSize = true;
            this.isOnVacation_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.isOnVacation_checkBox.ForeColor = System.Drawing.Color.White;
            this.isOnVacation_checkBox.Location = new System.Drawing.Point(260, 7);
            this.isOnVacation_checkBox.Name = "isOnVacation_checkBox";
            this.isOnVacation_checkBox.Size = new System.Drawing.Size(43, 29);
            this.isOnVacation_checkBox.TabIndex = 9;
            this.isOnVacation_checkBox.Text = " ";
            this.isOnVacation_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isOnVacation_checkBox.UseVisualStyleBackColor = true;
            // 
            // optionalClasses_label
            // 
            this.optionalClasses_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.optionalClasses_label.ForeColor = System.Drawing.Color.White;
            this.optionalClasses_label.Location = new System.Drawing.Point(12, 7);
            this.optionalClasses_label.Name = "optionalClasses_label";
            this.optionalClasses_label.Size = new System.Drawing.Size(244, 33);
            this.optionalClasses_label.TabIndex = 14;
            this.optionalClasses_label.Text = "Opional classes";
            this.optionalClasses_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // isTeacher_label
            // 
            this.isTeacher_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isTeacher_label.ForeColor = System.Drawing.Color.White;
            this.isTeacher_label.Location = new System.Drawing.Point(12, 7);
            this.isTeacher_label.Name = "isTeacher_label";
            this.isTeacher_label.Size = new System.Drawing.Size(244, 33);
            this.isTeacher_label.TabIndex = 12;
            this.isTeacher_label.Text = "Teacher";
            this.isTeacher_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // salary_label
            // 
            this.salary_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salary_label.ForeColor = System.Drawing.Color.White;
            this.salary_label.Location = new System.Drawing.Point(12, 7);
            this.salary_label.Name = "salary_label";
            this.salary_label.Size = new System.Drawing.Size(244, 33);
            this.salary_label.TabIndex = 6;
            this.salary_label.Text = "Salary";
            this.salary_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // isOnVacation_label
            // 
            this.isOnVacation_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isOnVacation_label.ForeColor = System.Drawing.Color.White;
            this.isOnVacation_label.Location = new System.Drawing.Point(12, 7);
            this.isOnVacation_label.Name = "isOnVacation_label";
            this.isOnVacation_label.Size = new System.Drawing.Size(244, 33);
            this.isOnVacation_label.TabIndex = 8;
            this.isOnVacation_label.Text = "On vacation";
            this.isOnVacation_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // isFormalForm_label
            // 
            this.isFormalForm_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isFormalForm_label.ForeColor = System.Drawing.Color.White;
            this.isFormalForm_label.Location = new System.Drawing.Point(12, 51);
            this.isFormalForm_label.Name = "isFormalForm_label";
            this.isFormalForm_label.Size = new System.Drawing.Size(244, 33);
            this.isFormalForm_label.TabIndex = 10;
            this.isFormalForm_label.Text = "Formal form";
            this.isFormalForm_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ok_button
            // 
            this.ok_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.ok_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ok_button.FlatAppearance.BorderSize = 0;
            this.ok_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.ok_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ok_button.Location = new System.Drawing.Point(263, 44);
            this.ok_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(118, 40);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = false;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // dateOfBirth_label
            // 
            this.dateOfBirth_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOfBirth_label.ForeColor = System.Drawing.Color.White;
            this.dateOfBirth_label.Location = new System.Drawing.Point(12, 7);
            this.dateOfBirth_label.Name = "dateOfBirth_label";
            this.dateOfBirth_label.Size = new System.Drawing.Size(244, 33);
            this.dateOfBirth_label.TabIndex = 4;
            this.dateOfBirth_label.Text = "Date of birth";
            this.dateOfBirth_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lastName_textBox
            // 
            this.lastName_textBox.AllowDrop = true;
            this.lastName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lastName_textBox.Location = new System.Drawing.Point(260, 58);
            this.lastName_textBox.Name = "lastName_textBox";
            this.lastName_textBox.Size = new System.Drawing.Size(244, 30);
            this.lastName_textBox.TabIndex = 3;
            // 
            // lastName_label
            // 
            this.lastName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastName_label.ForeColor = System.Drawing.Color.White;
            this.lastName_label.Location = new System.Drawing.Point(12, 58);
            this.lastName_label.Name = "lastName_label";
            this.lastName_label.Size = new System.Drawing.Size(244, 33);
            this.lastName_label.TabIndex = 2;
            this.lastName_label.Text = "Last name";
            this.lastName_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstName_label
            // 
            this.firstName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstName_label.ForeColor = System.Drawing.Color.White;
            this.firstName_label.Location = new System.Drawing.Point(12, 14);
            this.firstName_label.Name = "firstName_label";
            this.firstName_label.Size = new System.Drawing.Size(244, 33);
            this.firstName_label.TabIndex = 0;
            this.firstName_label.Text = "First name";
            this.firstName_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstName_textBox
            // 
            this.firstName_textBox.AllowDrop = true;
            this.firstName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.firstName_textBox.Location = new System.Drawing.Point(260, 14);
            this.firstName_textBox.Name = "firstName_textBox";
            this.firstName_textBox.Size = new System.Drawing.Size(244, 30);
            this.firstName_textBox.TabIndex = 1;
            // 
            // dateOfBirth_dateTimePicker
            // 
            this.dateOfBirth_dateTimePicker.AllowDrop = true;
            this.dateOfBirth_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateOfBirth_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirth_dateTimePicker.Location = new System.Drawing.Point(260, 7);
            this.dateOfBirth_dateTimePicker.Name = "dateOfBirth_dateTimePicker";
            this.dateOfBirth_dateTimePicker.Size = new System.Drawing.Size(244, 30);
            this.dateOfBirth_dateTimePicker.TabIndex = 5;
            // 
            // names_panel
            // 
            this.names_panel.Controls.Add(this.lastName_textBox);
            this.names_panel.Controls.Add(this.lastName_label);
            this.names_panel.Controls.Add(this.firstName_textBox);
            this.names_panel.Controls.Add(this.firstName_label);
            this.names_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.names_panel.Location = new System.Drawing.Point(0, 0);
            this.names_panel.Name = "names_panel";
            this.names_panel.Size = new System.Drawing.Size(516, 95);
            this.names_panel.TabIndex = 5;
            // 
            // dateOfBirth_panel
            // 
            this.dateOfBirth_panel.Controls.Add(this.dateOfBirth_label);
            this.dateOfBirth_panel.Controls.Add(this.dateOfBirth_dateTimePicker);
            this.dateOfBirth_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateOfBirth_panel.Location = new System.Drawing.Point(0, 95);
            this.dateOfBirth_panel.Name = "dateOfBirth_panel";
            this.dateOfBirth_panel.Size = new System.Drawing.Size(516, 44);
            this.dateOfBirth_panel.TabIndex = 6;
            // 
            // salary_panel
            // 
            this.salary_panel.Controls.Add(this.salary_label);
            this.salary_panel.Controls.Add(this.salary_numericUpDown);
            this.salary_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.salary_panel.Location = new System.Drawing.Point(0, 139);
            this.salary_panel.Name = "salary_panel";
            this.salary_panel.Size = new System.Drawing.Size(516, 44);
            this.salary_panel.TabIndex = 7;
            // 
            // vacationForm_panel
            // 
            this.vacationForm_panel.Controls.Add(this.isOnVacation_label);
            this.vacationForm_panel.Controls.Add(this.isFormalForm_checkBox);
            this.vacationForm_panel.Controls.Add(this.isOnVacation_checkBox);
            this.vacationForm_panel.Controls.Add(this.isFormalForm_label);
            this.vacationForm_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.vacationForm_panel.Location = new System.Drawing.Point(0, 183);
            this.vacationForm_panel.Name = "vacationForm_panel";
            this.vacationForm_panel.Size = new System.Drawing.Size(516, 86);
            this.vacationForm_panel.TabIndex = 8;
            // 
            // teacherPanel_panel
            // 
            this.teacherPanel_panel.Controls.Add(this.isTeacher_checkBox);
            this.teacherPanel_panel.Controls.Add(this.isTeacher_label);
            this.teacherPanel_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.teacherPanel_panel.Location = new System.Drawing.Point(0, 269);
            this.teacherPanel_panel.Name = "teacherPanel_panel";
            this.teacherPanel_panel.Size = new System.Drawing.Size(516, 43);
            this.teacherPanel_panel.TabIndex = 9;
            // 
            // optionalClasses_panel
            // 
            this.optionalClasses_panel.Controls.Add(this.optionalClasses_label);
            this.optionalClasses_panel.Controls.Add(this.optionalClasses_textBox);
            this.optionalClasses_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.optionalClasses_panel.Location = new System.Drawing.Point(0, 312);
            this.optionalClasses_panel.Name = "optionalClasses_panel";
            this.optionalClasses_panel.Size = new System.Drawing.Size(516, 44);
            this.optionalClasses_panel.TabIndex = 10;
            this.optionalClasses_panel.Visible = false;
            // 
            // EditForm
            // 
            this.AcceptButton = this.ok_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(516, 464);
            this.Controls.Add(this.buttons_panel);
            this.Controls.Add(this.optionalClasses_panel);
            this.Controls.Add(this.teacherPanel_panel);
            this.Controls.Add(this.vacationForm_panel);
            this.Controls.Add(this.salary_panel);
            this.Controls.Add(this.dateOfBirth_panel);
            this.Controls.Add(this.names_panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.buttons_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salary_numericUpDown)).EndInit();
            this.names_panel.ResumeLayout(false);
            this.names_panel.PerformLayout();
            this.dateOfBirth_panel.ResumeLayout(false);
            this.salary_panel.ResumeLayout(false);
            this.vacationForm_panel.ResumeLayout(false);
            this.vacationForm_panel.PerformLayout();
            this.teacherPanel_panel.ResumeLayout(false);
            this.teacherPanel_panel.PerformLayout();
            this.optionalClasses_panel.ResumeLayout(false);
            this.optionalClasses_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttons_panel;
        private System.Windows.Forms.CheckBox isTeacher_checkBox;
        private System.Windows.Forms.Label isTeacher_label;
        private System.Windows.Forms.CheckBox isFormalForm_checkBox;
        private System.Windows.Forms.Label isFormalForm_label;
        private System.Windows.Forms.Label isOnVacation_label;
        private System.Windows.Forms.Label salary_label;
        private System.Windows.Forms.Label dateOfBirth_label;
        private System.Windows.Forms.TextBox lastName_textBox;
        private System.Windows.Forms.Label lastName_label;
        private System.Windows.Forms.Label firstName_label;
        private System.Windows.Forms.TextBox firstName_textBox;
        private System.Windows.Forms.DateTimePicker dateOfBirth_dateTimePicker;
        private System.Windows.Forms.NumericUpDown salary_numericUpDown;
        private System.Windows.Forms.CheckBox isOnVacation_checkBox;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.TextBox optionalClasses_textBox;
        private System.Windows.Forms.Label optionalClasses_label;
        private System.Windows.Forms.Panel names_panel;
        private System.Windows.Forms.Panel dateOfBirth_panel;
        private System.Windows.Forms.Panel salary_panel;
        private System.Windows.Forms.Panel vacationForm_panel;
        private System.Windows.Forms.Panel teacherPanel_panel;
        private System.Windows.Forms.Panel optionalClasses_panel;
    }
}