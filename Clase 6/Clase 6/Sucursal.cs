using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6
{
    public class Sucursal
    {
        public int Codigo { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        List<Profesor> Profesores = new List<Profesor>();
        List<Curso> Cursos = new List<Curso>();
        List<Socio> Socios = new List<Socio>();
        public void InicializarSucursal()
        {
            this.CargarCursos();
            this.CargarSocios();
            this.CargarProfesores();
            this.MostrarDatos();
        }

        public void CargarCursos()
        {
            int i = 0;
            string rtaUsuario;

            Console.WriteLine("Inicio de carga de cursos");
            Curso c = new Curso();
            Cursos.Add(c);
            i++;
            while (i<10)
            {
                Console.WriteLine("Desea cargar otro curso? S para confirmar. Caso contrario, cualquier tecla.");
                rtaUsuario = Console.ReadLine();
                if (rtaUsuario == "s" || rtaUsuario == "S")
                {
                    Curso cu = new Curso();
                    Cursos.Add(cu);
                    i++;
                } else
                {
                    break;
                }
            }
        }
        public void CargarProfesores()
        {
            Console.WriteLine("Inicio carga de profesores");
            for (int i = 0; i <= 19; i++)
            {
                Console.WriteLine("Carga del profesor " + (i+1));
                Profesor p = new Profesor();
                Profesores.Add(p);
            }
        }
        public void CargarSocios()
        {
            Console.WriteLine("Inicio carga de socios");
            Socio s = new Socio();
            Socios.Add(s);
            string rtaUsuario = "s";
            while (rtaUsuario == "s" || rtaUsuario == "S")
            {
                Console.WriteLine("Desea cargar otro socio? S para confirmar. Caso contrario, cualquier tecla.");
                rtaUsuario = Console.ReadLine();
                if (rtaUsuario == "s" || rtaUsuario=="S")
                {
                    Socio soc = new Socio();
                    Socios.Add(soc);
                }
            }
        }
        public void MostrarDatos()
        {
            //MAX/MIN
            var edadMaxima = Socios.Max(x => (DateTime.Today.Year - x.FechaNacimiento.Year));
            var edadMinima = Socios.Min(x => (DateTime.Today.Year - x.FechaNacimiento.Year));

            //promedio
            var edadMedia = Socios.Average(x => (DateTime.Today.Year - x.FechaNacimiento.Year));

            Console.WriteLine("La edad máxima de socios es: " + edadMaxima);
            Console.WriteLine("La edad mínima de socios es: " + edadMinima);
            Console.WriteLine("El promedio de edades de socios es: " + edadMedia);

        }
    }
}
