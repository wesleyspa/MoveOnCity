using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoveOn_MVC.Models
{
    public class Contato
    {
        public string DDI { get; set; }
        public string DDD { get; set; }
        public Int64 Numero { get; set; }
        public string Tipo { get; set; }      
    }
}