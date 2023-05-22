using Intranet.Views.CRUD;
using Intranet.Views.UsersPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Intranet.Commands.CRUDPeSpecializari
{
    public class UpdateSpecializationButton : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            
            UpdateSpecialization specialization = new UpdateSpecialization();
            specialization.ShowDialog();
            if(specialization.Parent is AdminPage parent)
            {
                parent.Visibility = Visibility.Hidden;
            }
        }
    }
}
