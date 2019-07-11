namespace Trabalho___B.D {
    partial class FormConsultarLote {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panelConsultaLote = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPesquisarLote = new System.Windows.Forms.Button();
            this.panelPesquisar = new System.Windows.Forms.Panel();
            this.txbMortalidadeMaior = new System.Windows.Forms.TextBox();
            this.txbMortalidadeMenor = new System.Windows.Forms.TextBox();
            this.chkMortalidade = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbPesoMaior = new System.Windows.Forms.TextBox();
            this.txbPesoMenor = new System.Windows.Forms.TextBox();
            this.chkPeso = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkFase = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFasePesquisa = new System.Windows.Forms.ComboBox();
            this.txbAvesMaior = new System.Windows.Forms.TextBox();
            this.txbAvesMenor = new System.Windows.Forms.TextBox();
            this.txbNMaior = new System.Windows.Forms.TextBox();
            this.txbNMenor = new System.Windows.Forms.TextBox();
            this.btnOkPesquisar = new System.Windows.Forms.Button();
            this.chkAves = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkNumero = new System.Windows.Forms.CheckBox();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeaves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fasecrescimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesomedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mortalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelConsultaLote.SuspendLayout();
            this.panelPesquisar.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConsultaLote
            // 
            this.panelConsultaLote.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelConsultaLote.Controls.Add(this.btnSair);
            this.panelConsultaLote.Controls.Add(this.btnPesquisarLote);
            this.panelConsultaLote.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelConsultaLote.Location = new System.Drawing.Point(0, 0);
            this.panelConsultaLote.Name = "panelConsultaLote";
            this.panelConsultaLote.Size = new System.Drawing.Size(89, 213);
            this.panelConsultaLote.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSair.Location = new System.Drawing.Point(0, 178);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(89, 34);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnPesquisarLote
            // 
            this.btnPesquisarLote.BackColor = System.Drawing.Color.GhostWhite;
            this.btnPesquisarLote.Location = new System.Drawing.Point(0, 0);
            this.btnPesquisarLote.Name = "btnPesquisarLote";
            this.btnPesquisarLote.Size = new System.Drawing.Size(89, 34);
            this.btnPesquisarLote.TabIndex = 0;
            this.btnPesquisarLote.Text = "Pesquisar";
            this.btnPesquisarLote.UseVisualStyleBackColor = false;
            this.btnPesquisarLote.Click += new System.EventHandler(this.BtnPesquisarLote_Click);
            // 
            // panelPesquisar
            // 
            this.panelPesquisar.AutoScroll = true;
            this.panelPesquisar.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.panelPesquisar.Controls.Add(this.txbMortalidadeMaior);
            this.panelPesquisar.Controls.Add(this.txbMortalidadeMenor);
            this.panelPesquisar.Controls.Add(this.chkMortalidade);
            this.panelPesquisar.Controls.Add(this.label8);
            this.panelPesquisar.Controls.Add(this.label9);
            this.panelPesquisar.Controls.Add(this.txbPesoMaior);
            this.panelPesquisar.Controls.Add(this.txbPesoMenor);
            this.panelPesquisar.Controls.Add(this.chkPeso);
            this.panelPesquisar.Controls.Add(this.label6);
            this.panelPesquisar.Controls.Add(this.label7);
            this.panelPesquisar.Controls.Add(this.chkFase);
            this.panelPesquisar.Controls.Add(this.label5);
            this.panelPesquisar.Controls.Add(this.cmbFasePesquisa);
            this.panelPesquisar.Controls.Add(this.txbAvesMaior);
            this.panelPesquisar.Controls.Add(this.txbAvesMenor);
            this.panelPesquisar.Controls.Add(this.txbNMaior);
            this.panelPesquisar.Controls.Add(this.txbNMenor);
            this.panelPesquisar.Controls.Add(this.btnOkPesquisar);
            this.panelPesquisar.Controls.Add(this.chkAves);
            this.panelPesquisar.Controls.Add(this.label4);
            this.panelPesquisar.Controls.Add(this.label3);
            this.panelPesquisar.Controls.Add(this.label2);
            this.panelPesquisar.Controls.Add(this.label1);
            this.panelPesquisar.Controls.Add(this.chkNumero);
            this.panelPesquisar.Location = new System.Drawing.Point(89, 0);
            this.panelPesquisar.Name = "panelPesquisar";
            this.panelPesquisar.Size = new System.Drawing.Size(111, 90);
            this.panelPesquisar.TabIndex = 2;
            // 
            // txbMortalidadeMaior
            // 
            this.txbMortalidadeMaior.Location = new System.Drawing.Point(98, 253);
            this.txbMortalidadeMaior.Name = "txbMortalidadeMaior";
            this.txbMortalidadeMaior.Size = new System.Drawing.Size(40, 20);
            this.txbMortalidadeMaior.TabIndex = 27;
            // 
            // txbMortalidadeMenor
            // 
            this.txbMortalidadeMenor.Location = new System.Drawing.Point(28, 253);
            this.txbMortalidadeMenor.Name = "txbMortalidadeMenor";
            this.txbMortalidadeMenor.Size = new System.Drawing.Size(40, 20);
            this.txbMortalidadeMenor.TabIndex = 26;
            // 
            // chkMortalidade
            // 
            this.chkMortalidade.AutoSize = true;
            this.chkMortalidade.Location = new System.Drawing.Point(148, 255);
            this.chkMortalidade.Name = "chkMortalidade";
            this.chkMortalidade.Size = new System.Drawing.Size(69, 17);
            this.chkMortalidade.TabIndex = 25;
            this.chkMortalidade.Text = "Qualquer";
            this.chkMortalidade.UseVisualStyleBackColor = true;
            this.chkMortalidade.CheckedChanged += new System.EventHandler(this.ChkMortalidade_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Mortalidade:";
            // 
            // txbPesoMaior
            // 
            this.txbPesoMaior.Location = new System.Drawing.Point(98, 196);
            this.txbPesoMaior.Name = "txbPesoMaior";
            this.txbPesoMaior.Size = new System.Drawing.Size(40, 20);
            this.txbPesoMaior.TabIndex = 22;
            // 
            // txbPesoMenor
            // 
            this.txbPesoMenor.Location = new System.Drawing.Point(28, 196);
            this.txbPesoMenor.Name = "txbPesoMenor";
            this.txbPesoMenor.Size = new System.Drawing.Size(40, 20);
            this.txbPesoMenor.TabIndex = 21;
            // 
            // chkPeso
            // 
            this.chkPeso.AutoSize = true;
            this.chkPeso.Location = new System.Drawing.Point(148, 198);
            this.chkPeso.Name = "chkPeso";
            this.chkPeso.Size = new System.Drawing.Size(69, 17);
            this.chkPeso.TabIndex = 20;
            this.chkPeso.Text = "Qualquer";
            this.chkPeso.UseVisualStyleBackColor = true;
            this.chkPeso.CheckedChanged += new System.EventHandler(this.ChkPeso_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Peso Médio:";
            // 
            // chkFase
            // 
            this.chkFase.AutoSize = true;
            this.chkFase.Location = new System.Drawing.Point(148, 139);
            this.chkFase.Name = "chkFase";
            this.chkFase.Size = new System.Drawing.Size(56, 17);
            this.chkFase.TabIndex = 17;
            this.chkFase.Text = "Todos";
            this.chkFase.UseVisualStyleBackColor = true;
            this.chkFase.CheckedChanged += new System.EventHandler(this.ChkFase_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fase Crescimento:";
            // 
            // cmbFasePesquisa
            // 
            this.cmbFasePesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFasePesquisa.FormattingEnabled = true;
            this.cmbFasePesquisa.Items.AddRange(new object[] {
            "Fase Inicial",
            "Fase de Engorda",
            "Fase Crescimento"});
            this.cmbFasePesquisa.Location = new System.Drawing.Point(28, 137);
            this.cmbFasePesquisa.Name = "cmbFasePesquisa";
            this.cmbFasePesquisa.Size = new System.Drawing.Size(110, 21);
            this.cmbFasePesquisa.TabIndex = 15;
            // 
            // txbAvesMaior
            // 
            this.txbAvesMaior.Location = new System.Drawing.Point(98, 82);
            this.txbAvesMaior.Name = "txbAvesMaior";
            this.txbAvesMaior.Size = new System.Drawing.Size(40, 20);
            this.txbAvesMaior.TabIndex = 14;
            // 
            // txbAvesMenor
            // 
            this.txbAvesMenor.Location = new System.Drawing.Point(28, 82);
            this.txbAvesMenor.Name = "txbAvesMenor";
            this.txbAvesMenor.Size = new System.Drawing.Size(40, 20);
            this.txbAvesMenor.TabIndex = 13;
            // 
            // txbNMaior
            // 
            this.txbNMaior.Location = new System.Drawing.Point(98, 23);
            this.txbNMaior.Name = "txbNMaior";
            this.txbNMaior.Size = new System.Drawing.Size(40, 20);
            this.txbNMaior.TabIndex = 12;
            // 
            // txbNMenor
            // 
            this.txbNMenor.Location = new System.Drawing.Point(28, 23);
            this.txbNMenor.Name = "txbNMenor";
            this.txbNMenor.Size = new System.Drawing.Size(40, 20);
            this.txbNMenor.TabIndex = 11;
            // 
            // btnOkPesquisar
            // 
            this.btnOkPesquisar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnOkPesquisar.Location = new System.Drawing.Point(221, 272);
            this.btnOkPesquisar.Name = "btnOkPesquisar";
            this.btnOkPesquisar.Size = new System.Drawing.Size(75, 34);
            this.btnOkPesquisar.TabIndex = 10;
            this.btnOkPesquisar.Text = "OK";
            this.btnOkPesquisar.UseVisualStyleBackColor = false;
            this.btnOkPesquisar.Click += new System.EventHandler(this.BtnOkPesquisar_Click);
            // 
            // chkAves
            // 
            this.chkAves.AutoSize = true;
            this.chkAves.Location = new System.Drawing.Point(148, 84);
            this.chkAves.Name = "chkAves";
            this.chkAves.Size = new System.Drawing.Size(69, 17);
            this.chkAves.TabIndex = 9;
            this.chkAves.Text = "Qualquer";
            this.chkAves.UseVisualStyleBackColor = true;
            this.chkAves.CheckedChanged += new System.EventHandler(this.ChkAves_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantida de Aves:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número:";
            // 
            // chkNumero
            // 
            this.chkNumero.AutoSize = true;
            this.chkNumero.Location = new System.Drawing.Point(148, 25);
            this.chkNumero.Name = "chkNumero";
            this.chkNumero.Size = new System.Drawing.Size(56, 17);
            this.chkNumero.TabIndex = 0;
            this.chkNumero.Text = "Todos";
            this.chkNumero.UseVisualStyleBackColor = true;
            this.chkNumero.CheckedChanged += new System.EventHandler(this.ChkNumero_CheckedChanged);
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.Controls.Add(this.dgv);
            this.panelDataGrid.Location = new System.Drawing.Point(207, 0);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(111, 90);
            this.panelDataGrid.TabIndex = 3;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.quantidadeaves,
            this.fasecrescimento,
            this.pesomedio,
            this.mortalidade});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(111, 90);
            this.dgv.TabIndex = 0;
            // 
            // numero
            // 
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            // 
            // quantidadeaves
            // 
            this.quantidadeaves.HeaderText = "Quantidade de Aves";
            this.quantidadeaves.Name = "quantidadeaves";
            // 
            // fasecrescimento
            // 
            this.fasecrescimento.HeaderText = "Fase de Crescimento";
            this.fasecrescimento.Name = "fasecrescimento";
            // 
            // pesomedio
            // 
            this.pesomedio.HeaderText = "Peso Médio (Kg)";
            this.pesomedio.Name = "pesomedio";
            // 
            // mortalidade
            // 
            this.mortalidade.HeaderText = "Mortalidades";
            this.mortalidade.Name = "mortalidade";
            // 
            // FormConsultarLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 213);
            this.Controls.Add(this.panelDataGrid);
            this.Controls.Add(this.panelPesquisar);
            this.Controls.Add(this.panelConsultaLote);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(440, 252);
            this.MinimumSize = new System.Drawing.Size(440, 252);
            this.Name = "FormConsultarLote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Lote";
            this.panelConsultaLote.ResumeLayout(false);
            this.panelPesquisar.ResumeLayout(false);
            this.panelPesquisar.PerformLayout();
            this.panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConsultaLote;
        private System.Windows.Forms.Button btnPesquisarLote;
        private System.Windows.Forms.Panel panelPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAves;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOkPesquisar;
        private System.Windows.Forms.CheckBox chkFase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFasePesquisa;
        private System.Windows.Forms.TextBox txbAvesMaior;
        private System.Windows.Forms.TextBox txbAvesMenor;
        private System.Windows.Forms.TextBox txbNMaior;
        private System.Windows.Forms.TextBox txbNMenor;
        private System.Windows.Forms.TextBox txbPesoMaior;
        private System.Windows.Forms.TextBox txbPesoMenor;
        private System.Windows.Forms.CheckBox chkPeso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbMortalidadeMaior;
        private System.Windows.Forms.TextBox txbMortalidadeMenor;
        private System.Windows.Forms.CheckBox chkMortalidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeaves;
        private System.Windows.Forms.DataGridViewTextBoxColumn fasecrescimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesomedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn mortalidade;
    }
}