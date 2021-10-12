using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using aplicativoMVC.controle;
using aplicativoMVC.modelo;

namespace Tela_web
{
    public partial class Tela : System.Web.UI.Page
    {
        Gerenciador gerenciador;
        protected void Page_Load(object sender, EventArgs e)
        {
            gerenciador = new Gerenciador(BancoDeDados.SqlServer);
        }

        protected void btnConsulte_Click(object sender, EventArgs e)
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

        protected void btnInsira_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = txtNome.Text;
            p.telefone = Convert.ToInt32(txtTelefone.Text);
            gerenciador.dao.insira(p);
            txtNome.Text = "";
            txtTelefone.Text = "";
        }

        protected void btnAltere_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = txtNome.Text;
            p.telefone = Convert.ToInt32(txtTelefone.Text);
            gerenciador.dao.altere(p);
        }

        protected void btnExclua_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = txtNome.Text;
            p.telefone = Convert.ToInt32(txtTelefone.Text);
            gerenciador.dao.exclua(p);
        }
    }
}
