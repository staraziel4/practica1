using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Modelssss
{
    public class Materia
    {
        [Key]
        public int id_materia { get; set; }
        public string nombre { get; set; }
        public int id_docente { get; set; }
    }
}