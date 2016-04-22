using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoveOn_MVC.Models
{
    [Table("Cliente")]
    public class Cliente : IPessoa
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF_CNPJ { get; set; }
        public string CNH { get; set; }
        public string EstadoCivil { get; set; }
        public string Email { get; set; }

        //Collection de Endereço
        //Collection de Veiculo

    }
}