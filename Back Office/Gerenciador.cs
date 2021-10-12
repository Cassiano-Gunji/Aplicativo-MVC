using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aplicativoMVC.modelo;
using aplicativoMVC.modelo.dal;

namespace aplicativoMVC.controle
{
    public class Gerenciador
    {
        public PessoaDao dao;
        public Gerenciador(BancoDeDados bd)
        {
            switch (bd)
            {
                case BancoDeDados.Simulador:
                    dao = new SimuladorDao();
                    break;
                case BancoDeDados.MySql:
                    throw new NotImplementedException("DAO para MySql não implementado");
                case BancoDeDados.SqlServer:
                    dao = new SqlServerDao();
                    break;
            }
        }
    }
}
