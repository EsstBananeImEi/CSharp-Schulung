using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoApp.Business
{
    public class ToDo
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public List<ToDoCategory> Categories { get; set; }

        public string Body { get; set; }

        public ToDo(string title = "New ToDo")
        {
            Date = DateTime.Now.Date;
            Categories = new List<ToDoCategory>();
            Title = title;
            Body = "Body";
        }
    }
}