using CRUD.Comandos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Cadastro : Form
    {
        CadastroUser cadastro = new CadastroUser();
        Login login = new Login();

        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastroUser_Click(object sender, EventArgs e)
        {
            try
            {
                cadastro.Cadastrousuario(txtNome.Text, txtSenha.Text);
                MessageBox.Show("Cadastro realizado!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                login.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Não foi possivel realizar o cadastro", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
