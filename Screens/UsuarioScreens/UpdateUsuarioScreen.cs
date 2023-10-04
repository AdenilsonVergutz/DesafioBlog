using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBlog.Models;
using DesafioBlog.Repositories;

namespace DesafioBlog.Screens.UsuarioScreens
{
    public class UpdateUsuarioScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando um cadastro de usuário");
            Console.WriteLine("-------------");
            Console.Write("Código: ");
            var id = Console.ReadLine();

            Console.Write("Nome: ");
            var Nome = Console.ReadLine();

            Console.Write("Email: ");
            var  email = Console.ReadLine();

            Console.Write("senha: ");
            var senha = Console.ReadLine();

            Console.Write("Bio: ");
            var bio = Console.ReadLine();

            Console.Write("Imagem: ");
            var image = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Console.WriteLine("Código do perfil: ");
            var PerfilId = Console.ReadLine();



            Update(new Usuario
            {
                Id = int.Parse(id),
                Nome = Nome,
                Email = email,
                senha = senha,
                Bio = bio,
                Slug = slug,
                PerfilId = int.Parse(PerfilId)
            });
            Console.ReadKey();
            MenuUsuarioScreen.Load();
        }

        public static void Update(Usuario usuario)
        {
            try
            {
                var repository = new Repository<Usuario>(Database.Connection);
                repository.Update(usuario);
                Console.WriteLine("Usuário atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar o usuário desejado");
                Console.WriteLine(ex.Message);
            }
        }
    }
}