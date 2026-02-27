using SistemaOne.Mapeamento;
using SistemaOne.Negocio;
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
    public partial class AlunoListarForm : Form
    {
        public AlunoListarForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AlunoListarForm_Load(object sender, EventArgs e)
        {

        }

        private void listarButton_Click(object sender, EventArgs e)
        {
            AlunoDAO alunoDAO = new AlunoDAO();
            List<Aluno> alunos = alunoDAO.ListarFake(30);



            dataGridView1.DataSource = alunos;
        }


    }
}
