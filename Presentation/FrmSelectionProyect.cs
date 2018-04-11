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
    public partial class FrmSelectionProyect : Form
    {
        public FrmSelectionProyect()
        {
            InitializeComponent();
        }

        private void btnAddProyect_Click(object sender, EventArgs e)
        {
            FrmAddProyect frmAddProyect = new FrmAddProyect();

            frmAddProyect.Show();
            Close();
        }

        private void btnSearchProyect_Click(object sender, EventArgs e)
        {
            FrmSearcherProyect frmSearcherProyect = new FrmSearcherProyect();

            frmSearcherProyect.Show();
            Close();
        }
    }
}
