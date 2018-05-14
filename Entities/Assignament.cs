using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// Representa los atributos de las asignaciones.
    /// </summary>
    public class Assignament
    {
        /// <summary>
        /// Representa el nombre de la empresa.
        /// </summary>
        public Company Company { get; set; }
        /// <summary>
        /// Representa al estudiante.
        /// </summary>
        public Student Student { get; set; }
        /// <summary>
        /// Representa al proyecto.
        /// </summary>
        public Proyect Proyect { get; set; }

        public Assignament() { }

        public Assignament(Entities.Company company, Entities.Student student, Entities.Proyect proyect)
        {
            Company = company;
            Student = student;
            Proyect = proyect;
        }
    }
}
