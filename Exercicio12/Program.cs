using System;

public class Exercicio12
{
    public static void Main(string[] args)
    {
        int soma = 0;
        int counter;

        for (counter = 0; soma <= 100; counter++)
        {
            soma += counter;
            Console.WriteLine(soma);
        }
        Console.WriteLine("Último número adicionado: " + counter);
    }
}