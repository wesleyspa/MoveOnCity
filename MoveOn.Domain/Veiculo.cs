﻿namespace MoveOn.Domain
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public string Chassi { get; set; }
        public int Passageiros { get; set; }
        public int Portas { get; set; }

        public override string ToString()
        {
            return this.Marca + " " + this.Modelo + " - " + this.Placa;
        }
    }
}