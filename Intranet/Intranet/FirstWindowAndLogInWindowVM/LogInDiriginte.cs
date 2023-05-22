﻿using Intranet.Commands;
using Intranet.Database;
using Intranet.Database.BL;
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

namespace Intranet.FirstWindowAndLogInWindowVM
{
    public class LogInDiriginte:BaseVM
    {
        private string _username;
        private string _password;
        private BitmapImage _imageSource;
        private DiriginteBL dirigBL;
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
        public LogInDiriginte()
        {
            string based = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(based, "Resources/diriginte.png");
            image = path;
            dirigBL= new DiriginteBL();

        }
        private ICommand _connect;
        public ICommand connect
        {
            get
            {
                if (_connect == null)
                {
                    _connect = new RelayCommands(ConnectMethod);
                }
                return _connect;
            }
        }
        string eroare;
        public string Eroare
        {
            get { return eroare; }
            set
            {
                eroare = value;
                OnPropertyChanged(nameof(Eroare));
            }
        }
        public void ConnectMethod(object obj)
        {
            obj = new Diriginte()
            {
                Username = _username,
                Parola = _password,
            };


            dirigBL.findMethod(obj);
            eroare = dirigBL.ErrorMessage;
            if (eroare == "")
            {
                connectDirig();
            }


        }
        public void connectDirig()
        {
            DirigintePage diriginte = new DirigintePage();
            diriginte.ShowDialog();
        }
    }
}
