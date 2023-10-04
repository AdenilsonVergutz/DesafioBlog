using System;
using DesafioBlog;
using DesafioBlog.Models;
using DesafioBlog.Repositories;
using DesafioBlog.Screens.TagScreens;

namespace DesafioBlog.Screens.TagScreens
{
    public static class CreateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova tag");
            Console.WriteLine("-------------");
            Console.Write("Nome: ");
            var Nome = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();
            Console.ReadLine();

            Create(new Tag
            {
                Nome = Nome
            });
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Create(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Create(tag);
                Console.WriteLine("Tag cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}