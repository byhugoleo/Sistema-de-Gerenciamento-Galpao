namespace Trabalho___B.D
{
    partial class FormCadastroLote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.btnSairCadastro = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDadosLote = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txbMortalidade = new System.Windows.Forms.TextBox();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.cmbCrescimento = new System.Windows.Forms.ComboBox();
            this.txbAves = new System.Windows.Forms.TextBox();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAlterar = new System.Windows.Forms.Panel();
            this.btnEscolherLote = new System.Windows.Forms.Button();
            this.cmbLote = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvLote = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QntAves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaseCrescimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelAlterarDados = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.btnVoltarAlterar = new System.Windows.Forms.Button();
            this.btnSalvarAlterar = new System.Windows.Forms.Button();
            this.txbMortalidadeAlterar = new System.Windows.Forms.TextBox();
            this.txbPesoAlterar = new System.Windows.Forms.TextBox();
            this.cmbCrescimentoAlterar = new System.Windows.Forms.ComboBox();
            this.txbAvesAlterar = new System.Windows.Forms.TextBox();
            this.txbNumeroAlterar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelCadastro.SuspendLayout();
            this.panelDadosLote.SuspendLayout();
            this.panelAlterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote)).BeginInit();
            this.panelAlterarDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCadastro
            // 
            this.panelCadastro.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelCadastro.Controls.Add(this.btnSairCadastro);
            this.panelCadastro.Controls.Add(this.btnAlterar);
            this.panelCadastro.Controls.Add(this.btnCadastrar);
            this.panelCadastro.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCadastro.Location = new System.Drawing.Point(0, 0);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Size = new System.Drawing.Size(89, 213);
            this.panelCadastro.TabIndex = 1;
            // 
            // btnSairCadastro
            // 
            this.btnSairCadastro.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSairCadastro.Location = new System.Drawing.Point(0, 178);
            this.btnSairCadastro.Name = "btnSairCadastro";
            this.btnSairCadastro.Size = new System.Drawing.Size(89, 34);
            this.btnSairCadastro.TabIndex = 2;
            this.btnSairCadastro.Text = "Sair";
            this.btnSairCadastro.UseVisualStyleBackColor = false;
            this.btnSairCadastro.Click += new System.EventHandler(this.BtnSairCadastro_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnAlterar.Location = new System.Drawing.Point(0, 32);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(89, 34);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnCadastrar.Location = new System.Drawing.Point(0, 0);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(89, 34);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSalvar.Location = new System.Drawing.Point(228, 167);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 34);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número:";
            // 
            // panelDadosLote
            // 
            this.panelDadosLote.Controls.Add(this.label12);
            this.panelDadosLote.Controls.Add(this.btnSalvar);
            this.panelDadosLote.Controls.Add(this.txbMortalidade);
            this.panelDadosLote.Controls.Add(this.txbPeso);
            this.panelDadosLote.Controls.Add(this.cmbCrescimento);
            this.panelDadosLote.Controls.Add(this.txbAves);
            this.panelDadosLote.Controls.Add(this.txbNumero);
            this.panelDadosLote.Controls.Add(this.label5);
            this.panelDadosLote.Controls.Add(this.label4);
            this.panelDadosLote.Controls.Add(this.label3);
            this.panelDadosLote.Controls.Add(this.label2);
            this.panelDadosLote.Controls.Add(this.label1);
            this.panelDadosLote.Location = new System.Drawing.Point(89, 0);
            this.panelDadosLote.Name = "panelDadosLote";
            this.panelDadosLote.Size = new System.Drawing.Size(111, 90);
            this.panelDadosLote.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(151, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Kg";
            // 
            // txbMortalidade
            // 
            this.txbMortalidade.Location = new System.Drawing.Point(94, 142);
            this.txbMortalidade.Name = "txbMortalidade";
            this.txbMortalidade.Size = new System.Drawing.Size(53, 20);
            this.txbMortalidade.TabIndex = 12;
            // 
            // txbPeso
            // 
            this.txbPeso.Location = new System.Drawing.Point(95, 111);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(52, 20);
            this.txbPeso.TabIndex = 11;
            // 
            // cmbCrescimento
            // 
            this.cmbCrescimento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCrescimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCrescimento.FormattingEnabled = true;
            this.cmbCrescimento.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmbCrescimento.Items.AddRange(new object[] {
            "Fase Inicial",
            "Fase de Engorda",
            "Fase Crescimento"});
            this.cmbCrescimento.Location = new System.Drawing.Point(137, 80);
            this.cmbCrescimento.MaxDropDownItems = 3;
            this.cmbCrescimento.Name = "cmbCrescimento";
            this.cmbCrescimento.Size = new System.Drawing.Size(121, 21);
            this.cmbCrescimento.TabIndex = 10;
            // 
            // txbAves
            // 
            this.txbAves.Location = new System.Drawing.Point(135, 49);
            this.txbAves.Name = "txbAves";
            this.txbAves.Size = new System.Drawing.Size(39, 20);
            this.txbAves.TabIndex = 9;
            // 
            // txbNumero
            // 
            this.txbNumero.Enabled = false;
            this.txbNumero.Location = new System.Drawing.Point(76, 18);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(27, 20);
            this.txbNumero.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mortalidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Peso Médio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fase de crescimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade de aves:";
            // 
            // panelAlterar
            // 
            this.panelAlterar.Controls.Add(this.btnEscolherLote);
            this.panelAlterar.Controls.Add(this.cmbLote);
            this.panelAlterar.Controls.Add(this.label6);
            this.panelAlterar.Controls.Add(this.dgvLote);
            this.panelAlterar.Location = new System.Drawing.Point(207, 0);
            this.panelAlterar.Name = "panelAlterar";
            this.panelAlterar.Size = new System.Drawing.Size(111, 90);
            this.panelAlterar.TabIndex = 3;
            // 
            // btnEscolherLote
            // 
            this.btnEscolherLote.BackColor = System.Drawing.Color.GhostWhite;
            this.btnEscolherLote.Location = new System.Drawing.Point(228, 167);
            this.btnEscolherLote.Name = "btnEscolherLote";
            this.btnEscolherLote.Size = new System.Drawing.Size(75, 34);
            this.btnEscolherLote.TabIndex = 3;
            this.btnEscolherLote.Text = "Escolher";
            this.btnEscolherLote.UseVisualStyleBackColor = false;
            this.btnEscolherLote.Click += new System.EventHandler(this.BtnEscolherLote_Click);
            // 
            // cmbLote
            // 
            this.cmbLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLote.FormattingEnabled = true;
            this.cmbLote.Location = new System.Drawing.Point(156, 175);
            this.cmbLote.Name = "cmbLote";
            this.cmbLote.Size = new System.Drawing.Size(51, 21);
            this.cmbLote.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Escolha o lote para alterar: ";
            // 
            // dgvLote
            // 
            this.dgvLote.AllowUserToAddRows = false;
            this.dgvLote.AllowUserToDeleteRows = false;
            this.dgvLote.AllowUserToOrderColumns = true;
            this.dgvLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.QntAves,
            this.FaseCrescimento});
            this.dgvLote.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLote.Location = new System.Drawing.Point(3, 3);
            this.dgvLote.Name = "dgvLote";
            this.dgvLote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLote.Size = new System.Drawing.Size(323, 146);
            this.dgvLote.TabIndex = 0;
            // 
            // numero
            // 
            this.numero.HeaderText = "Número Lote";
            this.numero.Name = "numero";
            // 
            // QntAves
            // 
            this.QntAves.HeaderText = "Quantidade de Aves";
            this.QntAves.Name = "QntAves";
            // 
            // FaseCrescimento
            // 
            this.FaseCrescimento.HeaderText = "Fase Crescimento";
            this.FaseCrescimento.Name = "FaseCrescimento";
            // 
            // panelAlterarDados
            // 
            this.panelAlterarDados.Controls.Add(this.label13);
            this.panelAlterarDados.Controls.Add(this.btnVoltarAlterar);
            this.panelAlterarDados.Controls.Add(this.btnSalvarAlterar);
            this.panelAlterarDados.Controls.Add(this.txbMortalidadeAlterar);
            this.panelAlterarDados.Controls.Add(this.txbPesoAlterar);
            this.panelAlterarDados.Controls.Add(this.cmbCrescimentoAlterar);
            this.panelAlterarDados.Controls.Add(this.txbAvesAlterar);
            this.panelAlterarDados.Controls.Add(this.txbNumeroAlterar);
            this.panelAlterarDados.Controls.Add(this.label7);
            this.panelAlterarDados.Controls.Add(this.label8);
            this.panelAlterarDados.Controls.Add(this.label9);
            this.panelAlterarDados.Controls.Add(this.label10);
            this.panelAlterarDados.Controls.Add(this.label11);
            this.panelAlterarDados.Location = new System.Drawing.Point(89, 96);
            this.panelAlterarDados.Name = "panelAlterarDados";
            this.panelAlterarDados.Size = new System.Drawing.Size(111, 90);
            this.panelAlterarDados.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(151, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Kg";
            // 
            // btnVoltarAlterar
            // 
            this.btnVoltarAlterar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnVoltarAlterar.Location = new System.Drawing.Point(147, 167);
            this.btnVoltarAlterar.Name = "btnVoltarAlterar";
            this.btnVoltarAlterar.Size = new System.Drawing.Size(75, 34);
            this.btnVoltarAlterar.TabIndex = 13;
            this.btnVoltarAlterar.Text = "Voltar";
            this.btnVoltarAlterar.UseVisualStyleBackColor = false;
            this.btnVoltarAlterar.Click += new System.EventHandler(this.BtnVoltarAlterar_Click);
            // 
            // btnSalvarAlterar
            // 
            this.btnSalvarAlterar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSalvarAlterar.Location = new System.Drawing.Point(228, 167);
            this.btnSalvarAlterar.Name = "btnSalvarAlterar";
            this.btnSalvarAlterar.Size = new System.Drawing.Size(75, 34);
            this.btnSalvarAlterar.TabIndex = 0;
            this.btnSalvarAlterar.Text = "Salvar";
            this.btnSalvarAlterar.UseVisualStyleBackColor = false;
            this.btnSalvarAlterar.Click += new System.EventHandler(this.BtnSalvarAlterar_Click);
            // 
            // txbMortalidadeAlterar
            // 
            this.txbMortalidadeAlterar.Location = new System.Drawing.Point(94, 142);
            this.txbMortalidadeAlterar.Name = "txbMortalidadeAlterar";
            this.txbMortalidadeAlterar.Size = new System.Drawing.Size(53, 20);
            this.txbMortalidadeAlterar.TabIndex = 12;
            // 
            // txbPesoAlterar
            // 
            this.txbPesoAlterar.Location = new System.Drawing.Point(95, 111);
            this.txbPesoAlterar.Name = "txbPesoAlterar";
            this.txbPesoAlterar.Size = new System.Drawing.Size(52, 20);
            this.txbPesoAlterar.TabIndex = 11;
            // 
            // cmbCrescimentoAlterar
            // 
            this.cmbCrescimentoAlterar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCrescimentoAlterar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCrescimentoAlterar.FormattingEnabled = true;
            this.cmbCrescimentoAlterar.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmbCrescimentoAlterar.Items.AddRange(new object[] {
            "Fase Inicial",
            "Fase de Engorda",
            "Fase Crescimento"});
            this.cmbCrescimentoAlterar.Location = new System.Drawing.Point(137, 80);
            this.cmbCrescimentoAlterar.MaxDropDownItems = 3;
            this.cmbCrescimentoAlterar.Name = "cmbCrescimentoAlterar";
            this.cmbCrescimentoAlterar.Size = new System.Drawing.Size(121, 21);
            this.cmbCrescimentoAlterar.TabIndex = 10;
            // 
            // txbAvesAlterar
            // 
            this.txbAvesAlterar.Location = new System.Drawing.Point(135, 49);
            this.txbAvesAlterar.Name = "txbAvesAlterar";
            this.txbAvesAlterar.Size = new System.Drawing.Size(39, 20);
            this.txbAvesAlterar.TabIndex = 9;
            // 
            // txbNumeroAlterar
            // 
            this.txbNumeroAlterar.Enabled = false;
            this.txbNumeroAlterar.Location = new System.Drawing.Point(76, 18);
            this.txbNumeroAlterar.Name = "txbNumeroAlterar";
            this.txbNumeroAlterar.Size = new System.Drawing.Size(27, 20);
            this.txbNumeroAlterar.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mortalidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Peso Médio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Fase de crescimento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Quantidade de aves:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Número:";
            // 
            // FormCadastroLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 213);
            this.Controls.Add(this.panelAlterarDados);
            this.Controls.Add(this.panelDadosLote);
            this.Controls.Add(this.panelAlterar);
            this.Controls.Add(this.panelCadastro);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(440, 252);
            this.MinimumSize = new System.Drawing.Size(440, 252);
            this.Name = "FormCadastroLote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Lote";
            this.panelCadastro.ResumeLayout(false);
            this.panelDadosLote.ResumeLayout(false);
            this.panelDadosLote.PerformLayout();
            this.panelAlterar.ResumeLayout(false);
            this.panelAlterar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLote)).EndInit();
            this.panelAlterarDados.ResumeLayout(false);
            this.panelAlterarDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCadastro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDadosLote;
        private System.Windows.Forms.TextBox txbAves;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCrescimento;
        private System.Windows.Forms.TextBox txbMortalidade;
        private System.Windows.Forms.TextBox txbPeso;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Panel panelAlterar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvLote;
        private System.Windows.Forms.ComboBox cmbLote;
        private System.Windows.Forms.Button btnEscolherLote;
        private System.Windows.Forms.Panel panelAlterarDados;
        private System.Windows.Forms.Button btnSalvarAlterar;
        private System.Windows.Forms.TextBox txbMortalidadeAlterar;
        private System.Windows.Forms.TextBox txbPesoAlterar;
        private System.Windows.Forms.ComboBox cmbCrescimentoAlterar;
        private System.Windows.Forms.TextBox txbNumeroAlterar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbAvesAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn QntAves;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaseCrescimento;
        private System.Windows.Forms.Button btnVoltarAlterar;
        private System.Windows.Forms.Button btnSairCadastro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}