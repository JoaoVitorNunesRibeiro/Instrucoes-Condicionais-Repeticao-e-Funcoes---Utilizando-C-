using System;

class Program
{
    static void Main(string[] args)
    {
        int num;

        do
        {
            Console.Write("Digite um número entre 1 e 10: ");
            num = Convert.ToInt32(Console.ReadLine());
        } while (num < 1 || num > 10);

        Console.WriteLine("Você digitou o número " + num + ".");
    }
}