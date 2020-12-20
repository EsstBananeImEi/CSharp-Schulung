using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Business
{
    public class ToDoRepositoryEDM:DbContext
    {

        public DbSet<ToDo> ToDoes { get; set; }
        public DbSet<ToDoCategory> ToDoCategories { get; set; }

        public IQueryable<ToDo> GetAll()
        {
            return ToDoes;
        }

        public ToDo Create()
        {
            ToDo myResult = new ToDo("Neue Aufgabe");
            ToDoes.Add(myResult);

            this.SaveChanges();

            return myResult;
        }

        public void Update(ToDo myToDo)
        {
            this.SaveChanges();
        }

        public void Delete(ToDo myToDo)
        {
            ToDoes.Remove(myToDo);
            this.SaveChanges();
        }
    }
}
