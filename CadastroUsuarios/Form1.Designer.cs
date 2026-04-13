namespace CadastroUsuarios
{
    partial class Form1
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
            txtRM = new TextBox();
            lblRM = new Label();
            lblCPF = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            mskCPF = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            lblSexo = new Label();
            lblDataNacimento = new Label();
            lblNaturalidade = new Label();
            comboBox2 = new ComboBox();
            btnExibir = new Button();
            btnLimpar = new Button();
            bntFechar = new Button();
            btnCalculadora = new Button();
            btnBlocoNotas = new Button();
            btnInformaçõesSistema = new Button();
            btnGoogle = new Button();
            btnPainelControle = new Button();
            btnGerenciador = new Button();
            ListBox = new ListBox();
            SuspendLayout();
            // 
            // txtRM
            // 
            txtRM.Location = new Point(50, 55);
            txtRM.Margin = new Padding(4, 5, 4, 5);
            txtRM.Name = "txtRM";
            txtRM.Size = new Size(141, 31);
            txtRM.TabIndex = 0;
            // 
            // lblRM
            // 
            lblRM.AutoSize = true;
            lblRM.Location = new Point(50, 25);
            lblRM.Margin = new Padding(4, 0, 4, 0);
            lblRM.Name = "lblRM";
            lblRM.Size = new Size(39, 25);
            lblRM.TabIndex = 1;
            lblRM.Text = "RM";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(201, 25);
            lblCPF.Margin = new Padding(4, 0, 4, 0);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(42, 25);
            lblCPF.TabIndex = 3;
            lblCPF.Text = "CPF";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(376, 25);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 25);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(376, 55);
            txtNome.Margin = new Padding(4, 5, 4, 5);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(467, 31);
            txtNome.TabIndex = 4;
            // 
            // mskCPF
            // 
            mskCPF.Location = new Point(201, 55);
            mskCPF.Margin = new Padding(4, 5, 4, 5);
            mskCPF.Mask = "###.###.###-##";
            mskCPF.Name = "mskCPF";
            mskCPF.Size = new Size(141, 31);
            mskCPF.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(50, 137);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(284, 31);
            dateTimePicker1.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Feminino", "Masculino" });
            comboBox1.Location = new Point(376, 137);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 33);
            comboBox1.TabIndex = 8;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(376, 97);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(50, 25);
            lblSexo.TabIndex = 9;
            lblSexo.Text = "Sexo";
            // 
            // lblDataNacimento
            // 
            lblDataNacimento.AutoSize = true;
            lblDataNacimento.Location = new Point(50, 97);
            lblDataNacimento.Name = "lblDataNacimento";
            lblDataNacimento.Size = new Size(173, 25);
            lblDataNacimento.TabIndex = 10;
            lblDataNacimento.Text = "Data de Nascimento";
            // 
            // lblNaturalidade
            // 
            lblNaturalidade.AutoSize = true;
            lblNaturalidade.Location = new Point(574, 97);
            lblNaturalidade.Name = "lblNaturalidade";
            lblNaturalidade.Size = new Size(113, 25);
            lblNaturalidade.TabIndex = 11;
            lblNaturalidade.Text = "Naturalidade";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Jaboticabal", "Taquaritinga", "Monte Alto", "Dobrada", "Santa Ernestina" });
            comboBox2.Location = new Point(574, 139);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(269, 33);
            comboBox2.TabIndex = 12;
            // 
            // btnExibir
            // 
            btnExibir.Location = new Point(201, 248);
            btnExibir.Name = "btnExibir";
            btnExibir.Size = new Size(173, 68);
            btnExibir.TabIndex = 13;
            btnExibir.Text = "Exibir";
            btnExibir.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(3, 248);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(173, 68);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // bntFechar
            // 
            bntFechar.Location = new Point(407, 248);
            bntFechar.Name = "bntFechar";
            bntFechar.Size = new Size(173, 68);
            bntFechar.TabIndex = 15;
            bntFechar.Text = "Fechar";
            bntFechar.UseVisualStyleBackColor = true;
            // 
            // btnCalculadora
            // 
            btnCalculadora.Location = new Point(3, 393);
            btnCalculadora.Name = "btnCalculadora";
            btnCalculadora.Size = new Size(173, 68);
            btnCalculadora.TabIndex = 16;
            btnCalculadora.Text = "Calculadora";
            btnCalculadora.UseVisualStyleBackColor = true;
            // 
            // btnBlocoNotas
            // 
            btnBlocoNotas.Location = new Point(201, 393);
            btnBlocoNotas.Name = "btnBlocoNotas";
            btnBlocoNotas.Size = new Size(173, 68);
            btnBlocoNotas.TabIndex = 17;
            btnBlocoNotas.Text = "Bloco de Notas";
            btnBlocoNotas.UseVisualStyleBackColor = true;
            // 
            // btnInformaçõesSistema
            // 
            btnInformaçõesSistema.Location = new Point(407, 393);
            btnInformaçõesSistema.Name = "btnInformaçõesSistema";
            btnInformaçõesSistema.Size = new Size(173, 68);
            btnInformaçõesSistema.TabIndex = 18;
            btnInformaçõesSistema.Text = "Informações do Sistema";
            btnInformaçõesSistema.UseVisualStyleBackColor = true;
            // 
            // btnGoogle
            // 
            btnGoogle.Location = new Point(3, 481);
            btnGoogle.Name = "btnGoogle";
            btnGoogle.Size = new Size(173, 68);
            btnGoogle.TabIndex = 19;
            btnGoogle.Text = "Google Chrome";
            btnGoogle.UseVisualStyleBackColor = true;
            btnGoogle.Click += button4_Click;
            // 
            // btnPainelControle
            // 
            btnPainelControle.Location = new Point(201, 481);
            btnPainelControle.Name = "btnPainelControle";
            btnPainelControle.Size = new Size(173, 68);
            btnPainelControle.TabIndex = 20;
            btnPainelControle.Text = "Painel de Controle";
            btnPainelControle.UseVisualStyleBackColor = true;
            // 
            // btnGerenciador
            // 
            btnGerenciador.Location = new Point(407, 481);
            btnGerenciador.Name = "btnGerenciador";
            btnGerenciador.Size = new Size(173, 68);
            btnGerenciador.TabIndex = 21;
            btnGerenciador.Text = "Gerenciador de Tarefas";
            btnGerenciador.UseVisualStyleBackColor = true;
            // 
            // ListBox
            // 
            ListBox.FormattingEnabled = true;
            ListBox.ItemHeight = 25;
            ListBox.Location = new Point(586, 202);
            ListBox.Name = "ListBox";
            ListBox.Size = new Size(341, 329);
            ListBox.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1143, 750);
            Controls.Add(ListBox);
            Controls.Add(btnGerenciador);
            Controls.Add(btnPainelControle);
            Controls.Add(btnGoogle);
            Controls.Add(btnInformaçõesSistema);
            Controls.Add(btnBlocoNotas);
            Controls.Add(btnCalculadora);
            Controls.Add(bntFechar);
            Controls.Add(btnLimpar);
            Controls.Add(btnExibir);
            Controls.Add(comboBox2);
            Controls.Add(lblNaturalidade);
            Controls.Add(lblDataNacimento);
            Controls.Add(lblSexo);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(mskCPF);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblCPF);
            Controls.Add(lblRM);
            Controls.Add(txtRM);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRM;
        private Label lblRM;
        private Label lblCPF;
        private Label lblNome;
        private TextBox txtNome;
        private MaskedTextBox mskCPF;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label lblSexo;
        private Label lblDataNacimento;
        private Label lblNaturalidade;
        private ComboBox comboBox2;
        private Button btnExibir;
        private Button btnLimpar;
        private Button bntFechar;
        private Button btnCalculadora;
        private Button btnBlocoNotas;
        private Button btnInformaçõesSistema;
        private Button btnGoogle;
        private Button btnPainelControle;
        private Button btnGerenciador;
        private ListBox ListBox;
    }
}
