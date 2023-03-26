using System;

namespace Exercício1
{
    class Program{
        static void Main(string[] args)
        {
            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();
            
            Console.Write("Escreva o nome da primeira pessoa: ");
            pessoa1.nome = Console.ReadLine();
            Console.Write("Escreva a idade da primeira pessoa: ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.Write("Escreva o nome da segunda pessoa: ");
            pessoa2.nome = Console.ReadLine();
            Console.Write("Escreva a idade da segunda pessoa: ");
            pessoa2.idade = int.Parse(Console.ReadLine());

            if(pessoa1.idade == pessoa2.idade)
            {
                Console.WriteLine(pessoa1.nome + " e " + pessoa2.nome + " têm a mesma idade.");
            }
            else if (pessoa1.idade > pessoa2.idade) 
            {
                Console.WriteLine(pessoa1.nome + " é a pessoa mais velha");
            }
            else
            {
                Console.WriteLine(pessoa2.nome + " é a pessoa mais velha");
            }

            Console.ReadKey();

        }
    }
}
