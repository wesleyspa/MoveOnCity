using MoveOn.Domain;
using System.Data.Entity.ModelConfiguration;

namespace MoveOn.Infra.Mappings
{
    public class ContatoMap : EntityTypeConfiguration<Contato>
    {
        public ContatoMap()
        {
            ToTable("Contato");
            HasKey(x => x.Id);
            
            Property(x => x.DDI).IsRequired();
            Property(x => x.DDD).IsRequired();
            Property(x => x.Numero).IsRequired();            
        }
    }
}
