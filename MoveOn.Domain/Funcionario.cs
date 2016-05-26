using System;
using System.Collections.Generic;

namespace MoveOn.Domain
{
    public class Funcionario : IPessoa
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF_CNPJ { get; set; }
        public string CNH { get; set; }
        public string EstadoCivil { get; set; }
        public string Email { get; set; }
        public DateTime DataContrato { get; set; }
        public string Senha { get; set; }

        public int FunEnderecoId { get; set; }
        public virtual FunEndereco FunEnderecos { get; set; }

        public int FunContatoId { get; set; }
        public virtual ICollection<FunContato> FunContato { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }

    }
}