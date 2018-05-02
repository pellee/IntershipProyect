using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FrmAddStudent : Form
    {
        List<string> preferences = new List<string>();

        public FrmAddStudent()
        {
            InitializeComponent();
        }

        private bool ValidateForm()
        {
            bool status = true;
            string msg = "";
            string[] badmsg = new string[] { "No ingreso dni\n", "No ingreso nombre\n", "No ingreso apellido\n", "No ingreso promedio\n", "Dni mal ingresado\n", "Prmedio mal ingresado" };

            if(txtDni.Text.Length == 0) {
                status = false;

                msg += badmsg[0];
            }

            if(txtDni.Text.Length != 8) {
                status = false;

                msg += badmsg[4];
            }

            if(txtName.Text.Length == 0) {
                status = false;

                msg += badmsg[1];
            }

            if(txtLastName.Text.Length == 0) {
                status = false;

                msg += badmsg[2];
            }

            if(txtProm.Text.Length == 0) {
                status = false;

                msg += badmsg[3];
            }

            if(!double.TryParse(txtProm.Text, out double a)) {
                status = false;

                msg += badmsg[5];
            }

            if(msg != "")
                MessageBox.Show(msg);
            else
                MessageBox.Show("DATOS INGRESADO CON EXITO.");

            return status;
        }

        private void CleanAndFocus()
        {
            txtDni.Focus();
            txtDni.ResetText();
            txtLastName.ResetText();
            txtName.ResetText();
            txtProm.ResetText();
        }

        private void btnAddPreference_Click(object sender, EventArgs e)
        {
            preferences.Add(txtPreference.Text);

            lstboxPreferences.Items.Add(txtPreference.Text);

            txtPreference.ResetText();
            txtPreference.Focus();
        }

        private void btnCreateStu_Click(object sender, EventArgs e)
        {
            if (ValidateForm()) {
                var logStudent = new Logic.Student();

                //if (logStudent.ValidatePerson(txtDni.Text)) {
                    var entStudent = new Entities.Student(txtDni.Text, txtName.Text, txtLastName.Text, txtProm.Text, preferences);

                    try {
                        logStudent.CreateStudent(entStudent);
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }

                CleanAndFocus();
               // }
                //else
                    //MessageBox.Show("LA PERSONA YA EXISTE.");
            }
        }
    }
}
