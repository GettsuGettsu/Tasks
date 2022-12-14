using PeopleAccounting.Staff;
using PeopleAccounting.Staff.Post;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleAccountingWinForms.Journal.Forms
{
    public partial class EditFormDynamic : Form
    {
        #region Fields
        private bool isEdit;
        private object selectedObject = null;
        private Type objectType = null;
        #endregion

        #region Constructor
        internal EditFormDynamic(object selectedObject, bool isStudent = false)
        {
            this.isEdit = !(selectedObject == null);
            this.selectedObject = selectedObject;
            
            CheckObjectType(selectedObject, isStudent);
            InitializeForm(this.objectType);

            InitializeComponent();

            CalculateFormSize();
        }

        private void CalculateFormSize()
        {
            var controls = this.Controls;

            int calcWidth = controls[0].Width * 2 + 12 * 4; // that's magic for me
            int calcHeight = controls[controls.Count - 1].Top + controls[controls.Count - 1].Height + 14 * (controls.Count / 2 - 3);
            
            this.Size = new Size(calcWidth, calcHeight);
        }

        private void InitializeForm(Type objectType)
        {
            Font font = new Font("Microsoft Sans Serif", 10f);
            PropertyInfo[] objectProperties = objectType.GetProperties();
            Point pos = new Point(12, 14);
            Size size = new Size(244, 30);
            Point lastPos = new Point();

            for (int i = 0; i < objectProperties.Length; i++)
            {
                PropertyInfo prop = objectProperties[i];
                if (prop.Name == "Id")
                {
                    continue;
                }

                Label label = new Label();
                label.Left = pos.X;
                label.Height = size.Height;
                label.Width = size.Width;
                label.Name = prop.Name + "_Label" + (i + 1);
                label.Text = prop.Name;
                label.Font = font;
                label.ForeColor = Color.White;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Top = pos.Y;

                this.Controls.Add(label);

                Control valueControl = GetControlByPropertyType(prop.PropertyType);

                valueControl.Name = prop.Name + $"_{valueControl.GetType().Name}" + (i + 1);
                valueControl.Height = size.Height;
                valueControl.Width = size.Width;
                valueControl.Font = font;
                valueControl.Left = label.Width + label.Left;
                valueControl.Top = label.Top;

                this.Controls.Add(valueControl);

                pos.Y = label.Top + label.Height + 14;
                lastPos.X = valueControl.Left;
                lastPos.Y = valueControl.Top;
            }            

            // refactor button position
            Button okButton = CreateButton("OK", lastPos.X, lastPos.Y + size.Height + 25, size.Width / 2 - pos.X / 2, 40, true, false); 
            Button cancelButton = CreateButton("Cancel", okButton.Right + pos.X, okButton.Top, okButton.Width, okButton.Height, false, true);

            this.Controls.Add(okButton);
            this.Controls.Add(cancelButton);

            this.AcceptButton = okButton;
            this.CancelButton = cancelButton;
        }

        private Button CreateButton(string text, int left, int top, int width, int height, bool isOkButton, bool isCancelButton)
        {
            Button button = new Button();

            button.Name = text.ToLower() + "_Button";
            button.Text = text;
            button.Top = top;
            button.Left = left;
            button.Width = width;
            button.Height = height;
            button.FlatStyle = FlatStyle.Flat;
            button.ForeColor = SystemColors.ButtonFace;
            
            if (isOkButton)
            {
                button.BackColor = SystemColors.Highlight;
                button.DialogResult = DialogResult.OK;
                isCancelButton = false;
            }
            if (isCancelButton)
            {
                button.DialogResult = DialogResult.Cancel;
            }

            return button;
        }

        private Control GetControlByPropertyType(Type propertyType)
        {
            Control control;

            if (propertyType == typeof(decimal))
            {
                return new NumericUpDown();
            }

            if (propertyType == typeof(bool))
            {
                control = new CheckBox();
                (control as CheckBox).CheckedChanged += EditFormDynamic_CheckedChanged;
                return control;
            }

            if (propertyType == typeof(DateTime))
            {
                control = new DateTimePicker();
                (control as DateTimePicker).Format = DateTimePickerFormat.Short;
                return control;
            }

            control = new TextBox();
            (control as TextBox).TextAlign = HorizontalAlignment.Left;
            return control;
        }

        private void EditFormDynamic_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                this.Controls.Clear();
                InitializeForm(typeof(Teacher));
                CalculateFormSize();
            }
            this.Refresh();
        }

        private void CheckObjectType(object selectedObject, bool isStudent)
        {
            if (selectedObject == null)
            {
                objectType = isStudent ? typeof(Student) : typeof(Employee);
                return;
            }

            if (selectedObject.GetType() == typeof(Student))
            {
                objectType = typeof(Student);
                return;
            }

            if (selectedObject.GetType() == typeof(Teacher))
            {
                objectType = typeof(Teacher);
                return;
            }

            if (selectedObject.GetType() == typeof(Employee))
            {
                objectType = typeof(Employee);
                return;
            }

            MessageBox.Show($"The type {objectType} is not exist in the current system.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }
        #endregion

        #region Events
        private void EditForm_Load(object sender, EventArgs e)
        {
        }
        #endregion

        #region Methods
        #endregion
    }
}
