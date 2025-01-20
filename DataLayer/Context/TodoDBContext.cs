using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DataLayer.Context
{
    public class TodoDBContext:DbContext
    {
        public DbSet<Task> tasks { get; set; }
        public DbSet<User> users { get; set; }
    }
}
