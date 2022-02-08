// 11 Calcular a média final  (nota bimestre 1 + bimestre 2 +  bimestre3 dividido por 3 )dadas as  notas dos 4 bimestres e produzir uma saída com a média e a situação do aluno de acordo com o seguinte critério: média >=6, aprovado; média < 6, reprovado.
namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            calculoMedia();
        }

        static void calculoMedia()
    {
        Console.WriteLine("Digite a nota1:");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a nota2:");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a nota3:");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        double soma = (nota1 + nota2 + nota3) / 3;

        if(soma >= 6)
        {
            Console.WriteLine("A média foi: " + soma + "Aluno Aprovado!");
        }
        else
        {
            Console.WriteLine("A média foi: " + soma + "Aluno Reprovado!");
        }
    }

    }
}