// 17 - Ler três valores e determinar o maior dentre eles.
namespace Exercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            MaiorValorEntreTres();
            
        }

    static void MaiorValorEntreTres()
    {
        Console.WriteLine("Digite um valor");
        int valor1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite outro valor");
        int valor2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite mais um valor");
        int valor3 = Convert.ToInt32(Console.ReadLine());

        if(valor1 > valor2 && valor1 > valor3)
        {
            Console.WriteLine("O primeiro valor é maior!");
        }
        else if(valor2 > valor1 && valor2 > valor3)
        {
            Console.WriteLine("O segundo valor é maior!");
        }
        else if(valor3 > valor1 && valor3 > valor2)
        {
            Console.WriteLine("O terceiro valor é maior!");
        }
        else 
        {
            Console.WriteLine("Os valores são iguais");
        }
    }

    }
}