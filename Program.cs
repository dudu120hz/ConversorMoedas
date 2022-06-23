using System;
using ConversorMoedas.Classes;

namespace ConversorMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Conversor de Moedas");
            Console.Write(" Digite a moeda atual (real, dólar ou euro): ");
            string moedaAtual = Console.ReadLine();
            moedaAtual = moedaAtual.ToLower();

            Console.WriteLine("\n Digite a moeda para qual você quer converter");
            Console.Write(" (real, dólar ou euro): ");
            string moedaConverte = Console.ReadLine();
            moedaConverte = moedaConverte.ToLower();

            Console.WriteLine($"\n Digite o valor de {moedaAtual}");
            Console.Write(" que você quer converter: ");
            double valorAtual = Double.Parse(Console.ReadLine());

            if(moedaAtual == "real" || moedaAtual == "dólar" || moedaAtual == "dolar" || moedaAtual == "euro")
            {
                Conversor c = new Conversor(moedaAtual, moedaConverte, valorAtual);
            }
            else
            {
                throw new Exception("\n\n Você digitou errado o nome de alguma moeda, feche o programa e tente novamente \n");
            }
        }
    }
}