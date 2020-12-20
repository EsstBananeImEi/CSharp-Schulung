using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Business
{
    public interface IToDoRepository
    {
        IQueryable<ToDo> GetAll();

        ToDo Create();

        void Update(ToDo myToDo);

        void Delete(ToDo myToDo);
    }
}
