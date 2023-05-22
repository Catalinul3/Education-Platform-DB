using Intranet.Database;
using Intranet.ViewModelBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intranet.ViewModels.CRUDMaterie
{
    public class ReadMaterieView : BaseVM
    {
        AdminBL admin;
        ObservableCollection<MateriiSpecializari> materie;
        public ReadMaterieView()
        {
            admin = new AdminBL();
            ListaDeMaterii = admin.GetMateriiSpecializari();
            Materii = admin.GetMaterie();
            Specializari = admin.GetSpecializations();
        }
        public ObservableCollection<MateriiSpecializari> ListaDeMaterii
        {
            get => materie;
            set => materie = value;
        }
        private ObservableCollection<Materie> _materii;
        public ObservableCollection<Materie> Materii
        {
            get { return _materii; }
            set
            {
                _materii = value;
                OnPropertyChanged(nameof(Materii));
            }
        }

        private ObservableCollection<Specializare> _specializari;
        public ObservableCollection<Specializare> Specializari
        {
            get { return _specializari; }
            set
            {
                _specializari = value;
                OnPropertyChanged(nameof(Specializari));
            }
        }
    }
}