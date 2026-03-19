using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho109351
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void mensagemTimer_Tick(object sender, EventArgs e)
        {
            string mensagem = "Bom Dia";
            if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
                mensagem = "Boa Tarde";
            else
                mensagem = "Boa Noite";

            mensagem += " :: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            mensagemToolStripStatusLabel.Text = mensagem;
        }
        void CarregaDados()
        {
            //if (Trabalho109351.Settings2.Default.Tema == "Claro")
            //{
            //    this.BackColor = Color.White;
            //}
            //else if (Trabalho109351.Settings2.Default.Tema == "Escuro")
            //{
            //    this.BackColor = Color.DarkGray;
            //}
            this.BackColor = ColorTranslator.FromHtml(Trabalho109351.Settings2.Default.Tema);

        }

        private void PrincipalForm_Shown(object sender, EventArgs e)
        {
            CarregaDados();

                mensagemTimer.Start();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SobreForn().ShowDialog();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PerfilForm().ShowDialog();

            CarregaDados();
        }
    }
}
