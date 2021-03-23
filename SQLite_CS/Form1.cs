using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SQLite_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SQLiteConnection conexao;
        private SQLiteCommand comando;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        //set conexão
        private void SetConnection()
        {
            conexao = new SQLiteConnection
                ("Data Source=dbapps.db;Version=3;New=False;Compress=True;");
        }

        //set execução da query

        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            conexao.Open();
            comando = conexao.CreateCommand();
            comando.CommandText = txtQuery;
            comando.ExecuteNonQuery();
            conexao.Close();

        }

        //set loadDB

        private void LoadData()
        {
            SetConnection();
            conexao.Open();
            comando = conexao.CreateCommand();
            string CommandText = "select * from Pessoa";
            DB = new SQLiteDataAdapter(CommandText, conexao);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            conexao.Close();
        }

        private void LoadDataEsp(int id)
        {
            SetConnection();
            conexao.Open();
            comando = conexao.CreateCommand();
            string CommandText = "select * from Pessoa where id="+id+"";
            DB = new SQLiteDataAdapter(CommandText, conexao);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            conexao.Close();
        }


        private void btn_inserir_Click(object sender, EventArgs e)
        {
            string txtQuery = "insert into Pessoa(nome, email, telefone, idade) values('"+txt_nome.Text+"','"+txt_email.Text+"','"+txt_telefone.Text+"','"+txt_idade.Text+"')";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string txtQuery = "update pessoa set nome='" + txt_nome.Text + "', email='" + txt_email.Text + "', telefone='" + txt_telefone.Text + "', idade=" + txt_idade.Text + " where id='"+dataGridView1.SelectedRows[0].Cells[0].Value.ToString()+"'";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            string txtQuery = "delete from pessoa where id='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            LoadDataEsp(Convert.ToInt32(txt_busca.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nome.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txt_email.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txt_telefone.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txt_idade.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        
    }
}
