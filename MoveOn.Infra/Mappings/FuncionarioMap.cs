using MoveOn.Domain;
using System.Data.Entity.ModelConfiguration;

namespace MoveOn.Infra.Mappings
{
    public class FuncionarioMap : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioMap()
        {
            ToTable("Funcionario");
            HasKey(x => x.Id);
            
            Property(x => x.Nome).IsRequired().HasMaxLength(100);
            Property(x => x.EstadoCivil).IsRequired();
            Property(x => x.Email).IsRequired();
                                  
            //HasMany(x => x.Contato);
        }
    }
}
