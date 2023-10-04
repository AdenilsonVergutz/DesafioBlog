using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBlog.Models;
using DesafioBlog.Repositories;

namespace DesafioBlog.Screens.UsuarioScreens
{
    public class CreateUsuarioScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo Usuário");
            
            Console.WriteLine("-------------");
            Console.Write("Nome: ");
            var nome = Console.ReadLine();
            Console.Write("Email: ");
            var  email = Console.ReadLine();
            Console.Write("senha: ");
            var senha = Console.ReadLine();
            Console.Write("Bio: ");
            var bio = Console.ReadLine();
            Console.Write("Slug: ");
            var slug = Console.ReadLine();
            Console.WriteLine("Informe o perfil que deseja vincular com esse usuário: ");
            var PerfilId = Console.ReadLine();


            Create(new Usuario
            {
                Nome = nome,
                Email = email,
                senha = senha,
                Bio = bio,
                Slug = slug,
                PerfilId = int.Parse(PerfilId)

            });
            Console.ReadKey();
            MenuUsuarioScreen.Load();
        }

        public static void Create(Usuario Usuario)
        {
            try
            {
                var repository = new Repository<Usuario>(Database.Connection);
                repository.Create(Usuario);
                Console.WriteLine("Usuário cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar o usuário");
                Console.WriteLine(ex.Message);
            }
        }
    }
}