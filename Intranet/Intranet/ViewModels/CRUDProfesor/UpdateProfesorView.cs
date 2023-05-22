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
    public class UpdateProfesorView : BaseVM
    {   string _oldUsername;
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
        string _newUsername;
        string _newPassword;
        string _newSubject;
        ObservableCollection<string> _subjects;
       public string oldUsername
        {
            get => _oldUsername;
            set
            {
                _oldUsername= value;
            OnPropertyChanged("oldUsername");
            }
        }
        public string newUsername
        {
            get => _newUsername;
            set
            {
                _newUsername = value;
                OnPropertyChanged(nameof(newUsername));
            }
        }
        public string newPassword
        {
            get => _newPassword;
            set
            {
                _newPassword = value; OnPropertyChanged("password");
            }
        }
        public string newSubject
        {
            get => _newSubject; set
            {
                _newSubject = value;
                OnPropertyChanged(nameof(newSubject));
            }
        }
        public ObservableCollection<string> subjects
        {
            get => admin.getNameofSub(); set
            {
                _subjects = value;
                OnPropertyChanged(nameof(subjects));
            }
        }
        AdminBL admin;
        public UpdateProfesorView()
        {
            admin = new AdminBL();
        }
        ICommand update;
        public ICommand Update
        {
            get
            {
                if (update == null)
                {
                    update = new RelayCommands(UpdateMethod);
                }
                return update;
            }
        }
        public void UpdateMethod(object obj)
        { Materie m = admin.GetMateries(_newSubject);
            int i = admin.findProfesorByUsername(_oldUsername);
            obj = new Profesor()
            {  ProfesorID=i,
                Username = newUsername,
                Parola = newPassword,
              
            };
            admin.updateProfessor(obj, newSubject);

        }
    }
}
