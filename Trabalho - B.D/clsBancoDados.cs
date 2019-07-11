using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Trabalho___B.D
{
    class clsBancoDados
    {

        // Variáveis / Propriedades
        private const string V = "C:\\Users\\hugol\\source\\repos\\Trabalho - B.D\\Galpão.mdf";
        private static SqlConnection cnctSql;
        private static SqlTransaction Transaction;
        public static string Caminho { get; set; }

        // Métodos
        private clsBancoDados() { }

        public static SqlConnection GetConexao()
        {
            Caminho = V;
            if (String.IsNullOrEmpty(Caminho))
                return cnctSql;
            if (cnctSql == null || cnctSql.State == System.Data.ConnectionState.Closed)
            {
                cnctSql = new SqlConnection();
                cnctSql.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Caminho + ";Integrated Security=True;Connect Timeout=30;";
                cnctSql.Open();
            }
            return cnctSql;
        }

        public static SqlTransaction GetTransaction()
        {
            if (cnctSql != null || cnctSql.State == System.Data.ConnectionState.Closed)
                GetConexao();
            return Transaction;
        }

        public static void BeginTransaction()
        {
            if (cnctSql != null || cnctSql.State == System.Data.ConnectionState.Closed)
                GetConexao();
            Transaction = cnctSql.BeginTransaction();
        }

        public static void CommitTransaction()
        {
            Transaction.Commit();
        }

        public static void RollbackTransaction()
        {
            Transaction.Rollback();
        }
    }
}
