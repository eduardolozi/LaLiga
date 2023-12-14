using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Conversores;
using Domain.Enums;
using Domain.Modelos;

namespace App.Formularios
{
    public partial class FormCadastroTimes : Form
    {
        public Time time = new();
        private Estadio estadio = new();


        public FormCadastroTimes()
        {
            InitializeComponent();
            
        }

        private void AoCarregarFormulario(object sender, EventArgs e)
        {
            campoNomeEstadio.DataSource = Enum.GetValues(typeof(EstadioEnum));
            campoNomeEstadio.Text = "Selecione";

        }

        private void AoClicarBotaoCancelar(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado is DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void AoClicarBotaoBuscarImagemEstadio(object sender, EventArgs e)
        {
            var arquivos = new OpenFileDialog();
            arquivos.ShowDialog();

            var path = arquivos.FileName;
            campoFotoEstadio.Image = Image.FromFile(path);
            time.Estadio.FotoEstadio = ConversorDeImagem.ConverterPathParaBase64(path);

        }

        private void AoClicarBotaoBuscarImagemEmblema(object sender, EventArgs e)
        {
            var arquivos = new OpenFileDialog();
            arquivos.ShowDialog();

            var path = arquivos.FileName;
            campoFotoEmblema.Image = Image.FromFile(path);
            time.FotoEscudo = ConversorDeImagem.ConverterPathParaBase64(path);
        }

        private void AoClicarBotaoSalvar(object sender, EventArgs e)
        {
            time.Nome = campoNome.Text;
            estadio.Nome = Enum.Parse<EstadioEnum>(campoNomeEstadio.Text);
            estadio.Capacidade = int.Parse(campoCapacidade.Text);
            time.Estadio = estadio;
            time.AnoFundacao = campoDataFundacao.Value;

            this.DialogResult = DialogResult.OK;
        }
    }
}
