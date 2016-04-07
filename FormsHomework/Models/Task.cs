using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormsHomework.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDone { get; set; }
        public string Information { get; set; }

    public Task(int id, string name, string info, bool isDone)
        {
            Id = id;
            Name = name;
            Information = info;
            IsDone = isDone;
        }

    }
}