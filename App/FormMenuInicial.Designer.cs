namespace App
{
    partial class FormMenuInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            panel4 = new Panel();
            panelVerTimes = new Panel();
            botaoVerTimes = new Button();
            panel6 = new Panel();
            label3 = new Label();
            panelPersonalizarTimes = new Panel();
            botaoPersonalizarTimes = new Button();
            panel8 = new Panel();
            label4 = new Label();
            panelVerJogadores = new Panel();
            botaoVerJogadores = new Button();
            panel10 = new Panel();
            label5 = new Label();
            panelPersonalizarJogadores = new Panel();
            panel7 = new Panel();
            label6 = new Label();
            botaoPersonalizarJogadores = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelVerTimes.SuspendLayout();
            panel6.SuspendLayout();
            panelPersonalizarTimes.SuspendLayout();
            panel8.SuspendLayout();
            panelVerJogadores.SuspendLayout();
            panel10.SuspendLayout();
            panelPersonalizarJogadores.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 34);
            label1.TabIndex = 0;
            label1.Text = "La Liga";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1222, 54);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(0, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(1219, 11);
            panel3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.InfoText;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(linkLabel1);
            panel2.Location = new Point(0, 782);
            panel2.Name = "panel2";
            panel2.Size = new Size(1182, 30);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(3, 8);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 3;
            label2.Text = "Desenvolvido por";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(125, 8);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(117, 20);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Eduardo Lozano";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Crimson;
            panel4.Location = new Point(0, -926);
            panel4.Name = "panel4";
            panel4.Size = new Size(1219, 10);
            panel4.TabIndex = 3;
            // 
            // panelVerTimes
            // 
            panelVerTimes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelVerTimes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelVerTimes.BackColor = Color.LightGray;
            panelVerTimes.Controls.Add(botaoVerTimes);
            panelVerTimes.Controls.Add(panel6);
            panelVerTimes.Location = new Point(44, 96);
            panelVerTimes.MaximumSize = new Size(500, 380);
            panelVerTimes.Name = "panelVerTimes";
            panelVerTimes.Size = new Size(460, 270);
            panelVerTimes.TabIndex = 4;
            // 
            // botaoVerTimes
            // 
            botaoVerTimes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            botaoVerTimes.BackColor = Color.White;
            botaoVerTimes.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            botaoVerTimes.ForeColor = SystemColors.ActiveCaptionText;
            botaoVerTimes.Location = new Point(0, 235);
            botaoVerTimes.Name = "botaoVerTimes";
            botaoVerTimes.Size = new Size(460, 35);
            botaoVerTimes.TabIndex = 6;
            botaoVerTimes.Text = "Veja os times";
            botaoVerTimes.UseVisualStyleBackColor = false;
            botaoVerTimes.Click += AoClicarBotaoVerTimes;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BackColor = Color.Crimson;
            panel6.Controls.Add(label3);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(460, 34);
            panel6.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(0, 0);
            label3.MaximumSize = new Size(450, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 3, 0, 10);
            label3.Size = new Size(410, 40);
            label3.TabIndex = 5;
            label3.Text = "Conheça os times             ";
            // 
            // panelPersonalizarTimes
            // 
            panelPersonalizarTimes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPersonalizarTimes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelPersonalizarTimes.BackColor = Color.LightGray;
            panelPersonalizarTimes.Controls.Add(botaoPersonalizarTimes);
            panelPersonalizarTimes.Controls.Add(panel8);
            panelPersonalizarTimes.Location = new Point(678, 96);
            panelPersonalizarTimes.MaximumSize = new Size(500, 380);
            panelPersonalizarTimes.Name = "panelPersonalizarTimes";
            panelPersonalizarTimes.Size = new Size(460, 270);
            panelPersonalizarTimes.TabIndex = 5;
            // 
            // botaoPersonalizarTimes
            // 
            botaoPersonalizarTimes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            botaoPersonalizarTimes.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            botaoPersonalizarTimes.ForeColor = SystemColors.ActiveCaptionText;
            botaoPersonalizarTimes.Location = new Point(0, 235);
            botaoPersonalizarTimes.Name = "botaoPersonalizarTimes";
            botaoPersonalizarTimes.Size = new Size(460, 35);
            botaoPersonalizarTimes.TabIndex = 6;
            botaoPersonalizarTimes.Text = "Personalizar";
            botaoPersonalizarTimes.UseVisualStyleBackColor = true;
            botaoPersonalizarTimes.Click += AoClicarBotaoPersonalizarTimes;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = Color.Crimson;
            panel8.Controls.Add(label4);
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(460, 34);
            panel8.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(0, 0);
            label4.MaximumSize = new Size(450, 380);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 3, 0, 10);
            label4.Size = new Size(414, 40);
            label4.TabIndex = 5;
            label4.Text = "Personalize os times";
            // 
            // panelVerJogadores
            // 
            panelVerJogadores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelVerJogadores.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelVerJogadores.BackColor = Color.LightGray;
            panelVerJogadores.Controls.Add(botaoVerJogadores);
            panelVerJogadores.Controls.Add(panel10);
            panelVerJogadores.Location = new Point(44, 482);
            panelVerJogadores.MaximumSize = new Size(500, 380);
            panelVerJogadores.Name = "panelVerJogadores";
            panelVerJogadores.Size = new Size(460, 270);
            panelVerJogadores.TabIndex = 6;
            // 
            // botaoVerJogadores
            // 
            botaoVerJogadores.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            botaoVerJogadores.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            botaoVerJogadores.Location = new Point(0, 235);
            botaoVerJogadores.Name = "botaoVerJogadores";
            botaoVerJogadores.Size = new Size(460, 35);
            botaoVerJogadores.TabIndex = 6;
            botaoVerJogadores.Text = "Veja os jogadores";
            botaoVerJogadores.UseVisualStyleBackColor = true;
            botaoVerJogadores.Click += AoClicarBotaoVerJogadores;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel10.BackColor = Color.Crimson;
            panel10.Controls.Add(label5);
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(460, 34);
            panel10.TabIndex = 5;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(0, 0);
            label5.MaximumSize = new Size(450, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 3, 0, 10);
            label5.Size = new Size(410, 40);
            label5.TabIndex = 5;
            label5.Text = "Conheça os jogadores";
            // 
            // panelPersonalizarJogadores
            // 
            panelPersonalizarJogadores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPersonalizarJogadores.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelPersonalizarJogadores.BackColor = Color.LightGray;
            panelPersonalizarJogadores.Controls.Add(panel7);
            panelPersonalizarJogadores.Controls.Add(botaoPersonalizarJogadores);
            panelPersonalizarJogadores.Location = new Point(678, 482);
            panelPersonalizarJogadores.MaximumSize = new Size(500, 380);
            panelPersonalizarJogadores.Name = "panelPersonalizarJogadores";
            panelPersonalizarJogadores.Size = new Size(460, 270);
            panelPersonalizarJogadores.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel7.BackColor = Color.Crimson;
            panel7.Controls.Add(label6);
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(459, 32);
            panel7.TabIndex = 8;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(0, 0);
            label6.MaximumSize = new Size(450, 0);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 3, 0, 10);
            label6.Size = new Size(408, 40);
            label6.TabIndex = 0;
            label6.Text = "Personalize os jogadores";
            // 
            // botaoPersonalizarJogadores
            // 
            botaoPersonalizarJogadores.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            botaoPersonalizarJogadores.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            botaoPersonalizarJogadores.Location = new Point(0, 235);
            botaoPersonalizarJogadores.Name = "botaoPersonalizarJogadores";
            botaoPersonalizarJogadores.Size = new Size(460, 35);
            botaoPersonalizarJogadores.TabIndex = 0;
            botaoPersonalizarJogadores.Text = "Personalize";
            botaoPersonalizarJogadores.UseVisualStyleBackColor = true;
            botaoPersonalizarJogadores.Click += AoClicarBotaoPersonalizarJogadores;
            // 
            // FormMenuInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.MintCream;
            ClientSize = new Size(1182, 813);
            Controls.Add(panelPersonalizarJogadores);
            Controls.Add(panelVerJogadores);
            Controls.Add(panelPersonalizarTimes);
            Controls.Add(panelVerTimes);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(1200, 860);
            Name = "FormMenuInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += AoCarregarFormMenuInicial;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelVerTimes.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panelPersonalizarTimes.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panelVerJogadores.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panelPersonalizarJogadores.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private LinkLabel linkLabel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panelVerTimes;
        private Panel panel6;
        private Label label3;
        private Panel panelPersonalizarTimes;
        private Panel panel8;
        private Label label4;
        private Panel panelVerJogadores;
        private Panel panel10;
        private Label label5;
        private Button botaoVerTimes;
        private Button botaoPersonalizarTimes;
        private Button botaoVerJogadores;
        private Panel panelPersonalizarJogadores;
        private Panel panel7;
        private Button botaoPersonalizarJogadores;
        private Label label6;
    }
}