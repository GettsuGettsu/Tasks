using PeopleAccounting.Staff;
using PeopleAccounting.Staff.Post;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        private readonly int controlHeight = 30;
        private readonly int controlWidth = 244;
        #endregion

        #region Constructor
        internal EditFormDynamic(object selectedObject, bool isEdit = false)
        {
            this.isEdit = isEdit;
            this.selectedObject = selectedObject;
            
            CheckObjectType(selectedObject);
            InitializeForm();

            InitializeComponent();

            this.Width += this.Controls[0].Left;
        }

        private void InitializeForm()
        {
            Font font = new Font("Microsoft Sans Serif", 10f);
            PropertyInfo[] objectProperties = objectType.GetProperties();

            for (int i = 0; i < objectProperties.Length; i++)
            {
                PropertyInfo prop = objectProperties[i];
                if (prop.Name == "Id")
                {
                    continue;
                }

                Label label = new Label();
                label.Left = 12;
                label.Height = this.controlHeight;
                label.Width = this.controlWidth;
                label.Name = prop.Name + "_Label" + (i + 1);
                label.Text = prop.Name;
                label.Font = font;
                label.ForeColor = Color.White;
                label.TextAlign = ContentAlignment.MiddleLeft;

                if (this.Controls.Count == 0)
                {
                    label.Top = 14;
                }
                else
                {
                    Control prevLabel = this.Controls[this.Controls.Count - 1];
                    if (prevLabel.GetType() != typeof(Label))
                    {
                        prevLabel = this.Controls[this.Controls.Count - 2];
                    }                    

                    label.Top = prevLabel.Bottom + 7;
                }

                this.Controls.Add(label);

                Control valueControl = null;
                if (prop.PropertyType == typeof(decimal))
                {
                    valueControl = new NumericUpDown();
                }
                if (prop.PropertyType == typeof(bool))
                {
                    valueControl = new CheckBox();
                }
                if (prop.PropertyType == typeof(DateTime))
                {
                    valueControl = new DateTimePicker();                    
                    (valueControl as DateTimePicker).Format = DateTimePickerFormat.Short;
                }
                if (valueControl == null)
                {
                    valueControl = new TextBox();
                    (valueControl as TextBox).TextAlign = HorizontalAlignment.Left;
                }

                valueControl.Name = prop.Name + $"_{valueControl.GetType().Name}" + (i + 1);
                valueControl.Height = this.controlHeight;
                valueControl.Width = this.controlWidth;
                valueControl.Font = font;
                valueControl.Left = label.Width + label.Left * 2;
                valueControl.Top = label.Top;

                this.Controls.Add(valueControl);
            }
        }

        private void CheckObjectType(object selectedObject)
        {
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
