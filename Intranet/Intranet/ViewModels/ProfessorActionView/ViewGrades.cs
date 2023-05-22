using Intranet.Database;
using Intranet.Database.BL;
using Intranet.ViewModelBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intranet.ViewModels.ProfessorActionView
{
    public class ViewGrades:BaseVM
    {
        ProfesorBL profesor;
        ObservableCollection<NOTA> studenti;
        public ViewGrades()
        {profesor= new ProfesorBL();
            Studenti = profesor.GetStudentsGrade();
        }
        public ObservableCollection<NOTA> Studenti
        {
            get => studenti; set => studenti = value;
        }
    }
}
