﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    public class Personas
    {
        [Key] public int Id { get; set; }
        public long? Cedula { get; set; }
        public string? Nombre { get; set; }
        public long Numero { get; set; }
    }
}
