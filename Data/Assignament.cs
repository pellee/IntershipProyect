using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Assignament
    {
        public void CreateAssignament(Entities.Assignament assignament)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionSql.CnnString("Pasantia")))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@IdStudent", assignament.Student.IdStudent);
                parameters.Add("@IdProyect", assignament.Proyect.IdProyect);
                parameters.Add("@IdCompany", assignament.Company.CuilCom);

                connection.Execute("dbo.spAssignament_Insert", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
