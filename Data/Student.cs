using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Student
    {
        /// <summary>
        /// Guarda los datos en la DB.
        /// </summary>
        /// <param name="dni">Identificador del la persona.</param>
        /// <param name="fname">Primer nombre de la persona.</param>
        /// <param name="lname">Apellido de la persona.</param>
        public void CreatePerson(string dni, string fname, string lname)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionSql.CnnString("Pasantia")))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Dni", dni);
                parameters.Add("@FirstName", fname);
                parameters.Add("@LastName", lname);

                connection.Execute("dbo.spPerson_Insert", parameters, commandType: CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// Guarda los datos en la DB.
        /// </summary>
        /// <param name="prom">El promedio del estudiante.</param>
        /// <param name="dni">Identificador de la persona.</param>
        /// <returns></returns>
        public int CreateStudent(double prom, string dni)
        {
            int idstudent = 0;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionSql.CnnString("Pasantia")))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Prom", prom);
                parameters.Add("@IdPerson", dni);
                parameters.Add("@IdStudent", idstudent, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spStudent_Insert", parameters, commandType: CommandType.StoredProcedure);

                idstudent = parameters.Get<int>("@IdStudent");
            }

            return idstudent;
        }
        /// <summary>
        /// Guarda los datos en la DB.
        /// </summary>
        /// <param name="preference">Preferencia del alumno.</param>
        /// <param name="idstudent">Identificador del estudiante dentro de la DB.</param>
        public void CreatePreferenceStudent(string preference, int idstudent)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionSql.CnnString("Pasantia")))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Preference", preference);
                parameters.Add("@IdStudent", idstudent);

                connection.Execute("dbo.spPreference_Insert", parameters, commandType: CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// Busca a todas las personas de la DB.
        /// </summary>
        /// <returns>Retorna a todas las personas.</returns>
        public List<Entities.Person> GetAllPersons()
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionSql.CnnString("Pasantia")))
            {
                var persons = connection.Query<Entities.Person>("dbo.spPerson_GetPersons", commandType: CommandType.StoredProcedure).ToList();

                return persons;
            }

        }
    }
}