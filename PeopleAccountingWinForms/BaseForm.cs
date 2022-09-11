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
        internal readonly University university = new University("FirstUniv");
        private bool isStaffOpened = false;
        private bool isStudentOpened = false;

        public BaseForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            university.AddEmployee(new Employee("Andre", "Croldan", new DateTime(1991, 03, 14), false, 400));
            university.AddEmployee(new Employee("Lena", "Hordan", new DateTime(1987, 11, 07), false, 450));
            university.AddTeacher(new Teacher("Alexander", "Sirrius", new DateTime(1985, 05, 13), true, 657, EducationalHelper.ClassTypes.Math | EducationalHelper.ClassTypes.Physics));
        }

        // need to prevent opening multiple windows
        private void StaffButton_Click(object sender, EventArgs e)
        {
            if (!isStaffOpened)
            {
                isStaffOpened = true;
                
                StaffForm staffForm = new StaffForm();
                staffForm.Show(this);

                staffForm.FormClosed += StaffForm_FormClosed;
            }
        }

        private void StaffForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isStaffOpened = false;
        }

        private void StudentsButton_Click(object sender, EventArgs e)
        {
            if (!isStudentOpened)
            {
                isStudentOpened = true;
                
                StudentsForm studentsForm = new StudentsForm();
                studentsForm.Show(this);

                studentsForm.FormClosed += StudentsForm_FormClosed;
            }
        }

        private void StudentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isStudentOpened = false;
        }
    }
}
