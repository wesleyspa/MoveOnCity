using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoveOn_MVC.Models
{
    [Table("Atendimento")]
    public class Atendimento
    {
        public int AtendimentoID{ get; set; }
        public string StatusAtendimento { get; set; }
        public Cliente cliente { get; set; }
        public Endereco localizacao { get; set; }
        public string TipoServico { get; set; }
        public DateTime MomAbertura { get; set; }
        public string InfoConclusao { get; set; }        
    }
}