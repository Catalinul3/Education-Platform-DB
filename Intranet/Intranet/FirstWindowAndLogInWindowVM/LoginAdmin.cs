using Intranet.Commands;
using Intranet.Database;
using Intranet.ViewModelBase;
using Intranet.Views.UsersPage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Intranet.Commands;

namespace Intranet.FirstWindowAndLogInWindowVM
{
    public class LoginAdmin : BaseVM
    {
        private string _username;
        private string _password;
        private AdminBL adminBL;
        private BitmapImage _imageSource;
        private string _image;
        private ICommand _connect;
        public string image
        {
            get { return _image; }
            set
            {
                _image = value;
                OnPropertyChanged("image");
            }
        }
        public string username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged("username");
            }
        }
        public string password
        {
            get { return _password; }
            set
            {
                _password = value; OnPropertyChanged("password");
            }

        }
        public BitmapImage imageSource
        {
            get { return _imageSource; }
            set
            {
                _imageSource = value;
                OnPropertyChanged(nameof(imageSource));
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
       
     public LoginAdmin()
        {
            string based = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(based, "Resources/admin.png");
            image = path;
            adminBL= new AdminBL();
            

        }
        private bool canExecuteCommand = true;
        public bool CanExecuteCommand
        {
            get
            {
                return canExecuteCommand;
            }
            set
            {
                if (canExecuteCommand == value)
                {
                    return;
                }
                canExecuteCommand = value;
            }
        }
        public ICommand connect
        {
           get
            {
                if(_connect==null)
                {
                    _connect = new RelayCommands(ConnectMethod);
                }
                return _connect;
            }
        }
        public void ConnectMethod(object obj)
        {
            obj = new Admin()
            {
                Username = _username,
                Password = _password,
            };
          
       
           adminBL.findMethod(obj);
            eroare = adminBL.ErrorMessage;
            if(eroare=="")
            {
              connectAdmin();
            }
           
           
        }
        public void connectAdmin()
        {
            AdminPage admin=new AdminPage();
            admin.ShowDialog();
        }
        
    }
    
}
