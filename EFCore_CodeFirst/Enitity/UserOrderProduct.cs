using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_CodeFirst.Enitity
{
    [Table("tbl_user_order_product")]
    public class UserOrderProduct
    {
        [Key]
        public int Id { get; set; }
        public bool IsActive { get; set; } = true;
        public int Quantity { get; set; }
        public string Note {  get; set; } = string.Empty;
        public int Discount { get; set; }

        public int UserOrderId { get;set; }
        public UserOrder? UserOrder { get; set; }
        public int ProductId { get; set; }
        public Product? Products { get; set; }
     

    }
}
