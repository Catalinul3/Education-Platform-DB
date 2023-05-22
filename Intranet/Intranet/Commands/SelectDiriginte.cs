using Intranet.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Intranet.Commands
{
    public class SelectDiriginte:ICommand
    {
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            LogInDiriginte diriginteWindow = new LogInDiriginte();
            diriginteWindow.ShowDialog();
        }
    }
}
