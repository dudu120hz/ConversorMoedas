using System;

namespace ConversorMoedas.Classes
{
    class Conversor
    {
        public Conversor(string atual, string converte, double valor)
        {
            double valorAtual = valor;
            double valorConverte = 0.0;

            if(atual == "real" && converte == "dolar" || atual == "real" && converte == "dólar")
            {
                valorConverte = valorAtual * 0.19;
                Console.WriteLine($"\n A moeda {atual} convertida em {converte}");
                Console.WriteLine($" fica no valor de ${valorConverte}");
            }

            else if(atual == "real" && converte == "euro")
            {
                valorConverte = valorAtual * 0.18;
                Console.WriteLine($"\n A moeda {atual} convertida em {converte}");
                Console.WriteLine($" fica no valor de €{valorConverte}");
            }

            else if(atual == "dolar" && converte == "real" || atual == "dólar" && atual == "real")
            {
                valorConverte = valorAtual * 5.14;
                Console.WriteLine($"\n A moeda {atual} convertida em {converte}");
                Console.WriteLine($" fica no valor de R${valorConverte}");
            }

            else if(atual == "dolar" && converte == "euro" || atual == "dólar" && atual == "euro")
            {
                valorConverte = valorAtual * 0.95;
                Console.WriteLine($"\n A moeda {atual} convertida em {converte}");
                Console.WriteLine($" fica no valor de €{valorConverte}");
            }

            else if(atual == "euro" && converte == "real")
            {
                valorConverte = valorAtual * 5.40;
                Console.WriteLine($"\n A moeda {atual} convertida em {converte}");
                Console.WriteLine($" fica no valor de R${valorConverte}");
            }

            else if(atual == "euro" && converte == "dolar" || atual == "euro" && atual == "dólar")
            {
                valorConverte = valorAtual * 1.05;
                Console.WriteLine($"\n A moeda {atual} convertida em {converte}");
                Console.WriteLine($" fica no valor de ${valorConverte}");
            }

            // Atalhos do VSCode
            // Seleção de comentário:
            // Ctrl+K, Ctrl+C

            // Remover comentário da seleção:
            // Ctrl+K, Ctrl+U
        }   
    }
}