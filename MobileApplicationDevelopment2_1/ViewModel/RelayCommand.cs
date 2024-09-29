using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MobileApplicationDevelopment2_1.ViewModel
{
    public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);
        }

        public RelayCommand(Action<object?> execute)
        {
            _execute = execute;
        }

        private Action<object?> _execute;
    }
}
