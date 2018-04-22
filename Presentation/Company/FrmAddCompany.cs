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
    }
}
