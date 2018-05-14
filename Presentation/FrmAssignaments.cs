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
    public partial class FrmAssignaments : Form
    {
        List<Entities.Student> students;
        public FrmAssignaments()
        {
            InitializeComponent();

            var logStu = new Logic.Student();

            students = logStu.GetAllStudents();
        }

        private void WireUp(List<Entities.Student> students4lstbox)
        {
            lstboxShowStudents.DataSource = null;
            lstboxShowStudents.DataSource = students4lstbox;

            lstboxShowStudents.DisplayMember = "FirstName";
        }

        private void btnCreateAssignaments_Click(object sender, EventArgs e)
        {
            var logAssig = new Logic.Assignament();

            var assignaments = new List<Entities.Assignament>();

            try {
                assignaments = logAssig.AddAssignament();

                logAssig.CreateAssignament(assignaments);

                MessageBox.Show("SE ASIGNARON CORRECTAMENTE LOS PROYECTOS.");
            } catch (Exception ex ) {
                MessageBox.Show("ERROR. " + ex.Message);
            }

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var students4lstbox = new List<Entities.Student>();

            switch (cboxStudents.SelectedIndex)
            {
                case 0:
                    foreach (var s in students) {
                        if (s.Assigned)
                            students4lstbox.Add(s);
                    }

                    WireUp(students4lstbox);
                    break;

                case 1:
                    foreach (var s in students) {
                        if (!s.Assigned)
                            students4lstbox.Add(s);
                    }

                    WireUp(students4lstbox);
                    break;
            }
        }
    }
}
