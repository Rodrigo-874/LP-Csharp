using System;

public class Exercicio7
{
    static void Main(string[] args)
    {
        int nota = 86;

        switch (nota)
        {
            case int n when (nota >= 90):
                Console.WriteLine("A");
                break;

            case int n when (nota >= 80):
                Console.WriteLine("B");
                break;

            case int n when (nota >= 70):
                Console.WriteLine("C");
                break;

            case int n when (nota >= 60):
                Console.WriteLine("D");
                break;

            case int n when (nota <60):
                Console.WriteLine("Reprovado");
                break;

            default:
                Console.WriteLine("Faltou");
                break;

        }
    }
}
