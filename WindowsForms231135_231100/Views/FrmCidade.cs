using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms231135_231100.Models;


namespace WindowsForms231135_231100.Views
{
    public partial class FrmCidade : Form
    {
        Cidade c;
        public FrmCidade()
        {
            InitializeComponent();
        }
        void limpaControles()
            {
            txtcategorias.Clear();
            txtPesquisa.Clear();
        }
        void CarregarGrid(string pesquisa)
        { c = new Categoria();
            Categoria.categoria = pesquisa
        };
        DGVcategorias.DataSource = Categoria.Consultar();

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text == String.Empty) return;

            c = new Cidade()
            {
                id = int.Parse(txtId.Text),
                nome = txtNome.Text,
                uf = txtUF.Text
            };
            c.alterar();

            limpaControles();
            CarregarGrid("");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmCidade_Load(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == String.Empty)  return;

            c = new Cidade()
            {
                nome = txtNome.Text,
                uf = txtUF.Text
            };
            c.incluir();
            limpaControles();
            carregarGrid("");

        }

        private void DgvCidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvCidades.RowCount>0)
            {
                txtID.Text = DgvCidades.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text = DgvCidades.CurrentRow.Cells["nome"].Value.ToString();
                txtUF.Text = DgvCidades.CurrentRow.Cells["uf"].Value.ToString();
                
            }
        }
    }
}
