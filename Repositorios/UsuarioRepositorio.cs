using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiagoSantinParussolo_d3_avaliacao.Interfaces;
using ThiagoSantinParussolo_d3_avaliacao.Models;
using System.Data.SqlClient;

namespace ThiagoSantinParussolo_d3_avaliacao.Repositorios
{
    internal class UsuarioRepositorio : IUsuario
    {
        private readonly string stringConexao = "Server=labsoft.pcs.usp.br; Initial Catalog=db_25; User id=usuario_25; pwd=61266348379;";

        public List<Usuario> GetUsuarios()
        {
            List<Usuario> listaUsuarios = new();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelect = "SELECT * FROM Usuarios";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelect, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Usuario uu = new()
                        {
                            Id = rdr[0].ToString(),
                            Nome = rdr[1].ToString(),
                            Email = rdr[2].ToString(),
                            Senha = rdr[3].ToString()
                        };

                        listaUsuarios.Add(uu);
                    }
                }
            }
            return listaUsuarios;
        }

        public void PegaDados(Usuario user)
        {

        }

    }
}

