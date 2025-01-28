using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MailClient.Command
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> executeAction;
        Func<object, bool> canExecute;
        public bool CanExecute(object parameter)
        {
            if (canExecute == null)
            {
                return true;
            }
            else
            {
                return canExecute(parameter);
            }
        }

        public RelayCommand(Action executeAction)
            : this((o) => executeAction())
        { }

        public RelayCommand(Action<object> executeAction)
           : this(executeAction, (o) => true)
        { }

        public RelayCommand(Action<object> executeAction, Func<object, bool> canExecute)
        {
            this.executeAction = executeAction;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public void Execute(object parameter)
        {
            executeAction(parameter);
        }
    }
}
