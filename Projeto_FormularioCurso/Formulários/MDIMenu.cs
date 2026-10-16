using Projeto_FormularioCurso.Formulários;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_FormularioCurso
{
    public partial class MDIMenu : Form
    {
        public MDIMenu()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAberto2 = this.MdiChildren.FirstOrDefault(f => f is frmCadPessoa);

            if (formAberto2 != null)
            {
                formAberto2.Activate();
                MessageBox.Show("Formulário de Cadastro já aberto!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmCadPessoa frmCadPessoa = new frmCadPessoa();
                frmCadPessoa.MdiParent = this;
                frmCadPessoa.Show();
            }
        }

        private void pessoasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formAberto = this.MdiChildren.FirstOrDefault(f => f is frmConsulta); // Procura se tem um formulario ja aberto

            if (formAberto != null)
            {
                formAberto.Activate();
                MessageBox.Show("Formulário de Consulta já aberto!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmConsulta frmConsulta = new frmConsulta();
                frmConsulta.MdiParent = this;
                frmConsulta.Show();
            }
        }

        private void listagemDePessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAberto2 = this.MdiChildren.FirstOrDefault(f => f is frmCadPessoa);

            if (formAberto2 != null)
            {
                formAberto2.Activate();
                MessageBox.Show("Formulário de Cadastro já aberto!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmCadPessoa frmCadPessoa = new frmCadPessoa();
                frmCadPessoa.MdiParent = this;
                frmCadPessoa.Show();
            }
        }

        private void MDIMenu_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Environment.UserName;
        }

        private void relatórioDePessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAberto = this.MdiChildren.FirstOrDefault(f => f is frmVisualizeRelatorio); // Procura se tem um formulario ja aberto

            if (formAberto != null)
            {
                formAberto.Activate();
                MessageBox.Show("Formulário de Relatório já aberto!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmVisualizeRelatorio frmRelatorio = new frmVisualizeRelatorio();
                frmRelatorio.MdiParent = this;
                frmRelatorio.Show();
            }
        }

        private void MDIMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Deseja realmente sair?", "Saindo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listagemDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAberto2 = this.MdiChildren.FirstOrDefault(f => f is frmCadPessoa);

            if (formAberto2 != null)
            {
                formAberto2.Activate();
                MessageBox.Show("Formulário de Cadastro já aberto!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmCadPessoa frmCadPessoa = new frmCadPessoa();
                frmCadPessoa.MdiParent = this;
                frmCadPessoa.Show();
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var formAberto2 = this.MdiChildren.FirstOrDefault(f => f is frmCadPessoa);

            if (formAberto2 != null)
            {
                formAberto2.Activate();
                MessageBox.Show("Formulário de Cadastro já aberto!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmCadPessoa frmCadPessoa = new frmCadPessoa();
                frmCadPessoa.MdiParent = this;
                frmCadPessoa.Show();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var formAberto = this.MdiChildren.FirstOrDefault(f => f is frmConsulta); // Procura se tem um formulario ja aberto

            if (formAberto != null)
            {
                formAberto.Activate();
                MessageBox.Show("Formulário de Consulta já aberto!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmConsulta frmConsulta = new frmConsulta();
                frmConsulta.MdiParent = this;
                frmConsulta.Show();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var formAberto = this.MdiChildren.FirstOrDefault(f => f is frmVisualizeRelatorio); // Procura se tem um formulario ja aberto

            if (formAberto != null)
            {
                formAberto.Activate();
                MessageBox.Show("Formulário de Relatório já aberto!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmVisualizeRelatorio frmRelatorio = new frmVisualizeRelatorio();
                frmRelatorio.MdiParent = this;
                frmRelatorio.Show();
            }
        }
    }
}
