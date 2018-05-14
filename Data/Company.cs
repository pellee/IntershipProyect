using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Company
    {
        /// <summary>
        /// Guarda la empresa en la DB.
        /// </summary>
        /// <param name="company">Es la empresa que se quiere guardar en la DB.</param>
        public void CreateCompany(Entities.Company company)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionSql.CnnString("Pasantia")))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@CuilCom", company.CuilCom);
                parameters.Add("@NameCom", company.NameCom);
                parameters.Add("@AdressCom", company.AdressCom);

                connection.Execute("dbo.spCompany_Insert", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// Obtiene todos los proyectos de todas las empresas.
        /// </summary>
        /// <param name="connection">Para ejectucar el procedimiento de la DB.</param>
        /// <param name="companies">Una lista de empresas a la que se le agregar sus respectivos proyectos.</param>
        private void GetProyectsOfCompany(IDbConnection connection, List<Entities.Company> companies)
        {
            foreach (var c in companies) {
                var parameters = new DynamicParameters();

                parameters.Add("@CuilCom", c.CuilCom);

                c.Proyects= connection.Query<Entities.Proyect>("dbo.spCompany_GetProyectsOfCompany", parameters, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        /// <summary>
        /// Obtiene todas las empresas que hay en la DB.
        /// </summary>
        /// <returns>Devuele una lista con todas las empresas que hay en la DB.</returns>
        public List<Entities.Company> GetAllCompanies()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionSql.CnnString("Pasantia")))
            {
                var companies = connection.Query<Entities.Company>("dbo.spCompany_GetCompanies", commandType: CommandType.StoredProcedure).ToList();

                GetProyectsOfCompany(connection, companies);

                return companies;
            }
        }
    }
}
