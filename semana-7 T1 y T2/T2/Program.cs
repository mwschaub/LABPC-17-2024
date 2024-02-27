using System.Collections;
using System.Diagnostics;

namespace T2MWSG1243424E1yE2{
    class Program
    {

        static void Main (string [] args)
        {
        Console.WriteLine("Cálculo de velocidad final");
        double V0 = 0;
        double acele = 0;
        double tiempo = 0;
        double VF = 0;
        Console.WriteLine("Ingrese el valor de velocidad inicial");
        V0 = Double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el valor de aceleración");
        acele = Double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el valor del tiempo");
        tiempo = Double.Parse(Console.ReadLine());
        VF=V0 + (acele * tiempo);
        Console.WriteLine("La velocidad final es: "+VF);
        Console.ReadKey();
        //Aquí termina el programa 1 y empieza el dos
        Console.WriteLine("Bienvenido al calculo de equivalencia de billetes");
        Console.WriteLine("Ingrese una cantidad entre 0 y 999.99");
        double cantidad = 0;
        cantidad = Double.Parse(Console.ReadLine());
        if (cantidad < 0) {
                Console.WriteLine("No es válido");
        }
        else if (cantidad >=1000)
        {Console.WriteLine("No es válido");}
        else 
        {
             int centavos = (int)(cantidad * 100);
        int billete100 = centavos / 10000;
        centavos %= 10000;
        int billete50 = centavos / 5000;
        centavos %= 5000;
        int billete20 = centavos / 2000;
        centavos %= 2000;
        int billete10 = centavos / 1000;
        centavos %= 1000;
        int billete5 = centavos / 500;
        centavos %= 500;
        int moneda1 = centavos / 100;
        Console.WriteLine("Para la cantidad ingresada se necesitan:");
        Console.WriteLine($"{billete100} billetes de 100");
        Console.WriteLine($"{billete50} billetes de 50");
        Console.WriteLine($"{billete20} billetes de 20");
        Console.WriteLine($"{billete10} billetes de 10");
        Console.WriteLine($"{billete5} billetes de 5");
        Console.WriteLine($"{moneda1} monedas de 1");
        }
        }
    }
}