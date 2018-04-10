﻿using System;
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
        /// Llama a la capa de Data para crear y guardar el proyecto en la DB.
        /// </summary>
        /// <param name="proyect">Es el objeto que contiene los datos del proyecto.</param>
        public void CreateProyect(Entities.Proyect proyect)
        {
            Data.Proyect dataProyect = new Data.Proyect();

            dataProyect.CreateProyect(proyect);
        }

        public List<Entities.Proyect> GetAllProyects()
        {
            Data.Proyect dataProyect = new Data.Proyect();

            return dataProyect.GetAllProyects();
        }

    }
}
