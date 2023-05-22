using Intranet.Views.CRUDProfesorPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Intranet.Commands.CRUDPeProfesor
{
    public class UpdateProfessorButton : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
           UpdateProfesor updateProfesor=new UpdateProfesor();
            updateProfesor.Show();
        }
    }
}
