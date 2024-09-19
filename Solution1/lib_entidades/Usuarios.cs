using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace lib_entidades
{
    public class Usuarios
    {
        [Key] public int Id { get; set; }
        public string? Email { get; set; }
        public string? Contraseña { get; set; }
        public int Cod_Usuario { get; set; }
        public int Persona { get; set; }

        [ForeignKey("Persona")] public virtual Personas? _Personas { get; set; }

    }
}
