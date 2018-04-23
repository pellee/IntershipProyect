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
        List<Entities.Proyect> proyects4ComboBox;
        List<Entities.Proyect> proyects4ListBox = new List<Entities.Proyect>();

        public FrmAddCompany()
        {
            var logProyect = new Logic.Proyect();

            InitializeComponent();

            proyects4ComboBox = logProyect.GetAllProyects();

            WireUp();
        }

        private void WireUp()
        {

            cboxProyects.DataSource = null;

            cboxProyects.DataSource = proyects4ComboBox;
            cboxProyects.DisplayMember = "NamePro";

            lstboxProyects.DataSource = null;

            lstboxProyects.DataSource = proyects4ListBox;
            lstboxProyects.DisplayMember = "NamePro";
        }

        private void btnCreateProyect_Click(object sender, EventArgs e)
        {
            FrmAddProyect frmProyect = new FrmAddProyect();

            frmProyect.Show();
            Close();
        }

        private void FrmAddCompany_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAddProyect_Click(object sender, EventArgs e)
        {
            var p = (Entities.Proyect)cboxProyects.SelectedItem;

            if (p != null) {

                proyects4ComboBox.Remove(p);
                proyects4ListBox.Add(p);

                WireUp();
            }
            else
                MessageBox.Show("TIENE QUE SELECCIONAR UNO DE LOS ITEMS");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var p = (Entities.Proyect)lstboxProyects.SelectedItem;

            if (p != null){

                proyects4ListBox.Remove(p);
                proyects4ComboBox.Add(p);

                WireUp();
            }
            else
                MessageBox.Show("TIENE QUE SELECCIONAR UNO DE LOS ITEMS");
        }
    }
}
