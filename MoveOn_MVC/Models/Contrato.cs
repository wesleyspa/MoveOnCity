using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoveOn_MVC.Models
{
    [Table("Contrato")]
    public class Contrato
    {
        public int ContratoID { get; set; }
        public Cliente cliente { get; set; }
        public DateTime VigenciaInicial { get; set; }
        public DateTime VigenciaFinal { get; set; }

        //Collection de servico
        public Servico servico { get; set; }

    }
}