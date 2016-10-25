using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Entidades;


namespace DAL
{
    public class ClaseDb : DbContext
    {
        public ClaseDb() : base("name=conStr")
        {
               
        }

        public virtual DbSet<Grupos> Grupo { get; set; }
        public virtual DbSet<Estudiantes> Estudiante { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grupos>()
                .HasMany<Estudiantes>(g => g.Estudiantes)
                .WithMany(e => e.Grupos)
                .Map(ge =>
                {
                    ge.MapLeftKey("estudiantesId");
                    ge.MapRightKey("gruposId");
                    ge.ToTable("GrupoEstudiantes");
                });
        }
    }
}
