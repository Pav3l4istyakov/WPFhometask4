using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFhometask4
{
    public class ToDo
    {
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public bool Doing { get; set; }
        public string Description { get; set; }

        public ToDo(string title, DateTime dueDate, bool doing, string description)
        {
            Title = title;
            DueDate = dueDate;
            Doing = doing;
            Description = description;
        }
    }
}









