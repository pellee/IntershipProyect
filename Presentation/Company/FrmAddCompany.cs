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
    public partial class FrmAddCompany : Form
    {
        public FrmAddCompany()
        {
            InitializeComponent();
        }

        private bool ValidateForm()
        {
            bool status = true;

            string msg = "";
            string[] badmsg = new string[] { "No ingreso cuil\n", "No ingrese nombre\n", "Nom ingreso direccion" };

            if (txtCuilCom.Text.Length == 0) {
                status = false;

                msg += badmsg[0];
            }

            if (txtNameCom.Text.Length == 0) {
                status = false;

                msg += badmsg[1];
            }

            if (txtAdressCom.Text.Length == 0) {
                status = false;

                msg += badmsg[2];
            }

            if(msg != "")
                MessageBox.Show(msg);
            else
                MessageBox.Show("DATOS INGRESADO CON EXITO.");

            return status;
        }

        private void FocusAndClean()
        {
            txtCuilCom.Focus();
            txtCuilCom.ResetText();
            txtNameCom.ResetText();
            txtAdressCom.ResetText();
        }

        private void btnCreateCom_Click(object sender, EventArgs e)
        {
            if (ValidateForm()) {
                var logCompany = new Logic.Company();
                var entCompany = new Entities.Company(txtCuilCom.Text, txtNameCom.Text, txtAdressCom.Text);

                if (logCompany.ValidateCompany(entCompany)) {
                    try {
                        logCompany.CreateCompany(entCompany);
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("EMPRESA CREADA CON EXITO."); 
                }
                else
                    MessageBox.Show("LA EMPRESA YA A SIDO CREADA.");

                FocusAndClean();
            }
        }
    }
}