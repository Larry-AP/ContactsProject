using Microsoft.EntityFrameworkCore;

namespace MultiPageWebApp.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options):base(options)
            { }

        public DbSet<Contact> Contacts { get; set; } = null;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    Name = "Link",
                    PhoneNumber = 5557890345,
                    Address = "234 Tulip Tree Lane",
                    Note = "HS Friend"
                },
                new Contact
                {
                    Name = "Julia",
                    PhoneNumber = 5553782775,
                    Address = "9678 Oaks Drive",
                    Note = "Work Friend"
                },
                new Contact
                {
                    Name = "Quinn",
                    PhoneNumber = 5783087611,
                    Address = "4545 Green Court",
                    Note = "Mechanic"
                }

                );
            }
    }
}
