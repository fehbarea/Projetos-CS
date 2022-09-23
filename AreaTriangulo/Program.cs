using System;
using System.Globalization;

namespace AreaTriangulo{

    class Program{
        static void Main(){
            
            Console.Clear();
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            System.Console.WriteLine("Digite as medidas do triangulo X");
            x.l1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.l2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.l3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Digite as medidas do triangulo Y");
            y.l1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.l2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.l3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areax = x.Area();
            double areay = y.Area();

            System.Console.WriteLine($"A area do trinagulo x eh {x} a area do triangulo y eh {y}");

            if(areax>areay){
                System.Console.WriteLine("O triangulo x é maior");
            }
            else if(areax<areay){
                System.Console.WriteLine("O triangulo y é maior");
            }
        }
    }
}
