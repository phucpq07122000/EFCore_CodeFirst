using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_CodeFirst.Enitity
{
    [Table("tbl_user")]
    public class User
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }=string.Empty;
        public string Email { get; set; }= string.Empty;    
        public string Password { get; set; } = string.Empty;

        public UserDetail? UserDetail { get; set; }

        public ICollection<UserOrder>? UserOrders { get; set; }
    }
}
