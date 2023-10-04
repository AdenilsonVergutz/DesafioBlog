using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBlog.Models;
using DesafioBlog.Repositories;

namespace DesafioBlog.Screens.PerfilScreen
{
    public class ListPerfilScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de perfil");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuPerfilScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Perfil>(Database.Connection);
            var Perfil = repository.Get();
            foreach (var item in Perfil)
                Console.WriteLine($"Código: {item.Id} - {item.Nome} )");
        }
    }
}