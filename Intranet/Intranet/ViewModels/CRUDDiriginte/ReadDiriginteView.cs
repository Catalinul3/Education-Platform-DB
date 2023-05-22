using Intranet.Database;
using Intranet.ViewModelBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intranet.ViewModels.CRUDDiriginte
{
    public class ReadDiriginteView:BaseVM
    {
        AdminBL admin;
        ObservableCollection<Diriginte> diriginti;
        public ReadDiriginteView()
        {
            admin = new AdminBL();
            ListaDeDiriginti = admin.GetDiriginte();

        }
        public ObservableCollection<Diriginte> ListaDeDiriginti
        {
            get => diriginti;
            set => diriginti = value;
        }
    }
}
