using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBlog.Models;
using DesafioBlog.Repositories;

namespace DesafioBlog.Screens.PostScreen
{
    public class ListPostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Post cadastrados");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuPostScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Post>(Database.Connection);
            var posts = repository.Get();
            foreach (var item in posts)
                Console.WriteLine($"Código: {item.Id} - {item.Titulo} - {item.CategoriaId} - {item.AuthorId} - {item.Summary} - {item.Body} -  {item.Slug} - {item.TagNome} - {item.CreateDate} - {item.LastUpdateDate}");
        }
    }
}