using System;
using System.Globalization;

namespace ExercicioClasses4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler os dados de um funcionário (nome,
            salário bruto e imposto). Em seguida, mostrar os dados do
            funcionário (nome e salário líquido). Em seguida, aumentar o salário
            do funcionário com base em uma porcentagem dada (somente o
            salário bruto é afetado pela porcentagem) e mostrar novamente os
            dados do funcionário. Use a classe projetada abaixo.*/

            var funcionario = new Funcionario();

            Console.WriteLine("Digite nome:");
            funcionario.Nome = Console.ReadLine();
            Console.WriteLine("Digite salário bruto:");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite imposto:");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionario.SalarioLiquido();
            Console.WriteLine(funcionario);

            Console.WriteLine("Digite porcentagem de aumento:");
            double porcentagem= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);
            Console.WriteLine("Dados atualizados: " +funcionario);
        }
    }
}
