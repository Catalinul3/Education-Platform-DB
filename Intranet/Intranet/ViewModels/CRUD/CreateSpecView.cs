using Intranet.Database;
using Intranet.ViewModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Intranet.Commands;

namespace Intranet.ViewModels.CRUD
{
    public class CreateSpecView:BaseVM
    {
        string _denumire;
        public string denumire
        {
            get => _denumire;
            set
            {
                _denumire = value;
                OnPropertyChanged(nameof(denumire));
            }
        }
        string _eroare;
        public string eroare
        {
            get => _eroare;
            set
            {
                _eroare = value;
                OnPropertyChanged(nameof(eroare));
            }
        }
        AdminBL adminBL;
        private ICommand _creeazaSpecializare;
        public CreateSpecView()
        {
            adminBL = new AdminBL();
        }
        public ICommand CreeazaSpecializare
        {
            get
            {
                if(_creeazaSpecializare==null)
                {
                    _creeazaSpecializare = new RelayCommands(CreateSpecialization);
                }
                return _creeazaSpecializare;
            }
        }
        void CreateSpecialization(object obj)
        {
            obj = new Specializare
            {
                NumeSpecializare = denumire
        };
            adminBL.addSpecialization(obj);
            eroare = adminBL.ErrorMessage;   
        }

    }
}
