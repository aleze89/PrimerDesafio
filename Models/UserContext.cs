using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimerDesafio.Models;

namespace PrimerDesafio.Models
{
    public class UserContext : DbContext
    {
        
        public DbSet<PrimerDesafio.Models.User> Users { get; set; }
        public DbSet<PrimerDesafio.Models.Posts> Posts { get; set; }
        public DbSet<PrimerDesafio.Models.Comments> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-UJVMHBA\MSQLSERVER;Database=UserDB;Trusted_Connection=True;");
        }

    }
}
