﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsForms231135_231100
{
    public class Banco
    {
        public static MySqlConnection Conexao;

        public static MySqlCommand Comando;

        public static MySqlDataAdapter Adaptador;

        public static DataTable DatTabela;


        public static void AbrirConexao()
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau");
                Conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void FecharConexao()
        {
            try
            {
                Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void CriarBanco()
        {
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS vendas; USE vendas", Conexao);
                Comando.ExecuteNonQuery();
                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Cidades; USE vendas" +
                    "(id integer auto_increment primary key," +
                    "nome char(40)," +
                    "uf char(02))", Conexao);

                Comando.ExecuteNonQuery();

                FecharConexao();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    


       
                
        
            
       

