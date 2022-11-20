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

        internal EditForm(bool isStudents, bool isEdit, object human = null)
        {
            InitializeComponent();

            this.isStudents = isStudents;
            this.isEdit = isEdit;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            if (isEdit)
                DoEditPrepare();
        }

        private void DoEditPrepare()
        {
            var owner = this.Owner as StaffTableForm;
            DataGridView dataGridView = GetDataGrid(owner);

            if (dataGridView == null)
            {
                MessageBox.Show("Error!");
                Close();
            }

            GetSelectedLine(dataGridView);

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

        private void GetSelectedLine(DataGridView dataGridView)
        {
            var selectedCells = dataGridView.SelectedCells;
            //var dataTable = this.Controls["data_TableLayoutPanel"] as TableLayoutPanel;
            firstName_textBox.Text = (string)selectedCells[0].Value;
            lastName_textBox.Text = (string)selectedCells[1].Value;
            dateOfBirth_dateTimePicker.Value = (DateTime)selectedCells[2].Value;

        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (isStudents)
            {
                BaseForm.university.AddStudent(new Student(firstName_textBox.Text, lastName_textBox.Text, dateOfBirth_dateTimePicker.Value,
                    isOnVacation_checkBox.Checked, optionalClasses_textBox.Text));
            }
            else if (isTeacher_checkBox.Checked)
            {
                BaseForm.university.AddTeacher(new Teacher(firstName_textBox.Text, lastName_textBox.Text, dateOfBirth_dateTimePicker.Value,
                    isOnVacation_checkBox.Checked, (double)salary_numericUpDown.Value, optionalClasses_textBox.Text));
            }
            else
            {
                BaseForm.university.AddEmployee(new Employee(firstName_textBox.Text, lastName_textBox.Text, dateOfBirth_dateTimePicker.Value,
                    isOnVacation_checkBox.Checked, (double)salary_numericUpDown.Value));
            }
            this.Close();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            optionalClasses_panel.Visible = isTeacher_checkBox.Checked;
        }
    }
}
