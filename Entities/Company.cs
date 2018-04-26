using System.Collections.Generic;

namespace Entities
{
    /// <summary>
    /// Representa los atributos de una empresa.
    /// </summary>
    public class Company
    {
        /// <summary>
        /// Representa el nombre de la compania.
        /// </summary>
        public string NameCom { get; set; }
        /// <summary>
        /// Repreenta la direccion de la empresa.
        /// </summary>
        public string AdressCom { get; set; }
        /// <summary>
        /// Representa el cuil de la empresa.
        /// </summary>
        public int CuilCom { get; set; }
        /// <summary>
        /// Representa los proyectos que tiene la empresa.
        /// </summary>
        public List<Proyect> Proyects { get; set; } = new List<Proyect>();

        public Company() { }

        public Company(string cuil, string nameCom, string adressCom)
        {
            CuilCom = int.Parse(cuil);
            AdressCom = adressCom;
            NameCom = nameCom;

        }
    }
}
