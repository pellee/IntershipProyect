using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Assignament
    {
        public List<Entities.Assignament> AddAssignament()
        {
            var logStu = new Logic.Student();
            var logCom = new Logic.Company();

            var assignaments = new List<Entities.Assignament>();
            var students = logStu.GetAllStudents();
            var companies = logCom.GetAllCompanies();

            // TODO - arreglar cuando traigo las preferencias del 

            foreach (var s in students) {
                foreach (var pr in s.Preferences) {
                    foreach (var c in companies) {
                        foreach (var pro in c.Proyects) {
                            if(!s.Assigned && pr == pro.KindPro && pro.Slots != 0) {
                                s.Assigned = true;

                                pro.Slots--;

                                assignaments.Add(new Entities.Assignament { Company = c, Proyect = pro, Student = s });
                            }
                        }
                    }
                }
            }

            return assignaments;
        }

        public void CreateAssignament(List<Entities.Assignament> assignaments)
        {
            var dataAssig = new Data.Assignament();
            var logStu = new Student();
            var logPro = new Proyect();

            foreach (var a in assignaments) {
                dataAssig.CreateAssignament(a);

                logStu.UpdateStudent(a.Student);
                logPro.UpdateProyect(a.Proyect);
            }
        }


    }
}