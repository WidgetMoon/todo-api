using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Domain.ToDoAggregate
{
    public class ToDo
    {
        public ToDo() { }

        public ToDo(string description)
        {
            Id = new Guid();
            Description = description;
        }

        public Guid Id { get; private set; }
        public string Description { get; private set; }
    }
}
