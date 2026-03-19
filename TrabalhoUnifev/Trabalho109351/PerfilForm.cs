using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho109351
{
    public partial class PerfilForm : Form
    {
        public PerfilForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            Trabalho109351.Settings2.Default.Nome = nomeTextBox.Text.Trim();
            Trabalho109351.Settings2.Default.Email = emailTextBox.Text.Trim();
            Trabalho109351.Settings2.Default.Info = infoTextBox.Text.Trim();
            //this.BackColor = ColorTranslator.FromHtml(Trabalho109351.Settings2.Default.Tema);
            Trabalho109351.Settings2.Default.Tema = ColorTranslator.ToHtml(this.BackColor);
            Trabalho109351.Settings2.Default.Save();   
            Close();
        }


        void SalvarFoto()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images PNG | *.png";
            ofd.Multiselect = false;
            ofd.Title = "Escolha sua foto de Perfil";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(Application.StartupPath + "\\Imagens") == false)
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\Imagens");
                }
                
                File.Copy(ofd.FileName, Application.StartupPath + "\\Imagens\\FotoPerfil.png", true);

                CarregarFoto();
            }

        }

        void CarregarFoto()
        {
            if (File.Exists(Application.StartupPath + "\\Imagens\\FotoPerfil.png"))
            
                {
                    fotoPictureBox.ImageLocation = Application.StartupPath + "\\Imagens\\FotoPerfil.png";
                }
        }

        private void PerfilForm_Shown(object sender, EventArgs e)
        {

            nomeTextBox.Text = Trabalho109351.Settings2.Default.Nome;
            emailTextBox.Text = Trabalho109351.Settings2.Default.Email;
            infoTextBox.Text = Trabalho109351.Settings2.Default.Info;
            this.BackColor = ColorTranslator.FromHtml(Trabalho109351.Settings2.Default.Tema);

            CarregarFoto();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void fotoPictureBox_Click(object sender, EventArgs e)
        {
            SalvarFoto();
        }
    }
}
