using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Student
    {
        private void CreatePerson(Entities.Student student)
        {
            var dataStudent = new Data.Student();

            dataStudent.CreatePerson(student.Dni, student.FirstName, student.LastName);
        }

        private void CreatePreferenceStudent(Entities.Student student, int idstudent)
        {
            var dataStudent = new Data.Student();

            foreach (var p in student.Preferences)
                dataStudent.CreatePreferenceStudent(p, idstudent);
        }

        public void CreateStudent(Entities.Student student)
        {
            var dataStudent = new Data.Student();
            int idstudent = 0;

            CreatePerson(student);

            idstudent = dataStudent.CreateStudent(student.Prom, student.Dni);

            CreatePreferenceStudent(student, idstudent);
        }
        private List<Entities.Person> GetAllPersons()
        {
            var dataStudent = new Data.Student();

            return dataStudent.GetAllPersons();
        }

        public bool ValidatePerson(string dni)
        {
            var persons = GetAllPersons();

            foreach (var p in persons) {
                if (p.Dni == dni)
                    return true;
            }

            return false;
        }
    }
}
