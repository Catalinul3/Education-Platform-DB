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
    public class UpdateStudentView:BaseVM
    {
        string _oldUsername;
        ObservableCollection<string> _profiles;
        public ObservableCollection<string> Profiles
        {
            get => admin.getStudentUsername();
            set
            {
                _profiles = value;
                OnPropertyChanged("Profiles");
            }
        }
        string _newUsername;
        string _newPassword;
        string _newClass;
        ObservableCollection<string>classes;
        public string oldUsername
        {
            get => _oldUsername;
            set
            {
                _oldUsername = value;
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
        public string newClass
        {
            get => _newClass; set
            {
                _newClass = value;
                OnPropertyChanged(nameof(newClass));
            }
        }
        public ObservableCollection<string> Classes
        {
            get => admin.ClassName(); set
            {
                classes = value;
                OnPropertyChanged(nameof(classes));
            }
        }
        AdminBL admin;
        public UpdateStudentView()
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
        {
            Clasa c = admin.getClass(newClass);
            int i = admin.findStudentByUsername(oldUsername);
            obj = new Student()
            {
                StudentID = i,
                Username = newUsername,
                Parola = newPassword,
                Clasa=c,
            };
            
            admin.updateStudent(obj,newClass);

        }
    }
}

