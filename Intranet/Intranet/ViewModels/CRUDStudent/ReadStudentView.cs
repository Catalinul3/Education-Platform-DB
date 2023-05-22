using Intranet.Database;
using Intranet.ViewModelBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intranet.ViewModels.CRUDStudent
{
    public class ReadStudentView:BaseVM
    {
        AdminBL admin;
        ObservableCollection<Student> studenti;
        public ReadStudentView()
        {
            admin = new AdminBL();
            ListaDeStudenti = admin.GetStudents();

        }
        public ObservableCollection<Student> ListaDeStudenti
        {
            get => studenti;
            set => studenti = value;
        }

    }
}

