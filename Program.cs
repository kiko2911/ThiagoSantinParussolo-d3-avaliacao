using ThiagoSantinParussolo_d3_avaliacao.Models;
using ThiagoSantinParussolo_d3_avaliacao.Interfaces;
using ThiagoSantinParussolo_d3_avaliacao.Repositorios;
using System;

namespace ThiagoSantinParussolo_d3_avaliacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            string email;
            string senha;
            UsuarioRepositorio U1 = new();
            LogRepositorio R1 = new();

            do
            {
                Console.WriteLine("Ola! Voce quer: 1 - Acessar ou 2 - Cancelar\n");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("\nEmail: ");
                        email = Console.ReadLine();
                        Console.WriteLine("\nSenha: ");
                        senha = Console.ReadLine();

                        var lista = U1.GetUsuarios();
                        foreach(var usuario in lista)
                        {
                            if (usuario.Email == email && usuario.Senha == senha)
                            {
                                Console.WriteLine("\nSeja bem-vindo\n");
                                string path = "database/usuarios.csv";
                                R1.FazerArquivo(usuario, path);
                                

                                Console.WriteLine("E agora, o que voce deseja fazer? 1- deslogar ou 2 - encerrar: ");
                                opcao = Console.ReadLine();
                                
                            }
                            else
                            {
                                Console.WriteLine("\nTente novamente");
                                goto case "1";
                            }
                                
                        }

                        break;

                    default: break;
                }

            } while (opcao != "2");
        }
    }
}