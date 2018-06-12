﻿using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using VS.DLQ.Authorization.Roles;
using VS.DLQ.Authorization.Users;
using VS.DLQ.MultiTenancy;
using VS.DLQ.Licenses;
using VS.DLQ.Entitlements;
using VS.DLQ.UserLicenses;
using VS.DLQ.UserEmails;
using VS.DLQ.Fish;
using VS.DLQ.Rules;
using VS.DLQ.Engagement;

namespace VS.DLQ.EntityFrameworkCore
{
    public class DLQDbContext : AbpZeroDbContext<Tenant, Role, User, DLQDbContext>
    {
        /* Define a DbSet for each entity of the application */

        //User Related Entities
       // public DbSet<UserEmail> UserEmail { get; set; }
        
        //License Related Entities
        public DbSet<LicenseType> LicensesType { get; set; }
        public DbSet<LicenseStatus> LicenseStatus { get; set; }
        public DbSet<License> License { get; set; }
        public DbSet<LicenseImage> LicenseImage { get; set; }
        public DbSet<Entitlement> Entitlement { get; set; }
        public DbSet<LicenseTypeEntitlement> LicenseTypeEntitlement { get; set; }
        public DbSet<UserLicense> UserLicense { get; set; }
        public virtual DbSet<Species> Species { get; set; }
        public virtual DbSet<Rule> Rules { get; set; }
        public virtual DbSet<Query> Queries { get; set; }

        public DLQDbContext(DbContextOptions<DLQDbContext> options)
            : base(options)
        {
        }
    }
}

