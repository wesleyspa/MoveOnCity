using System;
using System.Collections.Generic;

namespace MoveOn_MVC.Models
{
    public class Contrato
    {
        public int ContratoID { get; set; }

        public int ClienteId { get; set; }
        public virtual Cliente cliente { get; set; }

        public DateTime VigenciaInicial { get; set; }
        public DateTime VigenciaFinal { get; set; }

        //Collection de servico
        public virtual ICollection<Servico> servicos { get; set; }


    }
}