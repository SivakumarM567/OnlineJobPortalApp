using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineJobPortal.DAL.Data
{
    public class JobDbContext : DbContext
    {
        public JobDbContext(DbContextOptions<JobDbContext> options) : base(options)
        {

        }
        public DbSet<RecruiterDetails> recruiterDetails { get; set; }
        public DbSet<RequirementDetails> requirementDetails { get; set; }
        public DbSet<JobseekersDetails> jobseekersDetails { get; set; }
        public DbSet<AdminDetails> adminDetails { get; set; }
    }
}
