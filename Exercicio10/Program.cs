using System;
using System.Runtime.Serialization;

public class Exercicio10
{
    public static void Main(string [] args)
    {
        int soma = 0;

        for (int contador = 0; contador <= 50; contador++)
        {
            if(contador %2 != 0)
            {
                soma += contador;
            }
            
        }
        Console.WriteLine(soma);
    }      
}
