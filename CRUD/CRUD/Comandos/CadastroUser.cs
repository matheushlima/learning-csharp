using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Comandos
{
    class CadastroUser
    {
        public string Nome { get; set; }
        public string Senha { get; set; }

        MySqlConnection conexao = new MySqlConnection("server = localhost; User ID = root; database = estudo; password = root;");
        string insert = "insert into usuario (NOME, SENHA) VALUES (@nome, @senha)";
        
        public void Cadastrousuario(string nome, string senha)
        {
            conexao.Open();
            MySqlCommand cmdinsert = new MySqlCommand(insert, conexao);
            cmdinsert.Parameters.Add(new MySqlParameter("@nome", nome));
            cmdinsert.Parameters.Add(new MySqlParameter("@senha", senha));
            Nome = nome;
            Senha = senha;
            cmdinsert.ExecuteNonQuery();
        }
        
    }
}
