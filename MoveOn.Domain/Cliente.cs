using System;
using System.Collections.Generic;

namespace MoveOn.Domain
{
    public class Cliente : IPessoa
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF_CNPJ { get; set; }
        public string CNH { get; set; }
        public string EstadoCivil { get; set; }
        public string Email { get; set; }

        public int ContratoId { get; set; }
        public virtual Contrato Contrato { get; set; }

        public int EnderecoId { get; set; }
        public virtual ICollection<Endereco> Endereco { get; set; }

        public int VeiculoId { get; set; }
        public virtual ICollection<Veiculo> Veiculo { get; set; }

        public int ContatoId { get; set; }
        public virtual ICollection<Contato> Contato { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}