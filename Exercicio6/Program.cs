// 6 - Leia um número e exiba o seu sucessor.
namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            NumeroSucessor();
        }

        static void NumeroSucessor()
        {
            Console.WriteLine("Digite um numero:");
            int numero = Convert.ToInt16(Console.ReadLine());
            numero = numero + 1;
            Console.WriteLine(numero);
        }
    }
}