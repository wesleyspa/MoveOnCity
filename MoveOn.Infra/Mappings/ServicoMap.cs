using MoveOn_MVC.Models;
using System.Data.Entity.ModelConfiguration;

namespace MoveOn.Infra.Mappings
{
    public class AtendimentoMap : EntityTypeConfiguration<Atendimento>
    {
        public AtendimentoMap()
        {
            ToTable("Atendimento");
            HasKey(a => a.AtendimentoID);

            Property(a => a.ClienteId).IsRequired();
            Property(a => a.EnderecoId).IsRequired();


    }
    }
}
