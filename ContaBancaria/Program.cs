using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace ContaBancaria
{
    public class Program
    {
        static void Main(){
            
            Console.Clear();

            Conta A;

            System.Console.WriteLine("Entre com o nome do titular");
            string nome = Console.ReadLine();
            System.Console.WriteLine("Entre com o numero da conta");
            int numConta = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Deseja relizar um deposito inicial ? (sim/nao)");
            string opcao = Console.ReadLine().ToLower();
            A = new Conta(nome, numConta);
            
            switch (opcao){
                case "sim": {
                    Console.WriteLine("Quanto deseja depositar ??");
                    double saldoinicial = double.Parse(Console.ReadLine());
                    A = new Conta(nome, numConta, saldoinicial);
                } break;
                case "nao": {
                    System.Console.WriteLine("Obrigado por abrir uma conta ");
                    Console.WriteLine(" ");
                }break;
            }

            Console.WriteLine(A);
            Console.WriteLine(" ");

            Console.WriteLine("...... Deposito  ......");
            A.RecebeDeposito(ValorDeposito());
            Console.WriteLine(A);

            Console.WriteLine(" ");
            Console.WriteLine("...... Saque ......");
            A.retiraSaque(ValorSaque());
            Console.WriteLine(A);
             
        }
        static double ValorDeposito(){

            System.Console.WriteLine("Quanto deseja depositar?");
            double valordep = double.Parse(Console.ReadLine());
            return valordep;
        }

        static double ValorSaque(){
             System.Console.WriteLine("Quanto deseja sacar ?");
            double valorsaq = double.Parse(Console.ReadLine());
            return valorsaq;
        }
    }
}