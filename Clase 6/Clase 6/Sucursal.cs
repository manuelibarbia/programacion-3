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
        }

        public void CargarCursos()
        {
            int i = 0;
            string rtaUsuario;

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
            //Console.WriteLine(Cursos);
        }
        public void CargarProfesores()
        {
            for (int i = 0; i < 2; i++) //CAMBIAR A <20
            {
                Profesor p = new Profesor();

                p.CargarDatosProfesor();
                Profesores.Add(p);
            }
        }
        public void CargarSocios()
        {
            int i = 1;
            string rtaUsuario;
            while (i == 1)
            {
                Console.WriteLine("Desea cargar otro socio? S para confirmar. Caso contrario, cualquier tecla.");
                rtaUsuario = Console.ReadLine();
                if (rtaUsuario == "s" || rtaUsuario=="S")
                {
                    Socio s = new Socio();
                    s.CargarDatosSocio();
                    Socios.Add(s);
                } else
                {
                    i = 0;
                }
            }
        }

    }
}
