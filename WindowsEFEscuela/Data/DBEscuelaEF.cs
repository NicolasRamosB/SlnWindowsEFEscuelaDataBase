using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFEscuela.Entity;

namespace WindowsEFEscuela.Data
{
    public class DBEscuelaEF : DbContext 
    {
        public DBEscuelaEF() : base("KeyDB") { }

        public DbSet<Alumno> Alumnos { get; set; }

        public DbSet<Profesor> Profesores { get; set; }


    }
}
