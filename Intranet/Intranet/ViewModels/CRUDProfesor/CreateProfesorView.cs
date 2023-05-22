using Intranet.Commands;
using Intranet.Database;
using Intranet.ViewModelBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Intranet.ViewModels.CRUDProfesor
{
    public class CreateProfesorView : BaseVM
    {
        string _nume;
        string _prenume;
        string _username;
        string _password;
        string _selectedSubject;
        AdminBL admin;
        ObservableCollection<string> _subjects;
        public string nume
        {
            get => _nume;
            set
            {
                _nume = value;
                OnPropertyChanged("Name");
            }
        }
        public string prenume
        {
            get => _prenume;
            set
            {
                _prenume = value;
                OnPropertyChanged("FirstName");

            }

        }
        public string username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged("Username");
            }
        }
        public string password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }
        public ObservableCollection<string> subjects
        {
            get => admin.getNameofSub();
            set
            {
                _subjects = value;
                OnPropertyChanged("Subjects");
            }
        }
        public string selectedSubject
        {
            get => _selectedSubject;
            set
            {
                _selectedSubject = value;
                OnPropertyChanged("SelectedSubject");
            }
        }
        public CreateProfesorView()
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
                    _create = new RelayCommands(CreateProfessor);
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
                OnPropertyChanged("eroare");
            }
        }
        public void CreateProfessor(object obj)
        {
            obj = new Profesor()
            {
                Nume = nume,
                Prenume = prenume,
                Username = username,
                Parola = password,

            };
            admin.addProfesor(obj, selectedSubject);
            eroare = admin.ErrorMessage;
        }
    }
}