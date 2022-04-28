using System.ComponentModel.DataAnnotations;

namespace ProyectoBibliotecaHD.Datos.modelo
{
    public class Estudiante
    {
        [Key]
        public int Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Carrera { get; set; }
        public int Grado { get; set; }
    }
}
