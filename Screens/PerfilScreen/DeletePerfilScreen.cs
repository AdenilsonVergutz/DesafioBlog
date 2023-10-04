using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBlog.Models;
using DesafioBlog.Repositories;

namespace DesafioBlog.Screens.PerfilScreen
{
    public class DeletePerfilScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir um perfil");
            Console.WriteLine("-------------");
            Console.Write("Qual o código do perfil que deseja exluir? ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuPerfilScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Perfil>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Perfil exluída com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível exluir esse perfil");
                Console.WriteLine(ex.Message);
            }
        }
    }
}