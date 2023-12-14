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
            components = new System.ComponentModel.Container();
            botaoRemover = new Button();
            botaoEditar = new Button();
            botaoAdcionar = new Button();
            gridTimes = new DataGridView();
            NomeEstadio = new DataGridViewTextBoxColumn();
            estadioBindingSource = new BindingSource(components);
            estadioBindingSource1 = new BindingSource(components);
            timeBindingSource = new BindingSource(components);
            timeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadioBindingSource2 = new BindingSource(components);
            estadioBindingSource3 = new BindingSource(components);
            jogadoresBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)gridTimes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)estadioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)estadioBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)estadioBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)estadioBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jogadoresBindingSource).BeginInit();
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
            gridTimes.AutoGenerateColumns = false;
            gridTimes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridTimes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTimes.Columns.AddRange(new DataGridViewColumn[] { NomeEstadio, timeIdDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn });
            gridTimes.DataSource = timeBindingSource;
            gridTimes.Location = new Point(12, 33);
            gridTimes.Name = "gridTimes";
            gridTimes.ReadOnly = true;
            gridTimes.RowHeadersWidth = 51;
            gridTimes.RowTemplate.Height = 29;
            gridTimes.Size = new Size(1158, 580);
            gridTimes.TabIndex = 4;
            // 
            // NomeEstadio
            // 
            NomeEstadio.DataPropertyName = "Domain.Modelos.Estadio";
            NomeEstadio.HeaderText = "Nome do Estádio";
            NomeEstadio.MinimumWidth = 6;
            NomeEstadio.Name = "NomeEstadio";
            NomeEstadio.ReadOnly = true;
            // 
            // estadioBindingSource
            // 
            estadioBindingSource.DataSource = typeof(Domain.Modelos.Estadio);
            // 
            // estadioBindingSource1
            // 
            estadioBindingSource1.DataSource = typeof(Domain.Modelos.Estadio);
            // 
            // timeBindingSource
            // 
            timeBindingSource.DataSource = typeof(Domain.Modelos.Time);
            // 
            // timeIdDataGridViewTextBoxColumn
            // 
            timeIdDataGridViewTextBoxColumn.DataPropertyName = "TimeId";
            timeIdDataGridViewTextBoxColumn.HeaderText = "TimeId";
            timeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeIdDataGridViewTextBoxColumn.Name = "timeIdDataGridViewTextBoxColumn";
            timeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadioBindingSource2
            // 
            estadioBindingSource2.DataSource = typeof(Domain.Modelos.Estadio);
            // 
            // estadioBindingSource3
            // 
            estadioBindingSource3.DataSource = typeof(Domain.Modelos.Estadio);
            // 
            // jogadoresBindingSource
            // 
            jogadoresBindingSource.DataMember = "Jogadores";
            jogadoresBindingSource.DataSource = timeBindingSource;
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
            ((System.ComponentModel.ISupportInitialize)estadioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)estadioBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)estadioBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)estadioBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)jogadoresBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button botaoRemover;
        private Button botaoEditar;
        private Button botaoAdcionar;
        private DataGridView gridTimes;
        private DataGridViewTextBoxColumn NomeEstadio;
        private DataGridViewTextBoxColumn timeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private BindingSource timeBindingSource;
        private BindingSource estadioBindingSource;
        private BindingSource estadioBindingSource1;
        private BindingSource estadioBindingSource2;
        private BindingSource estadioBindingSource3;
        private BindingSource jogadoresBindingSource;
    }
}