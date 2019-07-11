using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Trabalho___B.D {
    public partial class FormConsultarLote : Form {
        public FormConsultarLote() {
            InitializeComponent();
            panelPesquisar.Visible = panelDataGrid.Visible = false;
        }

        private void Reset() {
            panelPesquisar.Location = new System.Drawing.Point(89, 0);
            panelPesquisar.Size = new System.Drawing.Size(111, 90);
            panelDataGrid.Location = new System.Drawing.Point(207, 0);
            panelDataGrid.Size = new System.Drawing.Size(111, 90);
        }

        private void Set_ConsultaLote() {
            panelPesquisar.Location = new System.Drawing.Point(89, 0);
            panelPesquisar.Size = new System.Drawing.Size(329, 213);
        }

        private void Set_DataGrid() {
            panelDataGrid.Location = new System.Drawing.Point(89, 0);
            panelDataGrid.Size = new System.Drawing.Size(329, 213);
        }

        private void BtnPesquisarLote_Click(object sender, EventArgs e) {
            Reset();
            Set_ConsultaLote();
            panelPesquisar.Visible = true;
        }

        private void ChkNumero_CheckedChanged(object sender, EventArgs e) {
            if (chkNumero.Checked)
                txbNMenor.Enabled = txbNMaior.Enabled = false;
            else
                txbNMenor.Enabled = txbNMaior.Enabled = true;
        }

        private void ChkAves_CheckedChanged(object sender, EventArgs e) {
            if (chkAves.Checked)
                txbAvesMenor.Enabled = txbAvesMaior.Enabled = false;
            else
                txbAvesMenor.Enabled = txbAvesMaior.Enabled = true;
        }

        private void ChkFase_CheckedChanged(object sender, EventArgs e) {
            if (chkFase.Checked)
                cmbFasePesquisa.Enabled = false;
            else
                cmbFasePesquisa.Enabled = true;
        }

        private void BtnSair_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ChkPeso_CheckedChanged(object sender, EventArgs e) {
            if (chkPeso.Checked)
                txbPesoMenor.Enabled = txbPesoMaior.Enabled = false;
            else
                txbPesoMenor.Enabled = txbPesoMaior.Enabled = true;

        }

        private void ChkMortalidade_CheckedChanged(object sender, EventArgs e) {
            if (chkMortalidade.Checked)
                txbMortalidadeMenor.Enabled = txbMortalidadeMaior.Enabled = false;
            else
                txbMortalidadeMenor.Enabled = txbMortalidadeMaior.Enabled = true;
        }

        private void BtnOkPesquisar_Click(object sender, EventArgs e) {
            clsLote Lote = new clsLote();
            if (!chkNumero.Checked) {
                try {
                    int menor = int.Parse(txbNMenor.Text);
                    int maior = int.Parse(txbNMaior.Text);
                    if (maior < menor)
                        throw new Exception("O número do lote do  primeiro bloco deve ser menor do que o do segundo!");
                } catch (FormatException) {
                    MessageBox.Show("Número do lote inválido!\n");
                    return;
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            if (!chkAves.Checked) {
                try {
                    int menor = int.Parse(txbAvesMenor.Text);
                    int maior = int.Parse(txbAvesMaior.Text);
                    if (maior < menor)
                        throw new Exception("O número de aves do primeiro bloco deve ser menor do que o do segundo!\n");
                } catch (FormatException) {
                    MessageBox.Show("Formato inválido na seção Número!\n");
                    return;
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            if (cmbFasePesquisa.Text.Length == 0 && !chkFase.Checked) {
                MessageBox.Show("Selecione a fase de crescimento!\n");
                return;
            }
            if (!chkPeso.Checked) {
                try {
                    double menor = double.Parse(txbPesoMenor.Text);
                    double maior = double.Parse(txbPesoMaior.Text);
                    if (maior < menor)
                        throw new Exception("O peso do primeiro bloco deve ser menor que o do segundo!\n");
                    if (!txbPesoMenor.Text.Contains(",") || !txbPesoMaior.Text.Contains(","))
                        throw new FormatException();
                } catch (FormatException) {
                    MessageBox.Show("Formato inválido na seção Peso!\n");
                    return;
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            if (!chkMortalidade.Checked) {
                try {
                    int menor = int.Parse(txbMortalidadeMenor.Text);
                    int maior = int.Parse(txbMortalidadeMaior.Text);
                    if (maior < menor)
                        throw new Exception("O número de mortalidades do primeiro bloco dever ser menor do que o do segundo!\n");
                } catch (FormatException) {
                    MessageBox.Show("Formato inválido na seção Mortalidade!\n");
                    return;
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            List<KeyValuePair<string, string>> ls = new List<KeyValuePair<string, string>>();
            if (chkNumero.Checked)
                ls.Add(new KeyValuePair<string, string>("any", "any"));
            else
                ls.Add(new KeyValuePair<string, string>(txbNMenor.Text, txbNMaior.Text));
            if (chkAves.Checked)
                ls.Add(new KeyValuePair<string, string>("any", "any"));
            else
                ls.Add(new KeyValuePair<string, string>(txbAvesMenor.Text, txbAvesMaior.Text));
            if (chkFase.Checked)
                ls.Add(new KeyValuePair<string, string>("any", "any"));
            else
                ls.Add(new KeyValuePair<string, string>(cmbFasePesquisa.Text, "selected"));
            if (chkPeso.Checked)
                ls.Add(new KeyValuePair<string, string>("any", "any"));
            else
                ls.Add(new KeyValuePair<string, string>(txbPesoMenor.Text, txbPesoMaior.Text));
            if (chkMortalidade.Checked)
                ls.Add(new KeyValuePair<string, string>("any", "any"));
            else
                ls.Add(new KeyValuePair<string, string>(txbMortalidadeMenor.Text, txbMortalidadeMaior.Text));
            Reset();
            panelPesquisar.Visible = false;
            Set_DataGrid();
            clsLote.CarregaGrid(dgv, ls);
            panelDataGrid.Visible = true;
        }

    }
}
