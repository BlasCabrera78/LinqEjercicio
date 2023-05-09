using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEjercico
{
    public class Alumno
    {
        public string nombre;
        public string Apellido;
        public string Legajo;

        public Alumno(string Nombre, string Apellido, string Legajo) 
        {
            this.nombre = Nombre;
            this.Apellido = Apellido;
            this.Legajo = Legajo;
        }
    }
}
