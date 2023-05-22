using Intranet.ViewModelBase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Intranet.FirstWindowAndLogInWindowVM
{
    public class LogInStudent:BaseVM
    {
        private string _username;
        private string _password;
        private BitmapImage _imageSource;
        private string _image;
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
        public LogInStudent()
        {
            string based = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(based, "Resources/student.png");
            image = path;

        }
    }
}
