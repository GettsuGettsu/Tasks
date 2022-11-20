using PeopleAccounting.Staff;
using PeopleAccounting.Staff.Post;
using PeopleAccountingWinForms.Journal.Helpers;
using PeopleAccountingWinForms.Journal.StudentsButtonForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleAccountingWinForms
{
    public partial class StaffTableForm : Form
    {
        private DataTable staffTable = new DataTable();
        private bool isStudents = false;

        public StaffTableForm(List<Employee> employeeList)
        {
            InitializeComponent();

            CreateEmployeeTable(staffTable, employeeList);
            dataGridView1.DataSource = staffTable;
        }
        public StaffTableForm(List<Student> studentList)
        {
            InitializeComponent();

            this.isStudents = true;
            CreateStudentTable(staffTable, studentList);
            dataGridView1.DataSource = staffTable;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            EditForm addForm = new EditForm(isStudents, false);
            addForm.ShowDialog(this);

            staffTable.Clear();
            if (isStudents)
                CreateStudentTable(staffTable, BaseForm.university.Students);
            else
                CreateEmployeeTable(staffTable, BaseForm.university.Staff);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            object human;

            DataGridViewRow selectedRow;
            if (dataGridView1.SelectedRows.Count != 0)
                selectedRow = dataGridView1.SelectedRows[0];
            else
            {
                FormsHelper.ShowError("No selected rows!");
                return;
            }

            var cells = selectedRow.Cells;
            if (isStudents)
            {
                human = new Student((string)cells[0].Value, (string)cells[1].Value, (DateTime)cells[2].Value,
                    (bool)cells[3].Value, (EducationalHelper.ClassTypes)cells[5].Value);
            }
            else if ((bool)cells["Is teacher"].Value)
            {
                human = new Teacher((string)cells[0].Value, (string)cells[1].Value, (DateTime)cells[2].Value,
                    (bool)cells[4].Value, (double)cells[3].Value, (EducationalHelper.ClassTypes)cells[7].Value);
            }
            else
            {
                human = new Employee((string)cells[0].Value, (string)cells[1].Value, (DateTime)cells[2].Value,
                    (bool)cells[4].Value, (double)cells[3].Value);
            }

            EditForm addForm = new EditForm(isStudents, true, human);
            addForm.ShowDialog(this);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

        }

        #region Methods
        internal void CreateEmployeeTable(DataTable table, List<Employee> employeeList)
        {
            AddEmployeeColumns(table);
            AddEmployeeRows(table, employeeList);
        }

        internal void CreateStudentTable(DataTable table, List<Student> studentList)
        {
            AddStudentColumns(table);
            AddStudentRows(table, studentList);
        }

        private void AddEmployeeColumns(DataTable table)
        {
            if (table.Columns.Count > 0)
                return;

            //Teacher teacherColumns = new Teacher();

            DataColumn[] columns = {
                new DataColumn("First name", typeof(string)),
                new DataColumn("Last name", typeof(string)),
                new DataColumn("Date of birth", typeof(DateTime)),
                new DataColumn("Salary", typeof(double)),
                new DataColumn("Is on vacation", typeof(bool)),
                new DataColumn("Is formal form", typeof(bool)),
                new DataColumn("Is teacher", typeof(bool)),
                new DataColumn("Optional classes", typeof(EducationalHelper.ClassTypes)),
            };

            table.Columns.AddRange(columns);
        }

        private void AddEmployeeRows(DataTable table, List<Employee> employeeList)
        {
            if (table.Columns.Count == 0)
                throw new Exception("DataTable has no columns!");

            foreach (var item in employeeList) // (this.Owner as BaseForm).university.Staff)
            {
                EducationalHelper.ClassTypes? optionalClasses = null;

                try
                {
                    optionalClasses = (item as Teacher).OptionalClasses;
                }
                catch { }

                table.Rows.Add(item.FirstName, item.LastName,
                    item.DateOfBirth, item.Salary,
                    item.IsOnVacation, item.IsFormalForm,
                    item.IsTeacher, optionalClasses);
            }
        }

        private void AddStudentColumns(DataTable table)
        {
            if (table.Columns.Count > 0)
                return;

            //Teacher teacherColumns = new Teacher();

            DataColumn[] columns = {
                new DataColumn("First name", typeof(string)),
                new DataColumn("Last name", typeof(string)),
                new DataColumn("Date of birth", typeof(DateTime)),
                new DataColumn("Is on vacation", typeof(bool)),
                new DataColumn("Is formal form", typeof(bool)),
                new DataColumn("Optional classes", typeof(EducationalHelper.ClassTypes)),
            };

            table.Columns.AddRange(columns);
        }

        private void AddStudentRows(DataTable table, List<Student> studentList)
        {
            if (table.Columns.Count == 0)
                throw new Exception("DataTable has no columns!");

            foreach (var item in studentList) // (this.Owner as BaseForm).university.Students)
            {
                table.Rows.Add(item.FirstName, item.LastName,
                    item.DateOfBirth, item.IsOnVacation,
                    item.IsFormalForm, item.OptionalClasses);
            }
        }
        #endregion
    }
}
