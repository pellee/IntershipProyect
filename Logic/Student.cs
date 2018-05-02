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

        /*public List<Entities.Person> GetAllStudents()
        {
            var dataStudent = new Data.Student();

            return dataStudent.GetAllStudent();
        }

        public bool ValidatePerson(string dni)
        {
            var persons = GetAllStudents();

            foreach (var p in persons) {
                if (p.Dni == dni)
                    return true;
            }

            return false;
        }*/
    }
}
