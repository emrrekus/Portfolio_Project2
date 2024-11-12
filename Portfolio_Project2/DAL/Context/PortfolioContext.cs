using Microsoft.EntityFrameworkCore;
using Portfolio_Project2.DAL.Entities;


namespace Portfolio_Project2.DAL.Context
{
    public class PortfolioContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-S74UGVJ;initial catalog=Portfolio_Project2;integrated security=true; TrustServerCertificate=true");
        }


        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }

        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }

        public DbSet<Testimonial> Testimonials { get; set; }

        public DbSet<ToDoList> ToDoLists { get; set; }

    }
}
