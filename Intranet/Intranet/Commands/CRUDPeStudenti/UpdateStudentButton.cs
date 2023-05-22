using Intranet.Views.CRUDStudentPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Intranet.Commands.CRUDPeStudenti
{
    public class UpdateStudentButton : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            UpdateStudent update = new UpdateStudent();
            update.ShowDialog();
        }
    }
}
