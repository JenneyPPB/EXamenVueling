using System;
using AutoMapper;


namespace ConsoleAppMaping
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mapper.Map<Alumno, Alumno>();//clase de origen,clase destino, se pone 

            var alumno = new Alumno { Nombre = "test", id = "100500 " };

            var alumno_copy = Mapper.Map<Alumno>(alumno);

            Console.WriteLine("alumnotype is {0}", alumno.GetType());
            Console.WriteLine("alumno_copy type is {0}", alumno_copy.GetType());

            Console.WriteLine("alumno.Nombre={0} alumno.id={1}", alumno.Nombre, alumno.id);
            Console.WriteLine("alumno_copy.A={0} alumno_copy.B={1}", alumno_copy.Nombre, alumno_copy.id);
        }
    }
}