using Intranet.Database;
using Intranet.ViewModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Intranet.Commands;
using System.Collections.ObjectModel;

namespace Intranet.ViewModels
{
    public class CreateView : BaseVM
    {
        ObservableCollection<string> _nameSpec;
        public ObservableCollection<string> nameSpec
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
        public CreateView()
        {
            adminBL=new AdminBL();
        }
        AdminBL adminBL;
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
        private string _eroare;
        public string eroare
        {
            get { return _eroare; }
            set
            {
                _eroare = value;
                OnPropertyChanged(nameof(eroare));
            }
        }
        ICommand createClasa;
        public ICommand CreazaClasa
        {
            get
            {
                if (createClasa == null)
                {
                    createClasa = new RelayCommands(CreateClass);
                }
                return createClasa;
            }
        }
        public void CreateClass(object obg)
        {
            string nume = Specializare;
            Specializare specializare = new Specializare()
            {  SpecializareID=adminBL.findSpec(Specializare),
                NumeSpecializare = Specializare
            };
            obg = new Clasa()
            {
                Nume = _denumire,
                
            };
            adminBL.addClass(obg,specializare);
            eroare = adminBL.ErrorMessage;   
        }
    }

}

