using System;

namespace Exercicios_de_fixação
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            
            Console.Write("Qual o produto: ");
            string nome = Console.ReadLine();
            Console.Write("Qual a quantidade comprada: ");
            double quantidade = double.Parse(Console.ReadLine());
            Console.Write("Qual o preço unitario do produto: ");
            double preco = double.Parse(Console.ReadLine());
            
            double total = preco*quantidade;
            if (quantidade<=5)
            {
                double desconto = total*0.02;
                double valorFinal = preco-desconto;
                Console.WriteLine($"O valor final é de: {valorFinal}");
            }
            else
            {
                if (quantidade<5 || quantidade<=10)
                {
                    double desconto = total*0.03;
                    double valorFinal = preco-desconto;
                    Console.WriteLine($"O valor final é de: {valorFinal}");
                }
                else
                {
                    if (quantidade>10)
                    {
                        double desconto = total*0.05;
                        double valorFinal = preco-desconto;
                        Console.WriteLine($"O valor final é de: {valorFinal}");
                    }
                }
            }

        }
    }
}
