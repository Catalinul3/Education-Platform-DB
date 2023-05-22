﻿using Intranet.Views.CRUDMateriePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Intranet.Commands.CRUDPeMaterie
{
    public class ReadSubjectButton : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ReadSubject materie=new ReadSubject();
            App.Current.MainWindow.Hide();
            materie.ShowDialog();

        }
    }
}
