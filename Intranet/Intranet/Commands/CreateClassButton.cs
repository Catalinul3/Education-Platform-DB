﻿using Intranet.Views.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Intranet.Commands
{
    public class CreateClassButton:ICommand
    {
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            CreateClasa clasa= new CreateClasa();
            clasa.ShowDialog();
        }
    }
    
    
}
