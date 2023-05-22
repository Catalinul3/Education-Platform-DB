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

namespace Intranet.ViewModels.CRUDDiriginte
{
    public class UpdateDiriginteParolaView:BaseVM
    {
        ObservableCollection<string> materii;
        ObservableCollection<string> numeDiriginte;
        ObservableCollection<string> prenumeDiriginte;
        public ObservableCollection<string> _numeDiriginte
        {
            get => admin.NumeleDirigintilor();
            set
            {
                numeDiriginte = value;
                OnPropertyChanged("numeDiriginte");
            }
        }
        public ObservableCollection<string>_prenumeDiriginte
        {
            get => admin.PrenumeleDirigintilor();
            set
            {
             
                prenumeDiriginte = value;
                OnPropertyChanged("prenumeDiriginte");
            
            }
        }
        string nume;
        string prenume;
        public string Nume
        {
            get => nume;
            set
            {
                nume = value;
                OnPropertyChanged("Nume");
            }
        }
        public string Prenume
        {
            get => prenume;
            set
            {
                prenume = value;
                OnPropertyChanged("prenume");
            }
        }
        public ObservableCollection<string> materiiList
        {
            get => admin.getNameOfSubjectAndSpec();
            set
            {
                materii = value;
                OnPropertyChanged(nameof(materiiList));
            }
        }
        string nouaParola;
        public string _nouaParola
        {
            get => nouaParola;
            set
            {
                nouaParola = value;
                OnPropertyChanged(nameof(nouaParola));
            }
        }
        string materie;
        public string _materie
        {
            get => materie;
            set
            {

                materie = value; OnPropertyChanged("materie");
            }
        }
        AdminBL admin;
        public UpdateDiriginteParolaView()
        {
            admin = new AdminBL();
        }
        ICommand _update;
        public ICommand update
        {
            get
            {
                if (_update == null)
                {
                    _update = new RelayCommands(UpdateMethod);
                }
                return _update;

            }
        }
        string _eroare;
        public string eroare
        {
            get { return _eroare; }
            set
            {
                _eroare = value;
                OnPropertyChanged(nameof(eroare));
            }
        }
        public void UpdateMethod(object obj)
        {
            obj = new Diriginte()
            {
                Nume = Nume,
                PRENUME = prenume,
                Parola=nouaParola
            };
         
           
            MateriiSpecializari ms = admin.GetMateriiSpecializari(materie);
            admin.updateDiriginteParola(obj, ms.MaterieSpecializare);
            eroare = admin.ErrorMessage;

        }
    }
}

