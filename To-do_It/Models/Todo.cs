using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_do_It.Data;

namespace To_do_It.Models
{
    internal class Todo
    {
        private readonly int id;
        private String description;
        private bool done;
        private Person assignee;

        public Todo(int id, string description)
        {
            this.id = id;
            this.description = description;
            this.done = false;
        }

        public int Id
        {
            get { return id; }
        }

        public string Description 
        { 
            get 
            { return description; } 
            set { description = value; }
        }

        public bool Done
        {
            get { return done; }
            set { done = value; }
        }

        public Person Assignee
        {
            get { return assignee; }
            set
            {
                assignee = value;
            }
        }

    }
}
