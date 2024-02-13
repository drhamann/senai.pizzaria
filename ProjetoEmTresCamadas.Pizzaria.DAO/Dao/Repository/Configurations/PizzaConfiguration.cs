﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjetoEmTresCamadas.Pizzaria.DAO.ValueObjects;

namespace ProjetoEmTresCamadas.Pizzaria.DAO.Dao.Repository.Configurations
{
    public class PizzaConfiguration : IEntityTypeConfiguration<PizzaVo>
    {
        public void Configure(EntityTypeBuilder<PizzaVo> builder)
        {
            builder.ToTable("Pizzas");
            builder.HasKey(x => x.Id);
        }
    }
}