using System;

namespace ConversorMoedas.Classes
{
    class Conversor
    {
        public Conversor(string atual, string converte, double valor)
        {
            double real = valor;
            double dolar = valor;
            double euro = valor;
            double valorConverte = 0.0;

            if(atual == "real" && converte == "dolar" || atual == "real" && converte == "dólar")
            {
                valorConverte = real * 0.19;
                Console.WriteLine($"\n A moeda {atual} convertida em {converte}");
                Console.WriteLine($" fica no valor de ${valorConverte}");
            }

            else if(atual == "real" && converte == "euro")
            {
                valorConverte = real * 0.18;
                Console.WriteLine($"\n A moeda {atual} convertida em {converte}");
                Console.WriteLine($" fica no valor de €{valorConverte}");
            }

            else if(atual == "dolar" && converte == "real" || atual == "dólar" && atual == "real")
            {
                valorConverte = dolar * 5.14;
                Console.WriteLine($"\n A moeda {atual} convertida em {converte}");
                Console.WriteLine($" fica no valor de R${valorConverte}");
            }

            else if(atual == "dolar" && converte == "euro" || atual == "dólar" && atual == "euro")
            {
                valorConverte = dolar * 0.95;
                Console.WriteLine($"\n A moeda {atual} convertida em {converte}");
                Console.WriteLine($" fica no valor de €{valorConverte}");
            }

            else if(atual == "euro" && converte == "real")
            {
                valorConverte = euro * 5.40;
                Console.WriteLine($"\n A moeda {atual} convertida em {converte}");
                Console.WriteLine($" fica no valor de R${valorConverte}");
            }

            else if(atual == "euro" && converte == "dolar" || atual == "euro" && atual == "dólar")
            {
                valorConverte = euro * 1.05;
                Console.WriteLine($"\n A moeda {atual} convertida em {converte}");
                Console.WriteLine($" fica no valor de ${valorConverte}");
            }
        }   
    }
}