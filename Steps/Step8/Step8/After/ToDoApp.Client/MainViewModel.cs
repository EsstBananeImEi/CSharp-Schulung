using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
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

        private string _Suchwort;
        public string Suchwort
        {
            get { return _Suchwort; }
            set { _Suchwort = value; RaisePropertyChange("Suchwort"); }
        }

        private bool _IsBusy;
        public bool IsBusy
        {
            get { return _IsBusy; }
            set { _IsBusy = value; RaisePropertyChange("IsBusy"); }
        }


        public ICommand AddCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand SearchCommand { get; set; }

        private IToDoRepository<ToDo> _ToDoRepository;

        private IToDoRepository<ToDoCategory> _ToDoCateoryRepository;

        public MainViewModel()
        {
            IsBusy = false;
            DataList = new List<ToDo>();
            SelectedToDo = null;
            AddCommand = new StandardCommand(Add);
            DeleteCommand = new StandardCommand(Delete);
            UpdateCommand = new StandardCommand(Update);

            _ToDoRepository = RepositoryFactory.Create(ConfigurationManager.AppSettings["Repository"]);
            _ToDoCateoryRepository = _ToDoRepository as IToDoRepository<ToDoCategory>;

            SearchCommand = new StandardCommand(Search);
            Suchwort = "";
        }

        private void Search(object parameter)
        {
            Task.Run(new Action(delegate ()
            {
                IsBusy = true;
                try
                {
                    var myQuery = from myToDo in _ToDoRepository.GetAll()
                                  where myToDo.Title.Contains(this.Suchwort)
                                  select myToDo;

                    this.DataList = myQuery.ToList();
                }
                catch (Exception ex)
                {
                    Logging.WriteLog("Fehler: " + ex.ToString());
                    MessageBox.Show("Fehler: " + ex.Message);
                }

                IsBusy = false;
            })); 
        }

        private void Update(object parameter)
        {
            try
            {
                _ToDoRepository.Update(this.SelectedToDo);

                this.DataList = _ToDoRepository.GetAll().ToList(); 
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

                this.DataList = _ToDoRepository.GetAll().ToList();
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

                this.DataList = _ToDoRepository.GetAll().ToList();
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
