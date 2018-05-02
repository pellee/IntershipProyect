using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// Hace referencia a los atributos de una persona.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Es el dni de la persona.
        /// </summary>
        public string Dni { get; set; }
        /// <summary>
        /// El nombre del la persona.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// El apellido del la persona.
        /// </summary>
        public string LastName { get; set; }

        public Person(string dni, string fname, string lname)
        {
            Dni = dni;
            FirstName = fname;
            LastName = lname;
        }
    }
}
