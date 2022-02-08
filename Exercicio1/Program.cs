//1 – Elabore um algoritmo que calcule a idade média de 5 alunos.
namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite 5 idades");

            int idade1 = Convert.ToInt16(Console.ReadLine());
            int idade2 = Convert.ToInt16(Console.ReadLine());
            int idade3 = Convert.ToInt16(Console.ReadLine());
            int idade4 = Convert.ToInt16(Console.ReadLine());
            int idade5 = Convert.ToInt16(Console.ReadLine());

            int media = (idade1 + idade2 + idade3 + idade4 + idade5) / 5;

            Console.WriteLine($"A idade média é: {media}");
            Console.ReadKey();
        }
    }
}
