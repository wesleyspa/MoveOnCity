using System;

namespace MoveOn_MVC.Models
{
    public class Atendimento
    {
        public int AtendimentoID{ get; set; }

        public int ClienteId { get; set; }
        public virtual Cliente cliente { get; set; }

        public int EnderecoId { get; set; }
        public virtual Endereco localizacao { get; set; }

        public int ServicoId { get; set; }

        public string StatusAtendimento { get; set; }

        public DateTime MomAbertura { get; set; }

        public DateTime MomInicio { get; set; }
        public DateTime MomConclusao { get; set; }

        public string InfoConclusao { get; set; }

        public int ResponsavelId { get; set; }
        public virtual Funcionario responsavel { get; set; }

        public int VeiculoId { get; set; }
        public Veiculo veiculo { get; set; }

    }
}