using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante Fabricio = new Estudiante("Sergio", "Anchundia", 1316764974, "Soltero", 4);
            Fabricio.MostrarEstudiante();
            Fabricio.CambioEstadoCivil();
            Fabricio.CambiarCurso();

            Profesor Enrique = new Profesor("David", "Alonso", 1351663917, "Casado", 13, 2020, "Historia");
            Enrique.MostrarProfesor();
            Enrique.CambioEstadoCivil();
            Enrique.CambioDespacho();
            Enrique.CambioDepartamento();

            Personal Eddu = new Personal("Jonathan", "Delgado", 1398521664, "Divorciado", 5, 2018, "Cocina");
            Eddu.MostrarEmpleado();
            Eddu.CambioEstadoCivil();
            Eddu.CambioDespacho();
            Eddu.CambioSeccion();

            Fabricio.MostrarEstudianteFinal();
            Enrique.MostrarProfesorFinal();
            Eddu.MostrarEmpleadoFinal();
        }
    }
}
