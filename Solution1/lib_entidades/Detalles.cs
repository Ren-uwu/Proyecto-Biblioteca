using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    public class Detalles
    {
        [Key] public int Id { get; set; }
        public DateTime Fecha_Final { get; set; }
        public int Prestamo { get; set; }
        public int Copia { get; set; }

        [ForeignKey("Copia")] public virtual Copias_Libros? _Copias_Libros { get; set; }

        [ForeignKey("Prestamo")] public virtual Prestamos? _Prestamos { get; set; }
    }
}
