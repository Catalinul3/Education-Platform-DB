using Intranet.ViewModels.CRUDDiriginte;
using Intranet.Views.CRUDDirigintePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Intranet.Commands.CRUDPeDiriginti
{
    public class ReadDiriginteButton : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ReadDiriginte diriginte = new ReadDiriginte();
            diriginte.Show();
        }
    }
}
