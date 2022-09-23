using System;
using System.Globalization;
namespace BancoEstoque{

    class program{

        static void Main(string[] args){
           
            Console.Clear();

            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p1 = new Produto(nome, preco, quantidade);

            Console.WriteLine(" ");
            Console.WriteLine($" Dados do produto: {p1}");

            Console.WriteLine(" Digite o nunero de produtos adicionais: ");
            int addqtd = int.Parse(Console.ReadLine());
            p1.Adicionar(addqtd);

            Console.WriteLine(" ");      
            Console.WriteLine($"Dados atualizados: {p1}");

            Console.WriteLine(" ");
            Console.WriteLine(" Digite o nunero de produtos removidos: ");
            int removqtd = int.Parse(Console.ReadLine());
            p1.Adicionar(removqtd);

            Console.WriteLine(" ");
            Console.WriteLine($" Dados atualizados: {p1}");
        }
    }
}