using PeopleAccounting.Staff;
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
        private object sender;

        internal EditForm(object sender)
        {
            this.sender = sender;
            InitializeComponent();            
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            if ((this.sender as Button).Text == "Edit")
            {
                isEdit = true;
                DoEditPrepare();
            }
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

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            optionalClasses_label.Visible = isTeacher_checkBox.Checked;
            optionalClasses_textBox.Visible = isTeacher_checkBox.Checked;
        }        
    }
}
