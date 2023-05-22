using Intranet.Database;
using Intranet.ViewModelBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intranet.ViewModels.CRUDProfesor
{
    public class ReadProfesorView:BaseVM
    {
      
        
            AdminBL admin;
            ObservableCollection<MateriiProfesori> materie;
            ObservableCollection<Profesor> profesori;
            public ReadProfesorView()
            {
                admin = new AdminBL();
                ListaDeMateriiSiProfesori = admin.GetMateriiProfesori();
              
            }
            public ObservableCollection<MateriiProfesori> ListaDeMateriiSiProfesori
            {
                get => materie;
                set => materie = value;
            }
           
        }
    
}
