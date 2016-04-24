using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormsHomework.Models
{
    public class Task
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool IsDone { get; set; }
        public string Information { get; set; }


        public Task()
        {

        }

        public Task( string name, string info, bool isDone)
        {
            
            Name = name;
            Information = info;
            IsDone = isDone;
        }


    }
}