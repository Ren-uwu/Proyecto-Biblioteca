using lib_entidades;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class Copias_LibrosRepositorio : ICopias_LibrosRepositorio
    {
        private Conexion? conexion;

        public Copias_LibrosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Copias_Libros> Listar()
        {
            return conexion!.Listar<Copias_Libros>();
        }

        public List<Copias_Libros> Buscar(Expression<Func<Copias_Libros, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Copias_Libros Guardar(Copias_Libros entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Copias_Libros Modificar(Copias_Libros entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Copias_Libros Borrar(Copias_Libros entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public bool Existe(Expression<Func<Copias_Libros, bool>> condiciones)
        {
            return conexion!.Existe(condiciones);
        }
    }
}