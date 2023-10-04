using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBlog.Screens.TagScreens;

namespace DesafioBlog.Screens.TagScreens
{
    public static class MenuTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Tagas");
            Console.WriteLine("--------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar tags");
            Console.WriteLine("2 - Cadastrar tags");
            Console.WriteLine("3 - Atualizar Tag");
            Console.WriteLine("4 - Excluir Tag");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("5 - Sair");
            Console.ReadLine();

            var option = short.Parse(Console.ReadLine()!);


            switch (option)
            {
                case 1:
                    ListTagScreen.Load();
                    break;
                case 2:
                    CreateTagScreen.Load();
                    break;
                case 3:
                    UpdateTagScreen.Load();
                    break;
                case 4:
                    DeleteTagScreen.Load();
                    break;
                case 5 :
                    Program.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}