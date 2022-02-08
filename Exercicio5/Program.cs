// 5 – Faça um algoritmo que leia a altura e a matricula de dez aluno. Mostre a matricula do aluno mais alto e do aluno mais baixo.
namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura1,alturaSave1,alturaSave2;
            int matricula1,i1,matriculaDoMaisAlto,matriculaDoMaisBaixo;

            alturaSave1=0;
            alturaSave2=999;
            matriculaDoMaisBaixo=0;
            matriculaDoMaisAlto=0;

            for(i1=0;i1<3;i1++)
            {
                Console.WriteLine("Digite altura:");
                altura1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a matricula:");
                matricula1 = Convert.ToInt16(Console.ReadLine());

            if(altura1>alturaSave1)
                {
                    alturaSave1 = altura1;
                    matriculaDoMaisAlto = matricula1;
                }

                if(altura1<alturaSave2)
                {
                    alturaSave2 = altura1;
                    matriculaDoMaisBaixo = matricula1;
                }

                Console.Clear();

            }

                Console.WriteLine("Matricula:"+matriculaDoMaisBaixo);
                Console.WriteLine("Matricula:"+matriculaDoMaisAlto);

                Console.ReadKey();
                Console.Clear();
        }
    }
}