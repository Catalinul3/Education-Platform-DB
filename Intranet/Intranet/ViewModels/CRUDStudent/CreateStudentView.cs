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

namespace Intranet.ViewModels.CRUDStudent
{
    public class CreateStudentView : BaseVM
    {
        string _nume;
        string _prenume;
        string _username;
        string _parola;
        string _clasa;
        AdminBL admin;
        ObservableCollection<string> _clase;
        public string nume
        {
            get => _nume;
            set
            {
                _nume = value;
                OnPropertyChanged("Nume");
            }
        }
        public string prenume
        {
            get => _prenume;
            set
            {
                _prenume = value;
                OnPropertyChanged("Prenume");
            }
        }
        public string username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged("username");
            }
        }
        public string parola
        {
            get => _parola;
            set
            {
                _parola = value;
                OnPropertyChanged("parola");
            }
        }
        public string clasa
        {
            get => _clasa;
            set
            {
                _clasa = value;
                OnPropertyChanged("clasa");
            }
        }

        public ObservableCollection<string> clase
        {
            get => admin.ClassName();
            set
            {
                _clase = value;
                OnPropertyChanged("clase");
            }
        }
        string _eroare;
        public string eroare
        {
            get => _eroare;
            set
            {
                _eroare = value;
                OnPropertyChanged("eroare");
            }
        }
        public CreateStudentView()
        {
            admin = new AdminBL();
        }
        ICommand _create;
        public ICommand Create
        {
            get
            {
                if (_create == null)
                {
                    _create = new RelayCommands(CreateStudent);
                }
                return _create;
            }

        }
        public void CreateStudent(object obj)
        {
            obj = new Student()
            {
                Nume = nume,
                Prenume = prenume,
                Username = username,
                Parola = parola,
                ClasaElevului = admin.getClass(clasa).ClasaID
            };
            admin.addStudent(obj, clasa);
            eroare = admin.ErrorMessage;
        }
    }
}
