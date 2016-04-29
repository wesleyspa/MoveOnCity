using System;

namespace MoveOn_MVC.Models
{
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

        public int EnderecoId { get; set; }
        public virtual Endereco endereco { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }

    }
}