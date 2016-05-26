﻿namespace MoveOn.Domain
{
    public class FunEndereco
    {
        public int Id { get; set; }

        public string Logradouro { get; set; }
        public string _Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public decimal CoordenadaX { get; set; }
        public decimal CoordenadaY { get; set; }
    }
}