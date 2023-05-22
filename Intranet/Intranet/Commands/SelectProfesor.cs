using Intranet.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Intranet.Commands
{
    public class SelectProfesor:ICommand
    {
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            LogInProfesor profesorWindow = new LogInProfesor();
            profesorWindow.ShowDialog();
        }
    }
}
