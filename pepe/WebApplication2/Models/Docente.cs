using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Modelss
{
    public class Docente
    {
        [Key]
        public int id_docente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string ubicacion { get; set; }
        public bool sexo { get; set; }
        public string ci { get; set; }
        public int id_universidad { get; set; }
    }
}