using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace eCommerceTest.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
        [DisplayName("Display Order")]
        [Range(1,99,ErrorMessage = "Display Order must be between 1 and 99!!")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; }
= DateTime.Now;    
    }
}
