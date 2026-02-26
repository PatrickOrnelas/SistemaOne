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
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Manual de Instruções:\n\n" +
                "1. Para acessar os relatórios, clique no menu 'Relatórios'.\n" +
                "2. Selecione o relatório desejado para visualizar os dados.\n" +
                "3. Utilize as opções de filtro para refinar os resultados.\n" +
                "4. Para exportar um relatório, clique no botão 'Exportar' e escolha o formato desejado.\n" +
                "5. Para obter ajuda adicional, consulte a documentação ou entre em contato com o suporte.",
                "Manual de Instruções",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if
                (MessageBox.Show(
                    "Tem certeza de que deseja sair?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void horaTimer_Tick(object sender, EventArgs e)
        {
            // Faz a saudação de acordo com o horário do dia.
            if (DateTime.Now.Hour < 12)
            {
                saudacaoToolStripStatusLabel.Text = "Bom dia! ";
            }
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour <18)
            {
                saudacaoToolStripStatusLabel.Text = "Boa tarde! ";
            }
            else
            {
                saudacaoToolStripStatusLabel.Text = "Boa noite! ";
            }
            // Exibe a data e hora atual"
            horaToolStripStatusLabel3.Text =
                $"{DateTime.Now.ToString("dddd")}, " +
                $" {DateTime.Now.ToString("dd")} de " +
                $"{DateTime.Now.ToString("MMMM")} de " +
                $"{DateTime.Now.ToString("yyyy")} " +
                $"{DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void PrincipalForm_Shown(object sender, EventArgs e)
        {
            horaTimer.Start();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SobreForm sobreForm = new SobreForm();
            sobreForm.ShowDialog();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlunoListarForm alunoListarForm = new AlunoListarForm();
            alunoListarForm.ShowDialog();
        }
    }
}
