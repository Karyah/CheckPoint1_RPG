﻿using CheckPoint1_RPG.Models;
using Microsoft.EntityFrameworkCore;

namespace CheckPoint1_RPG.Persistence
{
    public class OracleDbContext : DbContext
    {
        public DbSet<Personagem> Personagens { get; set; }
            
        public OracleDbContext(DbContextOptions<OracleDbContext> options) :base(options)
        {}


    }

}
