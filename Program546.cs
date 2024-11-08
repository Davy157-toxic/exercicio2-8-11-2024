using System;
public class D22
{
    //exeercicio2
    public static void Main(string[] args)
    {
        int soma = 0;
        for (int i = 1; i < 50; i++)
        {
            if (i % 2 != 0)
            {
                soma = soma + i;
            }
        }
        Console.WriteLine("total é " + soma);
    }
}    
