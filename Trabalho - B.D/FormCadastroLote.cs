using System;
using System.Windows.Forms;

namespace Trabalho___B.D {
    public partial class FormCadastroLote : Form {
        // Métodos
        public FormCadastroLote() // Cronstutora padrão
        {
            InitializeComponent();
            panelAlterar.Visible = panelDadosLote.Visible = panelAlterarDados.Visible = false;
        }

        private void Reset() // Reseta todos os paineis
        {
            panelDadosLote.Location = new System.Drawing.Point(89, 0);
            panelDadosLote.Size = new System.Drawing.Size(111, 90);
            panelAlterar.Location = new System.Drawing.Point(207, 0);
            panelAlterar.Size = new System.Drawing.Size(111, 90);
            panelAlterarDados.Location = new System.Drawing.Point(89, 96);
            panelAlterarDados.Size = new System.Drawing.Size(111, 90);
        }

        private void Set_DadosLote() // Carrega o painel do cadastro dos lotes
        {
            panelDadosLote.Location = new System.Drawing.Point(89, 0);
            panelDadosLote.Size = new System.Drawing.Size(329, 213);
        }

        private void Set_Alterar() // Carrega o primeiro painel para selecionar o lote
        {
            panelAlterar.Location = new System.Drawing.Point(89, 0);
            panelAlterar.Size = new System.Drawing.Size(329, 213);
        }

        private void Set_AlterarDados() // Carrega o segundo painel para alterar os dados
        {
            panelAlterarDados.Location = new System.Drawing.Point(89, 0);
            panelAlterarDados.Size = new System.Drawing.Size(329, 213);
        }

        private void BtnCadastrar_Click(object sender, EventArgs e) // Botão para cadastrar um dado no lote
        {
            Reset();
            panelAlterar.Visible = false;
            Set_DadosLote();
            clsLote Lote = new clsLote();
            Lote.getNumeroLote();
            txbNumero.Text = Lote.Numero.ToString();
            txbAves.Clear();
            cmbCrescimento.ResetText();
            txbPeso.Clear();
            txbMortalidade.Clear();
            panelDadosLote.Visible = true;
        }

        private void BtnAlterar_Click(object sender, EventArgs e) // Botão para alterar dados no lote
        {
            Reset();
            panelDadosLote.Visible = false;
            Set_Alterar();
            panelAlterar.Visible = true;
            clsLote.CarregaGrid(dgvLote, cmbLote);
        }

        private void BtnEscolherLote_Click(object sender, EventArgs e) // Botão para carrega o segundo painel de alterar os dados
        {
            Reset();
            panelAlterar.Visible = false;
            Set_AlterarDados();
            clsLote Lote = new clsLote();
            Lote.Numero = int.Parse(cmbLote.Text);
            Lote.getDadosTabela();
            txbNumeroAlterar.Text = cmbLote.Text;
            txbAvesAlterar.Text = Lote.QntAves.ToString();
            cmbCrescimentoAlterar.SelectedIndex = cmbCrescimentoAlterar.FindString(Lote.FaseCrescimento);
            txbPesoAlterar.Text = Lote.PesoMedio.ToString();
            txbMortalidadeAlterar.Text = Lote.Mortalidade.ToString();
            panelAlterarDados.Visible = true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e) // Salvar os dados do cadastro no lote
        {
            clsLote Lote = new clsLote();
            Lote.getNumeroLote();
            try {
                Lote.QntAves = int.Parse(txbAves.Text);
            } catch (FormatException) {
                MessageBox.Show("Quantidade de aves inválida!\n");
                return;
            }
            if (cmbCrescimento.Text.Length == 0) {
                MessageBox.Show("Selecione a fase de crescimento!\n");
                return;
            }
            Lote.FaseCrescimento = cmbCrescimento.Text;
            try {
                Lote.PesoMedio = double.Parse(txbPeso.Text);
                if (!txbPeso.Text.Contains(","))
                    throw new FormatException();
            } catch (FormatException) {
                MessageBox.Show("Peso Médio inválido!\n");
                return;
            }
            try {
                Lote.Mortalidade = int.Parse(txbMortalidade.Text);
            } catch (FormatException) {
                MessageBox.Show("Número de mortalidades inválida!\n");
                return;
            }
            if (Lote.Salvar())
                MessageBox.Show("Salvo com sucesso!\n");
            else
                MessageBox.Show("Erro ao salvar!\n");
            Reset();
            panelDadosLote.Visible = false;
        }

        private void BtnSalvarAlterar_Click(object sender, EventArgs e) { // Botão de salvar os dados alterados no lote
            clsLote Lote = new clsLote();
            Lote.Numero = int.Parse(cmbLote.Text);
            Lote.getDadosTabela();
            try {
                Lote.QntAves = int.Parse(txbAvesAlterar.Text);
            } catch (FormatException) {
                MessageBox.Show("Quantidade de aves inválida!\n");
                return;
            }
            if (cmbCrescimentoAlterar.Text.Length == 0) {
                MessageBox.Show("Selecione a fase de crescimento!\n");
                return;
            }
            Lote.FaseCrescimento = cmbCrescimentoAlterar.Text;
            try {
                Lote.PesoMedio = double.Parse(txbPesoAlterar.Text);
                if (!txbPesoAlterar.Text.Contains(","))
                    throw new FormatException();
            } catch (FormatException) {
                MessageBox.Show("Peso Médio inválido!\n");
                return;
            }
            try {
                Lote.Mortalidade = int.Parse(txbMortalidadeAlterar.Text);
            } catch (FormatException) {
                MessageBox.Show("Número de mortalidades inválida!\n");
                return;
            }
            if (Lote.Salvar(true))
                MessageBox.Show("Salvo com sucesso!\n");
            else
                MessageBox.Show("Erro ao salvar!\n");
            Reset();
            panelAlterarDados.Visible = false;
        }

        private void BtnVoltarAlterar_Click(object sender, EventArgs e) { // Botão de voltar para escolher o lote
            Reset();
            panelAlterarDados.Visible = false;
            Set_Alterar();
            panelAlterar.Visible = true;
        }

        private void BtnSairCadastro_Click(object sender, EventArgs e) { // Botão de fechar a janela
            this.Close();
        }
    }
}