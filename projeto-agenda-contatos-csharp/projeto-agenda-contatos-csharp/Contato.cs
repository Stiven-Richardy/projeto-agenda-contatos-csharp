using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace projeto_agenda_contatos_csharp
{
    internal class Contato
    {
        private string nome;
        private string email;
        private DateTime dtNasc;
        private List<Telefone> telefones = new List<Telefone>();

        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DtNasc { get => dtNasc; set => dtNasc = value; }
        public List<Telefone> Telefones { get => telefones; set => telefones = value; }

        public Contato(string email, string nome, DateTime dtNasc)
        {
            Nome = nome;
            Email = email;
            DtNasc = dtNasc;
        }

        public Contato(string email, string nome, DateTime dtNasc, Telefone telefone)
        {
            Nome = nome;
            Email = email;
            DtNasc = dtNasc;
            adicionarTelefone(telefone);
        }

        public Contato(string nome) : this(nome, "", new DateTime()) { }

        public int getIdade()
        {
            DateTime dataAtual = DateTime.Now;
            int idade = dataAtual.Year - dtNasc.Year;
            if (dataAtual.Month < dtNasc.Month || (dataAtual.Month == dtNasc.Month && dataAtual.Day < dtNasc.Day))
            {
                idade--;
            }
            return idade;
        }

        public void adicionarTelefone(Telefone t)
        {
            if (t != null && t.Principal)
            {
                Telefone principalAtual = telefones.Find(tel => tel.Principal);
                if (principalAtual != null)
                    principalAtual.Principal = false;
            }
            if (t != null)
                telefones.Add(t);
        }

        public string getTelefonePrincipal()
        {
            Telefone telPrincipal = telefones.Find(t => t.Principal);
            return telPrincipal != null ? telPrincipal.Numero : " Não possui telefone principal";
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine($" Nome: {Nome}");
            s.AppendLine($" Email: {Email}");
            s.AppendLine($" Data de Nascimento: {DtNasc.ToString()}");
            s.AppendLine($" Idade: {getIdade()} anos");
            s.AppendLine($" Telefone Principal: {getTelefonePrincipal()}");
            if (telefones.Count > 0)
            {
                s.AppendLine(" Outros Telefones:");
                foreach (Telefone tel in telefones.Where(t => !t.Principal))
                {
                    s.AppendLine($" - {tel.Tipo}: {tel.Numero}");
                }
            }
            return s.ToString();
        }

        public override bool Equals(object obj)
        {
            bool igual = false;
            if (obj is Contato outroContato)
                if (Nome.Equals(outroContato.Nome, StringComparison.OrdinalIgnoreCase))
                    igual = true;
            return igual;
        }
    }
}
