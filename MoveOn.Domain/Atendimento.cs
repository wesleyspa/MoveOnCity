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
        public string Status { get; set; }

        public string Logradouro { get; set; }
        public string _Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public decimal CoordenadaX { get; set; }
        public decimal CoordenadaY { get; set; }


        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        public int VeiculoCliente { get; set; }       

        public int ServicoId { get; set; }
        public virtual Servico Servico { get; set; }

        public int? AteVeiculoId { get; set; }
        public virtual AteVeiculo AteVeiculo { get; set; }

        public int? FuncionarioId { get; set; }
        public virtual Funcionario Funcionario { get; set; }
    }
}