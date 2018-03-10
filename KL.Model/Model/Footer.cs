using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KLShop.Model.Abstract;
namespace KLShop.Model.Models
{
    [Table("Footers")]
    public class Footer : Auditable
    {
        [Key]
        [MaxLength(50)]
        public string ID { set; get; }

        [Required]
        public string Content { set; get; }
    }
}