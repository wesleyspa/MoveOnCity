using MoveOn.Domain;
using System.Data.Entity.ModelConfiguration;

namespace MoveOn.Infra.Mappings
{
    public class AtendimentoMap : EntityTypeConfiguration<Atendimento>
    {
        public AtendimentoMap()
        {
            ToTable("Atendimento");
            HasKey(x => x.AtendimentoId);

            HasRequired(x => x.Cliente);
            HasRequired(x => x.Veiculo);
            HasRequired(x => x.Localizacao);
            HasRequired(x => x.Servico);
        }
    }
}
