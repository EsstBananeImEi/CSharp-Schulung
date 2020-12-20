using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Business
{
    public interface IToDoRepository<T> 
            where T:class, new()
    {
        IQueryable<T> GetAll();

        T Create();

        void Update(T myToDo);

        void Delete(T myToDo);
    }
}
