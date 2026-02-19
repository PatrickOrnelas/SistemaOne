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
        }
    }
