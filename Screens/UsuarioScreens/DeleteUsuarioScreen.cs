using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBlog.Models;
using DesafioBlog.Repositories;

namespace DesafioBlog.Screens.UsuarioScreens
{
    public class DeleteUsuarioScreen
    {

        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir um cadastro de usuário");
            Console.WriteLine("-------------");
            Console.Write("Qual o código do Usuário que deseja exluir? ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuUsuarioScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Usuario>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Usuário exluído com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível exluir  o usuário");
                Console.WriteLine(ex.Message);
            }
        }
    }
}