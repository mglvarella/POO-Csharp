using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args) {

            Funcionarios funcionario1, funcionario2;
            double salarioMedio;

            funcionario1 = new Funcionarios();  
            funcionario2 = new Funcionarios();

            Console.Write("Escreva o nome do primeiro funcionário: ");
            funcionario1.nome = Console.ReadLine();
            Console.Write("Escreva o salário do primeiro funcionário: ");
            funcionario1.salario = double.Parse(Console.ReadLine());

            Console.Write("Escreva o nome do segundo funcionário: ");
            funcionario2.nome = Console.ReadLine();
            Console.Write("Escreva o salário do segundo funcionário: ");
            funcionario2.salario = double.Parse(Console.ReadLine());

            salarioMedio = (funcionario1.salario + funcionario2.salario) / 2;
            Console.WriteLine("A média salarial dos funcionários é: " +  salarioMedio);

        }
    }
}
