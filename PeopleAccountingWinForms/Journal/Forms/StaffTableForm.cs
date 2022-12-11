using PeopleAccounting.Staff;
using PeopleAccounting.Staff.Post;
using PeopleAccountingWinForms.Journal.Helpers;
using PeopleAccountingWinForms.Journal.Forms;
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
            //EditForm addForm = new EditForm(isStudents, false);
            EditFormDynamic addForm = new EditFormDynamic(dataGridView1.SelectedRows[0].DataBoundItem);
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

            //EditForm addForm = new EditForm(isStudents, true, dataGridView1.SelectedRows[0]);
            EditFormDynamic addForm = new EditFormDynamic(dataGridView1.SelectedRows[0].DataBoundItem, true);
            var result = addForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                CreateDataGridView();
            }
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
            ResetDataGridView(dataGridView1);            

            //staffTable.Clear(); // temporary deprecated
            //CreateTable(staffTable);

            if (isStudents)
            {
                dataGridView1.DataSource = BaseForm.university.Students;
            }
            else
            {                
                dataGridView1.DataSource = BaseForm.university.Staff; // staffTable;
                //DataGridViewColumn optionalClassesColumn = new DataGridViewTextBoxColumn();
                //optionalClassesColumn.DataPropertyName = "OptionalClasses";
                //optionalClassesColumn.Name = "OptionalClasses";

                var col = dataGridView1.Columns["OptionalClasses"];
                if (col == null)
                {
                    col = new DataGridViewTextBoxColumn();
                    col.Name = "OptionalClasses";
                    col.DataPropertyName = col.Name;                    
                    dataGridView1.Columns.Add(col);
                }
            }

            SortDataGridView(dataGridView1);
            dataGridView1.Columns["Id"].Visible = false;            
        }

        private void ResetDataGridView(DataGridView dataGridView1)
        {
            dataGridView1.DataSource = null; // handling the "index N does not have a value" exception
            //dataGridView1.Columns.Clear();
        }

        private void SortDataGridView(DataGridView dataGridView1)
        {
            int indexDifference = 0;
            for (int i = 0; i < columnsOrder.Length; i++)
            {
                if (dataGridView1.Columns[columnsOrder[i]] != null)
                    dataGridView1.Columns[columnsOrder[i]].DisplayIndex = i - indexDifference;
                else indexDifference++;
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
