using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6
{
    public class Curso
    {
        public string NombreCurso { get; set; }
        public int Dia { get; set; }
        public string Horario { get; set; }
        public string VigenteStr { get; set; }
        public bool Vigente { get; set; }

        public Curso()
        {
            Console.WriteLine("Ingrese nombre curso: ");
            NombreCurso = Console.ReadLine();

            Console.WriteLine("Ingrese el día: ");
            Dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el horario: ");
            Horario = Console.ReadLine();

            Console.WriteLine("¿Es vigente? S si es vigente.");
            VigenteStr = Console.ReadLine();
            if (VigenteStr == "s" || VigenteStr == "S")
            {
                Vigente = true;
            } else
            {
                Vigente = false;
            }
        }
    }
}
