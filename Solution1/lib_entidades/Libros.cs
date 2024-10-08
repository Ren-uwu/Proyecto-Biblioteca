﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    public class Libros
    {
        [Key] public int Id { get; set; }
        public string? Nombre_Libro { get; set; }
        public DateTime Fecha_Publicacion { get; set; }
        public string? Autor { get; set; }
        public int Cod_Libro { get; set; }
    }
}
