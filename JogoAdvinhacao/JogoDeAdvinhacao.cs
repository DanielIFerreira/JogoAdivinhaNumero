using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoAdvinhacao
{
    class JogoDeAdvinhacao : LimparJogo
    {
        public string Nome { get; set; }

        public object NomeUsuario()
        {

            Console.WriteLine("....Digite seu nome....");
            Nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine("========================================");
            Console.WriteLine($"Olá {Nome}, escolha o nivel do jogo!");
            Console.WriteLine("========================================");
            Console.WriteLine("");
            return Nome;
        }
        public void Opcaojogo(int max, int tentativas)
        {

            int num, cont = 1, resultado;
            Console.WriteLine($"Escolha um número de 1 a {max}");
            var jogar = new Random();
            resultado = jogar.Next(1, max + 1);
            do
            {
                Console.WriteLine("Digite um número...!");
                num = Convert.ToInt32(Console.ReadLine());
                if (tentativas > cont)
                {
                    if (num == resultado)
                    {

                        Console.WriteLine($"....Parabéns {Nome} você acertou...!!!.");
                        break;
                    }

                    else if (num > resultado)
                    {
                        Console.WriteLine($"{Nome}, Você errou..!! O número deve ser menor.");
                        Console.WriteLine($"Tentativa {cont++}\\{tentativas}.");
                    }
                    else if (num < resultado)
                    {
                        Console.WriteLine($"{Nome}, Você errou...!! O número deve ser maior.");
                        Console.WriteLine($"Tentativa {cont++}\\{tentativas}.");
                    }
                }

                else
                {
                    Console.WriteLine($"Que pena {Nome}, suas chances acabaram!, O número sorteado é {resultado}.");
                    break;
                }


            } while (cont != tentativas + 1);
        }
    }
}
