using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Entity
{
    [Table("Alumno")]
    public class Alumno
    {
        [Key]
        public int AlumnoId { get; set; }


        [Column(TypeName = "varchar")] 
        [StringLength(50)] 
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Apellido { get; set; }

        public DateTime ? FechaNacimiento { get; set; }


    }
}
