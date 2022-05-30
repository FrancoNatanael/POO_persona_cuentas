using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
{
    class Cuenta
    {
        protected Persona titular;
        protected double dinero;

        public Cuenta(Persona titular)
        {
            this.titular = titular;
        }
        /// <summary>
        /// Mostrar datos de la cuenta
        /// </summary>
        public virtual string Mostrar()
        {
            return "Titular de la cuenta : " + titular.MostrarNombre() + ", saldo actual : " + dinero;
        }
        /// <summary>
        /// Ingresar cifra de dinero a ingresar
        /// </summary>
        public void Ingresar(double dineroIngresado)
        {
            if (!(dineroIngresado < 0))
            {
                dinero += dineroIngresado;
            }
        }
        /// <summary>
        /// Ingresar cifra de dinero.
        /// </summary>
        public virtual void Retirar(double dineroARetirar)
        {
            dinero = dinero - dineroARetirar;
        }
    }
}
