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
    public partial class FrmSearcherProyect : Form
    {
        // TODO - Hacer el buscador.
        // TODO - Hacer que el usuario pueda elegir como buscar los proyectos.
        public FrmSearcherProyect()
        {
            InitializeComponent();

            Logic.Proyect logProyect = new Logic.Proyect();

            try {
                dgvProyects.DataSource = logProyect.GetAllProyects();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModifyPro_Click(object sender, EventArgs e)
        {
            // TODO - Cuando eliga el proyecto que se quiere modificar mostrar el otro Frm.
        }
    }
}