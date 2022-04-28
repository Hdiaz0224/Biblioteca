
using Microsoft.AspNetCore.Mvc;

namespace ProyectoBibliotecaHD.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BibliotecaController:ControllerBase
    {
        public string PropiedadBiblioteca { get; set; }

        public BibliotecaController()
        {
            //constructor
        }
        [HttpGet]
        public string ObtenerLibro()
        {
            return "Ya tienes el libro";
        }
        public string ObtenerEstudiante()
        {
            return "El estudiante fue obtenido";
        }
        public string ObtenerAutor()
        {
            return "Aqui tienes el Autor";
        }
        public string ObtenerPrestamo()
        {
            return "El prestamo fue obtenido";
        }
        [HttpPost]
        public string AgregarLibro()
        {
            return "Ya tienes el libro";
        }
        public string AgregarEstudiante()
        {
            return "El estudiante fue añadido";
        }
        public string AgregarAutor()
        {
            return "Ya tienes el Autor";
        }
        public string AgregarPrestamo()
        {
            return "El prestamo fue añadido";
        }
        [HttpPut]
        public string ActualizarLibro()
        {
            return "Ya tienes el libro";
        }
        public string ActualizarEstudiante()
        {
            return "Estudiante actualizado";
        }
        public string ActualizarAutor()
        {
            return "Ya actualizaste el Autor";
        }
        public string ActualizarPrestamo()
        {
            return "Prestamo actualizado";
        }
        [HttpDelete]
        public string EliminarLibro()
        { 
            return "Ya eliminaste el libro";
        }
        public string EliminarEstudiante()
        {
            return "El estudiante fue eliminado";
        }
        public string EliminarAutor()
        {
            return "Ya eliminaste el Autor";
        }
        public string EliminarPrestamo()
        {
            return "El prestamo fue eliminado";
        }
    }
}
