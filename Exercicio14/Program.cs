// 14 - Ler 02 números reais do teclado (A e B), verificar e imprimir qual deles é o maior, ou a mensagem "A = B" caso sejam iguais.
namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            VerificarNumero();
        }

        static void VerificarNumero()
        {
            Console.WriteLine("Digite um numero: ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite outro numero: ");
            double B = Convert.ToDouble(Console.ReadLine());

            if(A == B)
            {
                Console.WriteLine("Os numeros são iguais.");
            }
            else if(A > B)
            {
                Console.WriteLine("O numero " + A + " É maior.");
            }
            else if(B > A)
            {
                Console.WriteLine("O numero: " + B + " É maior");
            }
        }
    }
}
