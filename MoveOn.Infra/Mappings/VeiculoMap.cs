using MoveOn.Domain;
using System.Data.Entity.ModelConfiguration;

namespace MoveOn.Infra.Mappings
{
    public class VeiculoMap : EntityTypeConfiguration<Veiculo>
    {
        public VeiculoMap()
        {
            ToTable("Veiculo");
            HasKey(x => x.Id);

            Property(x => x.Marca).IsRequired().HasMaxLength(30);
            Property(x => x.Modelo).IsRequired().HasMaxLength(100);
            Property(x => x.AnoFabricacao).IsRequired();
            Property(x => x.Placa).IsRequired().HasMaxLength(8);
            Property(x => x.Cor).IsRequired().HasMaxLength(30);
            Property(x => x.Chassi).IsRequired().HasMaxLength(50);
            Property(x => x.Passageiros).IsRequired();
            Property(x => x.Portas).IsRequired();            
        }
    }
}
