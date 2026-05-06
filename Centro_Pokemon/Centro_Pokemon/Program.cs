using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            while (opcao != 4) // Loop para exibir o menu até que o usuário escolha a opção de sair, != diferente 
            {

                Console.Clear(); // Limpa a tela do console para exibir o menu atualizado
                Console.ForegroundColor = ConsoleColor.Blue; // Define a cor do texto

                Console.WriteLine(@"
██████╗░░█████╗░██╗░░██╗███████╗███╗░░░███╗░█████╗░███╗░░██╗
██╔══██╗██╔══██╗██║░██╔╝██╔════╝████╗░████║██╔══██╗████╗░██║
██████╔╝██║░░██║█████═╝░█████╗░░██╔████╔██║██║░░██║██╔██╗██║
██╔═══╝░██║░░██║██╔═██╗░██╔══╝░░██║╚██╔╝██║██║░░██║██║╚████║
██║░░░░░╚█████╔╝██║░╚██╗███████╗██║░╚═╝░██║╚█████╔╝██║░╚███║
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░░░░╚═╝░╚════╝░╚═╝░░╚══╝");
                Console.ResetColor();
                Console.WriteLine("\n Seja bem-vindo ao Centro Pokémon!\n");

                Console.WriteLine("\n 1 - Cadastrar Pokémon");
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("\n 2 - Consultar Pokémon");
                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("\n 3 - Apagar Pokémon");
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("\n 4 - Sair");
                Console.ResetColor();

                opcao = int.Parse(Console.ReadLine());

                switch (opcao) // Estrutura de controle de fluxo para lidar com as opções do menu
                {
                    case 1: // Se o usuário escolher a opção 1, chama o método para cadastrar um Pokémon

                        break; // Encerra o programa


                    case 2:
                        break;


                    case 3:
                        break;


                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Obrigado por usar o Centro Pokémon! Até a próxima!");
                        System.Threading.Thread.Sleep(2000);
                        Console.ResetColor();
                        break;

                    default: // Caso o usuário digite uma opção inválida, exibe uma mensagem de erro
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        Console.ResetColor();
                        System.Threading.Thread.Sleep(2000); // Aguarda 2 segundos para que o usuário possa ler a mensagem antes de limpar a tela e exibir o menu novamente
                        break; // Encerra o programa
                }
            }





        }
    }
}
