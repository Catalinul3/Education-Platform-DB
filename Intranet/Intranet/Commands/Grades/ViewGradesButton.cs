﻿using Intranet.ViewModels.ProfessorActionView;
using Intranet.Views.ProfesorAction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Intranet.Commands.Grades
{
    public class ViewGradesButton : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
           return true;
        }

        public void Execute(object parameter)
        {
            ViewCatalog vw=new ViewCatalog();
            vw.ShowDialog();
        }
    }
}