using MoveOn_MVC.Models;
using System.Data.Entity.ModelConfiguration;

namespace MoveOn.Infra.Mappings
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Cliente");
            HasKey(a => a.ClienteId);

            Property(a => a.ClienteId).IsRequired();
            Property(a => a.Nome).IsRequired();
            Property(a => a.CNH).IsRequired();
            Property(a => a.).IsRequired();


    }
    }
}
