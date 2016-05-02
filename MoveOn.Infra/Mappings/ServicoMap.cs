﻿using MoveOn.Domain;
using System.Data.Entity.ModelConfiguration;

namespace MoveOn.Infra.Mappings
{
    public class ServicoMap : EntityTypeConfiguration<Servico>
    {
        public ServicoMap()
        {
            ToTable("Servico");
            HasKey(a => a.ServicoId);

            Property(a => a.Descricao).IsRequired().HasMaxLength(30);            
        }
    }
}
