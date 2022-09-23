using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace BancoEstoque
{
    public class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;
            
        public Produto(string nome, double preco, int quantidade){

                _nome = nome;
                _preco = preco;
                _quantidade = quantidade;

        }

        public string GetNome(){
            return _nome;
        }

        public void Adicionar(int quant){
            _quantidade += quant;
            
        }
        public void Remover(int quant){
            _quantidade -= quant;
        }
        
        public double Valortotalemestoque(){
            return _preco * _quantidade;
        }

        public override string ToString()
        {
            return _nome 
            + ", $" 
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", " 
            + _quantidade
            + " Unidades, valor total em estoque: $ "
            + Valortotalemestoque().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
    
}