//16 -  Ler 4 números inteiros e calcular a soma dos que forem par.
namespace Exercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            SomaNumeroInteiro();
        }

        static void SomaNumeroInteiro()
        {
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite 4 numeros");
                int numero = Convert.ToInt32(Console.ReadLine());
                if(numero % 2 == 0)
                {
                    int soma = numero + numero;
                    Console.WriteLine($"O numero digitado é par, então a soma é: {soma}");
                } else
                {
                    Console.WriteLine("O numero digitado não é par.");
                }
            }
        }
    }
}