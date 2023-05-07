using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{

    public class TyrellCorporationContext : DbContext
    {
        
        public DbSet<Factory> Factories { get; set; } = null!;
        public DbSet<Function> Functions { get; set; } = null!;
        public DbSet<Replicant> Replicants { get; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = GetConnectionString();//GetConnectionString();

            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Factory>().HasData(
                new { Id = 1, Name = "Earth Orbital Replicants", Description = "Micro Gravity Assembly Plant", Location = "Earth Orbit"},
                new { Id = 2, Name = "Off World Replicants", Description = "Low Gravity Assembly Plant", Location = "Titan" },
                new { Id = 3, Name = "LA Replicants", Description = "Full Gravity Assembly Plant", Location = "Los Angeles, Earth" }
            );

            modelBuilder.Entity<Function>().HasData(
                new { Id = 1, Functionality = "Pleasure" },
                new { Id = 2, Functionality = "Military" },
                new { Id = 3, Functionality = "Loader, (nuc)" },
                new { Id = 4, Functionality = "Combat" },
                new { Id = 5, Functionality = "Leisure" },
                new { Id = 6, Functionality = "Assasination" },
                new { Id = 7, Functionality = "Janitorial" },
                new { Id = 8, Functionality = "Construction" }
                );


            modelBuilder.Entity<NexusModel>().HasData(
               new { Id = 1, ModelDescription = "Nexus 1"},
               new { Id = 2, ModelDescription = "Nexus 2" },
               new { Id = 3, ModelDescription = "Nexus 3" },
               new { Id = 4, ModelDescription = "Nexus 4" },
               new { Id = 5, ModelDescription = "Nexus 5" },
               new { Id = 6, ModelDescription = "Nexus 6" },
               new { Id = 7, ModelDescription = "Nexus 7" },
               new { Id = 8, ModelDescription = "Nexus 8" }

               );


           
            modelBuilder.Entity<Replicant>().HasData(
              new { Id = 1, Name = "Gilligan", Sex = "Male", FactoryId = 1, NexusModel = 1, InceptDate = DateTime.Parse("1/11/1963"), PhysicalAbility = "Weak", MentalAbility = "Stupid" },
               new { Id = 2, Name = "Ginger", Sex = "Female", FactoryId = 2, NexusModel = 2, InceptDate = DateTime.Parse("1/12/1963"), PhysicalAbility = "Weak", MentalAbility = "Medium" },
                new { Id = 3, Name = "Captain", Sex = "Male", FactoryId = 2, NexusModel = 3, InceptDate = DateTime.Parse("1/12/1963"), PhysicalAbility = "Medium", MentalAbility = "Medium" }

              );



        }



        public string GetConnectionString()
        {

            const string secretName = "TyrellCorpDBConnectionString";
            var keyVaultName = "tyrellcorp-kv";
            var kvUri = $"https://{keyVaultName}.vault.azure.net";

            var client = new SecretClient(new Uri(kvUri), new DefaultAzureCredential());
            var secret = client.GetSecret(secretName);

            return secret.Value.Value.ToString(); ;
        }


    }
}
