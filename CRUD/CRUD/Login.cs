using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD
{
    public partial class Login : Form
    {
        Form1 principal = new Form1();
        Cadastro cadastro = new Cadastro();
        
        MySqlConnection conexao = new MySqlConnection("server = localhost; User ID = root; database = estudo; password=root");

        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            conexao.Open();
            string selectUsuario = "SELECT nome_usuario, senha from usuario;";
            MySqlCommand cmdselect = new MySqlCommand(selectUsuario, conexao);
            MySqlDataReader select = cmdselect.ExecuteReader();
            while (select.Read())
            {
                if (select["nome_usuario"].ToString() == tbNome.Text && select["senha"].ToString() == tbSenha.Text)
                {
                    principal.Show();
                    this.Hide();
                }
            }
            
            

        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            //cadastro.Show();
            //this.Hide();
        }
    }
}
