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
    public partial class StudentsForm : Form
    {        
        public StudentsForm()
        {
            InitializeComponent();
        }

        private void AddColumns(DataTable table)
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

        private void AddRows(DataTable table)
        {
            if (table.Columns.Count == 0)
                throw new Exception("DataTable has no columns!");

            foreach (var item in (this.Owner as BaseForm).university.Students)
            {
                table.Rows.Add(item.FirstName, item.LastName,
                    item.DateOfBirth, item.IsOnVacation,
                    item.IsFormalForm, item.OptionalClasses);
            }
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            DataTable staffTable = new DataTable();
            
            AddColumns(staffTable);
            AddRows(staffTable);

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
    }
}
