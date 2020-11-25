using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhTriShop.Model.Models
{
    [Table("Footers")]//chiỉ ra cái class này sẽ gen ra tên bảng trong csdl ntn
    public class Footer
    {
        [Key]
        [MaxLength(50)]
        public string ID { get; set; }
        [Required]
        public string Content { get; set; }
    }
}
