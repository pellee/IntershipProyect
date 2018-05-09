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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddCompany();

            frm.Show();
        }

        private void btnProyect_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddProyect();

            frm.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddStudent();

            frm.Show();
        }
    }
}
