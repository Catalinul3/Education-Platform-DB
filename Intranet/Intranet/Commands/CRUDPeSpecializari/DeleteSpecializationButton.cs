using Intranet.ViewModels.CRUD;
using Intranet.Views.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Intranet.Commands.CRUDPeSpecializari
{
    public class DeleteSpecializationButton : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            DeleteSpecialization specialization = new DeleteSpecialization();
            specialization.ShowDialog();
        }
    }
}
