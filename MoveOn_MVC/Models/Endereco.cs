using System.ComponentModel.DataAnnotations.Schema;

namespace MoveOn_MVC.Models
{
    [Table("Endereco")]
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string _Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string CPF { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public decimal coordenadaX { get; set; }
        public decimal coordenadaY { get; set; }
    }
}