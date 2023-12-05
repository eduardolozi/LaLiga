using App.Formularios;

namespace App
{
    public partial class FormMenuInicial : Form
    {
        public FormMenuInicial()
        {
            InitializeComponent();
        }

        private void AoClicarBotaoPersonalizarTimes(object sender, EventArgs e)
        {
            var formTimes = new FormEquipes();
            formTimes.ShowDialog();
        }

        private void AoClicarBotaoVerTimes(object sender, EventArgs e)
        {
            var formTimes = new FormEquipes();
            formTimes.ShowDialog();
        }

        private void AoClicarBotaoVerJogadores(object sender, EventArgs e)
        {
            var formJogadores = new FormJogadores();
            formJogadores.ShowDialog();
        }

        private void AoClicarBotaoPersonalizarJogadores(object sender, EventArgs e)
        {
            var formJogadores = new FormJogadores();
            formJogadores.ShowDialog();
        }
    }
}