using lib_entidades;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class LibrosRepositorio : ILibrosRepositorio
    {
        private Conexion? conexion;

        public LibrosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Libros> Listar()
        {
            return conexion!.Listar<Libros>();
        }

        public List<Libros> Buscar(Expression<Func<Libros, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Libros Guardar(Libros entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Libros Modificar(Libros entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Libros Borrar(Libros entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public bool Existe(Expression<Func<Libros, bool>> condiciones)
        {
            return conexion!.Existe(condiciones);
        }
    }
}