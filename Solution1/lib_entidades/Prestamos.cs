﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    public class Prestamos
    {
        [Key] public int Id { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public int Usuario { get; set; }

        [ForeignKey("Usuario")] public virtual Usuarios? _Usuarios { get; set; }
    }
}
