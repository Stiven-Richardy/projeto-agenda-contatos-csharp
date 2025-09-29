namespace projeto_agenda_contatos_csharp
{
    partial class FrmEditar
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
            label1 = new Label();
            txtNome = new TextBox();
            dgvTelefones = new DataGridView();
            btnPesquisar = new Button();
            btnEditar = new Button();
            txtNomeEdit = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            gbPrincipal = new GroupBox();
            rbNao = new RadioButton();
            rbSim = new RadioButton();
            tbTelefone = new MaskedTextBox();
            lblTelefone = new Label();
            gpTipo = new GroupBox();
            rbFixo = new RadioButton();
            rbCelular = new RadioButton();
            btnAdicionarTel = new Button();
            btnEditarTel = new Button();
            dtpDtNasc = new DateTimePicker();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTelefones).BeginInit();
            gbPrincipal.SuspendLayout();
            gpTipo.SuspendLayout();
            SuspendLayout();
            // 
            // lblAdicionaContato
            // 
            lblAdicionaContato.Anchor = AnchorStyles.None;
            lblAdicionaContato.AutoSize = true;
            lblAdicionaContato.BackColor = Color.Transparent;
            lblAdicionaContato.FlatStyle = FlatStyle.Flat;
            lblAdicionaContato.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdicionaContato.Location = new Point(14, 32);
            lblAdicionaContato.Name = "lblAdicionaContato";
            lblAdicionaContato.Size = new Size(147, 24);
            lblAdicionaContato.TabIndex = 6;
            lblAdicionaContato.Text = "Editar Contato";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 67);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 7;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Location = new Point(14, 91);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(163, 27);
            txtNome.TabIndex = 8;
            // 
            // dgvTelefones
            // 
            dgvTelefones.AllowUserToAddRows = false;
            dgvTelefones.AllowUserToDeleteRows = false;
            dgvTelefones.AllowUserToResizeColumns = false;
            dgvTelefones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTelefones.Location = new Point(7, 164);
            dgvTelefones.Margin = new Padding(3, 4, 3, 4);
            dgvTelefones.MultiSelect = false;
            dgvTelefones.Name = "dgvTelefones";
            dgvTelefones.ReadOnly = true;
            dgvTelefones.RowHeadersWidth = 51;
            dgvTelefones.Size = new Size(534, 187);
            dgvTelefones.TabIndex = 9;
            dgvTelefones.CellContentClick += dgvTelefones_CellContentClick;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.Transparent;
            btnPesquisar.Cursor = Cursors.Hand;
            btnPesquisar.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnPesquisar.Location = new Point(14, 125);
            btnPesquisar.Margin = new Padding(3, 4, 3, 4);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(163, 31);
            btnPesquisar.TabIndex = 10;
            btnPesquisar.Text = "Pesquisar contato";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnEditar.Location = new Point(14, 538);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(260, 31);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar dados";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtNomeEdit
            // 
            txtNomeEdit.Cursor = Cursors.IBeam;
            txtNomeEdit.Location = new Point(14, 393);
            txtNomeEdit.Margin = new Padding(3, 4, 3, 4);
            txtNomeEdit.Name = "txtNomeEdit";
            txtNomeEdit.Size = new Size(260, 27);
            txtNomeEdit.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 369);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 12;
            label2.Text = "Nome:";
            // 
            // txtEmail
            // 
            txtEmail.Cursor = Cursors.Hand;
            txtEmail.Location = new Point(14, 448);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 27);
            txtEmail.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 424);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 14;
            label3.Text = "Email";
            // 
            // gbPrincipal
            // 
            gbPrincipal.Controls.Add(rbNao);
            gbPrincipal.Controls.Add(rbSim);
            gbPrincipal.Location = new Point(280, 432);
            gbPrincipal.Margin = new Padding(3, 4, 3, 4);
            gbPrincipal.Name = "gbPrincipal";
            gbPrincipal.Padding = new Padding(3, 4, 3, 4);
            gbPrincipal.Size = new Size(261, 57);
            gbPrincipal.TabIndex = 18;
            gbPrincipal.TabStop = false;
            gbPrincipal.Text = "Tel. Principal ?";
            // 
            // rbNao
            // 
            rbNao.AutoSize = true;
            rbNao.Cursor = Cursors.Hand;
            rbNao.Location = new Point(65, 29);
            rbNao.Margin = new Padding(3, 4, 3, 4);
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
            rbSim.Location = new Point(7, 29);
            rbSim.Margin = new Padding(3, 4, 3, 4);
            rbSim.Name = "rbSim";
            rbSim.Size = new Size(55, 24);
            rbSim.TabIndex = 14;
            rbSim.TabStop = true;
            rbSim.Text = "Sim";
            rbSim.UseVisualStyleBackColor = true;
            // 
            // tbTelefone
            // 
            tbTelefone.Cursor = Cursors.IBeam;
            tbTelefone.Location = new Point(280, 393);
            tbTelefone.Margin = new Padding(3, 4, 3, 4);
            tbTelefone.Mask = "(99) 00000-0000";
            tbTelefone.Name = "tbTelefone";
            tbTelefone.Size = new Size(261, 27);
            tbTelefone.TabIndex = 16;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(280, 369);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(129, 20);
            lblTelefone.TabIndex = 19;
            lblTelefone.Text = "Núm. de Telefone:";
            // 
            // gpTipo
            // 
            gpTipo.Controls.Add(rbFixo);
            gpTipo.Controls.Add(rbCelular);
            gpTipo.Location = new Point(280, 497);
            gpTipo.Margin = new Padding(3, 4, 3, 4);
            gpTipo.Name = "gpTipo";
            gpTipo.Padding = new Padding(3, 4, 3, 4);
            gpTipo.Size = new Size(261, 60);
            gpTipo.TabIndex = 17;
            gpTipo.TabStop = false;
            gpTipo.Text = "Tipo de Telefone";
            // 
            // rbFixo
            // 
            rbFixo.AutoSize = true;
            rbFixo.Cursor = Cursors.Hand;
            rbFixo.Location = new Point(7, 29);
            rbFixo.Margin = new Padding(3, 4, 3, 4);
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
            rbCelular.Location = new Point(128, 29);
            rbCelular.Margin = new Padding(3, 4, 3, 4);
            rbCelular.Name = "rbCelular";
            rbCelular.Size = new Size(76, 24);
            rbCelular.TabIndex = 10;
            rbCelular.TabStop = true;
            rbCelular.Text = "Celular";
            rbCelular.UseVisualStyleBackColor = true;
            rbCelular.CheckedChanged += rbCelular_CheckedChanged;
            // 
            // btnAdicionarTel
            // 
            btnAdicionarTel.Cursor = Cursors.Hand;
            btnAdicionarTel.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btnAdicionarTel.FlatStyle = FlatStyle.Flat;
            btnAdicionarTel.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnAdicionarTel.Location = new Point(423, 573);
            btnAdicionarTel.Margin = new Padding(3, 4, 3, 4);
            btnAdicionarTel.Name = "btnAdicionarTel";
            btnAdicionarTel.Size = new Size(118, 31);
            btnAdicionarTel.TabIndex = 20;
            btnAdicionarTel.Text = "Adicionar";
            btnAdicionarTel.UseVisualStyleBackColor = true;
            btnAdicionarTel.Click += btnAdicionarTel_Click;
            // 
            // btnEditarTel
            // 
            btnEditarTel.Cursor = Cursors.Hand;
            btnEditarTel.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btnEditarTel.FlatStyle = FlatStyle.Flat;
            btnEditarTel.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnEditarTel.Location = new Point(280, 573);
            btnEditarTel.Margin = new Padding(3, 4, 3, 4);
            btnEditarTel.Name = "btnEditarTel";
            btnEditarTel.Size = new Size(114, 31);
            btnEditarTel.TabIndex = 21;
            btnEditarTel.Text = "Editar";
            btnEditarTel.UseVisualStyleBackColor = true;
            btnEditarTel.Click += btnEditarTel_Click;
            // 
            // dtpDtNasc
            // 
            dtpDtNasc.Cursor = Cursors.Hand;
            dtpDtNasc.Location = new Point(14, 503);
            dtpDtNasc.Margin = new Padding(3, 4, 3, 4);
            dtpDtNasc.Name = "dtpDtNasc";
            dtpDtNasc.Size = new Size(260, 27);
            dtpDtNasc.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 479);
            label4.Name = "label4";
            label4.Size = new Size(142, 20);
            label4.TabIndex = 23;
            label4.Text = "Data de nascimento";
            // 
            // FrmEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 615);
            Controls.Add(label4);
            Controls.Add(dtpDtNasc);
            Controls.Add(btnEditarTel);
            Controls.Add(btnAdicionarTel);
            Controls.Add(gbPrincipal);
            Controls.Add(tbTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(gpTipo);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtNomeEdit);
            Controls.Add(label2);
            Controls.Add(btnEditar);
            Controls.Add(btnPesquisar);
            Controls.Add(dgvTelefones);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(lblAdicionaContato);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmEditar";
            Text = "FrmEditar";
            ((System.ComponentModel.ISupportInitialize)dgvTelefones).EndInit();
            gbPrincipal.ResumeLayout(false);
            gbPrincipal.PerformLayout();
            gpTipo.ResumeLayout(false);
            gpTipo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdicionaContato;
        private Label label1;
        private TextBox txtNome;
        private DataGridView dgvTelefones;
        private Button btnPesquisar;
        private Button btnEditar;
        private TextBox txtNomeEdit;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private GroupBox gbPrincipal;
        private RadioButton rbNao;
        private RadioButton rbSim;
        private MaskedTextBox tbTelefone;
        private Label lblTelefone;
        private GroupBox gpTipo;
        private RadioButton rbFixo;
        private RadioButton rbCelular;
        private Button btnAdicionarTel;
        private Button btnEditarTel;
        private DateTimePicker dtpDtNasc;
        private Label label4;
    }
}