using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6
{
    public class Socio : Persona
    {
        public Socio()
        {
            Console.WriteLine("Ingrese el nombre del socio: ");
            Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido: ");
            Apellido = Console.ReadLine();

            Console.WriteLine("Ingrese el DNI");
            DNI = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el teléfono: ");
            Telefono = Console.ReadLine();

            Console.WriteLine("Ingrese fecha de nacimiento: ");
            FechaNacimiento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la fecha en la que ingresó: ");
            FechaDesde = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la fechaHasta: ");
            FechaHasta = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("¿Es moroso? S si es moroso. Caso contrario, cualquier tecla.");
            EsMorosoStr = Console.ReadLine();
            if (EsMorosoStr == "s" || EsMorosoStr == "S")
            {
                EsMoroso = true;
            }
            else
            {
                EsMoroso = false;
            }
        }

        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public string EsMorosoStr { get; set; }
        public bool EsMoroso { get; set; }
        public List<Socio> ListaDeCursos { get; set; }
    }
}
