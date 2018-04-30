using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Company
    {
        /// <summary>
        /// Llama a la capa de data para guardar la empresa en la DB.
        /// </summary>
        /// <param name="company">Es la empresa que se quiere guardar en la DB.</param>
        public void CreateCompany(Entities.Company company)
        {
            var dataCompany = new Data.Company();

            dataCompany.CreateCompany(company);
        }

        /// <summary>
        /// Llama a la capa de data para obtener todas las empresas que hay en la DB.
        /// </summary>
        /// <returns>Devuelve una lista de todas las empresas que hay en la DB.</returns>
        public List<Entities.Company> GetAllCompanies()
        {
            var dataCompany = new Data.Company();

            return dataCompany.GetAllCompanies();
        }
    }
}
