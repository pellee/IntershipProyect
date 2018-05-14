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
        public int CreateStudent(double prom, string dni, bool assigned)
        {
            int idstudent = 0;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionSql.CnnString("Pasantia")))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Prom", prom);
                parameters.Add("@IdPerson", dni);
                parameters.Add("@Assigned", assigned);
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
        /// <summary>
        /// Obtiene todas las preferencias de todos los alumnos
        /// </summary>
        /// <param name="students">lista de los estudiantes.</param>
        /// <param name="connection">variable para ejectar el procedimiento de la DB.</param>
        private void GetPreferencesStudent(List<Entities.Student> students, IDbConnection connection)
        {
            foreach (var s in students)
                s.Preferences = connection.Query<string>("dbo.spStudent_GetPreferences", commandType: CommandType.StoredProcedure).ToList();
        }
        /// <summary>
        /// Trae todos los alumnos de la DB.
        /// </summary>
        /// <returns>Devuelve todos estudiantes con sus respectivos datos.</returns>
        public List<Entities.Student> GetAllStudents()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionSql.CnnString("Pasantia")))
            {
                var students = connection.Query<Entities.Student>("dbo.spStudent_GetStudents", commandType: CommandType.StoredProcedure).ToList();

                GetPreferencesStudent(students, connection);

                return students;
            }
        }
        /// <summary>
        /// Cambia valor a un estudiante en especial.
        /// </summary>
        /// <param name="assigned">El dato que se quiere cambiar.</param>
        /// <param name="dni">El alumno al que se quiere modificar.</param>
        public void UpdateStudent(bool assigned, string dni)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionSql.CnnString("Pasantia")))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Assigned", assigned);
                parameters.Add("@IdPerson", dni);

                connection.Execute("dbo.spStudent_UpdateAssigned", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}