﻿using Intranet.FirstWindowAndLogInWindowVM;
using Intranet.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Intranet.Commands
{
    public class SelectAdmin : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            LogInAdmin adminWindow = new LogInAdmin();
            adminWindow.ShowDialog();
        }
    }
}

