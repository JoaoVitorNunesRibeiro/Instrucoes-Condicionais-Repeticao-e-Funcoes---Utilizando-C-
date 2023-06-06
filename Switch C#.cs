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
                //condições, caso de tentativa de divisao por zero aparecerá a mensagem que esta entre aspas e em qualquer outra ocasião a divisão será feita normalmente
                if (double.IsNaN(resultado))
                {
                    Console.WriteLine("Erro: divisão por zero!");
                }
                else
                {
                    Console.WriteLine("O resultado é: " + resultado);
                } //aqui toda vez que o usuario responder a pergunta com "s" ou "S", vai fazer o programa repetir
Console.Write("Deseja fazer outro cálculo? (S/N): ");
                resposta = char.Parse(Console.ReadLine());
                Console.WriteLine();
            } while (resposta == 's' || resposta == 'S');
        }
    }
    //programa para fazer os calculos de adição, subtração, multiplicação e divisão.
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
                case '*':
                    return num1 num2;
                case '/':
                    if (num2 == 0) //condições, caso de tentativa de divisao por zero aparecerá a mensagem que esta entre aspas e em qualquer outra ocasião a divisão será feita normalmente
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
