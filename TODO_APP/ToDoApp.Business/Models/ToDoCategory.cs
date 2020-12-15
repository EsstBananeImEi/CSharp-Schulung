using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoApp.Business
{
    public class ToDoCategory
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public ToDoCategory()
        {
            Title = "Neue Todo"; 
        }
    }
}