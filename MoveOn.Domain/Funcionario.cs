using System;
using System.Collections.Generic;

namespace MoveOn.Domain
{
    public class Funcionario : IPessoa
    {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF_CNPJ { get; set; }
        public string CNH { get; set; }
        public string EstadoCivil { get; set; }
        public string Email { get; set; }
        public DateTime DataContrato { get; set; }

        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }

        public int ContatoId { get; set; }
        public virtual ICollection<Contato> Contato { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }

    }
}