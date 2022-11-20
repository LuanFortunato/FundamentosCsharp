using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Aula1
    {
        public static void Executar()
        {
            Console.WriteLine("Olá mundo");
            Console.Write("Digite seu nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Seja bem vindo, " + nome);
            Console.Write("Digite sua idade: ");
            var idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nome + " sua idade é: " + idade);

            if (idade >= 18)
                Console.WriteLine("Maior de idade");
            else
                Console.WriteLine("Menor de idade");

            Console.ReadKey();
        }
    }
}
