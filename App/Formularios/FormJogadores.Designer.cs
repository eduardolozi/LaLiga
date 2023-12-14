namespace App.Formularios
{
    partial class FormJogadores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxTimes = new ComboBox();
            gridJogadores = new DataGridView();
            botaoCadastrar = new Button();
            botaoEditar = new Button();
            botaoRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)gridJogadores).BeginInit();
            SuspendLayout();
            // 
            // comboBoxTimes
            // 
            comboBoxTimes.FormattingEnabled = true;
            comboBoxTimes.Location = new Point(12, 32);
            comboBoxTimes.Name = "comboBoxTimes";
            comboBoxTimes.Size = new Size(221, 28);
            comboBoxTimes.TabIndex = 0;
            comboBoxTimes.Text = "Selecione um time";
            // 
            // gridJogadores
            // 
            gridJogadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridJogadores.Location = new Point(12, 76);
            gridJogadores.Name = "gridJogadores";
            gridJogadores.RowHeadersWidth = 51;
            gridJogadores.RowTemplate.Height = 29;
            gridJogadores.Size = new Size(1158, 527);
            gridJogadores.TabIndex = 1;
            // 
            // botaoCadastrar
            // 
            botaoCadastrar.Location = new Point(805, 647);
            botaoCadastrar.Name = "botaoCadastrar";
            botaoCadastrar.Size = new Size(110, 44);
            botaoCadastrar.TabIndex = 2;
            botaoCadastrar.Text = "Cadastrar";
            botaoCadastrar.UseVisualStyleBackColor = true;
            botaoCadastrar.Click += aoClicarNoBotaoAdicionar;
            // 
            // botaoEditar
            // 
            botaoEditar.Location = new Point(933, 647);
            botaoEditar.Name = "botaoEditar";
            botaoEditar.Size = new Size(110, 44);
            botaoEditar.TabIndex = 3;
            botaoEditar.Text = "Editar";
            botaoEditar.UseVisualStyleBackColor = true;
            // 
            // botaoRemover
            // 
            botaoRemover.Location = new Point(1060, 647);
            botaoRemover.Name = "botaoRemover";
            botaoRemover.Size = new Size(110, 44);
            botaoRemover.TabIndex = 4;
            botaoRemover.Text = "Remover";
            botaoRemover.UseVisualStyleBackColor = true;
            // 
            // FormJogadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 703);
            Controls.Add(botaoRemover);
            Controls.Add(botaoEditar);
            Controls.Add(botaoCadastrar);
            Controls.Add(gridJogadores);
            Controls.Add(comboBoxTimes);
            MaximumSize = new Size(1200, 750);
            Name = "FormJogadores";
            Text = "Visualizar Jogadores";
            ((System.ComponentModel.ISupportInitialize)gridJogadores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxTimes;
        private DataGridView gridJogadores;
        private Button botaoCadastrar;
        private Button botaoEditar;
        private Button botaoRemover;
    }
}