using System;

public class Exercicio6
{
    public static void Main(string[] args)
    {
        int diasemana = 4;

        switch (diasemana)
        {
            case 1:
                Console.WriteLine("Segunda-feira");
                break;

            case 2:
                Console.WriteLine("Terça-feira");
                break;

            case 3:
                Console.WriteLine("Quarta-feira");
                break;

            case 4:
                Console.WriteLine("Quinta-feira");
                break;

            case 5:
                Console.WriteLine("Sexta-feira");
                break;

            case 6:
                Console.WriteLine("Sábado");
                break;

            case 7:
                Console.WriteLine("Domingo");
                break;

            default:
                Console.WriteLine("Outro dia");
                break;

        }
    }
}