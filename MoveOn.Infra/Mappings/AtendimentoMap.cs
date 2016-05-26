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
            Property(x => x.InfoConclusao).IsOptional().HasMaxLength(15);

            HasRequired(x => x.Cliente);            
            HasRequired(x => x.Servico);
            
            HasOptional(x => x.AteVeiculo);            
            HasOptional(x => x.Funcionario);
        }
    }
}
