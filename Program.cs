using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int x=2, y=5, resultado;
            String sl=System.Environment.NewLine;

            resultado=x+y;

            Console.WriteLine(sl+"Presentamos la calculadora del Equipo 2"+sl);
            Console.WriteLine("Integrantes: "+sl+"Fernandez Padierna Eduardo Martin"+sl+"Mezeta Yupit Josmar David"+sl+"Puc Oxte Rolando"+sl+"Chulin Eduardo");
            
            Console.WriteLine(sl+"Opreraciones: Suma, resta, multiplicacion y division:"+sl+"Variables:"+sl+" X ="+x+sl+"Y="+y);
            Console.WriteLine("En una suma el resultado es: "+resultado);
            
        }
    }
}
