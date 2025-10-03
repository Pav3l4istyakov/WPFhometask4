using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFhometask4
{
    public class ToDo
    {
        private string title;
        private DateTime dueDate;
        private string description;

        public ToDo(string title, DateTime dueDate, string description)
        {
            this.title = title;
            this.dueDate = dueDate;
            this.description = description;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }

}
