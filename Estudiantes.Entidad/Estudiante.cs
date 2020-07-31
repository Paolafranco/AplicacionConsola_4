using System.Collections.Generic;

namespace Estudiantes.Entidad
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<string> NotasEstudiantes { get; set; }
    }
}
