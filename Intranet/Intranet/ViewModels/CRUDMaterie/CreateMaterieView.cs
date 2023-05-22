using Intranet.Commands;
using Intranet.Database;
using Intranet.ViewModelBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Intranet.ViewModels.CRUDMaterie
{
    public class CreateMaterieView:BaseVM
    {
        ObservableCollection<string> _numeSpecializari;
        string _selectedSpecializare;
        public string selectedSpecializare
        {
            get
            {
                return _selectedSpecializare;
            }
            set
            {
                _selectedSpecializare = value;
                OnPropertyChanged("selected");
            }
        }
        bool _teza;
        public bool Teza
        {
            get
            {
                return _teza;
            }
            set
            {
                _teza = value; OnPropertyChanged("Teza");
            }
        }

        public ObservableCollection<string> numeSpecializari
        {
            get => adminBL.NameSpecializations();
            set { }
        }
        string _denumire;
        public string Denumire
        {
            get => _denumire;
            set
            {
                _denumire = value;
                OnPropertyChanged(nameof(Denumire));
            }
        }
        string _specializare;
        public string Specializare
        {
            get => _specializare;
            set
            {
                _specializare = value;
                OnPropertyChanged(nameof(Specializare));
            }
        }
        string _eroare;
        public string Eroare
        {
            get => _eroare;
            set
            {
                _eroare = value;
                OnPropertyChanged(nameof(Eroare));
            }
        }
        AdminBL adminBL;
        public CreateMaterieView()
        {
            adminBL = new AdminBL();
        }
        ICommand adaugaMaterie;
        public ICommand AdaugaMaterie
        {
            get
            {
                if (adaugaMaterie == null)
                {
                    adaugaMaterie = new RelayCommands(AdaugaMaterieNoua);
                }
                return adaugaMaterie;
            }
        }
        public void AdaugaMaterieNoua(object obj)
        {int spec = adminBL.findSpec(selectedSpecializare);
           

            obj = new Materie
            {
               Nume=Denumire,
               Teza=Teza
               
              
            };
            Specializare specialiare = new Specializare()
            {
                SpecializareID = spec
            };
           
            adminBL.addMaterie(obj);
            adminBL.addMaterieSpecializare(obj, specialiare);
            Eroare = adminBL.ErrorMessage;
            
        }
    }
}
