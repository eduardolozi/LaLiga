using Domain.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Formularios
{
    public partial class FormEquipes : Form
    {
        private List<Time> times = new();
        public FormEquipes()
        {
            InitializeComponent();
        }

        private void AoAtualizarGrid(List<Time> times)
        {
            gridTimes.DataSource = null;
            gridTimes.DataSource = times;
        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
        }

        private void botaoRemover_Click(object sender, EventArgs e)
        {
        }

        private void aoClicarNoBotaoAdicionar(object sender, EventArgs e)
        {
            var formCadastroTimes = new FormCadastroTimes();
            formCadastroTimes.ShowDialog();

            if (formCadastroTimes.DialogResult is DialogResult.OK)
            {
                times.Add(formCadastroTimes.time);
                AoAtualizarGrid(times);
            }

        }
    }
}
