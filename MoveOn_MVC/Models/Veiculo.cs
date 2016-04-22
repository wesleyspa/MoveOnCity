using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoveOn_MVC.Models
{
    [Table("Veiculo")]
    public class Veiculo
    {
        public int VeiculoID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public string Chassi { get; set; }
        public int Passageiros { get; set; }


        public Cliente cliente { get; set; }

    }
}