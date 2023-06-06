using System;
//quando criamos a classe de alguma coisa, inserimos os elementos/variaveis e como irá funcionara, ou seja, o método.
class Program
{
    static void Main(string[] args)
    {
        int num, i = 1;
        //pede pro usuario inserir um numero inteiro positivo
        Console.Write("Digite um numero inteiro positivo: ");
        num = int.Parse(Console.ReadLine());

        while (i <= num)
        {
            Console.Write(i + " ");
            i++;
        }

        Console.ReadLine();
    }
}
