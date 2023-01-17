using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFEscuela.Dac;
using WindowsEFEscuela.Entity;

namespace WindowsFormsAppAlumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno() {Name = textBoxName.Text, Apellido = textBoxApellido.Text, FechaNacimiento = Convert.ToDateTime(dateTimeFecha.Text) };
          
            int filasAfectadas = AdmAlumnos.Insert(alumno);

            if (filasAfectadas > 0)
            {

                MessageBox.Show($"Se ha Insertado Alumno {textBoxName.Text} {textBoxApellido.Text}");
                MostrarAlumnos();

            }
        }



        private void btnUpdateAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno() { AlumnoId = Convert.ToInt32(textBoxID.Text), Name = textBoxName.Text, Apellido = textBoxApellido.Text, FechaNacimiento = Convert.ToDateTime(dateTimeFecha.Text) };

            int filasAfectadas = AdmAlumnos.Update(alumno);

            if (filasAfectadas > 0)
            {

                MessageBox.Show($"Se ha modificado el alumno {textBoxName.Text} {textBoxApellido.Text}");
                MostrarAlumnos();


            }
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarAlumnos();

        }

        private void MostrarAlumnos()
        {
            dataGridAlumno.DataSource = AdmAlumnos.SelectAll();
        }




        private void btnFindIdAlumno_Click(object sender, EventArgs e)
        {
           
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                Alumno alumno = AdmAlumnos.SelectWhereById(id);
                MessageBox.Show($"Se ha encontrado {alumno.Name} {alumno.Apellido}");
            }
            catch 
            {

                MessageBox.Show($"No se ha encontrado el alumno {textBoxName.Text} {textBoxApellido.Text}");
            }
            
        }


        private void btnDeleteAlumno_Click(object sender, EventArgs e)
        {
             
                 try
                 {
                     Alumno alumno = new Alumno() { AlumnoId = Convert.ToInt32(textBoxID.Text), Name = textBoxName.Text, Apellido = textBoxApellido.Text};

                     int filasAfectadas = AdmAlumnos.Delete(alumno);
                     if (filasAfectadas > 0)
                     {

                     MessageBox.Show($"Se ha eliminado el alumno {textBoxID.Text} {textBoxName.Text} {textBoxApellido.Text}");
                     MostrarAlumnos();

                     }
                 }
                 catch
                 {

                    MessageBox.Show($"No se ha encontrado el alumno {textBoxName.Text} {textBoxApellido.Text}");
                  }
        }

        
    }
}
