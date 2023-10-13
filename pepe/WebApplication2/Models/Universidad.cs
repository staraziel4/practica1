using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Modelsss
{
    public class Universidad
    {
        [Key]
        public int id_universidad { get; set; }
        public string nombre { get; set; }

    }
}
