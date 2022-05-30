using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
{
    class Persona
    {
        string nombre;
        int edad;
        int dni;

        public Persona(string nombre, int edad, int dni)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        }
        /// <summary>
        /// Mostrar los datos de la persona
        /// </summary>
        public string Mostrar()
        {
            return nombre + " es una persona de " + edad + " años de edad, y su numero de DNI es " + dni;
        }
        /// <summary>
        /// Muestra si la persona es mayor de edad
        /// </summary>
        public bool EsMayorDeEdad()
        {
            return edad >= 18;
        }
        /// <summary>
        /// Muestra el nombre de la persona
        /// </summary>
        public string MostrarNombre()
        {
            return nombre;
        }
        /// <summary>
        /// Muestra la edad de la persona
        /// </summary>
        public int MostrarEdad()
        {
            return edad;
        }
    }
}
