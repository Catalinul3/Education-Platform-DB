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

namespace Intranet.ViewModels.CRUDProfesor
{
    public class DeleteProfesorView:BaseVM
    {

        ObservableCollection<string> _profiles;
        public ObservableCollection<string> Profiles
        {
            get => admin.getProfesorUsername();
            set
            {
                _profiles = value;
                OnPropertyChanged("Profiles");
            }
        }
        AdminBL admin;
        string _username;
        public string Username
        {
            get => _username;
            set
            {
                _username = value; OnPropertyChanged("Username");
            }
        }
        public DeleteProfesorView()
        {
            admin = new AdminBL();
        }
        ICommand _delete;
        public ICommand Delete
        {
            get
            {
                if (_delete == null)
                {
                    _delete = new RelayCommands(DeleteMethod);
                }
                return _delete;
            }

        }
        public void DeleteMethod(object obj)
        {
            obj = new Profesor()
            {
                Username = Username
            };
            admin.deleteProfesor(obj, Username);

        }

    }
}

