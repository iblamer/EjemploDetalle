using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class EstudiantesBLL
    {
        public static bool Insertar(Estudiantes est)
        {
            bool retorno = false;
            try
            {
                var db = new ClaseDb();

                db.Estudiante.Add(est);
                db.SaveChanges();
                retorno = true;
            }
            catch(Exception)
            {
                throw;
            }

            return retorno;
        }

        public static List<Estudiantes> GetLista()
        {
            var lista = new List<Estudiantes>();

            var db = new ClaseDb();

            lista = db.Estudiante.ToList();

            return lista;
        }
    }

}
