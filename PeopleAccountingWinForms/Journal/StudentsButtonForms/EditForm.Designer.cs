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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancel_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.data_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.optionalClasses_textBox = new System.Windows.Forms.TextBox();
            this.optionalClasses_label = new System.Windows.Forms.Label();
            this.isTeacher_checkBox = new System.Windows.Forms.CheckBox();
            this.isTeacher_label = new System.Windows.Forms.Label();
            this.isFormalForm_checkBox = new System.Windows.Forms.CheckBox();
            this.isFormalForm_label = new System.Windows.Forms.Label();
            this.isOnVacation_label = new System.Windows.Forms.Label();
            this.salary_label = new System.Windows.Forms.Label();
            this.dateOfBirth_label = new System.Windows.Forms.Label();
            this.lastName_textBox = new System.Windows.Forms.TextBox();
            this.lastName_label = new System.Windows.Forms.Label();
            this.firstName_label = new System.Windows.Forms.Label();
            this.firstName_textBox = new System.Windows.Forms.TextBox();
            this.dateOfBirth_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.salary_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.isOnVacation_checkBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.data_tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salary_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cancel_button);
            this.panel1.Controls.Add(this.ok_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 452);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 99);
            this.panel1.TabIndex = 0;
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Location = new System.Drawing.Point(387, 50);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(118, 37);
            this.cancel_button.TabIndex = 0;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(263, 50);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(118, 37);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // data_tableLayoutPanel
            // 
            this.data_tableLayoutPanel.ColumnCount = 2;
            this.data_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.data_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.data_tableLayoutPanel.Controls.Add(this.optionalClasses_textBox, 1, 7);
            this.data_tableLayoutPanel.Controls.Add(this.optionalClasses_label, 0, 7);
            this.data_tableLayoutPanel.Controls.Add(this.isTeacher_checkBox, 1, 6);
            this.data_tableLayoutPanel.Controls.Add(this.isTeacher_label, 0, 6);
            this.data_tableLayoutPanel.Controls.Add(this.isFormalForm_checkBox, 1, 5);
            this.data_tableLayoutPanel.Controls.Add(this.isFormalForm_label, 0, 5);
            this.data_tableLayoutPanel.Controls.Add(this.isOnVacation_label, 0, 4);
            this.data_tableLayoutPanel.Controls.Add(this.salary_label, 0, 3);
            this.data_tableLayoutPanel.Controls.Add(this.dateOfBirth_label, 0, 2);
            this.data_tableLayoutPanel.Controls.Add(this.lastName_textBox, 1, 1);
            this.data_tableLayoutPanel.Controls.Add(this.lastName_label, 0, 1);
            this.data_tableLayoutPanel.Controls.Add(this.firstName_label, 0, 0);
            this.data_tableLayoutPanel.Controls.Add(this.firstName_textBox, 1, 0);
            this.data_tableLayoutPanel.Controls.Add(this.dateOfBirth_dateTimePicker, 1, 2);
            this.data_tableLayoutPanel.Controls.Add(this.salary_numericUpDown, 1, 3);
            this.data_tableLayoutPanel.Controls.Add(this.isOnVacation_checkBox, 1, 4);
            this.data_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.data_tableLayoutPanel.Name = "data_tableLayoutPanel";
            this.data_tableLayoutPanel.Padding = new System.Windows.Forms.Padding(8);
            this.data_tableLayoutPanel.RowCount = 8;
            this.data_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.data_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.data_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.data_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.data_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.data_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.data_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.data_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.data_tableLayoutPanel.Size = new System.Drawing.Size(516, 452);
            this.data_tableLayoutPanel.TabIndex = 1;
            // 
            // optionalClasses_textBox
            // 
            this.optionalClasses_textBox.AllowDrop = true;
            this.optionalClasses_textBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.optionalClasses_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.optionalClasses_textBox.Location = new System.Drawing.Point(261, 410);
            this.optionalClasses_textBox.Name = "optionalClasses_textBox";
            this.optionalClasses_textBox.Size = new System.Drawing.Size(244, 30);
            this.optionalClasses_textBox.TabIndex = 15;
            this.optionalClasses_textBox.Visible = false;
            // 
            // optionalClasses_label
            // 
            this.optionalClasses_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.optionalClasses_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.optionalClasses_label.ForeColor = System.Drawing.Color.White;
            this.optionalClasses_label.Location = new System.Drawing.Point(11, 407);
            this.optionalClasses_label.Name = "optionalClasses_label";
            this.optionalClasses_label.Size = new System.Drawing.Size(244, 33);
            this.optionalClasses_label.TabIndex = 14;
            this.optionalClasses_label.Text = "Opional classes";
            this.optionalClasses_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionalClasses_label.Visible = false;
            // 
            // isTeacher_checkBox
            // 
            this.isTeacher_checkBox.AutoSize = true;
            this.isTeacher_checkBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.isTeacher_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.isTeacher_checkBox.ForeColor = System.Drawing.Color.White;
            this.isTeacher_checkBox.Location = new System.Drawing.Point(261, 353);
            this.isTeacher_checkBox.Name = "isTeacher_checkBox";
            this.isTeacher_checkBox.Size = new System.Drawing.Size(244, 29);
            this.isTeacher_checkBox.TabIndex = 13;
            this.isTeacher_checkBox.Text = " ";
            this.isTeacher_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isTeacher_checkBox.UseVisualStyleBackColor = true;
            this.isTeacher_checkBox.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // isTeacher_label
            // 
            this.isTeacher_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.isTeacher_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isTeacher_label.ForeColor = System.Drawing.Color.White;
            this.isTeacher_label.Location = new System.Drawing.Point(11, 350);
            this.isTeacher_label.Name = "isTeacher_label";
            this.isTeacher_label.Size = new System.Drawing.Size(244, 33);
            this.isTeacher_label.TabIndex = 12;
            this.isTeacher_label.Text = "Teacher";
            this.isTeacher_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // isFormalForm_checkBox
            // 
            this.isFormalForm_checkBox.AutoSize = true;
            this.isFormalForm_checkBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.isFormalForm_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.isFormalForm_checkBox.ForeColor = System.Drawing.Color.White;
            this.isFormalForm_checkBox.Location = new System.Drawing.Point(261, 296);
            this.isFormalForm_checkBox.Name = "isFormalForm_checkBox";
            this.isFormalForm_checkBox.Size = new System.Drawing.Size(244, 29);
            this.isFormalForm_checkBox.TabIndex = 11;
            this.isFormalForm_checkBox.Text = " ";
            this.isFormalForm_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isFormalForm_checkBox.UseVisualStyleBackColor = true;
            // 
            // isFormalForm_label
            // 
            this.isFormalForm_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.isFormalForm_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isFormalForm_label.ForeColor = System.Drawing.Color.White;
            this.isFormalForm_label.Location = new System.Drawing.Point(11, 293);
            this.isFormalForm_label.Name = "isFormalForm_label";
            this.isFormalForm_label.Size = new System.Drawing.Size(244, 33);
            this.isFormalForm_label.TabIndex = 10;
            this.isFormalForm_label.Text = "Formal form";
            this.isFormalForm_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // isOnVacation_label
            // 
            this.isOnVacation_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.isOnVacation_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isOnVacation_label.ForeColor = System.Drawing.Color.White;
            this.isOnVacation_label.Location = new System.Drawing.Point(11, 236);
            this.isOnVacation_label.Name = "isOnVacation_label";
            this.isOnVacation_label.Size = new System.Drawing.Size(244, 33);
            this.isOnVacation_label.TabIndex = 8;
            this.isOnVacation_label.Text = "On vacation";
            this.isOnVacation_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // salary_label
            // 
            this.salary_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.salary_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salary_label.ForeColor = System.Drawing.Color.White;
            this.salary_label.Location = new System.Drawing.Point(11, 179);
            this.salary_label.Name = "salary_label";
            this.salary_label.Size = new System.Drawing.Size(244, 33);
            this.salary_label.TabIndex = 6;
            this.salary_label.Text = "Salary";
            this.salary_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateOfBirth_label
            // 
            this.dateOfBirth_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateOfBirth_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOfBirth_label.ForeColor = System.Drawing.Color.White;
            this.dateOfBirth_label.Location = new System.Drawing.Point(11, 122);
            this.dateOfBirth_label.Name = "dateOfBirth_label";
            this.dateOfBirth_label.Size = new System.Drawing.Size(244, 33);
            this.dateOfBirth_label.TabIndex = 4;
            this.dateOfBirth_label.Text = "Date of birth";
            this.dateOfBirth_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lastName_textBox
            // 
            this.lastName_textBox.AllowDrop = true;
            this.lastName_textBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.lastName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lastName_textBox.Location = new System.Drawing.Point(261, 68);
            this.lastName_textBox.Name = "lastName_textBox";
            this.lastName_textBox.Size = new System.Drawing.Size(244, 30);
            this.lastName_textBox.TabIndex = 3;
            // 
            // lastName_label
            // 
            this.lastName_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.lastName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastName_label.ForeColor = System.Drawing.Color.White;
            this.lastName_label.Location = new System.Drawing.Point(11, 65);
            this.lastName_label.Name = "lastName_label";
            this.lastName_label.Size = new System.Drawing.Size(244, 33);
            this.lastName_label.TabIndex = 2;
            this.lastName_label.Text = "Last name";
            this.lastName_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstName_label
            // 
            this.firstName_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.firstName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstName_label.ForeColor = System.Drawing.Color.White;
            this.firstName_label.Location = new System.Drawing.Point(11, 8);
            this.firstName_label.Name = "firstName_label";
            this.firstName_label.Size = new System.Drawing.Size(244, 33);
            this.firstName_label.TabIndex = 0;
            this.firstName_label.Text = "First name";
            this.firstName_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstName_textBox
            // 
            this.firstName_textBox.AllowDrop = true;
            this.firstName_textBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.firstName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.firstName_textBox.Location = new System.Drawing.Point(261, 11);
            this.firstName_textBox.Name = "firstName_textBox";
            this.firstName_textBox.Size = new System.Drawing.Size(244, 30);
            this.firstName_textBox.TabIndex = 1;
            // 
            // dateOfBirth_dateTimePicker
            // 
            this.dateOfBirth_dateTimePicker.AllowDrop = true;
            this.dateOfBirth_dateTimePicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateOfBirth_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateOfBirth_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirth_dateTimePicker.Location = new System.Drawing.Point(261, 125);
            this.dateOfBirth_dateTimePicker.Name = "dateOfBirth_dateTimePicker";
            this.dateOfBirth_dateTimePicker.Size = new System.Drawing.Size(244, 30);
            this.dateOfBirth_dateTimePicker.TabIndex = 5;
            // 
            // salary_numericUpDown
            // 
            this.salary_numericUpDown.AllowDrop = true;
            this.salary_numericUpDown.DecimalPlaces = 2;
            this.salary_numericUpDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.salary_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.salary_numericUpDown.Location = new System.Drawing.Point(261, 182);
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
            // isOnVacation_checkBox
            // 
            this.isOnVacation_checkBox.AutoSize = true;
            this.isOnVacation_checkBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.isOnVacation_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.isOnVacation_checkBox.ForeColor = System.Drawing.Color.White;
            this.isOnVacation_checkBox.Location = new System.Drawing.Point(261, 239);
            this.isOnVacation_checkBox.Name = "isOnVacation_checkBox";
            this.isOnVacation_checkBox.Size = new System.Drawing.Size(244, 29);
            this.isOnVacation_checkBox.TabIndex = 9;
            this.isOnVacation_checkBox.Text = " ";
            this.isOnVacation_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isOnVacation_checkBox.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            this.AcceptButton = this.ok_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.cancel_button;
            this.ClientSize = new System.Drawing.Size(516, 551);
            this.Controls.Add(this.data_tableLayoutPanel);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.data_tableLayoutPanel.ResumeLayout(false);
            this.data_tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salary_numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel data_tableLayoutPanel;
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
    }
}