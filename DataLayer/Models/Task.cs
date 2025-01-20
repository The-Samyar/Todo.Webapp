using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }
        public int UserId { get; set; }

        [Display(Name = "عنوان")]
        [Required(ErrorMessage = " {0} خود را وارد کنید")]
        public string Title { get; set; }

        [DefaultValue(false)]
        public bool Complete { get; set; }
        public virtual User User { get; set; }
    }
}
