using System;

namespace Calculator
{   //quando criamos a classe de alguma coisa, inserimos os elementos/variaveis e como irá funcionara, ou seja, o método.
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            char resposta;
            do
            {   //interface pro usuario inserir dois valores e um operador
                double num1, num2, resultado;
                char operador;

                Console.Write("Entre com o primeiro valor: ");
                num1 = double.Parse(Console.ReadLine());

                Console.Write("Entre com o operador (+, -, *, /): ");
                operador = char.Parse(Console.ReadLine());

                Console.Write("Entre com o segundo valor: ");
                num2 = double.Parse(Console.ReadLine());

                resultado = calculator.Calculate(num1, num2, operador);

                if (double.IsNaN(resultado))
                {
                    Console.WriteLine("Erro: divisão por zero!");
                }
                else
                {
                    Console.WriteLine("O resultado é: " + resultado);
                }
Console.Write("Deseja fazer outro cálculo? (S/N): ");
                resposta = char.Parse(Console.ReadLine());
                Console.WriteLine();
            } while (resposta == 's' || resposta == 'S');
        }
    }

    class Calculator
    {
        public double Calculate(double num1, double num2, char operador)
        {
            switch (operador)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '':
                    return num1 num2;
                case '/':
                    if (num2 == 0)
                    {
                        return double.NaN;
                    }
                    else
                    {
                        return num1 / num2;
                    }
                default:
                    throw new ArgumentException("Operador inválido!");
            }
        }
    }
} 
