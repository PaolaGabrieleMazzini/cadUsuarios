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
            SuspendLayout();
            // 
            // txtRM
            // 
            txtRM.Location = new Point(35, 33);
            txtRM.Name = "txtRM";
            txtRM.Size = new Size(100, 23);
            txtRM.TabIndex = 0;
            // 
            // lblRM
            // 
            lblRM.AutoSize = true;
            lblRM.Location = new Point(35, 15);
            lblRM.Name = "lblRM";
            lblRM.Size = new Size(25, 15);
            lblRM.TabIndex = 1;
            lblRM.Text = "RM";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(141, 15);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(28, 15);
            lblCPF.TabIndex = 3;
            lblCPF.Text = "CPF";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(263, 15);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(263, 33);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(227, 23);
            txtNome.TabIndex = 4;
            // 
            // mskCPF
            // 
            mskCPF.Location = new Point(141, 33);
            mskCPF.Mask = "###.###.###-##";
            mskCPF.Name = "mskCPF";
            mskCPF.Size = new Size(100, 23);
            mskCPF.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(35, 82);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Feminino", "Masculino" });
            comboBox1.Location = new Point(263, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(mskCPF);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblCPF);
            Controls.Add(lblRM);
            Controls.Add(txtRM);
            Name = "Form1";
            Text = "Form1";
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
    }
}
