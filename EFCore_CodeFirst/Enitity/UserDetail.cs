using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_CodeFirst.Enitity
{
    [Table("tbl_user_detail")]
    public class UserDetail
    {
        [Key]
        public int Id { get; set; }
        public string Avatar { get; set; } = string.Empty;
        public int Age { get; set; } = 0;
        public DateTimeOffset Birthday { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
