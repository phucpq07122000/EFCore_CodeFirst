using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore_CodeFirst.Enitity
{
    [Table("tbl_user_oder")]
    public class UserOrder
    {
        [Key]
        public int Id { get; set; }
        public string OrderDetails { get; set; } = string.Empty;

        public int UserID { get; set; }
        public User? User { get; set; }
        public ICollection<UserOrderProduct>? UserOrderProducts { get; set; }

    }
}
