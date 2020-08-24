using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioClasses4
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public double AumentarSalario( double porcentagem)
        {
             return SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
            ;
        }

        public override string ToString()
        {
            return Nome +$" R$:" + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
