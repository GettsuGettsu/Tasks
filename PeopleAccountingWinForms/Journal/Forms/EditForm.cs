using PeopleAccounting.Staff;
using PeopleAccounting.Staff.Post;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleAccountingWinForms.Journal.StudentsButtonForms
{
    public partial class EditForm : Form
    {
        private bool isStudents = false;
        private bool isEdit = false;
        private DataGridViewRow selectedRow = null;

        internal EditForm(bool isStudents, bool isEdit, DataGridViewRow selectedRow = null)
        {
            InitializeComponent();

            this.isStudents = isStudents;
            this.isEdit = isEdit;
            this.selectedRow = selectedRow;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            if (isStudents)
            {
                salary_panel.Visible = false;
                teacherPanel_panel.Visible = false;
                optionalClasses_panel.Visible = true;
            }
            if (isEdit)
                DoEditPrepare(selectedRow);
        }

        private void DoEditPrepare(DataGridViewRow selectedRow)
        {
            object human;

            var cells = selectedRow.Cells;
            if (isStudents)
            {
                human = selectedRow.DataBoundItem as Student;// new Student((string)cells[1].Value, (string)cells[2].Value, (DateTime)cells[3].Value,
                                                             // (bool)cells[4].Value, (EducationalHelper.ClassTypes)cells[6].Value);
            }
            else if ((bool)cells["IsTeacher"].Value)
            {
                human = selectedRow.DataBoundItem as Teacher;// new Teacher((string)cells[1].Value, (string)cells[2].Value, (DateTime)cells[3].Value,
                                                             // (double)cells[4].Value, (bool)cells[5].Value, (EducationalHelper.ClassTypes)cells[8].Value);
            }
            else
            {
                human = selectedRow.DataBoundItem as Employee; // new Employee((string)cells[1].Value, (string)cells[2].Value, (DateTime)cells[3].Value,
                                                               //(double)cells[4].Value, (bool)cells[5].Value);
            }

            //dataGridView.SelectedRows[0].Cells[0]. DataSource = dataGridView.Rows;
        }

        private DataGridView GetDataGrid(Form formOwner)
        {
            DataGridView dataGridView = null;

            foreach (Control control in formOwner.Controls)
            {
                dataGridView = control as DataGridView;
                if (dataGridView != null)
                    return dataGridView;
            }

            return dataGridView;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (!isEdit)
                AddHuman();
            else
                EditHuman();

            //return DialogResult.OK;            
            this.Close();
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
                    (double)salary_numericUpDown.Value, isOnVacation_checkBox.Checked, optionalClasses_textBox.Text));
        }

        private void AddEmployee()
        {
            BaseForm.university.AddEmployee(new Employee(firstName_textBox.Text, lastName_textBox.Text, dateOfBirth_dateTimePicker.Value.Date,
                    (double)salary_numericUpDown.Value, isOnVacation_checkBox.Checked));
        }

        private void EditHuman()
        {
            throw new NotImplementedException();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            optionalClasses_panel.Visible = isTeacher_checkBox.Checked;
        }
    }
}
