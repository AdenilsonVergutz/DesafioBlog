using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBlog.Models;
using DesafioBlog.Repositories;
using DesafioBlog.Screens.UsuarioScreens;

namespace DesafioBlog.Screen

{
    public class ListUsuarioScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de usuários cadastrados");
            Console.WriteLine("-------------------------------");
            List();
            Console.ReadKey();
            MenuUsuarioScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Usuario>(Database.Connection);
            var usuarios = repository.Get();
            Console.WriteLine("Código   ---   Nome     ---    Email      --         Perfil             ");
            Console.WriteLine("");

            foreach (var item in usuarios)
                
            Console.WriteLine($"  {item.Id} - {item.Nome} - {item.Email}  - ({item.PerfilId} - {item.PerfilNome}) ");
        }
    }
}