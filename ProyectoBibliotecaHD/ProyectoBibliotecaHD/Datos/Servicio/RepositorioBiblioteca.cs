using Microsoft.EntityFrameworkCore;
using ProyectoBibliotecaHD.Datos.modelo;

namespace ProyectoBibliotecaHD.Datos.Servicio
{
    public class RepositorioBiblioteca : DbContext

    {
        public RepositorioBiblioteca(DbContextOptions<RepositorioBiblioteca>options):base(options)
        {

        }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Prestamo> Prestamo { get; set; }

    }
}
