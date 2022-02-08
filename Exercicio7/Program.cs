//7 - Calcular a quantidade de dinheiro gasta por um fumante. Dados: o número de anos que ele fuma, o nº de cigarros fumados por dia e o preço de uma carteira.
namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Calcular();
        }

        static void Calcular()
        {
            Console.Clear();
            Console.WriteLine("Digite quantos anos você fuma");
            int anos = Convert.ToInt32(Console.ReadLine());

            int cigarros = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite quantos cigarros você fuma por dia");

            Console.WriteLine("Digite qual o valor do cigarro");
            double valor = Convert.ToDouble(Console.ReadLine());
            
            if (valor > 0)
                {
                    double soma = (365 * anos * cigarros / 20) * valor;
                    Console.Write("Você gastou R$" + soma + ",00 com cigarros.");
                }
                else
                {
                    Console.WriteLine("Você digitou o valor do maço de cigarros errado.");
                }
        }
    }
}