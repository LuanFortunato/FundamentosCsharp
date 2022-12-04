using DataApp;
using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula 4");
            //Pessoa pessoa1 = new Pessoa();
            //pessoa1.SetIdade(18);
            //pessoa1.SetNome("Luan");

            //Console.WriteLine($"\tIdade: {pessoa1.GetIdade()} \n\tNome: {pessoa1.GetNome()}");

            //TiposNumericos tn = new TiposNumericos();
            //tn.Executa();

            //TiposNmericos2.Executa();

            //TiposNumericos3.Executar();

            Animal animal = new Animal();
            animal.Id = 1;
            animal.Especie = "Tigre";
            animal.Habitat = "Savana";

            Console.WriteLine(animal.Especie);

            Animal animal1 = animal;
            animal1.Id = 11;
            animal.Especie = "Gato";
            animal.Habitat = "Casa";

            Console.WriteLine(animal.Especie);
            Console.WriteLine(animal1.Especie);

            Carro carro = new Carro();
            carro.Id = 2;
            carro.Marca = "Jaguar";
            carro.Modelo = "XE";

            Carro carro1 = carro;
            carro.Id = 3;
            carro.Marca = "Ford";
            carro.Modelo = "Focus";

            Console.WriteLine(carro.Marca);
            Console.WriteLine(carro1.Marca);
            
            Console.ReadKey();
        }
    }
}