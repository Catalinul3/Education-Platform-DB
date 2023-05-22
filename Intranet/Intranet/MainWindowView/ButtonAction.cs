using Intranet.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Intranet.MainWindowView
{
    public class ButtonAction
    { public ICommand adminSelected { get; set; }
        public ICommand profesorSelected { get; set; }
        public ICommand diriginteSelected { get; set; }
        public ICommand studentSelected { get; set; }
    public ButtonAction()
        {
            adminSelected = new SelectAdmin();
            profesorSelected= new SelectProfesor();
            diriginteSelected= new SelectDiriginte();
            studentSelected= new SelectStudent();
        }
    }
}
