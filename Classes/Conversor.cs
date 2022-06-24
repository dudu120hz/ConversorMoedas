using System;

namespace ConversorMoedas.Classes
{
    class Conversor
    {
        public Conversor(string atual, string converte, double valor)
        {
            double valorAtual = valor;
            double valorConverte;

            if(atual == "real")
            {
                if(converte == "dolar" || converte == "dólar")
                {
                    valorConverte = valorAtual * 0.19;
                    converte = "dólar";
                    Console.WriteLine($"\n A moeda {atual} convertida em {converte}");
                    Console.WriteLine($" fica no valor de ${valorConverte}");
                }
                else if(converte == "euro")
                {
                    valorConverte = valorAtual * 0.18;
                    Console.WriteLine($"\n A moeda {atual} convertida em {converte}");
                    Console.WriteLine($" fica no valor de €{valorConverte}");
                }
                else
                {
                    throw new Exception("\n\n Você digitou errado o nome de alguma moeda, feche o programa e tente novamente \n");
                }
            }
            else if(atual == "dolar" || atual == "dólar")
            {
                atual = "dólar";
                if(converte == "real")
                {
                    valorConverte = valorAtual * 5.14;
                    Console.WriteLine($"\n A moeda {atual} convertida em {converte}");
                    Console.WriteLine($" fica no valor de R${valorConverte}");
                }
                else if(converte == "euro")
                {
                    valorConverte = valorAtual * 0.95;
                    Console.WriteLine($"\n A moeda {atual} convertida em {converte}");
                    Console.WriteLine($" fica no valor de €{valorConverte}");
                }
                else
                {
                    throw new Exception("\n\n Você digitou errado o nome de alguma moeda, feche o programa e tente novamente \n");
                }   
            }
            else if(atual == "euro")
            {
                if(converte == "real")
                {
                    valorConverte = valorAtual * 5.40;
                    Console.WriteLine($"\n A moeda {atual} convertida em {converte}");
                    Console.WriteLine($" fica no valor de R${valorConverte}");
                }
                else if(converte == "dolar" || converte == "dólar")
                {
                    valorConverte = valorAtual * 1.05;
                    converte = "dólar";
                    Console.WriteLine($"\n A moeda {atual} convertida em {converte}");
                    Console.WriteLine($" fica no valor de ${valorConverte}");
                }
                else
                {
                    throw new Exception("\n\n Você digitou errado o nome de alguma moeda, feche o programa e tente novamente \n");   
                }
            }
            else
            {
                throw new Exception("\n\n Você digitou errado o nome de alguma moeda, feche o programa e tente novamente \n");
            }
        }   
    }
}