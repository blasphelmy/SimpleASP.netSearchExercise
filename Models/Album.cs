using System.ComponentModel.DataAnnotations;
namespace CSI250Lab2{
public class Album
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Album Name")]
        [StringLength(20)]
        [Required(ErrorMessage = "Album Name cannot be blank")]
        public string Title { get; set; }
        
        [Required(ErrorMessage = "Album Artist cannot be blank")]
        //Artist must be 3 characters long
        [MinLength(3)]
        public string Artist { get; set; }
        [Required(ErrorMessage = "Album Genre cannot be blank")]
        [StringLength(20)]
        public string Genre { get; set; }
        [Range(0, 99999999.99)]
        [Required(ErrorMessage = "Album Price cannot be blank")]
        public decimal Price { get; set; }
    }
}
