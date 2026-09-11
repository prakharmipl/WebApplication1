using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model.Ecommerce
{
    public class CustomerModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string CustomerName { get; set; }

        [Column(TypeName = "datetime2(7)")]
        public DateTime? CreatedDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? Dob { get; set; }
    }
}
