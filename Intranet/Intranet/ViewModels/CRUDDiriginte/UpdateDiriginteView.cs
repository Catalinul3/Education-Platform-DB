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
    public class UpdateDiriginteView : BaseVM
    {
        ObservableCollection<string> materii;
        public ObservableCollection<string> materiiList
        {
            get=> admin.getNameOfSubjectAndSpec();
            set
            {
                materii = value;
                OnPropertyChanged(nameof(materiiList));
            }
        }
        ObservableCollection<string> noulDirig;
        ObservableCollection<string> vechiulDirig;
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
        { get => materie;
            set { 
            
            materie = value; OnPropertyChanged("materie");
            }
        }
        public ObservableCollection<string> vechiul
        {
            get => admin.NumeleDirigintilor();
            set
            {
                vechiulDirig = value;
                OnPropertyChanged("vechi");
            }
        }
        public ObservableCollection<string> noul
        {
            get => admin.NumeleDirigintilor();
            set
            {
                noulDirig = value;
                OnPropertyChanged("noul");
            }
        }
        ObservableCollection<string> vechiP;
        public ObservableCollection<string> VechiP
        {
            get => admin.PrenumeleDirigintilor();
            set
            {
                vechiP = value;
                OnPropertyChanged("vechiP");
            }
        }
        ObservableCollection<string> noulP;
        public ObservableCollection<string> NoulP
        {
            get => admin.PrenumeleDirigintilor();
            set
            {
                noulP = value;
                OnPropertyChanged("noulP");
            }
        }
        string _numeDiriginteVechi;
        string _prenumeDiriginteVechi;
        string _numeDiriginteNou;
        string _prenumeDiriginteNou;
        public string numeDiriginteVechi
        {
            get => _numeDiriginteVechi;
            set
            {
                _numeDiriginteVechi = value;
                OnPropertyChanged(nameof(numeDiriginteVechi));
            }
        }
        public string prenumeDiriginteVechi
        {
            get => _prenumeDiriginteVechi;
            set
            {
                _prenumeDiriginteVechi = value;
                OnPropertyChanged(nameof(prenumeDiriginteVechi));
            }
        }
        public string numeDiriginteNou
        {
            get => _numeDiriginteNou;
            set
            {
                _numeDiriginteNou = value;
                OnPropertyChanged(nameof(numeDiriginteNou));
            }
        }
        public string prenumeDiriginteNou
        {
            get => _prenumeDiriginteNou;
            set
            {
                _prenumeDiriginteNou = value;
                OnPropertyChanged(nameof(prenumeDiriginteNou));
            }
        }
        AdminBL admin;
        public UpdateDiriginteView()
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
                Nume = numeDiriginteVechi,
                PRENUME = prenumeDiriginteVechi
            };
            Diriginte dirigNou = new Diriginte()
            {
                Nume = numeDiriginteNou,
                PRENUME = prenumeDiriginteNou
            };
            admin.updateDiriginte(obj, dirigNou);
          
            eroare = admin.ErrorMessage;

        }
    }
}
