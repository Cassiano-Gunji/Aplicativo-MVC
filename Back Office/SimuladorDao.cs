using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicativoMVC.modelo.dal
{
    class SimuladorDao : PessoaDao
    {
        // Banco de dados simulado
        private static List<Pessoa> bd = new List<Pessoa>();
        void PessoaDao.altere(Pessoa p)
        {
            foreach (Pessoa pessoa in bd)
            {
                if (pessoa.nome.Equals(p.nome))
                {
                    pessoa.telefone = p.telefone;
                }
            }
        }

        List<Pessoa> PessoaDao.consulte()
        {
            return bd;
        }

        List<Pessoa> PessoaDao.consulte(string nome)
        {
            List<Pessoa> saida = new List<Pessoa>();

            foreach (Pessoa pessoa in bd)
            {
                if (pessoa.nome.Equals(nome))
                {
                    saida.Add(pessoa);
                }
            }

            return saida;
        }

        void PessoaDao.exclua(Pessoa p)
        {
            bd.Remove(p);
        }

        void PessoaDao.insira(Pessoa p)
        {
            bd.Add(p);
        }
    }
}
