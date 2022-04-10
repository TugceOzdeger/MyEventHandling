using System;
using System.Windows.Input;

namespace MyApplication
{
    public class DelegateCommand : ICommand
    {
        public DelegateCommand()
        { }

        public DelegateCommand(Predicate<object> _canexecute, Action<object> _execute) : this()
        {
            canExecute = _canexecute;
            execute = _execute;
        }

        #region Properties
        Predicate<object> canExecute;
        Action<object> execute;
        public event EventHandler CanExecuteChanged;
        #endregion

        #region Functions
        public bool CanExecute(object parameter)
        {
            return canExecute == null ? true : canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
        #endregion
    }
}