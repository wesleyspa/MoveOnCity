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
            Property(x => x.InfoConclusao).IsOptional().HasMaxLength(15);

            Property(x => x.Logradouro).IsOptional();
            Property(x => x._Endereco).IsOptional();
            Property(x => x.Numero).IsOptional();
            Property(x => x.Bairro).IsOptional();
            Property(x => x.Complemento).IsOptional();
            Property(x => x.CEP).IsOptional();
            Property(x => x.Cidade).IsOptional();
            Property(x => x.Estado).IsOptional();
            Property(x => x.Pais).IsOptional();
            Property(x => x.CoordenadaX).IsOptional();
            Property(x => x.CoordenadaY).IsOptional();

            Property(x => x.VeiculoCliente).IsRequired();
            HasRequired(x => x.Cliente);                        
            HasRequired(x => x.Servico);
            
            HasOptional(x => x.AteVeiculo);            
        }
    }
}
