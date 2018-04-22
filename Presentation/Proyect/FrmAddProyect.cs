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

                try {
                    var logProyect = new Logic.Proyect();
                    var entProyect = new Entities.Proyect(txtName.Text, txtGoal.Text, txtKindPro.Text, txtHoursPro.Text, dtpStartDate.Text, dtpEndDate.Text, txtSlot.Text);

                    FocusAndCleanForm();

                    logProyect.CreateProyect(entProyect);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }

            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Close();
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

        private void ChangeValidation(ref bool validation, bool value)
        {
            validation = value;
        }

        private void ChangeEntries(ref string entries, string value)
        {
            entries += (value + "\n");
        }

        private bool ValidateForm()
        {
            bool validation = true;
            string[] badEntries = new string[5] { "Nombre mal ingresado", "objetivo mal ingresado", "tipo pro mal ingresado", "horas pro mal ingresado", "vacante mal ingresado" };
            string entries = "";

            if(txtName.Text.Length == 0) {
                ChangeValidation(ref validation, false);
                ChangeEntries(ref entries, badEntries[0]);
            }

            if(txtGoal.Text.Length == 0) {
                ChangeValidation(ref validation, false);
                ChangeEntries(ref entries, badEntries[1]);
            }

            if(txtKindPro.Text.Length == 0) {
                ChangeValidation(ref validation, false);
                ChangeEntries(ref entries, badEntries[2]);
            }

            if(txtHoursPro.Text.Length == 0) {
                ChangeValidation(ref validation, false);
                ChangeEntries(ref entries, badEntries[3]);
            }

            if (!int.TryParse(txtSlot.Text, out int a)) {
                ChangeValidation(ref validation, false);
                ChangeEntries(ref entries, badEntries[4]);
            }

            if (entries == "")
                MessageBox.Show("DATOS INGRESADOS CON EXITO.");
            else
                MessageBox.Show(entries);

            return validation;
        }

        private void FrmAddProyect_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}