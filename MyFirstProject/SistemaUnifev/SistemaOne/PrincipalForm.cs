using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOne
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();   
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "O manual ainda esta em desenvolvimento\n\n Qualquer duvida entre em contato com o email: teste@teste.com",

                "Sistema ONE", MessageBoxButtons.OK, MessageBoxIcon.Information
                );
        }

        private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Deseja realmente fechar o sistema?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void horaTimer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour < 12)
            {
                saudacaoToolStripStatusLabel.Text = "Bom dia! flor do dia <3333";
            }
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour <= 18)
            {
                saudacaoToolStripStatusLabel.Text = "Boa tarde! meu Girassol";
            }
            else
            {
                saudacaoToolStripStatusLabel.Text = "Boa noite!";
            }
            horaToolStripStatusLabel.Text =
                $"{DateTime.Now.ToString("dddd")}, " +
                $"{DateTime.Now.ToString("dd")} de  " +
                $"{DateTime.Now.ToString("MMMM")} de " +
                $"{DateTime.Now.ToString("yyyy")} " +
                $"{DateTime.Now.ToString("HH:mm:ss")} ";

        }

        private void PrincipalForm_Shown(object sender, EventArgs e)
        {
            horaTimer.Start();
        }
    }
}
