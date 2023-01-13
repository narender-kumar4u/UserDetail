using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserDetail.Models
{
    public class User
    {
        [Index]
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter first name"), MaxLength(50)]
        [DisplayName("First Name")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Please enter family name"), MaxLength(50)]
        [DisplayName("Family Name")]
        public string? FamilyName { get; set; }
    }
}
