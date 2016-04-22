using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoveOn_MVC.Models
{
    [Table("Atendimento")]
    public class AtendimentoIniciado
    {        
        public DateTime MomInicio { get; set; }
        public DateTime MomConclusao { get; set; }
        public string InfoConclusao { get; set; }

        public Atendimento atendimento { get; set; }
        public Funcionario responsavel { get; set; }
        public Veiculo veiculo { get; set; }
    }
}