using PeopleAccounting.Staff.Post;
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

        public StaffTableForm(List<Employee> employeeList)
        {
            InitializeComponent();

            CreateEmployeeTable(staffTable, employeeList);
            dataGridView1.DataSource = staffTable;
        }
        public StaffTableForm(List<Student> studentList)
        {
            InitializeComponent();            

            CreateStudentTable(staffTable, studentList);
            dataGridView1.DataSource = staffTable;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            EditForm addForm = new EditForm(sender);
            addForm.ShowDialog(this);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

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
