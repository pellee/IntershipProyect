using System.Collections.Generic;

namespace Entities
{
    /// <summary>
    /// Representa los atributos de un alumno.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// El nombre del alumno.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// El apellido del alumno.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// El promedio del alumno.
        /// </summary>
        public double Prom { get; set; }
        /// <summary>
        /// Las preferencias del alumno.
        /// </summary>
        public List<string> Preferences { get; set; } = new List<string>();
    }
}
