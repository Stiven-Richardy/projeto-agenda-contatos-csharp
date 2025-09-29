using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_agenda_contatos_csharp
{
    
    public partial class FrmEditar : Form
    {
        public static string regexEmail = @"^[\w\.-]+@([\w-]+\.)+[\w-]{2,4}$";
        public static string regexTelefone = @"^\(?\d{2}\)?[\s-]?\d{4,5}-?\d{4}$";
        private Contatos agenda = new Contatos();
        BindingSource bs;
        Contato cttPesquisado;
        public FrmEditar()
        {
            InitializeComponent();
        }
        private void atualizarLista(Contato contato)
        {
            bs = new BindingSource();
            bs.DataSource = contato.Telefones;
            dgvTelefones.DataSource = bs;
            bs.ResetBindings(false);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            cttPesquisado = agenda.Agenda.Find(c => c.Nome == nome);
            if (cttPesquisado != null)
            {
                atualizarLista(cttPesquisado);
                txtEmail.Text = cttPesquisado.Email;
                txtNomeEdit.Text = cttPesquisado.Nome;
            }
            else
            {
                MessageBox.Show("Contato não encontrado");
            }

        }

        private void dgvTelefones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Telefone telSelecionado = (bs.Current as Telefone);
            if (telSelecionado.Principal)
            {
                rbSim.Checked = true;
                rbNao.Checked = false;
            }
            else
            {
                rbSim.Checked = false;
                rbNao.Checked = true;
            }
            if (telSelecionado.Tipo == "Telefone Fixo")
            {
                rbFixo.Checked = true;
                rbCelular.Checked = false;
            }
            else
            {
                rbFixo.Checked = false;
                rbCelular.Checked = true;
            }
            tbTelefone.Text = telSelecionado.Numero;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cttPesquisado == null)
            {
                MessageBox.Show("Nenhum contato pesquisado", "Contato inexistente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }
            string nome = txtNomeEdit.Text;
            string email = txtEmail.Text;
            DateTime dataNascimento = dtpDtNasc.Value;
            int idade = DateTime.Now.Year - dataNascimento.Year;

            if (String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(email))
            {
                MessageBox.Show("Existem campos vazios");
            }
            else
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, regexEmail))
                {
                    MessageBox.Show("Por favor, insira um formato de e-mail válido.",
                        "Erro de Validação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtEmail.Focus();
                    return;
                }
                if (dataNascimento > DateTime.Now)
                {
                    MessageBox.Show("A data de nascimento não pode ser uma data futura.",
                        "Data Inválida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    dtpDtNasc.Focus();
                    return;
                }
                if (dataNascimento.Date > DateTime.Now.Date.AddYears(-idade))
                {
                    idade--;
                }

                if (idade > 120)
                {
                    MessageBox.Show("Ano de nascimento inválido. A idade máxima permitida é 120 anos.",
                        "Data Inválida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    dtpDtNasc.Focus();
                    return;
                }
                cttPesquisado.Email = email;
                cttPesquisado.Nome = nome;
                cttPesquisado.DtNasc = dtpDtNasc.Value;
            }
            if (agenda.alterar(cttPesquisado))
            {
                MessageBox.Show("Usuário atualizado com sucesso!",
                   "Editar",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                txtNomeEdit.Clear();
                txtEmail.Clear();
            }
            ;
        }

        private void rbCelular_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCelular.Checked)
            {
                tbTelefone.Mask = "(99) 00000-0000";
                tbTelefone.Clear();
            }
        }

        private void rbFixo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFixo.Checked)
            {
                tbTelefone.Mask = "(99) 0000-0000";
                tbTelefone.Clear();
            }
        }

        private void btnEditarTel_Click(object sender, EventArgs e)
        {
            if (cttPesquisado == null)
            {
                MessageBox.Show("Nenhum contato pesquisado", "Contato inexistente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }
            if (!tbTelefone.MaskCompleted)
            {
                string tipoTelefoneErro = rbCelular.Checked ? "celular (9 dígitos)" : "telefone fixo (8 dígitos)";

                MessageBox.Show($"Por favor, preencha o número de {tipoTelefoneErro} completamente.",
                                "Telefone Incompleto",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                tbTelefone.Focus();
                return;
            }

            if (!rbCelular.Checked && !rbFixo.Checked)
            {
                MessageBox.Show("Por favor, selecione o tipo de telefone (Celular ou Fixo).",
                    "Seleção Obrigatória",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!rbSim.Checked && !rbNao.Checked)
            {
                MessageBox.Show("Por favor, informe se este é o telefone principal (Sim ou Não).",
                    "Seleção Obrigatória",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(tbTelefone.Text, regexTelefone))
            {
                MessageBox.Show("O telefone deve conter apenas números (entre 8 e 11 dígitos).",
                    "Erro de Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                tbTelefone.Focus();
                return;
            }
            Telefone telefone = bs.Current as Telefone;
            telefone.Principal = rbSim.Checked ? true : false;
            telefone.Numero = tbTelefone.Text;
            telefone.Tipo = rbFixo.Checked ? "Telefone Fixo" : "Celular";
            if (agenda.alterar(cttPesquisado))
            {
                if (agenda.alterar(cttPesquisado))
                {
                    MessageBox.Show("Telefone atualizado com sucesso!",
                       "Editar",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
            }
            atualizarLista(cttPesquisado);
        }

        private void btnAdicionarTel_Click(object sender, EventArgs e)
        {
            if (cttPesquisado == null)
            {
                MessageBox.Show("Nenhum contato pesquisado", "Contato inexistente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }
            if (!tbTelefone.MaskCompleted)
            {
                string tipoTelefoneErro = rbCelular.Checked ? "celular (9 dígitos)" : "telefone fixo (8 dígitos)";

                MessageBox.Show($"Por favor, preencha o número de {tipoTelefoneErro} completamente.",
                                "Telefone Incompleto",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                tbTelefone.Focus();
                return;
            }

            if (!rbCelular.Checked && !rbFixo.Checked)
            {
                MessageBox.Show("Por favor, selecione o tipo de telefone (Celular ou Fixo).",
                    "Seleção Obrigatória",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!rbSim.Checked && !rbNao.Checked)
            {
                MessageBox.Show("Por favor, informe se este é o telefone principal (Sim ou Não).",
                    "Seleção Obrigatória",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(tbTelefone.Text, regexTelefone))
            {
                MessageBox.Show("O telefone deve conter apenas números (entre 8 e 11 dígitos).",
                    "Erro de Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                tbTelefone.Focus();
                return;
            }
            string numero = tbTelefone.Text;
            bool principal = rbSim.Checked ? true : false;
            string tipo = rbFixo.Checked ? "Telefone Fixo" : "Celular";
            Telefone telefone = new Telefone(tipo, numero, principal);
            Telefone antigoPrincipal = cttPesquisado.Telefones.Find(t => t.Principal);
            if (telefone.Principal)
            {
                if (antigoPrincipal != null)
                {
                    antigoPrincipal.Principal = false;
                }
                cttPesquisado.adicionarTelefone(telefone);
            }
            if (agenda.alterar(cttPesquisado))
            {
                if (agenda.alterar(cttPesquisado))
                {
                    MessageBox.Show("Telefone adicionado com sucesso!",
                       "Adicionar",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
            }
            atualizarLista(cttPesquisado);

        }
    }

}

