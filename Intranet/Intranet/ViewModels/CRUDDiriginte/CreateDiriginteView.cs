using Intranet.Commands;
using Intranet.Database;
using Intranet.ViewModelBase;
using Intranet.Views.CRUD;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Intranet.ViewModels.CRUDDiriginte
{
    public class CreateDiriginteView:BaseVM
    {
        string _nume;
        string _prenume;
        string _username;
        string _password;
        string _class;
        string _subject;
        public string nume
        {
            get => _nume;
            set
            {
                _nume = value;
                OnPropertyChanged(nameof(nume));
            }
        }
        public string prenume
        {
            get => _prenume;
            set
            {
                _prenume = value;
                OnPropertyChanged(nameof(prenume));
            }
        }
        public string username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged(nameof(username));
            }
        }
        public string password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(password));
            }
        }
        public string clasa
        {
            get => _class;
            set
            {
                _class = value;
                OnPropertyChanged(nameof(clasa));
            }
        }
        string _materie;
        string _specializare;
        public string specializare
        {
            get => _specializare;
            set
            {
                _specializare = value;
                OnPropertyChanged(nameof(_specializare));
            }
        }
        public string materie
        {
            get => _materie;
            set
            {
                _materie = value;
                OnPropertyChanged(nameof(_materie));
            }
        }
        ObservableCollection<string> _clase;
        public ObservableCollection<string> Clase
        {
            get => admin.ClassName();
            set { }
        }
        ObservableCollection<string> _materii;
        public ObservableCollection<string> Materii
        {
            get => admin.getNameofSub();
            set { }
        }
     
        AdminBL admin;
        public CreateDiriginteView()
        {
            admin = new AdminBL();
        }
        private ICommand _create;
        public ICommand Create
        {
            get
            {
                if (_create == null)
                {
                    _create = new RelayCommands(CreateDiriginte);
                }
                return _create;
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
        public void CreateDiriginte(object obj)
        { Clasa clasa = admin.getClassas(_class);
            Materie materieM = admin.GetMateries(materie);
            int idmaterie = materieM.MaterieID;
          
            obj = new Diriginte()
            {
                Nume = nume,
                PRENUME = prenume,
                Username = username,
                Parola = password,
                Clasa =clasa.ClasaID,
                MateriePredata = idmaterie
            };
            admin.addDiriginte(obj);
            eroare = admin.ErrorMessage;
        }
    }
}
