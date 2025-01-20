using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = " {0} خود را وارد کنید")]
        [MaxLength(50, ErrorMessage = "حداکثر طول {0} 50 کاراکتر است")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "ایمیل وارد شده صحیح نیست")]
        public string Email { get; set; }
        
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
