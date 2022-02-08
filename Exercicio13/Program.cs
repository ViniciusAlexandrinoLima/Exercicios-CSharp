//13 Ler um nome do teclado e verificar se é igual ao seu nome. Imprimir conforme o caso: " NOME CORRETO "  ou  " NOME INCORRETO ".
namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            VerificarNome();
        }

        static void VerificarNome()
        {
            Console.WriteLine("Digite seu nome:");
            string? nome = Convert.ToString(Console.ReadLine());

            if(nome == "Vinicius")
            {
                Console.WriteLine("NOME CORRETO");
            }
            else
            {
                Console.WriteLine("NOME INCORRETO");
            }
        }
    }
}