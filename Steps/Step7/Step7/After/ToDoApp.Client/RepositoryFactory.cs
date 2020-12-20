using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Business;

namespace ToDoApp.Client
{
    static class RepositoryFactory
    {
        public static IToDoRepository<ToDo> Create(string myClassname)
        {
            string[] myToken = myClassname.Split(',');
            Assembly myAssembly = Assembly.LoadFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, myToken[0]+".dll"));

            var myResult = myAssembly.CreateInstance(myToken[1]);

            return myResult as IToDoRepository<ToDo>;
        }
    }
}
