using Intranet.Database;
using Intranet.ViewModelBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intranet.ViewModels.CRUD
{
    public class ReadSpecView:BaseVM
    {
        AdminBL adminBL;
        ObservableCollection<Specializare> _listaDeSpecializari;
       public ReadSpecView()
        {
            adminBL= new AdminBL();
            ListaDeSpecializari = adminBL.GetSpecializations();
        }
        public ObservableCollection<Specializare> ListaDeSpecializari
        {
            get  => adminBL.ListaDeSpecializari; 
            set =>adminBL.ListaDeSpecializari = value;

        }
    }
}
