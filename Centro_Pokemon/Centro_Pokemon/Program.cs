using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
                Console.ForegroundColor= ConsoleColor.White;
                Console.Write("\n Escolha uma opção: ");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());  

                switch (opcao) // Estrutura de controle de fluxo para lidar com as opções do menu
                {
                    case 1: // Se o usuário escolher a opção 1, chama o método para cadastrar um Pokémon
                        cadastroPokemon(); // abre a funçao
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

            static void cadastroPokemon() // Método para cadastrar um Pokémon
            {
                Console.Clear();
                Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░\n");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write("Digite o nome do Pokémon: ");
                string nome = Console.ReadLine(); // armazena a variável "nome"

            
            Console.Write("Digite o tipo do Pokémon: ");
                string tipo = Console.ReadLine();

           
            Console.Write("Digite a altura do Pokémon (em metros): ");
                double altura = double.Parse(Console.ReadLine()); // Converte a entrada do usuário para um número decimal 

           
            Console.Write("Digite o peso do Pokémon (em kg): ");
                double peso = double.Parse(Console.ReadLine());

            // fraqueza do Pokémon

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite as fraquezas do Pokémon : ");
            int qtdFraquezas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdFraquezas; i++)
            { // Loop para ler as fraquezas do Pokémon, começando de 1 até a quantidade de fraquezas informada pelo usuário
                Console.Write($"Fraqueza {i}: ");
                string fraquezaPokemon = Console.ReadLine();
            }



            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Quantas Evoluções ele tem? : ");
            int qtdEvolucao = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= qtdEvolucao; i++)
            { // Loop para ler as fraquezas do Pokémon, começando de 1 até a quantidade de fraquezas informada pelo usuário
                Console.Write($"Evolução: {i}: ");
                string qtdpokemon = Console.ReadLine();
            }
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine("\n Pokémon cadastrado com sucesso!"); // Exibe uma mensagem de sucesso após o cadastro do Pokémon
            Thread.Sleep(2000); // Aguarda 2 segundos para que o usuário possa ler a mensagem antes de limpar a tela e exibir o menu novamente
            Console.ResetColor();

            
        }
        
    }
}
