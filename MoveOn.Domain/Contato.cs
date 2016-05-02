using System;

namespace MoveOn.Domain
{
    public class Contato
    {
        public int ContatoId { get; set; }
        public string DDI { get; set; }
        public string DDD { get; set; }
        public Int64 Numero { get; set; }
        public string Tipo { get; set; }
        public string Info { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}