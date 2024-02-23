using Microsoft.EntityFrameworkCore;

namespace WebAppMultiPage.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    Name = "Link",
                    PhoneNumber = "555-789-4509",
                    Address = "567 Tulip Tree Lane",
                    Note = "HS Friend"
                },
            new Contact
            {
                ContactId = 2,
                Name = "Julia",
                PhoneNumber = "555-837-4722",
                Address = "5784 Oaks Drive",
                Note = "Work"
            },
                new Contact
                {
                    ContactId = 3,
                    Name = "Quinn",
                    PhoneNumber = "555-203-0045",
                    Address = "239 Green Road",
                    Note = "ISU"
                }
            );

        }
    }
}
