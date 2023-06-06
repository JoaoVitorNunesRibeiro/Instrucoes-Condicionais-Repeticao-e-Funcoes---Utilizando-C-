using System;

class Program {
    static void Main() {
        int num;
        // pede valores inteiros e positivos para o usuário inserir 
        Console.Write("Digite um número inteiro positivo: ");
        num = int.Parse(Console.ReadLine());
        // resposta para o usuário
        Console.Write("Os primeiros " + num + " números pares são: ");
        // for tem função de inicialização, condição e atualização
        for (int i = 2; i <= num * 2; i += 2) {
            Console.Write(i + " ");
        }
    }
}
