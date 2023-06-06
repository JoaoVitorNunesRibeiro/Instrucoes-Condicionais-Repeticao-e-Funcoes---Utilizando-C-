using System;
//quando criamos a classe de alguma coisa, inserimos os elementos/variaveis e como irá funcionara, ou seja, o método.
class Program
{   //calculo de adição
    static double Somar(double a, double b)
    {
        return a + b;
    }
    //calculo subtração
    static double Subtrair(double a, double b)
    {
        return a - b;
    }
    //calculo de multiplicação
    static double Multiplicar(double a, double b)
    {
        return a * b;
    }
    //calculo de divisão
    static double Dividir(double a, double b)
    {   //condições, caso de tentativa de divisao por zero aparecerá a mensagem que esta entre aspas e em qualquer outra ocasião a divisão será feita normalmente
        if (b == 0)
        {
            Console.WriteLine("Erro: divisão por zero!");
            return 0;
        }
        else
        {
            return a / b;
        }
    }
    //colocando valores para variaveis x e y
    static void Main(string[] args)
    {
        double x = 4;
        double y = 8;
        //interface que vai apresentar os resultados dos calculos
        double resultado = Somar(x, y);
        Console.WriteLine(x + " + " + y + " = " + resultado);

        resultado = Subtrair(x, y);
        Console.WriteLine(x + " - " + y + " = " + resultado);

        resultado = Multiplicar(x, y);
        Console.WriteLine(x + " * " + y + " = " + resultado);

        resultado = Dividir(x, y);
        Console.WriteLine(x + " / " + y + " = " + resultado);

        //imprime o código
        Console.ReadKey();
    }
}
