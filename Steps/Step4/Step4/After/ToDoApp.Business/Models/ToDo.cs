using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ToDoApp.Business
{
    public class ToDo:ModelBase
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

        private DateTime? _Date;
        public DateTime? Date
        {
            get { return _Date; }
            set { _Date = value; RaisePropertyChange("Date"); }
        }

       
        private ObservableCollection<ToDoApp.Business.ToDoCategory> _Categories;
        public ObservableCollection<ToDoApp.Business.ToDoCategory> Categories
        {
            get { return _Categories; }
            set { _Categories = value; RaisePropertyChange("Categories"); }
        }

   
        private string _Body;
        public string Body
        {
            get { return _Body; }
            set { _Body = value; RaisePropertyChange("Body"); }
        }

        public ToDo() : this("Neue Aufgabe")
        {            
        }

        public ToDo(string myTitle)
        {            
            Title = myTitle;
            Date = DateTime.Now.Date;
            Categories = new ObservableCollection<ToDoCategory>();
            Body = "";
        }
    }
}