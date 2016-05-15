using System;
using System.Collections.Generic;

namespace MoveOn.Domain
{
    public class Contrato
    {
        public int Id { get; set; }

        public DateTime VigenciaInicial { get; set; }
        public DateTime VigenciaFinal { get; set; }

        //public int ServicoId { get; set; }
        //public virtual ICollection<Servico> Servico { get; set; }
    }
}