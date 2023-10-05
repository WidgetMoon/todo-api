using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ToDo.Data
{
    public class ToDoDbContext :DbContext
    {
        DbSet<Domain.ToDoAggregate.ToDo> ToDos { get; set; }

        public ToDoDbContext()
        {
            
        }
    }
}
