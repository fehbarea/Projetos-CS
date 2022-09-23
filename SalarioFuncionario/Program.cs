using System;
using System.Globalization;

namespace SalarioFuncionario{

    class Program{

        static void Main(){
            
            Console.Clear();
            Funcionario A = new Funcionario();

            System.Console.WriteLine("Digite o nome do funcionario o seu salario e o imposto ");
            A.Nome = Console.ReadLine();
            A.SalarioBruto = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            float Imposto = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(A.SalarioLiquido(Imposto));

            float porcentagem;

                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("Quanto de aumento deseja dar para o funcionario ");
                    porcentagem = float.Parse(Console.ReadLine());

            Console.WriteLine( A.Aumento(porcentagem));



           
        }
    }
}
