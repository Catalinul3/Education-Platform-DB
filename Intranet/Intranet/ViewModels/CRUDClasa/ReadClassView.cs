using Intranet.Database;
using Intranet.ViewModelBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intranet.ViewModels.CRUDClasa
{
    public class ReadClassView:BaseVM
    {
        AdminBL admin;
        ObservableCollection<Clasa> _listaDeClase;
        public ReadClassView()
        {
            admin= new AdminBL();
            ListaDeClase = admin.GetClasa();
        }
        public ObservableCollection<Clasa> ListaDeClase
        {
            get => _listaDeClase;
            set => _listaDeClase = value; 
        }
    }
}
