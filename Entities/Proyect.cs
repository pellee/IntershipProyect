using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// Representa los atributos de un proyecto.
    /// </summary>
    public class Proyect
    {
        public int Id { get; set; }
        /// <summary>
        /// Representa el nombre del proyecto.
        /// </summary>
        public string NamePro { get; set; }
        /// <summary>
        /// Representa el objetivo del proyecto.
        /// </summary>
        public string GoalPro { get; set; }
        /// <summary>
        /// Representa el tipo del proyecto.
        /// </summary>
        public string KindPro { get; set; }
        /// <summary>
        /// Representa las horas del proyecto.
        /// </summary>
        public string HoursPro { get; set; }
        /// <summary>
        /// Representa la fecha de inicio del proyecto.
        /// </summary>
        public DateTime StartDatePro { get; set; }
        /// <summary>
        /// Representa la fecha de finalizacion del proyecto.
        /// </summary>
        public DateTime EndDatePro { get; set; }
        /// <summary>
        /// Representa la cantidad de vacantes disponibles del proyecto.
        /// </summary>
        public int Slots { get; set; }

        public Proyect() { }

        public Proyect(string namePro, string goalPro, string kindPro, string hoursPro, string startDatePro, string endDatePro, string slots)
        {
            NamePro = namePro;
            GoalPro = goalPro;
            KindPro = kindPro;
            HoursPro = hoursPro;
            StartDatePro = DateTime.Parse(startDatePro);
            EndDatePro = DateTime.Parse(endDatePro);
            Slots = int.Parse(slots);
        }


    }
}
