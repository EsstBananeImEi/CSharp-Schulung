using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ToDoApp.Business;
using ToDoApp.Business.Utility;

namespace ToDoApp.Client
{
    public class MainViewModel:ModelBase
    {
        private List<ToDo> _DataList;
        public List<ToDo> DataList
        {
            get { return _DataList; }
            set { _DataList = value; RaisePropertyChange("DataList"); }
        }

        private ToDo _SelectedToDo;
        public ToDo SelectedToDo
        {
            get { return _SelectedToDo; }
            set { _SelectedToDo = value; RaisePropertyChange("SelectedToDo"); }
        }

       
        public ICommand AddCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand UpdateCommand { get; set; }

        private ToDoRepository _ToDoRepository;

        public MainViewModel()
        {
            DataList = new List<ToDo>();
            SelectedToDo = null;
            AddCommand = new StandardCommand(Add);
            DeleteCommand = new StandardCommand(Delete);
            UpdateCommand = new StandardCommand(Update);
            _ToDoRepository = new ToDoRepository();
        }

        private void Update(object parameter)
        {
            try
            {
                _ToDoRepository.Update(this.SelectedToDo);

                this.DataList = _ToDoRepository.GetAll(); 
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Fehler: " + ex.ToString());
                MessageBox.Show("Fehler: " + ex.Message);
            }
        }

        private void Delete(object parameter)
        {
            try
            {
                 _ToDoRepository.Delete(SelectedToDo);

                this.DataList = _ToDoRepository.GetAll();
                this.SelectedToDo = null;
            }
            catch (Exception ex)
            {
                Logging.WriteLog("Fehler: " + ex.ToString());
                MessageBox.Show("Fehler: " + ex.Message);
            }
        }

        private void Add(object parameter)
        {
            try
            {
                var myToDo = _ToDoRepository.Create();

                this.DataList = _ToDoRepository.GetAll();
                this.SelectedToDo = myToDo;
            }
            catch( Exception ex )
            {
                Logging.WriteLog("Fehler: " + ex.ToString());
                MessageBox.Show("Fehler: " + ex.Message);
            }
            
        }
    }

}
