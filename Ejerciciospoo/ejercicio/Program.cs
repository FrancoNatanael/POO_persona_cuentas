using System;

namespace ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona titularCuentaTracidional = new Persona("Julio", 40, 2078633);
            Persona titularCuentaJoven = new Persona("Franco", 20, 44006754);

            Cuenta cuentaTradicional = new Cuenta(titularCuentaTracidional);
            CuentaJoven cuentaJoven = new CuentaJoven(15, titularCuentaJoven);

            Console.WriteLine("------Datos cuenta Tradicional---------");
            Console.WriteLine(cuentaTradicional.Mostrar());
            cuentaTradicional.Ingresar(10000);
            Console.WriteLine("**Despues de ingresar dinero");
            Console.WriteLine(cuentaTradicional.Mostrar());
            cuentaTradicional.Retirar(50000);
            Console.WriteLine("**Despues de retirar dinero");
            Console.WriteLine(cuentaTradicional.Mostrar());

            Console.WriteLine("------Datos cuenta Joven---------");
            Console.WriteLine(cuentaJoven.Mostrar());
            Console.WriteLine("Es titular valido ? " + cuentaJoven.esTitularValido());
           

        }
    }
}
