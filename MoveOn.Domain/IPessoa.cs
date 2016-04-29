using System;

namespace MoveOn_MVC.Models
{
    public interface IPessoa
    {        
        string Nome { get; set; }
        DateTime DataNascimento { get; set; }
        string CPF_CNPJ { get; set; }
        string CNH { get; set; }
        string EstadoCivil { get; set; }
        string Email { get; set; }
    }
}