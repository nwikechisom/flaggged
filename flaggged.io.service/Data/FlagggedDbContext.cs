using System;
using System.Collections.Generic;
using System.Text;
using flaggged.io.service.data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace flaggged.io.service.Data
{
    public class FlagggedDbContext : IdentityDbContext
    {
        public virtual DbSet<Flagggee> Flagggees  { get; set; }
        public virtual DbSet<ProofDocument> ProofDocuments  { get; set; }
        public FlagggedDbContext(DbContextOptions<FlagggedDbContext> options)
            : base(options)
        {
        }
    }
}