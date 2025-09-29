using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;

namespace projeto_agenda_contatos_csharp
{
    public partial class Form1 : Form
    {
        private Form frmAtivo;
        private Contatos agenda = new Contatos();
        BindingSource bs;
        public static string regexEmail = @"^[\w\.-]+@([\w-]+\.)+[\w-]{2,4}$";
        public static string regexTelefone = @"^\(?\d{2}\)?[\s-]?\d{4,5}-?\d{4}$";

        public Form1()
        {
            InitializeComponent();
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            pnForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
                frmAtivo.Close();
        }

        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in pnPrincipal.Controls)
                ctrl.BackColor = Color.LightGray;

            frmAtivo.ForeColor = Color.Black;
            frmAtivo.BackColor = Color.OrangeRed;
        }



        private void atualizarLista()
        {
            bs = new BindingSource();
            bs.DataSource = agenda.Agenda;
            dgvContatos.DataSource = bs;
            bs.ResetBindings(false);
        }

        private void dgvContatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(agenda.Agenda[bs.Position].ToString());
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (bs != null && bs.Position > -1)
            {
                Contato contatoSelecionado = bs.Current as Contato;
                string nomeContato = contatoSelecionado != null ? $"'{contatoSelecionado.Nome}'" : "este contato";

                DialogResult resultado = MessageBox.Show(
                    $"Você tem certeza que deseja apagar {nomeContato}?",
                    "Confirmar Remoção",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    agenda.Agenda.RemoveAt(bs.Position);
                    MessageBox.Show("Contato removido com sucesso!",
                        "Remover",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    atualizarLista();
                }
            }
            else
            {
                MessageBox.Show("Selecione um contato da lista para remover!",
                    "Nenhum Contato Selecionado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnListaAgenda_Click(object sender, EventArgs e)
        {
            atualizarLista();
            ActiveButton(btnListaAgenda);
            ActiveFormClose();
        }

        private void btnCadastraContato_Click(object sender, EventArgs e)
        {
            atualizarLista();
            ActiveButton(btnCadastraContato);
            FormShow(new FrmAdicionar());
        }

        private void btnEditaContato_Click(object sender, EventArgs e)
        {
            atualizarLista();
            ActiveButton(btnEditaContato);
            FormShow(new FrmEditar());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
