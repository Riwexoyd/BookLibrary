﻿using BookLibrary.Db.Constants;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;

namespace BookLibrary.Db.Models.Configurations
{
    internal class RoleConfiguration : EntityConfiguration<Role>
    {
        internal static readonly Guid AdminRoleId = Guid.Parse("{750B375A-475F-4195-9F31-6EE246BBF2CB}");

        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);

            builder.HasData(new Role
            {
                Id = AdminRoleId,
                Name = DefaultRoles.AdminRole,
                NormalizedName = DefaultRoles.AdminRole.ToUpper()
            });
        }
    }
}
