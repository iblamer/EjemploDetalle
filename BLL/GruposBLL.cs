using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Entidades;


namespace BLL
{
    public class GruposBLL
    {
        public static bool Insertar(Grupos grp)
        {
            bool retorno = false;

            try
            {
                ClaseDb db = new ClaseDb();

                db.Grupo.Add(grp);
                db.SaveChanges();

                retorno = true;   
            }
            catch(Exception)
            {
                throw;
            }

            return retorno;
        }
    }
}
