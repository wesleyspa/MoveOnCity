using System;

namespace MoveOn.Domain
{
    public class Contato
    {
        public int Id { get; set; }

        public string DDI { get; set; }
        public string DDD { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public string Info { get; set; }        
    }
}