using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Estudiantes
    {
       [Key]
        public int estudiantesId { get; set; }
        public string nombreEstudiantes { get; set; }

        public virtual ICollection <Grupos> Grupos  { get; set; }

        public Estudiantes()
        {
            this.Grupos = new HashSet<Grupos>();
        }

        public Estudiantes(int estudiantesId, string nombreEstudiantes)
        {
            this.estudiantesId = estudiantesId;
            this.nombreEstudiantes = nombreEstudiantes;
            this.Grupos = new HashSet<Grupos>();
            
        }
    }
}
