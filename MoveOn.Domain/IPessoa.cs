using System;

namespace MoveOn.Domain
{
    public interface IPessoa
    {        
        string Nome { get; set; }
        string DataNascimento { get; set; }
        string CPF_CNPJ { get; set; }
        string CNH { get; set; }
        string EstadoCivil { get; set; }
        string Email { get; set; }
    }
}