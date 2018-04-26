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
    public partial class FrmAddProyect : Form
    {
        public FrmAddProyect()
        {
            InitializeComponent();
        }

        private void btnCreateProyect_Click(object sender, EventArgs e)
        {
            if (ValidateForm()) {
                var logProyect = new Logic.Proyect();
                var frm = new FrmAddCompany();

                var entProyect = new Entities.Proyect(txtName.Text, txtGoal.Text, txtKindPro.Text, txtHoursPro.Text, dtpStartDate.Text, dtpEndDate.Text, txtSlot.Text);

                logProyect.CreateProyect(entProyect);

                frm.Show();
                Close();
            }
            else
                FocusAndCleanForm();
        }
        
        private void FocusAndCleanForm()
        {
            txtName.Focus();

            txtName.ResetText();
            txtGoal.ResetText();
            txtHoursPro.ResetText();
            txtKindPro.ResetText();
            txtSlot.ResetText();
        }

        private bool ValidateForm()
        {
            bool status = true;
            string[] badmsg = new string[5] { "Nombre mal ingresado", "objetivo mal ingresado", "tipo pro mal ingresado", "horas pro mal ingresado", "vacante mal ingresado" };
            string msg = "";

            if(txtName.Text.Length == 0) {
                status = false;
                msg += badmsg[0];
            }

            if(txtGoal.Text.Length == 0) {
                status = false;
                msg += badmsg[1];
            }

            if(txtKindPro.Text.Length == 0) {
                status = false;
                msg += badmsg[2];
            }

            if(txtHoursPro.Text.Length == 0) {
                status = false;
                msg += badmsg[3];
            }

            if (!int.TryParse(txtSlot.Text, out int a)) {
                status = false;
                msg += badmsg[4];
            }

            if (msg != "")
                MessageBox.Show(msg);
            else
                MessageBox.Show("DATOS INGRESADOS CON EXITO.");

            return status;
        }
    }
}