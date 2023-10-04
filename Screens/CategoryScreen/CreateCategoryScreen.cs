using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBlog.Models;
using DesafioBlog.Repositories;

namespace DesafioBlog.Screens.CategoryScreen
{
    public class CreateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova Categoria");
            Console.WriteLine("-------------");
            Console.Write("Nome: ");
            var Nome = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Categoria
            {
                Nome = Nome,

            });
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void Create(Categoria category)
        {
            try
            {
                var repository = new Repository<Categoria>(Database.Connection);
                repository.Create(category);
                Console.WriteLine("Categoria cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar essa categoria");
                Console.WriteLine(ex.Message);
            }
        }
    }
}