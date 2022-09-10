using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Para un sistema dedicado a un gimnasio hacer las siguientes consignas:

//-Crear la clase Persona
//Propiedades: Nombre(string), Apellido(string), DNI(int), Telefono(string), Direccion(string), FechaNacimiento(DateTime)

//- Clase Socio: Hereda de Persona
//FechaDesde(DateTime), FechaHasta(DateTime), EsMoroso(bool), Cursos(Lista de cursos)

//- Clase Profesor, Hereda de Persona
//FechaInicio(DateTime), FechaFin(DateTime), Cursos(Lista de cursos)
//Metodo AsignarCurso: Debe recibir un curso y agregarlo a la lista de cursos del profesor

//-Crear la clase Curso:
//Propiedades: NombreCurso(string), Dia(int), Horario(string), Vigente(bool)

//- Crear la clase Sucursal:
//Propiedades: Codigo(int), Direccion(string), Ciudad(string), Cursos(Lista de cursos), Profesores(Lista de profesores), Socios(Lista de socios)

//Programa Principal:
//-En el metodo InicializarSucursal() debe cargar los datos de la misma, incluídos los datos de cada uno de los Cursos, Profesores, Socios.
//Las clases Cursos, Profesores, Socios deben tener un metodo constructor en el cual se soliciten los datos para cargarlos.

//Las limitaciones son:
//Los cursos no pueden ser mas de diez, se deben cargar usando un while.
//Los profesores son veinte, y se deben cargar con una sentencia for.
//No se sabe cuantos socios hay, se deben cargar usando un while

//Ademas, se desea saber el promedio de edad de los socios, la edad máxima y la edad minima, usando linq.


namespace Clase_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Sucursal s = new Sucursal();
            s.InicializarSucursal();
        }
    }
}
