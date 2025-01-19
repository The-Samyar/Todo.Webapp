using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Todo.Webapp.Models
{
    public class Tasks
    {
        [Key]
        public int TaskId { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [DefaultValue(false)]
        public bool Complete { get; set; }
    }
}