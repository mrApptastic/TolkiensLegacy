using admin_app.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace admin_app.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<BaseStat> MerpStats {get; set;}
        // public DbSet<StatSet> MerpStatSets {get; set;}
        public DbSet<Race> MerpRaces {get; set;}
        public DbSet<Language> MerpLanguages { get; set; }
        public DbSet<Deity> MerpDeities { get; set; }
        public DbSet<SkillCategory> MerpSkillCategories { get; set; }
        public DbSet<Skill> MerpSkills { get; set; }
    }
}   

