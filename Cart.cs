using System.ComponentModel.DataAnnotations;
namespace backend
{
    public class Cart
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public Book[] books { get; set; }
    }
}
