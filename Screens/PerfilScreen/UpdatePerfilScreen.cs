using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBlog.Models;
using DesafioBlog.Repositories;

namespace DesafioBlog.Screens.PerfilScreen
{
    public class UpdatePerfilScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando um perfil");
            Console.WriteLine("-------------");
            Console.Write("Código: ");
            var id = Console.ReadLine();

            Console.Write("Nome: ");
            var Nome = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(new Perfil
            {
                Id = int.Parse(id),
                Nome = Nome,
            });
            Console.ReadKey();
            MenuPerfilScreen.Load();
        }

        public static void Update(Perfil Perfil)
        {
            try
            {
                var repository = new Repository<Perfil>(Database.Connection);
                repository.Update(Perfil);
                Console.WriteLine("Perfil atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar");
                Console.WriteLine(ex.Message);
            }
        }
    }
}