using lib_entidades;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface ICopias_LibrosRepositorio
    {
        void Configurar(string string_conexion);
        List<Copias_Libros> Listar();
        List<Copias_Libros> Buscar(Expression<Func<Copias_Libros, bool>> condiciones);
        Copias_Libros Guardar(Copias_Libros entidad);
        Copias_Libros Modificar(Copias_Libros entidad);
        Copias_Libros Borrar(Copias_Libros entidad);
        bool Existe(Expression<Func<Copias_Libros, bool>> condiciones);
    }
}