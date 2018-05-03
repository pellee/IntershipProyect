using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Dapper;
using System.Data;

namespace Data
{
    /// <summary>
    /// Es la clase que contiene las connectionStrings de las DB.
    /// </summary>
    public static class ConnectionSql
    {
        /// <summary>
        /// El metodo retorna la connectionString para abrir la DB.
        /// </summary>
        /// <param name="cnnName">El nombre para encontrar la DB.</param>
        /// <returns>La connectionString.</returns>
        public static string CnnString(string cnnName)
        {
            return ConfigurationManager.ConnectionStrings[cnnName].ConnectionString;
        }
    }

}
