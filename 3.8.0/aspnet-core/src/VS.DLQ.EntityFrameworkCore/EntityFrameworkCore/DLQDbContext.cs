using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using VS.DLQ.Authorization.Roles;
using VS.DLQ.Authorization.Users;
using VS.DLQ.MultiTenancy;
using VS.DLQ.LicenseTypes;
using VS.DLQ.LicenseStatuses;
using VS.DLQ.Licenses;
using VS.DLQ.LicenseImages;
using VS.DLQ.Entitlements;
using VS.DLQ.LicenseTypeEntitlements;
using VS.DLQ.UserLicenses;
using VS.DLQ.UserEmails;
using VS.DLQ.Fish;
using VS.DLQ.Rules;
using VS.DLQ.Engagement;
using VS.DLQ.UserProfiles;
using VS.DLQ.UserAddresses;
using VS.DLQ.SocialStatuses;
using VS.DLQ.MyTrips;

namespace VS.DLQ.EntityFrameworkCore
{
    public class DLQDbContext : AbpZeroDbContext<Tenant, Role, User, DLQDbContext>
    {
        /* Define a DbSet for each entity of the application */

        //User Related Entities
        public DbSet<UserEmail> UserEmails { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<SocialStatus> SocialStatuses { get; set; }

        //License Related Entities
        public DbSet<LicenseType> LicensesType { get; set; }
        public DbSet<LicenseStatus> LicenseStatus { get; set; }
        public DbSet<License> License { get; set; }
        public DbSet<LicenseImage> LicenseImage { get; set; }
        public DbSet<Entitlement> Entitlement { get; set; }
        public DbSet<LicenseTypeEntitlement> LicenseTypeEntitlement { get; set; }
        public DbSet<UserLicense> UserLicense { get; set; }

        //Fish Related Entities
        public virtual DbSet<Species> Species { get; set; }
        public virtual DbSet<Rule> Rules { get; set; }

        //Engagements Related Entites
        public DbSet<Query> Queries { get; set; }
        public DbSet<ReportIllegalActivity> ReportIllegalActivities { get; set; }
        public DbSet<ReportIssue> ReportIssues { get; set; }

        //Trip Related Entities
        public DbSet<MyTrip> MyTrips { get; set; }
        public DbSet<MyTripImage> MyTripImages { get; set; }

        public DLQDbContext(DbContextOptions<DLQDbContext> options)
            : base(options)
        {
        }
    }
}

