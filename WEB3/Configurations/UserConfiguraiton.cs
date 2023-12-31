﻿using WEB3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB3.Configurations;

internal class UserConfiguraiton : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Gender)
            .WithMany(x => x.Users)
            .HasForeignKey(x => x.GenderId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
