using MoveOn.Domain;
using System.Data.Entity.ModelConfiguration;

namespace MoveOn.Infra.Mappings
{
    public class StatusMap : EntityTypeConfiguration<Status>
    {
        public StatusMap()
        {
            ToTable("Status");
            HasKey(a => a.StatusId);

            Property(a => a.Descricao).IsRequired().HasMaxLength(30);            
        }
    }
}
