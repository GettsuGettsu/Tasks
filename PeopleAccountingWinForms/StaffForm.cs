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

        private DataColumn[] GetColumns(Type type)
        {
            PropertyInfo[] objectProperties = type.GetProperties();
            DataColumn[] columns = new DataColumn[objectProperties.Length];

            for (int i = 0; i < objectProperties.Length; i++)
            {
                columns[i] = new DataColumn(objectProperties[i].Name, objectProperties[i].PropertyType);
            }

            columns = SortColumns(columns);

            return columns;
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            DataTable staffTable = new DataTable();
            DataColumn[] columns = GetColumns(typeof(Teacher));
            //columns.ToList().Ins

            staffTable.Columns.AddRange(columns);

            foreach (var item in (this.Owner as BaseForm).university1.Staff)
            {
                var row1 = staffTable.NewRow();// Rows.Add(a);
                var props = item.GetType().GetProperties(); //row1[a]
                
                if (props.Length < columns.Length)
                {
                    var props2 = new PropertyInfo[columns.Length];
                    
                    for (int i = 0; i < props.Length; i++)
                    {
                        props2[i] = props[i];
                    }

                    props = props2;
                }

                props = SortColumns(props);

                for (int i = 0; i < props.Length; i++)
                {
                    row1[i] = props[i].GetValue(item);
                }

                staffTable.Rows.Add(row1);
            }

            DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
            DataGridViewColumn column1 = new DataGridViewColumn();
            dataGridView1.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell()));
            dataGridView1.DataSource = staffTable;
        }

        private T[] SortColumns<T>(T[] columns)
        {
            //var cols = columns.ToList();
            T[] columnsSorted = new T[columns.Length];

            int j = 0;
            for (int i = columns.Length - 5; i < columns.Length; i++)
            {
                columnsSorted[j++] = columns[i];
            }

            for (int i = 0; i < columns.Length - 5; i++)
            {
                columnsSorted[j++] = columns[i];
            }

            columns = columnsSorted;

            return columns;
        }
    }
}
