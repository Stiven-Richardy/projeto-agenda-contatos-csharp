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
    public partial class FrmAdicionar : Form
    {
        private Contatos agenda = new Contatos();
        public static string regexEmail = @"^[\w\.-]+@([\w-]+\.)+[\w-]{2,4}$";
        public static string regexTelefone = @"^\(?\d{2}\)?[\s-]?\d{4,5}-?\d{4}$";

        public FrmAdicionar()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNome.Text))
            {
                MessageBox.Show("O campo 'Nome' é obrigatório.", 
                    "Erro de Validação", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                tbNome.Focus();
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(tbEmail.Text, regexEmail))
            {
                MessageBox.Show("Por favor, insira um formato de e-mail válido.", 
                    "Erro de Validação", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                tbEmail.Focus();
                return;
            }

            DateTime dataNascimento = dtpDtNasc.Value;
            int idade = DateTime.Now.Year - dataNascimento.Year;

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

            string tipoTelefone = rbCelular.Checked ? "Celular" : "Telefone Fixo";
            bool principal = rbSim.Checked;

            Telefone telefone = new Telefone(tipoTelefone, tbTelefone.Text, principal);
            Contato contato = new Contato(tbEmail.Text, tbNome.Text, dtpDtNasc.Value, telefone);

            if (agenda.adicionar(contato))
            {
                MessageBox.Show("Usuário cadastrado com sucesso!",
                    "Cadastrar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                tbNome.Clear();
                tbEmail.Clear();
                tbTelefone.Clear();
            }
            else
            {
                MessageBox.Show("Usuário não foi cadastrado!",
                    "Cadastrar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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
    }
}
