using MoveOn.Domain;
using System.Data.Entity.ModelConfiguration;

namespace MoveOn.Infra.Mappings
{
    public class ContratoMap : EntityTypeConfiguration<Contrato>
    {
        public ContratoMap()
        {
            ToTable("Contrato");
            HasKey(x => x.Id);            
        }
    }
}
