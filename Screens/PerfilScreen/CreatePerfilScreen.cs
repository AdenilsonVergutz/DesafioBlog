using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBlog.Models;
using DesafioBlog.Repositories;

namespace DesafioBlog.Screens.PerfilScreen
{
    public class CreatePerfilScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo perfil");
            Console.WriteLine("-------------");
            Console.Write("Nome: ");
            var Nome = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Perfil
            {
                Nome = Nome,

            });
            Console.ReadKey();
            MenuPerfilScreen.Load();
        }

        public static void Create(Perfil Perfil)
        {
            try
            {
                var repository = new Repository<Perfil>(Database.Connection);
                repository.Create(Perfil);
                Console.WriteLine("Perfil cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar");
                Console.WriteLine(ex.Message);
            }
        }
    }
}