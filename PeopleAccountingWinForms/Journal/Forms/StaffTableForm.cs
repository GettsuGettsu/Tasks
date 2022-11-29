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
        #region Fields
        private DataTable staffTable = new DataTable();
        private bool isStudents = false;
        #endregion

        #region Constructors
        public StaffTableForm(bool isStudents)
        {
            InitializeComponent();

            dataGridView1.RowHeadersWidth = dataGridView1.ColumnHeadersHeight;

            this.isStudents = isStudents;
            CreateDataGridView();
        }
        #endregion

        #region Form events
        private void AddButton_Click(object sender, EventArgs e)
        {
            EditForm addForm = new EditForm(isStudents, false);
            var result = addForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                CreateDataGridView();
            }
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
                human = new Student((string)cells[1].Value, (string)cells[2].Value, (DateTime)cells[3].Value,
                    (bool)cells[4].Value, (EducationalHelper.ClassTypes)cells[6].Value);
            }
            else if ((bool)cells["Is teacher"].Value)
            {
                human = new Teacher((string)cells[1].Value, (string)cells[2].Value, (DateTime)cells[3].Value,
                    (double)cells[4].Value, (bool)cells[5].Value, (EducationalHelper.ClassTypes)cells[8].Value);
            }
            else
            {
                human = new Employee((string)cells[1].Value, (string)cells[2].Value, (DateTime)cells[3].Value,
                    (double)cells[4].Value, (bool)cells[5].Value);
            }

            EditForm addForm = new EditForm(isStudents, true, human);
            addForm.ShowDialog(this);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows;
            foreach (DataGridViewRow row in selectedRows)
            {
                if (isStudents)
                {
                    var student = BaseForm.university.Students.FirstOrDefault(member => (Guid)row.Cells[0].Value == member.Id);
                    BaseForm.university.Students.Remove(student);
                }
                else
                {
                    var staff = BaseForm.university.Staff.FirstOrDefault(member => (Guid)row.Cells[0].Value == member.Id);
                    BaseForm.university.Staff.Remove(staff);
                }
            }

            CreateDataGridView();           
        }
        #endregion

        #region Methods
        private void CreateDataGridView()
        {
            staffTable.Clear();
            CreateTable(staffTable);

            dataGridView1.DataSource = staffTable;
            dataGridView1.Columns[0].Visible = false;
        }

        private void CreateTable(DataTable table)
        {
            AddColumns(table);
            AddRows(table);
        }

        private void AddColumns(DataTable table)
        {
            if (table.Columns.Count > 0)
                return;

            List<DataColumn> columns = new List<DataColumn>() {
                new DataColumn("ID", typeof(Guid)),
                new DataColumn("First name", typeof(string)),
                new DataColumn("Last name", typeof(string)),
                new DataColumn("Date of birth", typeof(DateTime)),
                new DataColumn("Is on vacation", typeof(bool)),
                new DataColumn("Is formal form", typeof(bool)),
                new DataColumn("Optional classes", typeof(EducationalHelper.ClassTypes)),
            };

            if (!isStudents)
            {
                columns.Insert(4, new DataColumn("Salary", typeof(double)));
                columns.Insert(columns.Count - 2, new DataColumn("Is teacher", typeof(bool)));
            }

            table.Columns.AddRange(columns.ToArray());
        }

        private void AddRows(DataTable table)
        {
            if (table.Columns.Count == 0)
                throw new Exception("DataTable has no columns!");

            if (isStudents)
            {
                foreach (var item in BaseForm.university.Students) // staffList as List<Student>)
                {
                    table.Rows.Add(item.Id, item.FirstName, item.LastName,
                        item.DateOfBirth, item.IsOnVacation,
                        item.IsFormalForm, item.OptionalClasses);
                }
            }
            else
            {
                foreach (var item in BaseForm.university.Staff) // staffList as List<Employee>)
                {
                    EducationalHelper.ClassTypes? optionalClasses = null;

                    try
                    {
                        optionalClasses = (item as Teacher).OptionalClasses;
                    }
                    catch { }

                    table.Rows.Add(item.Id, item.FirstName, item.LastName,
                        item.DateOfBirth, item.Salary,
                        item.IsOnVacation, item.IsFormalForm,
                        item.IsTeacher, optionalClasses);
                }
            }
        }
        #endregion
    }
}
