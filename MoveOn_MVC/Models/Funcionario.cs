using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoveOn_MVC.Models
{
    [Table("Funcionario")]
    public class Funcionario : IPessoa
    {
        public int FuncionarioID { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF_CNPJ { get; set; }
        public string CNH { get; set; }
        public string EstadoCivil { get; set; }
        public string Email { get; set; }
        public DateTime DataContrato { get; set; }


        public Endereco endereco { get; set; }


    }
}