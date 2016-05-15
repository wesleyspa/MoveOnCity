using MoveOn.Domain;
using System.Data.Entity.ModelConfiguration;

namespace MoveOn.Infra.Mappings
{
    public class AtendimentoMap : EntityTypeConfiguration<Atendimento>
    {
        public AtendimentoMap()
        {
            ToTable("Atendimento");
            HasKey(x => x.Id);
            
            Property(x => x.MomConclusao).IsOptional();
            Property(x => x.MomInicio).IsOptional();
            Property(x => x.InfoConclusao).IsOptional().HasMaxLength(500);
            Property(x => x.FuncionarioId).IsOptional();

            HasRequired(x => x.Cliente);
            HasRequired(x => x.Veiculo);
            HasRequired(x => x.Localizacao);
            HasRequired(x => x.Servico);
            HasMany(x => x.Contatos);
            HasOptional(x => x.Funcionario);
        }
    }
}
