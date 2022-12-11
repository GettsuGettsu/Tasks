using PeopleAccounting.Staff;
using PeopleAccounting.Staff.Post;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleAccountingWinForms.Journal.Forms
{
    public partial class EditForm : Form
    {
        #region Fields
        private bool isStudents = false;
        private bool isEdit = false;
        private DataGridViewRow selectedRow = null;
        private object human = null;
        #endregion

        #region Constructor
        internal EditForm(bool isStudents, bool isEdit, DataGridViewRow selectedRow = null)
        {
            InitializeComponent();

            this.isStudents = isStudents;
            this.isEdit = isEdit;
            this.selectedRow = selectedRow;
        }
        #endregion

        #region Events
        private void EditForm_Load(object sender, EventArgs e)
        {
            if (isStudents)
            {
                salary_panel.Visible = false;
                teacherPanel_panel.Visible = false;
                optionalClasses_panel.Visible = true;
            }
            if (isEdit)
                DoEditPrepare();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (!isEdit)
                AddHuman();
            else
                EditHuman();

            this.Close();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            optionalClasses_panel.Visible = isTeacher_checkBox.Checked;
        }
        #endregion

        #region Methods
        private void DoEditPrepare()
        {
            GetHumanFromSelectedRow();            
            FillForm(this.human);
        }

        private void GetHumanFromSelectedRow()
        {            
            var cells = selectedRow.Cells;

            if (isStudents)
            {
                this.human = selectedRow.DataBoundItem as Student; // new Student((string)cells[1].Value, (string)cells[2].Value, (DateTime)cells[3].Value, (bool)cells[4].Value, (EducationalHelper.ClassTypes)cells[6].Value);
            }
            else
            {
                if ((bool)cells["IsTeacher"].Value)
                    this.human = selectedRow.DataBoundItem as Teacher; // new Teacher((string)cells[1].Value, (string)cells[2].Value, (DateTime)cells[3].Value, (double)cells[4].Value, (bool)cells[5].Value, (EducationalHelper.ClassTypes)cells[8].Value);
                else
                {
                    this.human = selectedRow.DataBoundItem as Employee; // new Employee((string)cells[1].Value, (string)cells[2].Value, (DateTime)cells[3].Value, (double)cells[4].Value, (bool)cells[5].Value);
                }
            }
        }

        private void FillForm(object obj)
        {
            foreach (Panel panel in this.Controls)
            {
                if (!panel.Visible)
                {
                    continue;
                }

                foreach (Control control in panel.Controls)
                {
                    object cntrl = control as TextBox;
                    if (cntrl != null)
                    {
                        (cntrl as TextBox).Text = GetPropertyValue(obj, GetPropertyNameFromControlName(control.Name)).ToString();
                        continue;
                    }

                    cntrl = control as DateTimePicker;
                    if (cntrl != null)
                    {
                        (cntrl as DateTimePicker).Value = (DateTime)GetPropertyValue(obj, GetPropertyNameFromControlName(control.Name));
                        continue;
                    }

                    cntrl = control as NumericUpDown;
                    if (cntrl != null)
                    {
                        (cntrl as NumericUpDown).Value = (decimal)GetPropertyValue(obj, GetPropertyNameFromControlName(control.Name));
                        continue;
                    }

                    cntrl = control as CheckBox;
                    if (cntrl != null)
                    {
                        (cntrl as CheckBox).Checked = (bool)GetPropertyValue(obj, GetPropertyNameFromControlName(control.Name));
                    }
                }
            }
        }

        private static string GetPropertyNameFromControlName(string controlName)
        {
            string propName = char.ToUpper(controlName[0]) + controlName.Substring(1);
            propName = propName.Substring(0, propName.IndexOf('_'));

            return propName;
        }

        private static object GetPropertyValue(object obj, string propName)
        {
            object value = obj.GetType().GetProperty(propName).GetValue(obj);
            return value;
        }

        private void AddHuman()
        {
            if (isStudents)
            {
                AddStudent();
            }
            else if (isTeacher_checkBox.Checked)
            {
                AddTeacher();
            }
            else
            {
                AddEmployee();
            }
        }

        private void AddStudent()
        {
            BaseForm.university.AddStudent(new Student(firstName_textBox.Text, lastName_textBox.Text, dateOfBirth_dateTimePicker.Value.Date,
                    isOnVacation_checkBox.Checked, optionalClasses_textBox.Text));
        }

        private void AddTeacher()
        {
            BaseForm.university.AddTeacher(new Teacher(firstName_textBox.Text, lastName_textBox.Text, dateOfBirth_dateTimePicker.Value.Date,
                    salary_numericUpDown.Value, isOnVacation_checkBox.Checked, optionalClasses_textBox.Text));
        }

        private void AddEmployee()
        {
            BaseForm.university.AddEmployee(new Employee(firstName_textBox.Text, lastName_textBox.Text, dateOfBirth_dateTimePicker.Value.Date,
                    salary_numericUpDown.Value, isOnVacation_checkBox.Checked)); ;
        }

        private void EditHuman()
        {
            foreach (var prop in human.GetType().GetProperties())
            {
                if (prop.Name == "Id" || prop.Name == "IsFormalForm")
                {
                    continue;
                }

                object value = null;

                switch (GetControlByPropName(prop.Name))
                {
                    case TextBox textBox:
                        value = textBox.Text;
                        break;

                    case DateTimePicker dateTimePicker:
                        value = dateTimePicker.Value;
                        break;

                    case NumericUpDown numericUpDown:
                        value = numericUpDown.Value;
                        break;

                    case CheckBox checkBox:
                        value = checkBox.Checked;
                        break;
                }

                if (prop.Name == "OptionalClasses")
                {
                    prop.SetValue(human, EducationalHelper.ToOptionalClasses((string)value));
                    continue;
                }
                prop.SetValue(human, value);
            }
        }

        private Control GetControlByPropName(string propName)
        {
            foreach (Panel panel in this.Controls)
            {
                if (!panel.Visible)
                {
                    continue;
                }

                foreach (Control control in panel.Controls)
                {
                    if (!control.Name.Contains("label") && control.Name.ToLower().Contains(propName.ToLower()))
                        return control;
                }
            }
            
            return null;
        }
        #endregion
    }
}
