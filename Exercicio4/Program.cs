using System;

public class Exercicio4
{
    public static void Main(string[] args)
    {
        int idade = 19;

        if (idade < 11) 
        {
            Console.WriteLine("És uma criança.");
        }
        else if (idade >= 11 && idade < 18) 
        {
            Console.WriteLine("És um adolescente.");
        }
        else
        {
            Console.WriteLine("Já és um adulto.");
        }

}   }