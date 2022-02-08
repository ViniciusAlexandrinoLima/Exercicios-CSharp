//8.   Ler dois números inteiros, X e Y, e imprimir o quociente e o resto da divisão inteira entre eles.
namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            quocienteErestoDivisao();
        }

        static void quocienteErestoDivisao()
        {
            Console.WriteLine("Digite um numero: ");
            Console.WriteLine("Digite outro numero: ");

            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if(numero1 == 0 && numero2 == 0)
            {
                Console.WriteLine("Digite um numero valido");
            } else 
            {
                Console.WriteLine($"Numero quociente:{numero1 / numero2}");
                Console.WriteLine($"Resto da divisão: {numero1 % numero2}");
            }
        }
    }
}