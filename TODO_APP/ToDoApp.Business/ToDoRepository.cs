using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Business
{
    public class ToDoRepository
    {
        private List<ToDo> _Data;

        public List<ToDo> GetAll()
        {
            return _Data.ToList();
        }

        public ToDo Create()
        {
            ToDo myResult = new ToDo("Neue Aufgabe");
            myResult.ID = 1;
            if (_Data.Count > 0)
                myResult.ID = _Data.Max(x => x.ID) + 1;
            _Data.Add(myResult);
            return myResult;

        }

        public void Update(ToDo myToDo)
        {
            for (int i = 0; i < _Data.Count; i++)
            {
                if (_Data[i].ID == myToDo.ID)
                {
                    _Data[i] = myToDo;
                    return;
                }
            }

        }

        public void Delete(ToDo myToDo)
        {
            _Data.Remove(myToDo);
        }

        public ToDoRepository()
        {
            _Data = new List<ToDo>();
        }


    }
}
