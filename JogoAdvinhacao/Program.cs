using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoAdvinhacao
{
    class Program
    {
        static void Main(string[] args)
        {
            char valor;

            do
            {

                Console.WriteLine("***Jogo de Adivinhação***");
                Console.WriteLine("==========================");

                int opcao;
                JogoDeAdvinhacao usuario = new JogoDeAdvinhacao();
                usuario.NomeUsuario();

                Console.WriteLine("Nível 1- números de 1 a 20, com 5 chances para acertar. ");
                Console.WriteLine("Nível 2- números de 1 a 40, com 10 chances para acertar. ");
                opcao = Convert.ToInt32(Console.ReadLine());
                usuario.Limpar();

                if (opcao == 1)
                {
                    usuario.Opcaojogo(20, 5);
                }
                else if (opcao == 2)
                {
                    usuario.Opcaojogo(40, 10);
                }
                else
                {
                    Console.WriteLine("Número inválido!");
                }

                Console.WriteLine("Deseja jogar novamente? (S\\N).");
                valor = Convert.ToChar(Console.ReadLine().ToUpper());
                usuario.Limpar();

            } while (valor == 'S');
        }
    }
}
