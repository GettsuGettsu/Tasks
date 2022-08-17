using PeopleAccounting;
using PeopleAccounting.Staff;
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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            University university1 = new University("FirstUniv");

            university1.AddEmployee(new Employee("Andre", "Croldan", new DateTime(1991, 03, 14), false, 400));
            university1.AddEmployee(new Employee("Lena", "Hordan", new DateTime(1987, 11, 07), false, 450));
            // 0 fName,
            // 1 lName,
            // 2 doBirth,
            // 3 salary,
            // 4 isOnVacation,
            // 5 isFForm
            // 6 isTeacher,
            // 7 oClasses

            // 0 oClasses,
            // 1 salary,
            // 2 isTeacher,
            // 3 isFormalForm,
            // 4 fName,
            // 5 lName,
            // 6 doBirth,
            // 7 isOnVac

            DataTable staffTable = new DataTable();
            DataColumn[] columns = GetColumns(typeof(Teacher));
            //columns.ToList().Ins

            //staffTable.Columns.AddRange();            

           /* foreach (var item in university1.Staff)
            {
                var row1 = staffTable.NewRow();// Rows.Add(a);
                var props = item.GetType().GetProperties(); //row1[a]

                for (int i = 0; i < props.Length; i++)
                {
                    row1[i] = props[i].GetValue(item);
                }

                staffTable.Rows.Add(row1);
            }*/

            //DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
            //DataGridViewColumn column1 = new DataGridViewColumn();
            //dataGridView1.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()));
            //dataGridView1.DataSource = staffTable;
        }

        private DataColumn[] GetColumns(Type type)
        {
            PropertyInfo[] objectProperties = type.GetProperties();
            DataColumn[] columns = new DataColumn[objectProperties.Length];
            
            for (int i = 0; i < objectProperties.Length; i++)
            {
                columns[i] = new DataColumn(objectProperties[i].Name, objectProperties[i].PropertyType);
            }

            return columns;
        }
    }
}
