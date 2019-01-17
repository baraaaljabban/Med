using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Test2.ViewModels;

namespace Test2.Commands
{
    class NavigateCommand : ICommand
    {
        private MainWindowViewModel viewModel;

        public NavigateCommand(MainWindowViewModel viewModel)
        {
            this.viewModel = viewModel;

        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
                return true;
        }

        public void Execute(object parameter)
        {
            viewModel.NavigateAsync((FLAGS.MODELS)parameter);
        }
    }
}
