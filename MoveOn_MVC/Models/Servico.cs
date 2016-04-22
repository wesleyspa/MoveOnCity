using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoveOn_MVC.Models
{
    [Table("Servico")]
    public class Servico
    {
        public int ServicoID { get; set; }
        public string Descricao { get; set; }
        public decimal ValorAdicional { get; set; }
        public DateTime VigenciaInicial { get; set; }
        public DateTime VigenciaFinal { get; set; }
        public string InfoAdicional { get; set; }
    }
}