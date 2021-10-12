using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace aplicativoMVC.modelo
{
    public interface PessoaDao
    {
        void insira(Pessoa p);
        List<Pessoa> consulte();
        List<Pessoa> consulte(string nome);
        void altere(Pessoa p);
        void exclua(Pessoa p);
    }
}
