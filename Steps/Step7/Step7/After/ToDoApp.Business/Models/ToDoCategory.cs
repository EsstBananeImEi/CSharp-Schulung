using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ToDoApp.Business
{
    public class ToDoCategory:ModelBase
    {
        private int _ID;
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
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