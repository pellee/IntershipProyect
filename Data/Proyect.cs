﻿using System;
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
        public void CreateProyect(Entities.Proyect proyect, int cuil)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionSql.CnnString("Pasantia")))
            {
                var parameters = new DynamicParameters();


                parameters.Add("@NamePro", proyect.NamePro);
                parameters.Add("@GoalPro", proyect.GoalPro);
                parameters.Add("@KindPro", proyect.KindPro);
                parameters.Add("@HoursPro", proyect.HoursPro);
                parameters.Add("@StartDatePro", proyect.StartDatePro);
                parameters.Add("@EndDatePro", proyect.EndDatePro);
                parameters.Add("@Slots", proyect.Slots);
                parameters.Add("@IdCompany", cuil);

                connection.Execute("dbo.spProyects_Insert", parameters, commandType: CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// Obtiene todos los proyectos que hay en la DB.
        /// </summary>
        /// <returns>Devuele una lista con los proyectos que hay en la DB.</returns>
        public List<Entities.Proyect> GetAllProyects()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionSql.CnnString("Pasantia")))
            {
                var proyects = connection.Query<Entities.Proyect>("dbo.spProyects_GetProyects", commandType: CommandType.StoredProcedure).ToList();

                return proyects;
            }
        }
        /// <summary>
        /// Cambia el valor de un proyecto en especial.
        /// </summary>
        /// <param name="idProyect">Proyecto que se quiere cambiar.</param>
        /// <param name="slots">data que se quiere cambiar.</param>
        public void UpdateProyect(int idProyect, int slots)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionSql.CnnString("Pasantia")))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@IdProyect", idProyect);
                parameters.Add("@Slots", slots);

                connection.Execute("dbo.spProyect_UpdateProyect", parameters, commandType: CommandType.StoredProcedure);
            }

        }
    }
}