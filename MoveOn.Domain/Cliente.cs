using System;
using System.Collections.Generic;

namespace MoveOn_MVC.Models
{
    public class Cliente : IPessoa
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF_CNPJ { get; set; }
        public string CNH { get; set; }
        public string EstadoCivil { get; set; }
        public string Email { get; set; }

        public int contratoId { get; set; }
        public virtual Contrato contrato { get; set; }

        //Collection de Endereço
        public virtual ICollection<Endereco> enderecos { get; set; }
        //Collection de Veiculo
        public virtual ICollection<Veiculo> veiculos { get; set; }


        public override string ToString()
        {
            return this.Nome;
        }
    }

    
}