//3 – Faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos. O algoritmo deverá ler a idade de 10 pessoas.
namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            maiorOuMenorIdade();
        }

        static void maiorOuMenorIdade()
        {
            int idadeMaior = 18;
        
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Digite sua idade");
                int idade = Convert.ToInt32(Console.ReadLine());
                if(idade >= idadeMaior) {
                    Console.WriteLine("pode entrar!");
                } else {
                    Console.WriteLine("Não pode entrar!");
                }
            }
        }
    }
}