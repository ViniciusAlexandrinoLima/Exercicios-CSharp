//2 – Crie um algoritmo que verifique se um número informado é par ou impar
namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            ConfereImparPar();
        }

        static void ConfereImparPar()
            {
                Console.WriteLine("Digite um numero");
                int numero = Convert.ToInt16(Console.ReadLine());
                    if(numero % 2 == 0)
                    {
                        Console.WriteLine("É par!");
                    } else
                    {
                        Console.WriteLine("É Impar!");
                    }
            }
    }
}