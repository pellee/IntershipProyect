using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Student
    {
        /// <summary>
        /// Llama a capa de data para guardar los datos en la DB.
        /// </summary>
        /// <param name="student">Contiene los datos que se quieren guardar.</param>
        private void CreatePerson(Entities.Student student)
        {
            var dataStudent = new Data.Student();

            dataStudent.CreatePerson(student.Dni, student.FirstName, student.LastName);
        }
        /// <summary>
        /// Llama a capa de data para guardar los datos en la DB.
        /// </summary>
        /// <param name="student">Contiene los datos que se quiere guardar.</param>
        /// <param name="idstudent">El identificador del alumno en la DB.</param>
        private void CreatePreferenceStudent(Entities.Student student, int idstudent)
        {
            var dataStudent = new Data.Student();

            foreach (var p in student.Preferences)
                dataStudent.CreatePreferenceStudent(p, idstudent);
        }
        /// <summary>
        /// Llama a capa de data para guardar los datos en la DB.
        /// </summary>
        /// <param name="student">Contiene los datos que se quiere guardar.</param>
        public void CreateStudent(Entities.Student student)
        {
            var dataStudent = new Data.Student();
            int idstudent = 0;

            CreatePerson(student);

            idstudent = dataStudent.CreateStudent(student.Prom, student.Dni);

            CreatePreferenceStudent(student, idstudent);
        }
        /// <summary>
        /// LLama a la capa de data para buscar datos de la DB.
        /// </summary>
        /// <returns>Devuelve una lista de tipo Person.</returns>
        private List<Entities.Person> GetAllPersons()
        {
            var dataStudent = new Data.Student();

            return dataStudent.GetAllPersons();
        }
        /// <summary>
        /// Verifica que el alumno que se quiere crear no exista en la DB.
        /// </summary>
        /// <param name="dni">El identificador para saber si esta o no en la DB.</param>
        /// <returns>Retorna true si lo encontro en la DB y false si no lo encontro.</returns>
        public bool ValidatePerson(string dni)
        {
            var persons = GetAllPersons();

            foreach (var p in persons) {
                if (p.Dni == dni)
                    return true;
            }

            return false;
        }

        public List<Entities.Student> OrderByProm()
        {
            var dataStudent = new Data.Student();
            var students = dataStudent.GetAllStudents();

            return students;
        }
    }
}
