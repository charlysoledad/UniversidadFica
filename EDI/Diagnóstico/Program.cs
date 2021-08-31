using System;

namespace Diagnóstico
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta();

            cuenta.titular = "Juan";

            Console.WriteLine(cuenta.toString());

            cuenta.ingresar(1000.0);
            
            Console.WriteLine(cuenta.toString());
            
            cuenta.ingresar(-200.0);

            Console.WriteLine(cuenta.toString());
            
            cuenta.ingresar(0.75);

            Console.WriteLine(cuenta.toString());
            
            cuenta.retirar(1000.75);

            Console.WriteLine(cuenta.toString());

            cuenta.cantidad = 1200.5;

            Console.WriteLine(cuenta.toString());

            Cuenta cuenta1 = new Cuenta("Pedro");
            Console.WriteLine(cuenta1.toString());
            
            Cuenta cuenta2 = new Cuenta("Ricardo", 5970.95);
            Console.WriteLine(cuenta2.toString());
        }
    }
}
