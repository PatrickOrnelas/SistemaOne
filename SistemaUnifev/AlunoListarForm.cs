using SistemaUnifev.Mapeamento;
using SistemaUnifev.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaUnifev
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

        private void listarButton_Click(object sender, EventArgs e)
        {
            AlunoDAO alunoDAO = new AlunoDAO();
            List<Aluno> alunos = alunoDAO.ListarFake(30);
            dataGridView1.DataSource = alunos;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
