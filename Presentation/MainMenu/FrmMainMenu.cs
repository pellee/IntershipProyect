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
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void btnProyect_Click(object sender, EventArgs e)
        {
            FrmSelectionProyect formProyect = new FrmSelectionProyect();

            formProyect.Show();
            Hide();
        }

        private void FrmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            FrmAddCompany frmCompany = new FrmAddCompany();

            frmCompany.Show();
            Hide();
        }
    }
}
