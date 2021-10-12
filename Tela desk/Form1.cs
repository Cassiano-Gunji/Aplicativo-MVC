using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aplicativoMVC.controle;
using aplicativoMVC.modelo;

namespace Tela_desk
{
    public partial class Form1 : Form
    {
        private Gerenciador gerenciador;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gerenciador = new Gerenciador(BancoDeDados.SqlServer);
        }

        private void btnConsulte_Click(object sender, EventArgs e)
        {
            List<Pessoa> pessoas;
            if (txtNome.Text.Equals(""))
            {
                pessoas = gerenciador.dao.consulte();
            }
            else
            {
                pessoas = gerenciador.dao.consulte(txtNome.Text);
            }
            lbAgenda.Items.Clear();
            foreach (Pessoa p in pessoas)
            {
                lbAgenda.Items.Add(p.ToString());
            }
        }

        private void btnInsira_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = txtNome.Text;
            p.telefone = Convert.ToInt32(txtTelefone.Text);
            gerenciador.dao.insira(p);
            txtNome.Text = "";
            txtTelefone.Text = "";
        }

        private void btnAltere_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = txtNome.Text;
            p.telefone = Convert.ToInt32(txtTelefone.Text);
            gerenciador.dao.altere(p);
        }

        private void btnExclua_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = txtNome.Text;
            p.telefone = Convert.ToInt32(txtTelefone.Text);
            gerenciador.dao.exclua(p);
        }
    }
}
