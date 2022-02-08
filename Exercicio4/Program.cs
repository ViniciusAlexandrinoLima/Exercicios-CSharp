// 4 - Faça um algoritmo que calcule e exiba o salário reajustado de dez funcionários de acordo com a seguinte regra: Salário até 300, reajuste de 50%; Salários maiores que 300, reajuste de 30%.
namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            ConfereSalario();
        }

        static void ConfereSalario()
        {
            Console.Clear();
            for(int i = 0; i <= 10; i++) {
            Console.WriteLine("Digite o seu salario");
            double salario = Convert.ToInt32(Console.ReadLine());

            if(salario <= 300) 
            {
                double percentual = 50.0 / 100.0;
                double salarioAtualizado = salario + (percentual * salario);
                Console.WriteLine(salarioAtualizado);
            } else 
            {
                double percentual = 30.0 / 100.0;
                double salarioAtualizado = salario + (percentual * salario);
                Console.WriteLine(salarioAtualizado);
            }
        }

        }
    }
}