namespace App.Formularios
{
    partial class FormEquipes
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
            botaoRemover = new Button();
            botaoEditar = new Button();
            botaoAdcionar = new Button();
            gridTimes = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            DataFundacao = new DataGridViewTextBoxColumn();
            NomeEstadio = new DataGridViewTextBoxColumn();
            CapacidadeEstadio = new DataGridViewTextBoxColumn();
            FotoEstadio = new DataGridViewTextBoxColumn();
            FotoEmblema = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridTimes).BeginInit();
            SuspendLayout();
            // 
            // botaoRemover
            // 
            botaoRemover.Location = new Point(1076, 635);
            botaoRemover.Name = "botaoRemover";
            botaoRemover.Size = new Size(94, 35);
            botaoRemover.TabIndex = 7;
            botaoRemover.Text = "Remover";
            botaoRemover.UseVisualStyleBackColor = true;
            // 
            // botaoEditar
            // 
            botaoEditar.Location = new Point(947, 635);
            botaoEditar.Name = "botaoEditar";
            botaoEditar.Size = new Size(94, 35);
            botaoEditar.TabIndex = 6;
            botaoEditar.Text = "Editar";
            botaoEditar.UseVisualStyleBackColor = true;
            // 
            // botaoAdcionar
            // 
            botaoAdcionar.Location = new Point(819, 635);
            botaoAdcionar.Name = "botaoAdcionar";
            botaoAdcionar.Size = new Size(94, 35);
            botaoAdcionar.TabIndex = 5;
            botaoAdcionar.Text = "Adicionar";
            botaoAdcionar.UseVisualStyleBackColor = true;
            botaoAdcionar.Click += aoClicarNoBotaoAdicionar;
            // 
            // gridTimes
            // 
            gridTimes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridTimes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTimes.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, DataFundacao, NomeEstadio, CapacidadeEstadio, FotoEstadio, FotoEmblema });
            gridTimes.Location = new Point(12, 33);
            gridTimes.Name = "gridTimes";
            gridTimes.ReadOnly = true;
            gridTimes.RowHeadersWidth = 51;
            gridTimes.RowTemplate.Height = 29;
            gridTimes.Size = new Size(1158, 580);
            gridTimes.TabIndex = 4;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // DataFundacao
            // 
            DataFundacao.HeaderText = "Data de Fundação";
            DataFundacao.MinimumWidth = 6;
            DataFundacao.Name = "DataFundacao";
            DataFundacao.ReadOnly = true;
            // 
            // NomeEstadio
            // 
            NomeEstadio.HeaderText = "Estádio";
            NomeEstadio.MinimumWidth = 6;
            NomeEstadio.Name = "NomeEstadio";
            NomeEstadio.ReadOnly = true;
            // 
            // CapacidadeEstadio
            // 
            CapacidadeEstadio.HeaderText = "Capacidade do Estádio";
            CapacidadeEstadio.MinimumWidth = 6;
            CapacidadeEstadio.Name = "CapacidadeEstadio";
            CapacidadeEstadio.ReadOnly = true;
            // 
            // FotoEstadio
            // 
            FotoEstadio.HeaderText = "Foto do Estádio";
            FotoEstadio.MinimumWidth = 6;
            FotoEstadio.Name = "FotoEstadio";
            FotoEstadio.ReadOnly = true;
            // 
            // FotoEmblema
            // 
            FotoEmblema.HeaderText = "Foto do Emblema";
            FotoEmblema.MinimumWidth = 6;
            FotoEmblema.Name = "FotoEmblema";
            FotoEmblema.ReadOnly = true;
            // 
            // FormEquipes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 703);
            Controls.Add(botaoRemover);
            Controls.Add(botaoEditar);
            Controls.Add(botaoAdcionar);
            Controls.Add(gridTimes);
            MaximumSize = new Size(1200, 750);
            Name = "FormEquipes";
            Text = "FormularioEquipes";
            ((System.ComponentModel.ISupportInitialize)gridTimes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button botaoRemover;
        private Button botaoEditar;
        private Button botaoAdcionar;
        private DataGridView gridTimes;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn DataFundacao;
        private DataGridViewTextBoxColumn NomeEstadio;
        private DataGridViewTextBoxColumn CapacidadeEstadio;
        private DataGridViewTextBoxColumn FotoEstadio;
        private DataGridViewTextBoxColumn FotoEmblema;
    }
}