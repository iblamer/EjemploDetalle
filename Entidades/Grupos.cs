using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Entidades;

namespace Entidades
{
    public class Grupos
    {
        [Key]
        public int gruposId { get; set; }
        public string grupoNombres { get; set; }

        public virtual List<Estudiantes> Estudiantes { get; set; }

        public Grupos()
        {
            this.Estudiantes = new List<Estudiantes>();
        }

    }
}
