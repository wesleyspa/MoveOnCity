﻿using MoveOn.Domain;
using System.Data.Entity.ModelConfiguration;

namespace MoveOn.Infra.Mappings
{
    public class ContatoMap : EntityTypeConfiguration<Contato>
    {
        public ContatoMap()
        {
            ToTable("Contato");
            HasKey(x => x.Id);
            
            Property(x => x.DDI).IsRequired().HasMaxLength(3);
            Property(x => x.DDD).IsRequired().HasMaxLength(3);
            Property(x => x.Numero).IsRequired().HasMaxLength(9);
            Property(x => x.Tipo).IsRequired().HasMaxLength(11);
            Property(x => x.Info).HasMaxLength(50);

            //HasRequired(x => x.Cliente);
        }
    }
}
