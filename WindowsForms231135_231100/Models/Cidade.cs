using System;
using MySql.Data.MySqlclient;
using System.Data;
using System.Windows.Forms;

namespace WindowsForms231135_231100.Models
{
    public class Cidade
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public string uf { get; set; }



        public void incluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("INSERT INTO cidades (nome, uf) VALUES (@nome, @uf)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@nome, nome");
                Banco.Comando.Parameters.AddWithValue("@uf, uf");
                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void alterar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("Update cidades set nome =@nome,uf =@uf where id =@id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@nome", nome);
                Banco.Comando.Parameters.AddWithValue("@uf", uf);
                Banco.Comando.Parameters.AddWithValue("@id", id);

                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void Excluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("delete from cidades where id=@id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@id", id);
                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception e)
            {




                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable consultar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("SELECT * FROM cidades where nome like @nome" +
                    "order by nome", Banco.Conexao);
                Banco.Comando.parameters.AddWithValue("@nome", nome + "%");
                Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.Adaptador.Fill(Banco.DatTabela);
                Banco.FecharConexao();
                return Banco.DatTabela
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}








