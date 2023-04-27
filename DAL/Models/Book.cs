using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Book
    {
        [Key]
        public Guid ID { get; set; }
        public string? Title { get; set; }
        public DateTime? PublicationDate { get; set; }
        public string? Description { get; set; }
        public int? PageQuantity { get; set; }
    }
}
