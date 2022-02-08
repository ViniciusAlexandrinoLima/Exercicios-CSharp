//12 Fazer um algoritmo para ler 03 números reais do teclado e verificar se o primeiro é maior que a soma dos outros dois.
namespace Exercicio12
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
        Console.WriteLine("Digite um numero: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite outro numero: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite mais um numero: ");
        double numero3 = Convert.ToDouble(Console.ReadLine());

        double soma = numero2 + numero3;

        if(numero1 > soma)
        {
            Console.WriteLine("O primeiro numero: " + numero1 + " é maior que o valor da soma: " + soma);
        } 
        else 
        {
            Console.WriteLine("O primeiro numero digitado não é maior. " + " Soma: " + soma);
        }
    }

    }
}