using MoveOn.Domain;
using System.Data.Entity.ModelConfiguration;

namespace MoveOn.Infra.Mappings
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Cliente");
            HasKey(x => x.ClienteId);

            Property(x => x.ClienteId).IsRequired();
            Property(x => x.Nome).IsRequired().HasMaxLength(100);
            Property(x => x.CNH).IsRequired();
            Property(x => x.EstadoCivil).IsRequired();
            Property(x => x.Email).IsRequired();

            HasRequired(x => x.Endereco);
            HasRequired(x => x.Contrato);
            HasRequired(x => x.Veiculo);
            HasRequired(x => x.Contato);
        }
    }
}
