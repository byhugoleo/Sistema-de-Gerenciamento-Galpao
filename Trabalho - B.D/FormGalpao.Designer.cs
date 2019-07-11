namespace Trabalho___B.D
{
    partial class FormMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLotes = new System.Windows.Forms.Button();
            this.panelLotes = new System.Windows.Forms.Panel();
            this.btnConsultarLote = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.pcbWelcome = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLotes.SuspendLayout();
            this.panelWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.btnLotes);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(89, 213);
            this.panelMenu.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.GhostWhite;
            this.button4.Location = new System.Drawing.Point(0, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 34);
            this.button4.TabIndex = 4;
            this.button4.Text = "Estoque";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.GhostWhite;
            this.button3.Location = new System.Drawing.Point(0, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Movimentação";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.GhostWhite;
            this.button2.Location = new System.Drawing.Point(0, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Compras";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GhostWhite;
            this.button1.Location = new System.Drawing.Point(0, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Vendas";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnLotes
            // 
            this.btnLotes.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLotes.Location = new System.Drawing.Point(0, 0);
            this.btnLotes.Name = "btnLotes";
            this.btnLotes.Size = new System.Drawing.Size(89, 34);
            this.btnLotes.TabIndex = 0;
            this.btnLotes.Text = "Lotes";
            this.btnLotes.UseVisualStyleBackColor = false;
            this.btnLotes.Click += new System.EventHandler(this.BtnLotes_Click);
            // 
            // panelLotes
            // 
            this.panelLotes.Controls.Add(this.btnConsultarLote);
            this.panelLotes.Controls.Add(this.btnCadastrar);
            this.panelLotes.Location = new System.Drawing.Point(89, 0);
            this.panelLotes.Name = "panelLotes";
            this.panelLotes.Size = new System.Drawing.Size(111, 90);
            this.panelLotes.TabIndex = 1;
            // 
            // btnConsultarLote
            // 
            this.btnConsultarLote.BackColor = System.Drawing.Color.GhostWhite;
            this.btnConsultarLote.Location = new System.Drawing.Point(55, 56);
            this.btnConsultarLote.Name = "btnConsultarLote";
            this.btnConsultarLote.Size = new System.Drawing.Size(219, 38);
            this.btnConsultarLote.TabIndex = 1;
            this.btnConsultarLote.Text = "Consultar Dados";
            this.btnConsultarLote.UseVisualStyleBackColor = false;
            this.btnConsultarLote.Click += new System.EventHandler(this.BtnConsultarLote_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnCadastrar.Location = new System.Drawing.Point(55, 12);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(219, 38);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar/Alterar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // panelWelcome
            // 
            this.panelWelcome.Controls.Add(this.pcbWelcome);
            this.panelWelcome.Location = new System.Drawing.Point(206, 0);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(111, 90);
            this.panelWelcome.TabIndex = 2;
            // 
            // pcbWelcome
            // 
            this.pcbWelcome.Image = ((System.Drawing.Image)(resources.GetObject("pcbWelcome.Image")));
            this.pcbWelcome.Location = new System.Drawing.Point(40, 12);
            this.pcbWelcome.Name = "pcbWelcome";
            this.pcbWelcome.Size = new System.Drawing.Size(249, 104);
            this.pcbWelcome.TabIndex = 0;
            this.pcbWelcome.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 213);
            this.Controls.Add(this.panelLotes);
            this.Controls.Add(this.panelWelcome);
            this.Controls.Add(this.panelMenu);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(440, 252);
            this.MinimumSize = new System.Drawing.Size(440, 252);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Galpão";
            this.panelMenu.ResumeLayout(false);
            this.panelLotes.ResumeLayout(false);
            this.panelWelcome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbWelcome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnLotes;
        private System.Windows.Forms.Panel panelLotes;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.PictureBox pcbWelcome;
        private System.Windows.Forms.Button btnConsultarLote;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

