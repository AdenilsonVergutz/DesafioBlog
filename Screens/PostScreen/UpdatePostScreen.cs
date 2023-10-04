using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBlog.Models;
using DesafioBlog.Repositories;

namespace DesafioBlog.Screens.PostScreen
{
    public class UpdatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando o Post");
            Console.WriteLine("-------------");
            Console.Write("Qual o código do post que deseja atualizar?: ");
            var id = Console.ReadLine();

            Console.Write("Nome: ");
            var CategoriaId = Console.ReadLine();

            Console.Write("Email: ");
            var  authorId = Console.ReadLine();

            Console.Write("senha: ");
            var Titulo = Console.ReadLine();

            Console.Write("Bio: ");
            var summary = Console.ReadLine();

            Console.Write("Imagem: ");
            var body = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();
            
            Console.Write("Tag: ");
            var tagId = Console.ReadLine();

            

            Update(new Post
            {
                Id = int.Parse(id),
                CategoriaId = int.Parse(CategoriaId),
                AuthorId = int.Parse(authorId),
                Titulo = Titulo,
                Summary = summary,
                Body = body,
                Slug = slug,
                TagId = int.Parse(tagId)
            });
            Console.ReadKey();
            MenuPostScreen.Load();
        }

        public static void Update(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Update(post);
                Console.WriteLine("Post atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar");
                Console.WriteLine(ex.Message);
            }
        }
    }
}