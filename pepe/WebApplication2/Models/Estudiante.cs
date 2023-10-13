using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Estudiante
    {
        [Key]
        public int id_estudiante { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public bool sexo { get; set; }
        public int id_universidad { get; set; }
    }
}