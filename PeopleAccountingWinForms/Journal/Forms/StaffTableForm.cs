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
        private DataTable staffTable = new DataTable(); // temporary deprecated
        private bool isStudents = false;
        private readonly string[] columnsOrder = new string[]
            {
                "Id", "FirstName", "LastName", "DateOfBirth",
                "Salary", "IsOnVacation", "IsFormalForm", "IsTeacher",
                "OptionalClasses"
            };
        #endregion

        #region Constructors
        public StaffTableForm(bool isStudents)
        {
            InitializeComponent();
            this.isStudents = isStudents;
        }
        #endregion

        #region Events
        private void StaffTableForm_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersWidth = dataGridView1.ColumnHeadersHeight;
            CreateDataGridView();
        }

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
            if (dataGridView1.SelectedRows.Count == 0)            
            {
                FormsHelper.ShowError("No selected rows!");
                return;
            }

            EditForm addForm = new EditForm(isStudents, true, dataGridView1.SelectedRows[0]);
            addForm.ShowDialog(this);
            
            CreateDataGridView();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows;
            foreach (DataGridViewRow row in selectedRows)
            {
                if (isStudents)
                {
                    var student = row.DataBoundItem as Student;// BaseForm.university.Students.FirstOrDefault(member => (Guid)row.Cells[0].Value == member.Id);
                    BaseForm.university.Students.Remove(student);
                }
                else
                {
                    var staff = row.DataBoundItem as Employee;// BaseForm.university.Staff.FirstOrDefault(member => (Guid)row.Cells[0].Value == member.Id);
                    BaseForm.university.Staff.Remove(staff);
                }
            }
            
            CreateDataGridView();
        }
        #endregion

        #region Methods
        private void CreateDataGridView()
        {
            dataGridView1.DataSource = null; // handling the "index N does not have a value" exception

            //staffTable.Clear(); // temporary deprecated
            //CreateTable(staffTable);

            if (isStudents)
                dataGridView1.DataSource = BaseForm.university.Students;
            else
                dataGridView1.DataSource = BaseForm.university.Staff; // staffTable;

            SortDataGridView(dataGridView1);
            dataGridView1.Columns[0].Visible = false;
        }

        private void SortDataGridView(DataGridView dataGridView1)
        {
            DataGridViewColumn column = new DataGridViewColumn();
            int i = 0;
            while (i < columnsOrder.Length)
            {
                try
                {
                    column = dataGridView1.Columns[columnsOrder[i]];
                    dataGridView1.Columns.Remove(column);
                    dataGridView1.Columns.Add(column);
                    dataGridView1.Columns[columnsOrder[i]].DisplayIndex = i;
                    i++;
                }
                catch
                {
                    i++;
                    continue;
                }
            }
        }

        #region Temporary deprecated
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

        #endregion
    }
}
