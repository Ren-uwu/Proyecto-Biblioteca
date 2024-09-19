using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    public class Copias_Libros
    {
        [Key] public int Id { get; set; }
        public string? Notas { get; set; }
        public string? Estado { get; set; }
        public int Libro { get; set; }

        [ForeignKey("Libro")] public virtual Libros? _Libros { get; set; }
    }
}
