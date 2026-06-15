using System;

public class Exercicio5
{
    public static void Main(string[] args)
    {
        int idade = 24;
        bool casado = true;

        if (idade < 18)
        {
            Console.WriteLine("És menor de idade.");
        }
        if (idade >= 18)
        {
              if (casado)
            {
                Console.WriteLine("És adulto e casado.");
            }
              else
            {
                Console.WriteLine("És adulto e solteiro.");
            }
        }
        else if (idade >= 65)
        {
            Console.WriteLine("És sénior.");
        }

    }
}