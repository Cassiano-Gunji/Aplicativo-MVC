using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicativoMVC.modelo.dal
{
    public class SqlServerDao : PessoaDao
    {
        // Armazena uma única instância de conexão com o BD.
        private static SqlConnection con;

        // Construtor
        public SqlServerDao()
        {
            // Se não existe uma conexão aberta, cria uma.
            if (con == null)
            {
                try
                {
                    // Objeto que auxilia a configurar uma conexão com BD.
                    SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
                    cs.DataSource = "Localhost";
                    cs.InitialCatalog = "Agenda";
                    cs.Authentication = SqlAuthenticationMethod.ActiveDirectoryIntegrated;
                    cs.TrustServerCertificate = true;

                    // Instancia e abre a conexão.
                    con = new SqlConnection(cs.ConnectionString);
                    con.Open();
                }
                catch (SqlException e)
                {
                    Console.Error.WriteLine("Ocorreu uma exceção de BD: " + e.Message);
                    throw new ApplicationException("Ocorreu uma exceção de BD: " + e.Message);
                }
            }
        }

        void PessoaDao.altere(Pessoa p)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE Agenda SET Telefone = " + p.telefone + " WHERE Nome = '" +
                p.nome + "';";
            cmd.ExecuteNonQuery();
        }

        List<Pessoa> PessoaDao.consulte()
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Nome, Telefone FROM Agenda;";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Pessoa pessoa = new Pessoa();
                pessoa.nome = reader.GetString(0);
                pessoa.telefone = reader.GetInt32(1);
                pessoas.Add(pessoa);
            }
            reader.Close();

            return pessoas;
        }

        List<Pessoa> PessoaDao.consulte(string nome)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Nome, Telefone FROM Agenda WHERE Nome = '"
                + nome + "';";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Pessoa pessoa = new Pessoa();
                pessoa.nome = reader.GetString(0);
                pessoa.telefone = reader.GetInt32(1);
                pessoas.Add(pessoa);
            }
            reader.Close();

            return pessoas;
        }

        void PessoaDao.exclua(Pessoa p)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM Agenda WHERE Nome = '" + p.nome
                + "' AND Telefone = " + p.telefone + ";";
            cmd.ExecuteNonQuery();
        }

        void PessoaDao.insira(Pessoa p)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Agenda (Nome, Telefone)" + 
                " VALUES ('" + p.nome + "', " + p.telefone + ");";
            cmd.ExecuteNonQuery();
        }
    }
}
