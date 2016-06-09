﻿using MoveOn.Domain;
using System.Data.Entity.ModelConfiguration;

namespace MoveOn.Infra.Mappings
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Cliente");
            HasKey(x => x.Id);

            Property(x => x.Id).IsRequired();
            Property(x => x.Nome).IsRequired().HasMaxLength(100);
            Property(x => x.CNH).IsRequired().HasMaxLength(20);
            Property(x => x.CPF_CNPJ).IsRequired().HasMaxLength(15);
            Property(x => x.EstadoCivil).IsRequired().HasMaxLength(12);
            Property(x => x.Email).IsRequired().HasMaxLength(50);
            Property(x => x.Senha).IsRequired().HasMaxLength(20);
            Property(x => x.DataNascimento).IsRequired().HasMaxLength(17);
            Property(x => x.Telefone1).IsRequired().HasMaxLength(20);
            Property(x => x.Telefone2).IsOptional().HasMaxLength(20);

            //HasOptional(x => x.Contrato);
            HasRequired(x => x.Endereco);
            HasRequired(x => x.Veiculo);
            
        }
    }
}
