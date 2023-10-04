using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesafioBlog.Models;
using DesafioBlog.Repositories;
using Microsoft.Data.SqlClient;

namespace DesafioBlog.Formulario
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        public class UsuarioRepository : Repository<Usuario>
        {
            private readonly SqlConnection _connection;

            public UsuarioRepository(SqlConnection connection)
            : base(connection)
               => _connection = connection;

            private void idUsuarioTextBox_TextChanged(object sender, EventArgs e)
            {

            }

            private void slugLabel_Click(object sender, EventArgs e)
            {

            }
        }
    }
}
