//10. Fazer um algoritmo para ler dois valores reais do teclado, calcular e imprimir na tela:
        //a) A soma destes valores   b) O produto deles    c) O quociente entre eles.
namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Calculos();
        }

        static void Calculos()
        {
            Console.WriteLine("Digite um numero");
            Double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite outro numero");
            Double numero2 = Convert.ToDouble(Console.ReadLine());

            double soma = numero1 + numero2;
            double multiplicacao = numero1 * numero2;
            double divisao = numero1 / numero2;

            Console.WriteLine("Soma entre: " + numero1 + " + " + numero2 + " = " + soma);
            Console.WriteLine("multiplicacao entre: " + numero1 + " + " + numero2 + " = " + multiplicacao);
            Console.WriteLine("divisao entre: " + numero1 + " + " + numero2 + " = " + divisao);
        }
    }
}