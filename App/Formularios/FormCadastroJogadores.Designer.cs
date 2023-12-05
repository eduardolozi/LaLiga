namespace App.Formularios
{
    partial class FormCadastroJogadores
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
            label1 = new Label();
            campoIdade = new TextBox();
            campoNumeroCamisa = new TextBox();
            campoNomeJogador = new TextBox();
            campoNomeTime = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            campoFotoJogador = new PictureBox();
            label5 = new Label();
            botaoBuscarImagemJogador = new Button();
            comboPernaBoa = new ComboBox();
            comboPosicao = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            botaoSalvarCadastroJogadores = new Button();
            ((System.ComponentModel.ISupportInitialize)campoFotoJogador).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 98);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // campoIdade
            // 
            campoIdade.Location = new Point(12, 211);
            campoIdade.Name = "campoIdade";
            campoIdade.Size = new Size(191, 27);
            campoIdade.TabIndex = 1;
            // 
            // campoNumeroCamisa
            // 
            campoNumeroCamisa.Location = new Point(12, 303);
            campoNumeroCamisa.Name = "campoNumeroCamisa";
            campoNumeroCamisa.Size = new Size(191, 27);
            campoNumeroCamisa.TabIndex = 2;
            // 
            // campoNomeJogador
            // 
            campoNomeJogador.Location = new Point(12, 121);
            campoNomeJogador.Name = "campoNomeJogador";
            campoNomeJogador.Size = new Size(191, 27);
            campoNomeJogador.TabIndex = 3;
            // 
            // campoNomeTime
            // 
            campoNomeTime.Location = new Point(12, 47);
            campoNomeTime.Name = "campoNomeTime";
            campoNomeTime.Size = new Size(191, 27);
            campoNomeTime.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 188);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 6;
            label2.Text = "Idade";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 280);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 7;
            label3.Text = "Numero da camisa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 24);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 8;
            label4.Text = "Time";
            // 
            // campoFotoJogador
            // 
            campoFotoJogador.Location = new Point(257, 47);
            campoFotoJogador.Name = "campoFotoJogador";
            campoFotoJogador.Size = new Size(261, 248);
            campoFotoJogador.TabIndex = 9;
            campoFotoJogador.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(257, 24);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 10;
            label5.Text = "Foto do Jogador";
            // 
            // botaoBuscarImagemJogador
            // 
            botaoBuscarImagemJogador.Location = new Point(257, 303);
            botaoBuscarImagemJogador.Name = "botaoBuscarImagemJogador";
            botaoBuscarImagemJogador.Size = new Size(94, 29);
            botaoBuscarImagemJogador.TabIndex = 11;
            botaoBuscarImagemJogador.Text = "Buscar";
            botaoBuscarImagemJogador.UseVisualStyleBackColor = true;
            // 
            // comboPernaBoa
            // 
            comboPernaBoa.FormattingEnabled = true;
            comboPernaBoa.Location = new Point(12, 396);
            comboPernaBoa.Name = "comboPernaBoa";
            comboPernaBoa.Size = new Size(191, 28);
            comboPernaBoa.TabIndex = 12;
            comboPernaBoa.Text = "Selecione";
            // 
            // comboPosicao
            // 
            comboPosicao.FormattingEnabled = true;
            comboPosicao.Location = new Point(12, 484);
            comboPosicao.Name = "comboPosicao";
            comboPosicao.Size = new Size(191, 28);
            comboPosicao.TabIndex = 13;
            comboPosicao.Text = "Selecione";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 373);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 14;
            label6.Text = "Perna Boa";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 461);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 15;
            label7.Text = "Posição";
            // 
            // botaoSalvarCadastroJogadores
            // 
            botaoSalvarCadastroJogadores.Location = new Point(399, 479);
            botaoSalvarCadastroJogadores.Name = "botaoSalvarCadastroJogadores";
            botaoSalvarCadastroJogadores.Size = new Size(119, 34);
            botaoSalvarCadastroJogadores.TabIndex = 16;
            botaoSalvarCadastroJogadores.Text = "Salvar";
            botaoSalvarCadastroJogadores.UseVisualStyleBackColor = true;
            // 
            // FormCadastroJogadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 528);
            Controls.Add(botaoSalvarCadastroJogadores);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboPosicao);
            Controls.Add(comboPernaBoa);
            Controls.Add(botaoBuscarImagemJogador);
            Controls.Add(label5);
            Controls.Add(campoFotoJogador);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(campoNomeTime);
            Controls.Add(campoNomeJogador);
            Controls.Add(campoNumeroCamisa);
            Controls.Add(campoIdade);
            Controls.Add(label1);
            MaximumSize = new Size(548, 600);
            Name = "FormCadastroJogadores";
            Text = "FormCadastroJogadores";
            Load += FormCadastroJogadores_Load;
            ((System.ComponentModel.ISupportInitialize)campoFotoJogador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox campoIdade;
        private TextBox campoNumeroCamisa;
        private TextBox campoNomeJogador;
        private TextBox campoNomeTime;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox campoFotoJogador;
        private Label label5;
        private Button botaoBuscarImagemJogador;
        private ComboBox comboPernaBoa;
        private ComboBox comboPosicao;
        private Label label6;
        private Label label7;
        private Button botaoSalvarCadastroJogadores;
    }
}