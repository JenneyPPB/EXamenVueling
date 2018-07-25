using System;
using System.Reflection;

namespace ConsoleAppReflexion
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly myAssembly = typeof(Program).Assembly;
            Type alumnoType = myAssembly.GetType("Reflection.Alumno");

            object objetoDeAlumno = Activator.CreateInstance(alumnoType, 1, "Pepe", "Soto", "3243434x");
            Console.WriteLine(((Alumno)objetoDeAlumno).Nombre);
        }
    }
}
