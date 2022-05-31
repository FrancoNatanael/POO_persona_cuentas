using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
{
    class CuentaJoven:Cuenta
    {
        double porcentaje;

        public CuentaJoven(double porcentaje,Persona titular) : base(titular)
        {
            this.porcentaje = porcentaje;
        }
        /// <summary>
        /// Valida si el titular esta dentro de los parametros para una cuenta joven
        /// </summary>
        public bool esTitularValido()
        {
            if(this.titular.MostrarEdad() > 18 && this.titular.MostrarEdad() < 25)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public override void Retirar(double dineroARetirar)
        {
            if (esTitularValido())
            {
                base.Retirar(dineroARetirar);
            }
            
        }

        public override string Mostrar()
        {
            
            return "Cuenta Joven con bonificacion de " + this.porcentaje + "%";
        }
    }
}
