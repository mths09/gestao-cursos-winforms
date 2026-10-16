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
    public partial class frmVisualizeRelatorio : Form
    {
        public frmVisualizeRelatorio()
        {
            InitializeComponent();
        }

        private void frmVisualizeRelatório_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.Curso'. Você pode movê-la ou removê-la conforme necessário.
            this.cursoTableAdapter.Fill(this.dataSet1.Curso);

            this.reportViewer1.RefreshReport();
        }
    }
}
