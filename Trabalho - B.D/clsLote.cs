using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Trabalho___B.D {
    class clsLote {
        // Variáveis/Propriedades
        public int Numero { get; set; }
        public int QntAves { get; set; }
        public string FaseCrescimento { get; set; }
        public double PesoMedio { get; set; }
        public int Mortalidade { get; set; }

        // Métodos
        private static KeyValuePair<SqlConnection, Boolean> Conexao_BD() { // Efetuar Conexão com o Banco de Dados
            SqlConnection c;
            try {
                c = clsBancoDados.GetConexao();
            } catch(Exception e) {
                MessageBox.Show("Erro de Conexão!\n\n" + e.Message);
                return new KeyValuePair<SqlConnection, bool>(new SqlConnection(), false);
            }
            return new KeyValuePair<SqlConnection, bool>(c, true);
        }

        public Boolean Salvar(bool updt = false) { // Botão para salvar e alterar dados do lote

            // Conexão
            KeyValuePair<SqlConnection, Boolean> Conexao = Conexao_BD();
            if (!Conexao.Value)
                return false;
            // Fim Conexão

            // Criar/Executar Comando
            SqlCommand com;
            com = Conexao.Key.CreateCommand();
            com.Transaction = clsBancoDados.GetTransaction();
            if (!updt)
                com.CommandText = "insert into lote (numero, quantidadeaves, fasecrescimento, pesomedio, mortalidade) " +
                " values (@Numero, @QntAves, @FaseCrescimento, @PesoMedio, @Mortalidade);";
            else
                com.CommandText = "update lote set numero = @Numero, quantidadeaves = @QntAves, fasecrescimento = @FaseCrescimento," +
                "pesomedio = @PesoMedio, mortalidade = @Mortalidade where numero = @Numero";
            com.Parameters.Add(new SqlParameter("@Numero", SqlDbType.Int));
            com.Parameters[0].Value = this.Numero;
            com.Parameters.Add(new SqlParameter("@QntAves", SqlDbType.Int));
            com.Parameters[1].Value = this.QntAves;
            com.Parameters.Add(new SqlParameter("@FaseCrescimento", SqlDbType.VarChar));
            com.Parameters[2].Value = this.FaseCrescimento;
            com.Parameters.Add(new SqlParameter("@PesoMedio", SqlDbType.Decimal));
            com.Parameters[3].Value = this.PesoMedio;
            com.Parameters.Add(new SqlParameter("@Mortalidade", SqlDbType.Int));
            com.Parameters[4].Value = this.Mortalidade;
            try {
                com.ExecuteNonQuery();
            } catch (Exception e) {
                MessageBox.Show("Erro ao Salvar!\n\n" + e.Message);
                return false;
            }
            // Fim Criar/Executar
            MessageBox.Show("Mudei aqui");
            return true;
        }

        public void getNumeroLote() { // Pegar o número do último lote

            // Conexão
            KeyValuePair<SqlConnection, Boolean> Conexao = Conexao_BD();
            if (!Conexao.Value)
                return;
            // Fim Conexão 

            // Criar/Executar Comando
            SqlCommand com = new SqlCommand();
            com = Conexao.Key.CreateCommand();
            com.Transaction = clsBancoDados.GetTransaction();
            com.CommandText = "select numero from lote order by numero desc;";
            SqlDataReader dbr;
            dbr = com.ExecuteReader();
            // Fim Criar/Executar

            // Ler dados da tabela
            if (!dbr.Read())
                this.Numero = 1;
            else
                this.Numero = dbr.GetInt32(dbr.GetOrdinal("numero")) + 1;
            dbr.Close();
            // Fim Leitura

        }

        public void getDadosTabela() { // Pegar todos os dados de um lote

            // Conexão
            KeyValuePair<SqlConnection, Boolean> Conexao = Conexao_BD();
            if (!Conexao.Value)
                return;
            // Fim Conexão 

            // Criar/Executar Comando
            SqlCommand com = new SqlCommand();
            com = Conexao.Key.CreateCommand();
            com.Transaction = clsBancoDados.GetTransaction();
            com.CommandText = "select quantidadeaves, fasecrescimento, pesomedio, mortalidade from lote where numero = @Numero;";
            com.Parameters.Add(new SqlParameter("@Numero", SqlDbType.Int)); ;
            com.Parameters[0].Value = this.Numero;
            SqlDataReader dbr;
            dbr = com.ExecuteReader();
            // Fim Criar/Executar

            // Ler dados da tabela
            dbr.Read();
            this.QntAves = dbr.GetInt32(dbr.GetOrdinal("quantidadeaves"));
            this.FaseCrescimento = dbr.GetString(dbr.GetOrdinal("fasecrescimento"));
            this.PesoMedio = Convert.ToDouble(dbr.GetDecimal(dbr.GetOrdinal("pesomedio")));
            this.Mortalidade = dbr.GetInt32(dbr.GetOrdinal("mortalidade"));
            dbr.Close();
            // Fim Leitura

        }

        public static void CarregaGrid(System.Windows.Forms.DataGridView dgv, System.Windows.Forms.ComboBox cmb) { // Colocar os dados da tabela lote e carrega no grid e combobox

            // Conexão
            KeyValuePair<SqlConnection, Boolean> Conexao = Conexao_BD();
            if (!Conexao.Value)
                return;
            // Fim Conexão

            // Criar/Executar comando
            SqlCommand com = new SqlCommand();
            com = Conexao.Key.CreateCommand();
            com.Transaction = clsBancoDados.GetTransaction();
            com.CommandText = "select numero, quantidadeaves, fasecrescimento from lote order by numero;";
            SqlDataReader dbr;
            dbr = com.ExecuteReader();
            // Fim Criar/Executar

            // Build/Ler dados
            dgv.Rows.Clear();
            cmb.Items.Clear();
            while (dbr.Read()) {
                string[] vs = new string[3];
                vs[0] = dbr.GetInt32(dbr.GetOrdinal("numero")).ToString();
                vs[1] = dbr.GetInt32(dbr.GetOrdinal("quantidadeaves")).ToString();
                vs[2] = dbr.GetString(dbr.GetOrdinal("fasecrescimento"));
                dgv.Rows.Add();
                cmb.Items.Add(vs[0]);
                dgv.Rows[dgv.RowCount - 1].SetValues(vs);
            }
            dbr.Close();
            // Fim Build/Ler dados

            return;
        }

        public static void CarregaGrid(System.Windows.Forms.DataGridView dgv, List<KeyValuePair<string, string>> ls) { // Colocar os dados da tabela lote e carrega no grid

            // Conexão
            KeyValuePair<SqlConnection, Boolean> Conexao = Conexao_BD();
            if (!Conexao.Value)
                return;
            // Fim Conexão

            // Criar/Executar comando
            SqlCommand com = new SqlCommand();
            com = Conexao.Key.CreateCommand();
            com.Transaction = clsBancoDados.GetTransaction();
            com.CommandText = "select * from lote";
            string[] st = new string[5] {
                "", "", "", "", ""};
            int cnt = 0;
            bool uw = false;
            bool[] vc = new bool[5] {
                false, false, false, false, false };
            if (ls[0].Key != "any") {
                st[0] = (!uw ? " where " : "") + "numero >= @nmenor and numero <= @nmaior"; uw = vc[0] = true;
            }
            if (ls[1].Key != "any") {
                st[1] = (!uw ? " where " : "") + "quantidadeaves >= @qntmenor and quantidadeaves <= @qntmaior"; uw = vc[1] = true;
            }
            if (ls[2].Value == "selected") {
                st[2] = (!uw ? " where " : "") + "fasecrescimento = @fase"; uw = vc[2] = true;
            }
            if (ls[3].Key != "any") {
                st[3] = (!uw ? " where " : "") + "pesomedio >= @pesomenor and pesomedio <= @pesomaior"; uw = vc[3] = true;
            }
            if (ls[4].Key != "any") {
                st[4] = (!uw ? " where " : "") + "mortalidade >= @mmenor and mortalidade <= @mmaior"; uw = vc[4] = true;
            }
            bool ve = false;
            if (uw == true) {
                foreach (var s in st) {
                    if (s != "" && ve)
                        com.CommandText += " and " + s;
                    else if (s != "" && !ve) {
                        com.CommandText += s;
                        ve = true;
                    }
                }
            }
            if (vc[0]) {
                com.Parameters.Add(new SqlParameter("@nmenor", SqlDbType.Int));
                com.Parameters[cnt++].Value = int.Parse(ls[0].Key);
                com.Parameters.Add(new SqlParameter("@nmaior", SqlDbType.Int));
                com.Parameters[cnt++].Value = int.Parse(ls[0].Value);
            }
            if (vc[1]) {

                com.Parameters.Add(new SqlParameter("@qntmenor", SqlDbType.Int));
                com.Parameters[cnt++].Value = int.Parse(ls[1].Key);
                com.Parameters.Add(new SqlParameter("@qntmaior", SqlDbType.Int));
                com.Parameters[cnt++].Value = int.Parse(ls[1].Value);
            }
            if (vc[2]) {
                com.Parameters.Add(new SqlParameter("@fase", SqlDbType.VarChar));
                com.Parameters[cnt++].Value = ls[2].Key;
            }
            if (vc[3]) {
                com.Parameters.Add(new SqlParameter("@pesomenor", SqlDbType.Decimal));
                com.Parameters[cnt++].Value = double.Parse(ls[3].Key);
                com.Parameters.Add(new SqlParameter("@pesomaior", SqlDbType.Decimal));
                com.Parameters[cnt++].Value = double.Parse(ls[3].Value);
            }
            if (vc[4]) {
                com.Parameters.Add(new SqlParameter("@mmenor", SqlDbType.Int));
                com.Parameters[cnt++].Value = int.Parse(ls[4].Key);
                com.Parameters.Add(new SqlParameter("@mmaior", SqlDbType.Int));
                com.Parameters[cnt++].Value = int.Parse(ls[4].Value);
            }
            SqlDataReader dbr;
            dbr = com.ExecuteReader();
            // Fim Criar/Executar

            // Build/Ler dados
            dgv.Rows.Clear();
            while (dbr.Read()) {
                string[] vs = new string[5];
                vs[0] = dbr.GetInt32(dbr.GetOrdinal("numero")).ToString();
                vs[1] = dbr.GetInt32(dbr.GetOrdinal("quantidadeaves")).ToString();
                vs[2] = dbr.GetString(dbr.GetOrdinal("fasecrescimento"));
                vs[3] = dbr.GetDecimal(dbr.GetOrdinal("pesomedio")).ToString();
                vs[4] = dbr.GetInt32(dbr.GetOrdinal("mortalidade")).ToString();
                dgv.Rows.Add();
                dgv.Rows[dgv.RowCount - 1].SetValues(vs);
            }
            dbr.Close();
            // Fim Build/Ler dados

            return;
        }
    }
}
