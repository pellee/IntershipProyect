using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Data
{
    public class Proyect
    {

        /// <summary>
        /// Crea y guarda el proyecto en la DB.
        /// </summary>
        /// <param name="proyect">Es el objeto que contiene los valores para crear el proyecto y guardarlo en la DB.</param>
        public void CreateProyect(Entities.Proyect proyect)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionSql.CnnString("Pasantia")))
            {
                var parameters = new DynamicParameters();
                //int i = 0;

                //if (proyect.Status)
                //    i = 1;


                parameters.Add("@NamePro", proyect.NamePro);
                parameters.Add("@GoalPro", proyect.GoalPro);
                parameters.Add("@KindPro", proyect.KindPro);
                parameters.Add("@HoursPro", proyect.HoursPro);
                parameters.Add("@StatusPro", proyect.Status);
                parameters.Add("@StarDatePro", proyect.StartDatePro);
                parameters.Add("@EndDatePro", proyect.EndDatePro);
                parameters.Add("@Slots", proyect.Slots);

                connection.Execute("dbo.spProyects_Insert", parameters, commandType: CommandType.StoredProcedure);
            }
        }
        public List<Entities.Proyect> GetAllProyects()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionSql.CnnString("Pasantia")))
            {
                var proyects = connection.Query<Entities.Proyect>("dbo.spProyects_GetProyects", commandType: CommandType.StoredProcedure).ToList();

                return proyects;
            }
        }
    }
}