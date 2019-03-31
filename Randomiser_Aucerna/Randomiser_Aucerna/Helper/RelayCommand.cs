using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Randomiser_Aucerna.Helper
{
    public class RelayCommand : ICommand
    {
        
        #region Constructors

        Action<object> _execute;
        Func<object, bool> _canexecute;

        public RelayCommand(Action<object> execute)
    : this(execute, null)
        {
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canexecute)
        {
            _execute = execute;
            _canexecute = canexecute;
        }

        #endregion // Constructors

        #region ICommand Members

        public bool CanExecute(object parameter)
        {
            if (_canexecute != null)
            {
                return _canexecute(parameter);
            }
            else
            {
                return false;
            }
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

    }
}
#endregion