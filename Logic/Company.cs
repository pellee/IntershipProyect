using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Company
    {
        public void CreateCompany(Entities.Company company)
        {
            var dataCompany = new Data.Company();

            dataCompany.CreateCompany(company);
        }

        public List<Entities.Company> GetAllCompanies()
        {
            var dataCompany = new Data.Company();

            return dataCompany.GetAllCompanies();
        }
    }
}
