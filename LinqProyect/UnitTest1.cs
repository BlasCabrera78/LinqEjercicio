using LinqEjercico;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections;
using System.Collections.Generic;

namespace LinqProyect
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(100000)]
        public void Prueba(int cantidad)
        {
            Hashtable alumnos = new Hashtable();
            for (int i = 0; i < cantidad; i++)
            {
                string nombre = $"nombre{i}";
                string apellido = $"apellido{i}";
                string legajo = $"{i}";
                var alumno = new Alumno(nombre, apellido, legajo);
                alumnos.Add(i, alumno);
            }
            var a = alumnos.Values;
            var Nombres = from Alumno x in a
                          where x.Apellido.EndsWith("11")
                          select a;
            Assert.Equal(100000, a.Count );
            Assert.Equal(1000, Nombres.Count());
        }
    }
}