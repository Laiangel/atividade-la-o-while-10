using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");

        // Lê o número informado pelo usuário
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            // Lida com números negativos
            numero = Math.Abs(numero);

            int contador = 0;

            // Verifica quantos dígitos o número possui
            do
            {
                contador++;
                numero /= 10; // Remove o último dígito
            } while (numero > 0);

            Console.WriteLine($"O número possui {contador} dígito(s).");
        }
        else
        {
            Console.WriteLine("Por favor, insira um número inteiro válido.");
        }
    }
}

