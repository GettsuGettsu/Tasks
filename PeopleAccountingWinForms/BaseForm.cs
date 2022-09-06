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
        internal readonly University university1 = new University("FirstUniv");

        public BaseForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            // 3 fName,
            // 4 lName,
            // 5 doBirth,
            // 6 isOnVac            
            // 7 isFormalForm,
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            StaffForm staffForm = new StaffForm();
            staffForm.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm();
            studentsForm.Show(this);
        }
    }
}
