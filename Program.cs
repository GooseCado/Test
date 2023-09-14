// See https://aka.ms/new-console-template for more information
namespace Fibonacci
{
  using System;

public class Nathy
{
    public static void Main()
    {
        Console.WriteLine("10 fibonacci");
        
        int n = 10;
        if (int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Sequência de Fibonacci com os primeiros " + n + " termos:");
            
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
            
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Por favor, insira um número inteiro.");
        }
    }
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        else
            return Fibonacci(n - 1) + Fibonacci(n-2);
    }
}
}
