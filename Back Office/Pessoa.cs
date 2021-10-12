using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicativoMVC.modelo
{
    public class Pessoa
    {
        public string nome { get; set; }
        public int telefone { get; set; }
        public override bool Equals(object obj)
        {
            bool saida = false;

            if (typeof(Pessoa) == obj.GetType()){
                Pessoa pessoa = (Pessoa)obj;
                if (this.nome.Equals(pessoa.nome) && this.telefone == pessoa.telefone)
                {
                    saida = true;
                }
            }

            return saida;
        }
        public override string ToString()
        {
            return nome + " - " + telefone;
        }
    }
}
