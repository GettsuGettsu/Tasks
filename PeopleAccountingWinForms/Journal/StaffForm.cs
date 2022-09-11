using PeopleAccounting.Staff.Post;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleAccountingWinForms
{
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        //private DataColumn[] GetColumns(Type type)
        //{
        //    PropertyInfo[] objectProperties = type.GetProperties();
        //    DataColumn[] columns = new DataColumn[objectProperties.Length];

        //    for (int i = 0; i < objectProperties.Length; i++)
        //    {
        //        columns[i] = new DataColumn(objectProperties[i].Name, objectProperties[i].PropertyType);
        //    }

        //    columns = SortColumns(columns);

        //    return columns;
        //}

        private void AddColumns(DataTable table)
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

        private void AddRows(DataTable table)
        {
            if (table.Columns.Count == 0)
                throw new Exception("DataTable has no columns!");

            foreach (var item in (this.Owner as BaseForm).university.Staff)
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

        private void StaffForm_Load(object sender, EventArgs e)
        {
            DataTable staffTable = new DataTable();

            AddColumns(staffTable);
            AddRows(staffTable);

            #region comment
            //DataColumn[] columns = GetColumns(typeof(Teacher));
            ////columns.ToList().Ins

            //staffTable.Columns.AddRange(columns);

            //foreach (var item in (this.Owner as BaseForm).university1.Staff)
            //{
            //    var row1 = staffTable.NewRow();// Rows.Add(a);
            //    var props = item.GetType().GetProperties(); //row1[a]

            //    if (props.Length < columns.Length)
            //    {
            //        var props2 = new PropertyInfo[columns.Length];

            //        for (int i = 0; i < props.Length; i++)
            //        {
            //            props2[i] = props[i];
            //        }

            //        props = props2;
            //    }

            //    props = SortColumns(props);

            //    for (int i = 0; i < props.Length; i++)
            //    {
            //        row1[i] = props[i].GetValue(item);
            //    }

            //    staffTable.Rows.Add(row1);
            //}
            #endregion

            dataGridView1.DataSource = staffTable;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

        }

        //private T[] SortColumns<T>(T[] columns)
        //{
        //    //var cols = columns.ToList();
        //    T[] columnsSorted = new T[columns.Length];

        //    int j = 0;
        //    for (int i = columns.Length - 5; i < columns.Length; i++)
        //    {
        //        columnsSorted[j++] = columns[i];
        //    }

        //    for (int i = 0; i < columns.Length - 5; i++)
        //    {
        //        columnsSorted[j++] = columns[i];
        //    }

        //    columns = columnsSorted;

        //    return columns;
        //}
    }
}
