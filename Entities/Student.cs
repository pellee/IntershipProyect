using System.Collections.Generic;

namespace Entities
{
    /// <summary>
    /// Representa los atributos de un alumno.
    /// </summary>
    public class Student : Person
    {
        public int IdStudent { get; set; }
        /// <summary>
        /// El promedio del alumno.
        /// </summary>
        public double Prom { get; set; }
        /// <summary>
        /// Las preferencias del alumno.
        /// </summary>
        public List<string> Preferences { get; set; } = new List<string>();

        public bool Assigned { get; set; }

        public Student() { }

        public Student(string dni, string fname, string lname, string prom, List<string> preferences): base (dni, fname, lname)
        {
            Prom = double.Parse(prom);
            Preferences = preferences;
            Assigned = false;
        }
    }
}
