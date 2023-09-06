using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Ejercicio_1
{
    internal class Persona
    {
        public int Id { get; set; }
        public string Nombres { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public DateTime Mes { get; set; }

        public double Cantidad { get; set; }

        public Persona(int id, string nombres, string direccion, string telefono, DateTime mes, double cantidad)
        {
            Id  = id;
            Nombres = nombres;
            Direccion = direccion;
            Telefono = telefono;
            Mes = mes;
            Cantidad = cantidad;
        }
    }
}
