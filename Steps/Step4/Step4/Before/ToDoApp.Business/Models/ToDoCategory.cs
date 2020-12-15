using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoApp.Business
{
    public class ToDoCategory:ModelBase
    {
        private int _ID;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; RaisePropertyChange("ID"); }
        }

        private string _Title;
        public string Title
        {
            get { return _Title; }
            set { _Title = value; RaisePropertyChange("Title"); }
        }

        public ToDoCategory()
        {
            Title = "Neue Kategorie";
        }
    }
}