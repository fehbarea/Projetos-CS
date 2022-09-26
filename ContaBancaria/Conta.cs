using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace ContaBancaria
{
    class Conta
    {
        public string Nome { get; set; }
        public int NumConta {get; }
        public double Saldo{get; private set;}

        public Conta(string nome, int numConta){
            Nome = nome;
            NumConta = numConta;
        }
        public Conta(string nome, int numConta, double saldo): this(nome, numConta){
            Saldo = saldo;
        }

        public double RecebeDeposito(double deposito){
            return Saldo += deposito;
        }


        public double retiraSaque(double saque){
            int encargos = 5;
            return Saldo -= saque + encargos;
        
        }

        public override string ToString(){
            return "Conta: "
            + NumConta
            + ", Titular "
            + Nome
            +", Saldo: "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
        

    }
}