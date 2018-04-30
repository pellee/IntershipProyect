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
        List<Entities.Company> companies;
        Entities.Company selectedCom;

        public FrmAddProyect()
        {
            InitializeComponent();

            var logCompany = new Logic.Company();

            companies = logCompany.GetAllCompanies();

            WireUp();
        }

        private void WireUp()
        {
            cboxCompanies.DataSource = null;

            cboxCompanies.DataSource = companies;
            cboxCompanies.DisplayMember = "NameCom";
        }
        
        private void FocusAndClean()
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

        private void btnCreateProyect_Click(object sender, EventArgs e)
        {
            if (ValidateForm()) {
                var logProyect = new Logic.Proyect();
                var entProyect = new Entities.Proyect(txtName.Text, txtGoal.Text, txtKindPro.Text, txtHoursPro.Text, dtpStartDate.Text, dtpEndDate.Text, txtSlot.Text);
                
                logProyect.CreateProyect(entProyect, selectedCom.CuilCom);

                companies.Add(selectedCom);

                WireUp();
            }

            FocusAndClean();
        }

        private void btnSelecCom_Click(object sender, EventArgs e)
        {

            if (selectedCom == null) {
                if (cboxCompanies.SelectedValue != null) {
                    selectedCom = (Entities.Company)cboxCompanies.SelectedValue;

                    companies.Remove(selectedCom);

                    WireUp(); 
                }
            }
            else {
                companies.Add(selectedCom);

                selectedCom = (Entities.Company)cboxCompanies.SelectedValue;

                companies.Remove(selectedCom);

                WireUp();

            }

            MessageBox.Show("EMPRESA SELECCIONADA: " + selectedCom.NameCom);
        }
    }
}