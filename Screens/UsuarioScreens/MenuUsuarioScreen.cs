using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBlog.Screen;
using DesafioBlog.Screens.UsuarioScreens;

namespace DesafioBlog.Screens.UsuarioScreens
{
    public static class MenuUsuarioScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Usuários");
            Console.WriteLine("--------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Usuários");
            Console.WriteLine("2 - Cadastrar Usuário");
            Console.WriteLine("3 - Atualizar Usuário");
            Console.WriteLine("4 - Excluir Usuário");
            Console.WriteLine();
            Console.WriteLine("5 - Sair");

            var option = short.Parse(Console.ReadLine()!);


            switch (option)
            {
                case 1:
                    ListUsuarioScreen.Load();
                    break;
                case 2:
                    CreateUsuarioScreen.Load();
                    break;
                 case 3:
                    UpdateUsuarioScreen.Load();
                    break;
                case 4:
                    DeleteUsuarioScreen.Load();
                    break;
                 case 5:
                    Program.Load();
                    break;
                default: Load(); break;

            }
        }
    }
}