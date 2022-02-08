// 9 Ler dois números inteiros, X e Y, e apresentar mensagem informando se o X é múltiplo de Y.
namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Multiplo();
        }

        static void Multiplo()
        {
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if(numero1 % numero2 == 0)
            {
                Console.WriteLine("È multiplo");
            }
            else
            {
                Console.WriteLine("Não é multiplo");
            }
        }
    }
}