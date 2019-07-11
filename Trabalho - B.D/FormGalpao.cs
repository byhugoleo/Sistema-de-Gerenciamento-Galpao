using System;
using System.Windows.Forms;

namespace Trabalho___B.D {
    public partial class FormMenu : Form {

        public FormMenu() {
            InitializeComponent();
            panelLotes.Visible = false;
            panelWelcome.Visible = true;
            panelWelcome.Location = new System.Drawing.Point(89, 0);
            panelWelcome.Size = new System.Drawing.Size(329, 213);
        }

        private void Reset() {
            panelWelcome.Visible = false;
            panelLotes.Location = new System.Drawing.Point(89, 0);
            panelLotes.Size = new System.Drawing.Size(111, 90);
            panelWelcome.Location = new System.Drawing.Point(207, 0);
            panelWelcome.Size = new System.Drawing.Size(111, 90);
        }

        private void Set_Lote() {
            panelLotes.Location = new System.Drawing.Point(89, 0);
            panelLotes.Size = new System.Drawing.Size(329, 213);
        }

        private void BtnLotes_Click(object sender, EventArgs e) {
            Reset();
            Set_Lote();
            panelLotes.Visible = true;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e) {
            new FormCadastroLote().Show();
        }

        private void BtnConsultarLote_Click(object sender, EventArgs e) {
            new FormConsultarLote().Show();
        }
    }
}
