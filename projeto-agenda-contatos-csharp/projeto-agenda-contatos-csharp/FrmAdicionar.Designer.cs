namespace projeto_agenda_contatos_csharp
{
    partial class FrmAdicionar
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
            lblAdicionaContato = new Label();
            lblNome = new Label();
            tbNome = new TextBox();
            gpTipo = new GroupBox();
            rbFixo = new RadioButton();
            rbCelular = new RadioButton();
            lblTelefone = new Label();
            lblEmail = new Label();
            tbEmail = new TextBox();
            dtpDtNasc = new DateTimePicker();
            lblDtNasc = new Label();
            tbTelefone = new MaskedTextBox();
            gbPrincipal = new GroupBox();
            rbNao = new RadioButton();
            rbSim = new RadioButton();
            btnCadastrar = new Button();
            gpTipo.SuspendLayout();
            gbPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // lblAdicionaContato
            // 
            lblAdicionaContato.Anchor = AnchorStyles.None;
            lblAdicionaContato.AutoSize = true;
            lblAdicionaContato.BackColor = Color.Transparent;
            lblAdicionaContato.FlatStyle = FlatStyle.Flat;
            lblAdicionaContato.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdicionaContato.Location = new Point(12, 29);
            lblAdicionaContato.Margin = new Padding(4, 0, 4, 0);
            lblAdicionaContato.Name = "lblAdicionaContato";
            lblAdicionaContato.Size = new Size(180, 24);
            lblAdicionaContato.TabIndex = 5;
            lblAdicionaContato.Text = "Adicionar Contato";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 83);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // tbNome
            // 
            tbNome.Cursor = Cursors.IBeam;
            tbNome.Location = new Point(12, 105);
            tbNome.Margin = new Padding(4);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(536, 27);
            tbNome.TabIndex = 3;
            // 
            // gpTipo
            // 
            gpTipo.Controls.Add(rbFixo);
            gpTipo.Controls.Add(rbCelular);
            gpTipo.Location = new Point(12, 241);
            gpTipo.Margin = new Padding(4);
            gpTipo.Name = "gpTipo";
            gpTipo.Padding = new Padding(4);
            gpTipo.Size = new Size(536, 62);
            gpTipo.TabIndex = 3;
            gpTipo.TabStop = false;
            gpTipo.Text = "Tipo de Telefone";
            // 
            // rbFixo
            // 
            rbFixo.AutoSize = true;
            rbFixo.Cursor = Cursors.Hand;
            rbFixo.Location = new Point(8, 28);
            rbFixo.Margin = new Padding(4);
            rbFixo.Name = "rbFixo";
            rbFixo.Size = new Size(118, 24);
            rbFixo.TabIndex = 9;
            rbFixo.TabStop = true;
            rbFixo.Text = "Telefone Fixo";
            rbFixo.UseVisualStyleBackColor = true;
            rbFixo.CheckedChanged += rbFixo_CheckedChanged;
            // 
            // rbCelular
            // 
            rbCelular.AutoSize = true;
            rbCelular.Cursor = Cursors.Hand;
            rbCelular.Location = new Point(140, 28);
            rbCelular.Margin = new Padding(4);
            rbCelular.Name = "rbCelular";
            rbCelular.Size = new Size(76, 24);
            rbCelular.TabIndex = 10;
            rbCelular.TabStop = true;
            rbCelular.Text = "Celular";
            rbCelular.UseVisualStyleBackColor = true;
            rbCelular.CheckedChanged += rbCelular_CheckedChanged;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(12, 377);
            lblTelefone.Margin = new Padding(4, 0, 4, 0);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(129, 20);
            lblTelefone.TabIndex = 11;
            lblTelefone.Text = "Núm. de Telefone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 135);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "E-mail:";
            // 
            // tbEmail
            // 
            tbEmail.Cursor = Cursors.IBeam;
            tbEmail.Location = new Point(12, 155);
            tbEmail.Margin = new Padding(4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(536, 27);
            tbEmail.TabIndex = 5;
            // 
            // dtpDtNasc
            // 
            dtpDtNasc.Cursor = Cursors.Hand;
            dtpDtNasc.Location = new Point(12, 207);
            dtpDtNasc.Margin = new Padding(4);
            dtpDtNasc.Name = "dtpDtNasc";
            dtpDtNasc.Size = new Size(536, 27);
            dtpDtNasc.TabIndex = 6;
            // 
            // lblDtNasc
            // 
            lblDtNasc.AutoSize = true;
            lblDtNasc.Location = new Point(12, 184);
            lblDtNasc.Margin = new Padding(4, 0, 4, 0);
            lblDtNasc.Name = "lblDtNasc";
            lblDtNasc.Size = new Size(148, 20);
            lblDtNasc.TabIndex = 7;
            lblDtNasc.Text = "Data de Nascimento:";
            // 
            // tbTelefone
            // 
            tbTelefone.Cursor = Cursors.Hand;
            tbTelefone.Location = new Point(12, 399);
            tbTelefone.Margin = new Padding(4);
            tbTelefone.Mask = "(99) 00000-0000";
            tbTelefone.Name = "tbTelefone";
            tbTelefone.Size = new Size(536, 27);
            tbTelefone.TabIndex = 3;
            // 
            // gbPrincipal
            // 
            gbPrincipal.Controls.Add(rbNao);
            gbPrincipal.Controls.Add(rbSim);
            gbPrincipal.Location = new Point(12, 311);
            gbPrincipal.Margin = new Padding(4);
            gbPrincipal.Name = "gbPrincipal";
            gbPrincipal.Padding = new Padding(4);
            gbPrincipal.Size = new Size(536, 62);
            gbPrincipal.TabIndex = 11;
            gbPrincipal.TabStop = false;
            gbPrincipal.Text = "Tel. Principal ?";
            // 
            // rbNao
            // 
            rbNao.AutoSize = true;
            rbNao.Cursor = Cursors.Hand;
            rbNao.Location = new Point(71, 28);
            rbNao.Margin = new Padding(4);
            rbNao.Name = "rbNao";
            rbNao.Size = new Size(58, 24);
            rbNao.TabIndex = 15;
            rbNao.TabStop = true;
            rbNao.Text = "Não";
            rbNao.UseVisualStyleBackColor = true;
            // 
            // rbSim
            // 
            rbSim.AutoSize = true;
            rbSim.Cursor = Cursors.Hand;
            rbSim.Location = new Point(8, 28);
            rbSim.Margin = new Padding(4);
            rbSim.Name = "rbSim";
            rbSim.Size = new Size(55, 24);
            rbSim.TabIndex = 14;
            rbSim.TabStop = true;
            rbSim.Text = "Sim";
            rbSim.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnCadastrar.Location = new Point(12, 432);
            btnCadastrar.Margin = new Padding(4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(536, 62);
            btnCadastrar.TabIndex = 16;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FrmAdicionar
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(553, 615);
            Controls.Add(btnCadastrar);
            Controls.Add(lblAdicionaContato);
            Controls.Add(gbPrincipal);
            Controls.Add(tbTelefone);
            Controls.Add(lblNome);
            Controls.Add(lblDtNasc);
            Controls.Add(tbNome);
            Controls.Add(dtpDtNasc);
            Controls.Add(gpTipo);
            Controls.Add(tbEmail);
            Controls.Add(lblTelefone);
            Controls.Add(lblEmail);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmAdicionar";
            Text = "FrmAdicionar";
            gpTipo.ResumeLayout(false);
            gpTipo.PerformLayout();
            gbPrincipal.ResumeLayout(false);
            gbPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAdicionaContato;
        private Label lblNome;
        private TextBox tbNome;
        private GroupBox gpTipo;
        private RadioButton rbFixo;
        private RadioButton rbCelular;
        private Label lblTelefone;
        private Label lblEmail;
        private TextBox tbEmail;
        private DateTimePicker dtpDtNasc;
        private Label lblDtNasc;
        private MaskedTextBox tbTelefone;
        private GroupBox gbPrincipal;
        private RadioButton rbNao;
        private RadioButton rbSim;
        private Button btnCadastrar;
    }
}