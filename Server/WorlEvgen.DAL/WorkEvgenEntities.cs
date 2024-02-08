using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Transactions;

namespace WorlEvgen.DAL
{
    public class WorkEvgenEntities : DbContext, IWorkEvgenEntities
    {
        public WorkEvgenEntities(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AddConfiguration(modelBuilder);

            base.OnModelCreating(modelBuilder);

            //Для теста
            //GenerateUsers(modelBuilder);
            //GenerateCardBalance(modelBuilder);
            //GenerateTransactions(modelBuilder);
        }

        private void AddConfiguration(ModelBuilder modelBuilder)
        {
        }
    
    }
}
