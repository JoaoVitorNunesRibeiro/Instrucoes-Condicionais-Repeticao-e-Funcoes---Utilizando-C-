using System;
//quando criamos a classe de alguma coisa, inserimos os elementos/variaveis e como irá funcionara, ou seja, o método.
class Program
{
    static void Main(string[] args)
    {
        int num;
        // do while pede pro programa fazer uma ação enquanto outra for verdadeira
        do
        {   //pede pro usuário inserir um numero entre 1 e 10
            Console.Write("Digite um número entre 1 e 10: ");
            num = Convert.ToInt32(Console.ReadLine());
        } while (num < 1 || num > 10);
        //mostra pro usuario o numero que o mesmo digitou
        Console.WriteLine("Você digitou o número " + num + ".");
    }
}
