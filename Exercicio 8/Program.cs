using System;
using System.Data.SqlTypes;

public class Exercicio_8
{
    public static void Main(string[] args)
    {
        int nota = 19;
        switch (nota)
        {
            case int n when (nota > 20 || nota < 0):
            Console.WriteLine("Nota invalida");
                break;
            case int n when (nota >= 17):
                Console.WriteLine("Excelente");
                break;

            case int n when (nota >= 14):
                Console.WriteLine("Bom");
                break;

            case int n when (nota >= 12):
                Console.WriteLine("Suficiente");
                break;

            case int n when (nota >= 7):
                Console.WriteLine("Insuficiente");
                break;

            default:
                Console.WriteLine("Nota invalida");
                break;

        }
    }
}
