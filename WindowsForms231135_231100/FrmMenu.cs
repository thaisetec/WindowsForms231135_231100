﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms231135_231100.Views;

namespace WindowsForms231135_231100
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
         
            {
                Banco.CriarBanco();
            }

            private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
            {
                FrmCidades form = new FrmCidades();
                form.Show();
            }

            private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
            {
                FormMarcas form = new FormMarcas();
                form.Show();
            }
        }
    }
}
   

