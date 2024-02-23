using System.ComponentModel.DataAnnotations;

namespace MultiPageWebApp.Models
{
    public class Contact
    {

        public string Name { get; set; }

        public long PhoneNumber { get; set; }

        public string Address { get; set; }

        public string Note { get; set; }
    }
}
