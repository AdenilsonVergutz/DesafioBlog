using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBlog.Screens.PerfilScreen
{
    public class MenuPerfilScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Perfil");
            Console.WriteLine("--------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar");
            Console.WriteLine("2 - Cadastrar");
            Console.WriteLine("3 - Atualizar");
            Console.WriteLine("4 - Excluir");
            Console.WriteLine();
            Console.WriteLine("5 - Sair");

            var option = short.Parse(Console.ReadLine()!);


            switch (option)
            {
                case 1:
                    ListPerfilScreen.Load();
                    break;
                case 2:
                    CreatePerfilScreen.Load();
                    break;
                case 3:
                    UpdatePerfilScreen.Load();
                    break;
                case 4:
                    DeletePerfilScreen.Load();
                    break;
                case 5:
                    Program.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}