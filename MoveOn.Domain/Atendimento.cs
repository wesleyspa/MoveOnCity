using System;
using System.Collections.Generic;

namespace MoveOn.Domain
{
    public class Atendimento
    {
        public Atendimento()
        {
            this.MomAbertura = DateTime.Now;
        }

        public int Id{ get; set; }

        public DateTime MomAbertura { get; set; }
        public DateTime? MomInicio { get; set; }
        public DateTime? MomConclusao { get; set; }
        public string InfoConclusao { get; set; }

        public int ContatoId { get; set; }
        public virtual ICollection<Contato> Contatos { get; set; }

        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        public int VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }

        public int EnderecoId { get; set; }
        public virtual Endereco Localizacao { get; set; }

        public int ServicoId { get; set; }
        public virtual Servico Servico { get; set; }

        public int StatusId { get; set; }
        public Status Status { get; set; }

        public int? FuncionarioId { get; set; }
        public virtual Funcionario Funcionario { get; set; }
    }
}