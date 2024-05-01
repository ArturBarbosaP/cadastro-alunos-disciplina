using MySql.Data.MySqlClient;
using System.Data;

namespace BD_03
{
    class ConexaoBD
    {
        private MySqlConnection conexao;
        public void ConectarBD()
        {
            conexao = new MySqlConnection("");
            conexao.Open();
        }

        public void AlterarTabelas(string sql)
        {
            ConectarBD();
            MySqlCommand comandos = new MySqlCommand(sql, conexao);
            comandos.ExecuteNonQuery();
            conexao.Close();
        }

        public DataTable ConsultarTabelas (string sql)
        {
            ConectarBD();
            MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexao);
            DataTable resultado = new DataTable();
            consulta.Fill(resultado);
            conexao.Close();
            return resultado;
        }
    }
}
