using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFEscuela.Data;
using WindowsEFEscuela.Entity;

namespace WindowsEFEscuela.Dac
{
    public static class AdmAlumnos
    {
        private static DBEscuelaEF context = new DBEscuelaEF();

        public static List<Alumno> SelectAll()
        {
            return context.Alumnos.ToList();
        }

        public static Alumno SelectWhereById(int id)
        {
            return context.Alumnos.Find(id);
        }

        public static int Insert(Alumno alumno)
        {
            context.Alumnos.Add(alumno);
            return context.SaveChanges();
        }

        public static int Update(Alumno alumno)
        {
            Alumno alumnoDeOrigen = context.Alumnos.Find(alumno.AlumnoId);

            alumnoDeOrigen.Name = alumno.Name;
            alumnoDeOrigen.Apellido = alumno.Apellido;
            alumnoDeOrigen.FechaNacimiento = alumno.FechaNacimiento;



            return context.SaveChanges();
        }

        public static int Delete(Alumno alumno)
        {
            Alumno alumnoDeOrigen = context.Alumnos.Find(alumno.AlumnoId);

            if (alumnoDeOrigen != null)
            {
                context.Alumnos.Remove(alumnoDeOrigen);
                return context.SaveChanges();
            }

            return 0;
        }
    }
}
