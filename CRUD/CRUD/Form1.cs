using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD
{
    public partial class Form1 : Form
    {
        //Conexão com o banco
        
        MySqlConnection conexao = new MySqlConnection("server=localhost;User Id=root;database=estudo; password=root");
        string selectaluno = "SELECT* FROM aluno";
        string sucesso = "Conexão OK";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            label1.Text = "";
            lblDescbanco.Text = "";

            btnDesconectar.Enabled = false;

            txtID.Enabled = false;
        }

        //Botão para conectar com o banco
        private void btnCon_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                label1.Text = sucesso;
                label1.BackColor = Color.Chartreuse;
                lblDescbanco.Text = "";
                lblDescbanco.BackColor = Color.Transparent;

                btnCon.Enabled = false;
                btnDesconectar.Enabled = true;

                txtID.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Falha na conexão", "Status Conexão com o BD", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Botão para gerar arquivo TXT
        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(selectaluno, conexao);
            MySqlDataReader select = cmd.ExecuteReader();
            string caminho = "C:\\Users\\Matheus H\\Desktop\\Teste\\arq.txt";
            StreamWriter x = File.CreateText(caminho);

            x.WriteLine("ID".PadRight(6) + "Nome".PadRight(25) + "Idade");

            while (select.Read())
            {
               x.WriteLine(select["Idaluno"].ToString() + "     " + select["nome"].ToString().PadRight(20) + "     " + int.Parse(select["idade"].ToString()));
            }
            x.Close();
            MessageBox.Show("Relatorio Gerado", "Geração Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //Botão para se desconectar do banco
        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            conexao.Close();
            lblDescbanco.Text = "Banco Desconectado";
            lblDescbanco.BackColor = Color.Red;
            label1.Text = "";
            label1.BackColor = Color.Transparent;
            txtID.Text = "";
            txtIdade.Text = "";
            txtNome.Text = "";

            btnCon.Enabled = true;
            btnDesconectar.Enabled = false;

            dtgSelect.DataSource = "";
        }

        //Inserir dados na tabela
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand insert = new MySqlCommand("insert into aluno (nome, idade)" + "VALUES ('" +txtNome.Text + "'," +txtIdade.Text +");", conexao);
                insert.ExecuteNonQuery();
                MessageBox.Show("Dados Cadastrados", "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Erro no cadastro", "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void dtgSelect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var linha = dtgSelect.CurrentRow.Index;

            txtID.Text = dtgSelect.Rows[linha].Cells[0].Value.ToString();
            txtNome.Text = dtgSelect.Rows[linha].Cells[1].Value.ToString();
            txtIdade.Text = dtgSelect.Rows[linha].Cells[2].Value.ToString();
            txtID.Enabled = false;

        }

        //Consultar Dados
        private void btnSelect_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand(selectaluno, conexao);
            MySqlDataReader select = cmd.ExecuteReader();
            DataTable aluno = new DataTable();
            aluno.Load(select);

            if (aluno.Rows.Count > 0)
            {
                dtgSelect.DataSource = aluno.DefaultView;
            }
            txtID.Enabled = false;

        }

        public void dtgSelect_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        //Atualizar dados
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            
            if (txtID.Enabled == false)
            {
                try
                {
                    MySqlCommand update = new MySqlCommand("update estudo.aluno set idade = @idade Where idaluno = @idaluno;", conexao);
                    update.Parameters.Add(new MySqlParameter("@idade", txtIdade.Text));
                    update.Parameters.Add(new MySqlParameter("@idaluno", txtID.Text));
                    update.ExecuteNonQuery();

                    MessageBox.Show("Cadastro Atualizados", "Atualização de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Erro ao atualizar cadastro", "Atualização de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else { MessageBox.Show("Selecionar um cadastro para realizar a atualização!", "Atualização de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            
        }


        //Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(DialogResult.Yes == MessageBox.Show("Deletar registro?", "Deletar Cdastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    MySqlCommand delete = new MySqlCommand("DELETE FROM aluno WHERE idaluno = @idaluno", conexao);
                    delete.Parameters.Add(new MySqlParameter("@idaluno", txtID.Text));

                    delete.ExecuteNonQuery();

                    MessageBox.Show("Registro deletado com sucesso", "Deletar Cdastro", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

                txtID.Clear();
                txtIdade.Text = "";
                txtNome.Text = "";


            }
            catch
            {
                MessageBox.Show("Não foi possivel deletar, verifique os dados!", "Deletar Cdastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

    }
}
