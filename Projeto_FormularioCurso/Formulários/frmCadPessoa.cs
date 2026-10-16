using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_FormularioCurso.Formulários
{
    public partial class frmCadPessoa : Form
    {
        public frmCadPessoa()
        {
            InitializeComponent();
        }

        private void frmCadPessoa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.Curso'. Você pode movê-la ou removê-la conforme necessário.
            this.cursoTableAdapter.Fill(this.dataSet1.Curso);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente apagar tudo??", "Apagando...",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                cursoBindingSource.RemoveCurrent();
                tableAdapterManager.UpdateAll(dataSet1);

                MessageBox.Show("Registro Excluido!", "Excluido!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {
            this.Validate();
            this.cursoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }
    }
}
