﻿using System;
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
    public partial class FormJogadores : Form
    {
        public FormJogadores()
        {
            InitializeComponent();
        }

        private void aoClicarNoBotaoAdicionar(object sender, EventArgs e)
        {
            var formCadastroJogadores = new FormCadastroJogadores();
            formCadastroJogadores.ShowDialog();
        }
    }
}
