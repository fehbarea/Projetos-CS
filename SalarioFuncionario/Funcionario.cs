using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;


namespace SalarioFuncionario
{
    public class Funcionario
    {
        public string Nome;
        public float SalarioBruto;

        public float SalarioLiquido(float Impostos){
            return SalarioBruto - Impostos;
        }


        public float Aumento(float porc){
            return SalarioBruto = (SalarioBruto) + SalarioBruto*(porc/100);
        }

        public override string ToString()
        {
            return " O funcionario: "
            + Nome
            + " recebe: "
            + SalarioBruto;

        }


    }
}