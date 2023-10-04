using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBlog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace DesafioBlog.Repositories
{
    public class UsuarioRepository : Repository<Usuario>
    {
        private readonly SqlConnection _connection;

        public UsuarioRepository(SqlConnection connection)
        :base(connection)
           => _connection = connection;

    public List<Usuario> GetWithPerfils()
    {
        var query = @"
        SELECT
            [Usuario].*,
            [Perfil].*
        FROM    [Usuario]
                LEFT JOIN UsuarioPerfil ON UsuarioPerfil.UsuarioId = [Usuario].[Id]
                LEFT JOIN Perfil ON UsuarioPerfil.PerfilId = Perfil.Id";

        var usuarios = new List<Usuario> ();

        var items = _connection.Query<Usuario, Perfil, Usuario>(
            query, 
            (usuario, perfil) =>
            {
                var usr = usuarios.FirstOrDefault(x => x.Id == usuario.Id);
                if (usr == null)
                {
                    usr = usuario;
                    if(perfil != null)
                        usr.Perfils.Add(perfil);
                        
                    usuarios.Add(usr);
                }
                else
                    usr.Perfils.Add(perfil);

                return usuario;
            }, splitOn: "Id");

        return usuarios;
    }
    
    }
}