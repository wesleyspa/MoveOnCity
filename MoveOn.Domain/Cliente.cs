using System;
using System.Collections.Generic;

namespace MoveOn.Domain
{
    public class Cliente : IPessoa
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF_CNPJ { get; set; }
        public string CNH { get; set; }
        public string EstadoCivil { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }

        //public int ContratoId { get; set; }
        //public virtual Contrato Contrato { get; set; }

        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }

        public int VeiculoId { get; set; }
        public virtual Veiculo Veiculo { get; set; }
               
        public override string ToString()
        {
            return this.Nome;
        }
    }
}