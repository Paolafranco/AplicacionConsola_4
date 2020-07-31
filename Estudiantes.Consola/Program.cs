using Estudiantes.AccesoDatos;
using Estudiantes.Inplementacion;
using Estudiantes.Negocio;
using Estudiantes.Entidad;
using System;

namespace Estudiantes.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Profesor MiProfesor = new Profesor();


            var estudiante = new EstudianteMusical();
            estudiante.Id = 1;
            MiProfesor.MatricularEstudiantes(estudiante);
            MiProfesor.RealizarProyecto();

            var estudiante1 = new EstudianteMallaNueva();
            estudiante1.Id = 1;
            MiProfesor.MatricularEstudiantes(new EstudianteMallaNueva());
            MiProfesor.RealizarProyecto();

            var estudiante2 = new EstudianteAplicado();
            estudiante2.Id = 1;
            MiProfesor.MatricularEstudiantes(new EstudianteAplicado());
            MiProfesor.RealizarProyecto();

            var estudiante3 = new EstudianteRelajado();
            estudiante3.Id = 1;
            MiProfesor.MatricularEstudiantes(new EstudianteRelajado());
            MiProfesor.RealizarProyecto();

            var estudiante4 = new EstudianteDescuidado();
            estudiante4.Id = 1;
            MiProfesor.MatricularEstudiantes(new EstudianteDescuidado());
            MiProfesor.RealizarProyecto();

            MiProfesor.MatricularEstudiantes(new EstudianteEstandar());
            MiProfesor.RealizarProyecto();

            MiProfesor.MatricularEstudiantes(new EstudianteAntiguo());
            MiProfesor.RealizarProyecto();

           

            ApplicationDbContext applicationDbContext = new ApplicationDbContext();
            applicationDbContext.Estudiantes.Add(new Estudiante());
            applicationDbContext.SaveChanges();

            Console.ReadKey();
        }
    }
}
