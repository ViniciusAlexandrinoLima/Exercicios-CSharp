// 15 Ler 02 números inteiros do teclado. Se o segundo for diferente de zero, calcular e imprimir o quociente do primeiro pelo segundo. Caso contrário, imprimir a mensagem: "DIVISÃO POR ZERO".
namespace Exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Quociente();
        }

        static void Quociente()
        {
            Console.WriteLine("Digite um numero:");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro numero:");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if(numero2 != 0)
            {
                int calcular = numero1 % numero2;
                Console.Write($"quociente: {calcular}"); 
            }
            else
            {
                Console.WriteLine("DIVISÂO POR ZERO");
            }
        }
    }
}