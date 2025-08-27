using Aris3._0.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aris3._0.Infrastructure.Data.Configurations
{
    public class SubscriptionConfigure : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.HasKey(s => s.Id);
            builder.HasMany(s=>s.SupportedDevices)
                   .WithMany(d => d.Subscriptions)
                   .UsingEntity(j => j.ToTable("SubscriptionSupportedDevices"));     
        }
    }
}
