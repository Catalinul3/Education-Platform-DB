using Intranet.Views.CRUDClasaPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Intranet.Commands.CRUDPeClase
{
    public class UpdateClassButton : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            UpdateClass clasa = new UpdateClass();
            clasa.ShowDialog();
        }
    }
}
