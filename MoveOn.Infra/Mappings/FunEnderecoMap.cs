using MoveOn.Domain;
using System.Data.Entity.ModelConfiguration;

namespace MoveOn.Infra.Mappings
{
    public class FunEnderecoMap : EntityTypeConfiguration<FunEndereco>
    {
        public FunEnderecoMap()
        {
            ToTable("FunEndereco");
            HasKey(x => x.Id);

            Property(x => x.Logradouro).IsRequired().HasMaxLength(10);
            Property(x => x._Endereco).IsRequired().HasMaxLength(100);
            Property(x => x.Numero).IsRequired().HasMaxLength(15);
            Property(x => x.Bairro).IsRequired().HasMaxLength(100);
            Property(x => x.Complemento).HasMaxLength(100);
            Property(x => x.CEP).IsRequired().HasMaxLength(8);
            Property(x => x.Cidade).IsRequired().HasMaxLength(50);
            Property(x => x.Estado).IsRequired().HasMaxLength(2);
            Property(x => x.Pais).IsRequired().HasMaxLength(30);            
        }
    }
}
