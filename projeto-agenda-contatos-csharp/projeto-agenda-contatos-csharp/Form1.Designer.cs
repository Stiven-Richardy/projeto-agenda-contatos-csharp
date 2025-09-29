namespace projeto_agenda_contatos_csharp
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
            dgvContatos = new DataGridView();
            btnRemover = new Button();
            pnPrincipal = new Panel();
            btnSair = new Button();
            btnEditaContato = new Button();
            btnCadastraContato = new Button();
            btnListaAgenda = new Button();
            panel3 = new Panel();
            label1 = new Label();
            pnForm = new Panel();
            lblListaContato = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvContatos).BeginInit();
            pnPrincipal.SuspendLayout();
            panel3.SuspendLayout();
            pnForm.SuspendLayout();
            SuspendLayout();
            // 
            // dgvContatos
            // 
            dgvContatos.AllowUserToAddRows = false;
            dgvContatos.AllowUserToDeleteRows = false;
            dgvContatos.AllowUserToResizeColumns = false;
            dgvContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContatos.Location = new Point(7, 41);
            dgvContatos.Margin = new Padding(3, 4, 3, 4);
            dgvContatos.MultiSelect = false;
            dgvContatos.Name = "dgvContatos";
            dgvContatos.ReadOnly = true;
            dgvContatos.RowHeadersWidth = 51;
            dgvContatos.Size = new Size(533, 500);
            dgvContatos.TabIndex = 1;
            dgvContatos.CellContentClick += dgvContatos_CellContentClick;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.LightGray;
            btnRemover.Cursor = Cursors.Hand;
            btnRemover.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnRemover.Location = new Point(7, 548);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(533, 52);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // pnPrincipal
            // 
            pnPrincipal.BackColor = Color.LightGray;
            pnPrincipal.Controls.Add(btnSair);
            pnPrincipal.Controls.Add(btnEditaContato);
            pnPrincipal.Controls.Add(btnCadastraContato);
            pnPrincipal.Controls.Add(btnListaAgenda);
            pnPrincipal.Controls.Add(panel3);
            pnPrincipal.Dock = DockStyle.Left;
            pnPrincipal.Location = new Point(0, 0);
            pnPrincipal.Margin = new Padding(3, 4, 3, 4);
            pnPrincipal.Name = "pnPrincipal";
            pnPrincipal.Size = new Size(229, 615);
            pnPrincipal.TabIndex = 4;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.Cursor = Cursors.Hand;
            btnSair.Dock = DockStyle.Top;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnSair.ForeColor = Color.Black;
            btnSair.Location = new Point(0, 334);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(229, 67);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnEditaContato
            // 
            btnEditaContato.BackColor = Color.Transparent;
            btnEditaContato.Cursor = Cursors.Hand;
            btnEditaContato.Dock = DockStyle.Top;
            btnEditaContato.FlatAppearance.BorderSize = 0;
            btnEditaContato.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btnEditaContato.FlatStyle = FlatStyle.Flat;
            btnEditaContato.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnEditaContato.ForeColor = Color.Black;
            btnEditaContato.Location = new Point(0, 267);
            btnEditaContato.Margin = new Padding(3, 4, 3, 4);
            btnEditaContato.Name = "btnEditaContato";
            btnEditaContato.Size = new Size(229, 67);
            btnEditaContato.TabIndex = 7;
            btnEditaContato.Text = "Editar";
            btnEditaContato.UseVisualStyleBackColor = false;
            btnEditaContato.Click += btnEditaContato_Click;
            // 
            // btnCadastraContato
            // 
            btnCadastraContato.BackColor = Color.Transparent;
            btnCadastraContato.Cursor = Cursors.Hand;
            btnCadastraContato.Dock = DockStyle.Top;
            btnCadastraContato.FlatAppearance.BorderSize = 0;
            btnCadastraContato.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btnCadastraContato.FlatStyle = FlatStyle.Flat;
            btnCadastraContato.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnCadastraContato.ForeColor = Color.Black;
            btnCadastraContato.Location = new Point(0, 200);
            btnCadastraContato.Margin = new Padding(3, 4, 3, 4);
            btnCadastraContato.Name = "btnCadastraContato";
            btnCadastraContato.Size = new Size(229, 67);
            btnCadastraContato.TabIndex = 6;
            btnCadastraContato.Text = "Adicionar";
            btnCadastraContato.UseVisualStyleBackColor = false;
            btnCadastraContato.Click += btnCadastraContato_Click;
            // 
            // btnListaAgenda
            // 
            btnListaAgenda.BackColor = Color.Transparent;
            btnListaAgenda.Cursor = Cursors.Hand;
            btnListaAgenda.Dock = DockStyle.Top;
            btnListaAgenda.FlatAppearance.BorderSize = 0;
            btnListaAgenda.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btnListaAgenda.FlatStyle = FlatStyle.Flat;
            btnListaAgenda.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnListaAgenda.ForeColor = Color.Black;
            btnListaAgenda.Location = new Point(0, 133);
            btnListaAgenda.Margin = new Padding(3, 4, 3, 4);
            btnListaAgenda.Name = "btnListaAgenda";
            btnListaAgenda.Size = new Size(229, 67);
            btnListaAgenda.TabIndex = 5;
            btnListaAgenda.Text = "Lista de Contatos";
            btnListaAgenda.UseVisualStyleBackColor = false;
            btnListaAgenda.Click += btnListaAgenda_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.ForeColor = Color.DimGray;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(229, 133);
            panel3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(44, 51);
            label1.Name = "label1";
            label1.Size = new Size(134, 33);
            label1.TabIndex = 0;
            label1.Text = "AGENDA";
            // 
            // pnForm
            // 
            pnForm.Controls.Add(lblListaContato);
            pnForm.Controls.Add(dgvContatos);
            pnForm.Controls.Add(btnRemover);
            pnForm.Dock = DockStyle.Fill;
            pnForm.Location = new Point(229, 0);
            pnForm.Margin = new Padding(3, 4, 3, 4);
            pnForm.Name = "pnForm";
            pnForm.Size = new Size(553, 615);
            pnForm.TabIndex = 5;
            // 
            // lblListaContato
            // 
            lblListaContato.Anchor = AnchorStyles.None;
            lblListaContato.AutoSize = true;
            lblListaContato.BackColor = Color.Transparent;
            lblListaContato.FlatStyle = FlatStyle.Flat;
            lblListaContato.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListaContato.Location = new Point(7, 12);
            lblListaContato.Name = "lblListaContato";
            lblListaContato.Size = new Size(177, 24);
            lblListaContato.TabIndex = 4;
            lblListaContato.Text = "Lista de Contatos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(782, 615);
            Controls.Add(pnForm);
            Controls.Add(pnPrincipal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Agenda de Contatos";
            ((System.ComponentModel.ISupportInitialize)dgvContatos).EndInit();
            pnPrincipal.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnForm.ResumeLayout(false);
            pnForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvContatos;
        private Button btnRemover;
        private Panel pnPrincipal;
        private Panel panel3;
        private Button btnListaAgenda;
        private Button btnCadastraContato;
        private Button btnEditaContato;
        private Button btnSair;
        private Panel pnForm;
        private Label lblListaContato;
        private Label label1;
    }
}
