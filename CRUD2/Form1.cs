namespace CRUD2

{

using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using CRUD2.Models;
using System;



    public partial class Form1 : Form
    {

        public readonly string _connectionString;
        private List<Usuario> _usuarios = new();
        public Form1(IConfiguration config)
        {
            InitializeComponent();
            _connectionString = config.GetConnectionString("Default");
        }

        private void RefreshData(IDbConnection con)
        {
            _usuarios = con.Query<Usuario>("select * from Usuario").ToList();
            UsuarioList.DataSource = _usuarios; 
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario
            {
                Name = ProdutosNameTextBox.Text,
                Email = ProdutosEmailTextBox.Text,
                Telephone = ProdutosTelephoneTextBox.TextLength,
                Address = ProdutosAddressTextBox.Text,
                Date = DateTime.Now 
            };

            using var con = new SqlConnection(_connectionString);
            con.Execute(
                @"Insert into Usuario
                values (@Name, @Email, @Telephone, @Address, @Date)", usuario);
            RefreshData(con);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UsuarioList.CurrentRow is null)
                return;

            var usuario = new Usuario
            {
                Name = ProdutosNameTextBox.Text,
                Email = ProdutosEmailTextBox.Text,
                Telephone = Convert.ToInt32(ProdutosTelephoneTextBox.TextLength),
                Address = ProdutosAddressTextBox.Text,
                Date = DateTime.Now
            };

            using var con = new SqlConnection(_connectionString);
            con.Execute(
                @"update Usuario set 
                Name = @Name, 
                Email = @Email, 
                Telephone = @Telephone, 
                Address = @Address",
                 usuario
            );
            RefreshData(con);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (UsuarioList.CurrentRow is null)
                return;

            using var con = new SqlConnection(_connectionString);
            con.Execute(
                "delete Usuario where ID = @ID",
                new { ID = _usuarios[UsuarioList.CurrentRow.Index].ID }
                );
            RefreshData(con);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using var con = new SqlConnection(_connectionString);
            RefreshData(con);
        }
    }   
}       