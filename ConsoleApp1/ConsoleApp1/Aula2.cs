using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Aula2
    {
        public static void Executar()
        {
            Pessoa pessoa1 = new Pessoa();

            Console.WriteLine("********** CADASTRO DE USUARIO ***************");
            Console.Write("Digite se nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Digite seu sobrenome: ");
            pessoa1.Sobrenome = Console.ReadLine();
            Console.Write("Digite seu cpf: ");
            pessoa1.Cpf = Console.ReadLine();

            //Console.WriteLine("Nome completo: " + nome + " " + sobrenome + " Cpf: " + cpf);
            Console.WriteLine($"Nome completo: {pessoa1.Nome} {pessoa1.Sobrenome} Cpf: {pessoa1.Cpf}");

            Console.ReadKey();
        }
    }
}
