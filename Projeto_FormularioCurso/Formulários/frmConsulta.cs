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
    public partial class frmConsulta : Form
    {
        private object pessoaBindingSource;

        public frmConsulta()
        {
            InitializeComponent();
        }

        private void cursoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cursoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet1.Curso'. Você pode movê-la ou removê-la conforme necessário.
            this.cursoTableAdapter.Fill(this.dataSet1.Curso);

        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbmBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool entre = cmbBuscar.SelectedItem?.ToString() == "Que esteja entre";
            txtValor2.Visible = entre;
            lblValor2.Visible = entre;
        }

        private void cbmProcurar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBuscar.Items.Clear();

            if (cmbProcurar.Text == "data_inicio" || cmbProcurar.Text == "Carga_horaria")
            {
                cmbBuscar.Items.Add("Igual a");
                cmbBuscar.Items.Add("Que começa com");
                cmbBuscar.Items.Add("Que termina em");
                cmbBuscar.Items.Add("Que esteja entre");
                cmbBuscar.Items.Add("Todos");
            }
            else
            {
                cmbBuscar.Items.Add("Igual a");
                cmbBuscar.Items.Add("Que começa com");
                cmbBuscar.Items.Add("Que termina em");
                cmbBuscar.Items.Add("Que contém");
                cmbBuscar.Items.Add("Todos");
            }

            cmbBuscar.SelectedIndex = 0;

            // esconde o valor2
            txtValor2.Visible = false;
            lblValor2.Visible = false;
            return;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            string coluna = cmbProcurar.Text;
            string colunaFormatada = "[" + coluna + "]";
            string filtro = colunaFormatada;

            if (cmbBuscar.Text == "Igual a")
            {
                filtro += "= '" + txtValor1.Text + "'";
            }
            else if (cmbBuscar.Text == "Que começa com")
            {
                filtro += " like '" + txtValor1.Text + "%'";
            }
            else if (cmbBuscar.Text == "Que termina em")
            {
                filtro += " like '%" + txtValor1.Text + "'";
            }
            else if (cmbBuscar.Text == "Que contém")
            {
                filtro += " like '%" + txtValor1.Text + "%'";
            }
            else if (cmbBuscar.Text == "Que esteja entre")
            {
                txtValor2.Visible = true;
                lblValor2.Visible = true;
                filtro += " >='" + txtValor1.Text + "' AND " + colunaFormatada + " <= '" + txtValor2.Text + "'";
            }
            else // todos
            {
                cursoBindingSource.Filter = null;
                lblLinhas.Text = dataGridView1.Rows.Count.ToString() + "Linhas";
                return;
            }

            // --- FORMATAR DATA ---
            DateTime data;
            DateTime data2;

            if (cmbProcurar.Text == "data_inicio")
            {
                switch (cmbBuscar.Text)
                {
                    case "Igual a":
                        if (DateTime.TryParse(txtValor1.Text, out data))
                        {
                            filtro = $"data_inicio = #{data: MM/dd/yyyy}#";
                        }
                        break;
                    case "Que começa com":
                        if (DateTime.TryParse(txtValor1.Text, out data))
                        {
                            filtro = $"data_inicio < #{data: MM/dd/yyyy}#";
                        }
                        break;
                    case "Que termina em":
                        if (DateTime.TryParse(txtValor1.Text, out data))
                        {
                            filtro = $"data_inicio > #{data: MM/dd/yyyy}#";
                        }
                        break;
                    case "Que esteja entre":
                        if (DateTime.TryParse(txtValor1.Text, out data) &&
                            DateTime.TryParse(txtValor2.Text, out data2))
                        {
                            filtro = $"data_inicio >= #{data: MM/dd/yyyy}# AND data_inicio <= #{data2: MM/dd/yyyy}#";
                        }
                        break;
                    case "Todos":
                        cursoBindingSource.Filter = null;
                        lblLinhas.Text = dataGridView1.Rows.Count.ToString() + "Linhas";
                        break;
                }
            }

            //APLICA O FILTRO
            cursoBindingSource.Filter = filtro;
            // Conta Linhas
            lblLinhas.Text = dataGridView1.Rows.Count.ToString() + "Linhas";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtValor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblValor2_Click(object sender, EventArgs e)
        {

        }
    }
}
