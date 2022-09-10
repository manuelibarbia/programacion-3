﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6
{
    public class Profesor : Persona
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public List<Curso> ListaDeCursos = new List<Curso>();

        //public void AsignarCurso()
        //{
        //    int cantidadCursos = 0;
        //    string curso;
        //    while (cantidadCursos < 10)
        //    {
        //        Console.WriteLine("Agregue un curso: ");
        //        curso = Console.ReadLine();
        //        cantidadCursos++;
        //    }
        //}

        public void CargarDatosProfesor()
        {
            Console.WriteLine("Ingrese el nombre del profesor: ");
            Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido: ");
            Apellido = Console.ReadLine();

            Console.WriteLine("Ingrese el DNI");
            DNI = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el teléfono: ");
            Telefono = Console.ReadLine();

            Console.WriteLine("Ingrese fecha de nacimiento: ");
            FechaNacimiento = DateTime.Parse(Console.ReadLine());
        }
    }
}
