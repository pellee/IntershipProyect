using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Proyect
    {
        /// <summary>
        /// Llama a la capa de data para guardar el proyecto en la DB.
        /// </summary>
        /// <param name="proyect">Contiene todos los valores del proyecto.</param>
        /// <param name="cuil">Es la referencia a la empresa que pertenece el proyecto.</param>
        public void CreateProyect(Entities.Proyect proyect, int cuil)
        {
            Data.Proyect dataProyect = new Data.Proyect();

            dataProyect.CreateProyect(proyect, cuil);
        }

        /// <summary>
        /// Llama a la capa de Data y trae todos los proyectos que estan guardados en la DB
        /// </summary>
        /// <returns>Devuelve una lista de todos los proyectos</returns>
        public List<Entities.Proyect> GetAllProyects()
        {
            Data.Proyect dataProyect = new Data.Proyect();

            return dataProyect.GetAllProyects();
        }

        /// <summary>
        /// Verifica si el proyecto ya existe.
        /// </summary>
        /// <param name="proyect">Es el proyecto que se quiere verificar.</param>
        /// <returns>false si el proyecto existe, true si no existe. </returns>
        public bool ValidateProyect(Entities.Proyect proyect)
        {
            //TODO - Fijarme como verificar si existe el proyecto.

            var dataProyect = new Data.Proyect();
            var proyects = dataProyect.GetAllProyects();

            foreach (var p in proyects) {
                if (p == proyect)
                    return false;
            }

            return true;
        }

    }
}
