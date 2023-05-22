using Intranet.Views.CRUDProfesorPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Intranet.Commands.CRUDPeProfesor
{
    public class CreateProfessorButton : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
           CreateProfessor professor=new CreateProfessor();
            professor.ShowDialog();
        }
    }
}
