using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms231135_231100.Models
{
    public class Clientes
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int idCidade { get; set; }
        public DateTime nascimento { get; set; }
        public double renda { get; set; }
        public string cpf { get; set; }
        public string foto { get; set; }
        public bool venda { get; set; }

        public void Incluir()
        {
            try
            {
                Banco.Conectar.Open();
                Banco.Comando = new MySqlCommand("INSERT INTO clientes (nome, idCidade, nascimento, renda, cpf, foto, venda) (@nome, @idCidade, @nascimento, @renda, @cpf, @foto, @venda)", Banco.Conectar);
                Banco.Comando.Parameters.AddWithValue("@nome", nome);
                Banco.Comando.Parameters.AddWithValue("@idCidade", idCidade);
                Banco.Comando.Parameters.AddWithValue("@nascimento", nascimento);
                Banco.Comando.Parameters.AddWithValue("@renda", renda);
                Banco.Comando.Parameters.AddWithValue("@cpf", cpf);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.Parameters.AddWithValue("@venda", venda);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conectar.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Alterar()
        {
            try
            {
                Banco.Conectar.Open();
                Banco.Comando = new MySqlCommand("UPDATE clientes SET nome = @nome, idCidade = @idCidade, nascimento = @nascimento, renda = @renda, cpf = @cpf, foto = @foto, venda = @venda where id = @id", Banco.Conectar);
                Banco.Comando.Parameters.AddWithValue("@nome", nome);
                Banco.Comando.Parameters.AddWithValue("@idCidade", idCidade);
                Banco.Comando.Parameters.AddWithValue("@nascimento", nascimento);
                Banco.Comando.Parameters.AddWithValue("@renda", renda);
                Banco.Comando.Parameters.AddWithValue("@cpf", cpf);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.Parameters.AddWithValue("@venda", venda);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conectar.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Excluir()
        {
            Banco.Conectar.Open();
            Banco.Comando = new MySqlCommand("DELETE FROM clientes WHERE id = @id", Banco.Conectar);
            Banco.Comando.Parameters.AddWithValue("@id", id);
            Banco.Comando.ExecuteNonQuery();
            Banco.Conectar.Close();
        }

        public DataTable Consultar()
        {
            try
            {
                Banco.Comando = new MySqlCommand("SELECT cl.*, ci.nome cidade, ci.uf FROM clientes cl INNER JOIN cidades ci on (ci.id = cl.idCidade) where cl.nome like ?nome order by cl.nome", Banco.Conectar);
                Banco.Comando.Parameters.AddWithValue("@nome", nome + "%");
                Banco.Adaptar = new MySqlDataAdapter(Banco.Comando);
                Banco.DataTabela = new DataTable();
                Banco.Adaptar.Fill(Banco.DataTabela);
                return Banco.DataTabela;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
