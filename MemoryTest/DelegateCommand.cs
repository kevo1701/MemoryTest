using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace MemoryTest
{
    public class DelegateCommand : ICommand
    {
        private Action<object> _command;

        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action<object> command)
        {
            _command = command;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _command(parameter);
        }
    }
}
