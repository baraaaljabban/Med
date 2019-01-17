using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Test2.Interfaces;

namespace Test2.Commands
{
    class ExportCommand : ICommand
    {
        IExport viewModel;
        public ExportCommand(IExport viewModel)
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
            if (parameter == null)
                return false;
            return true;
        }

        public void Execute(object parameter)
        {
            viewModel.ExportToExcel((ContentControl)parameter);
        }
    }
}
