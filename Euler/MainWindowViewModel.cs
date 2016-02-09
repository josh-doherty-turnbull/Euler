using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Euler.MVVM;
using System.Collections.ObjectModel;
using Euler.Problems;
using System.Reflection;

namespace Euler
{
    class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            IEnumerable<Type> problems = Assembly.GetExecutingAssembly().GetTypes()
                                                 .Where(t => t.IsClass &&
                                                             t.Namespace == "Euler.Problems" &&
                                                             t.Name.Substring(0, 7) == "Problem");

            AvailableProblems = new ObservableCollection<IProblem>();

            foreach (Type type in problems)
            {
                AvailableProblems.Add(Activator.CreateInstance(type) as IProblem);
            }
        }

        private ObservableCollection<IProblem> _AvailableProblems;

        public ObservableCollection<IProblem> AvailableProblems
        {
            get { return _AvailableProblems; }
            set
            {
                _AvailableProblems = value;
                RaisePropertyChanged("AvailableProblems");
            }
        }

        private IProblem _SelectedProblem;

        public IProblem SelectedProblem
        {
            get { return _SelectedProblem; }
            set
            {
                _SelectedProblem = value;
                RaisePropertyChanged("SelectedProblem");
                Answer = null;
            }
        }

        private string _Answer;

        public string Answer
        {
            get { return _Answer; }
            set
            {
                _Answer = value;
                RaisePropertyChanged("Answer");
            }
        }

        public RelayCommand CalculateCommand { get { return new RelayCommand(Calculate, CanCalculate); } }

        private bool CanCalculate(object obj)
        {
            return SelectedProblem != null;
        }

        private async void Calculate(object obj)
        {
            MarkBusy();

            Answer = await SelectedProblem.SolveAsync();

            MarkFree();
        }
    }
}
