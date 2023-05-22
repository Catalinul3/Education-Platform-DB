using Intranet.Commands;
using Intranet.Database;
using Intranet.ViewModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Intranet.ViewModels.CRUDMaterie
{
    public class UpdateMaterieView : BaseVM
    {
        string _vecheaMaterie;
        string _nouaMaterie;
        string _specializareVeche;
        string _specializareNoua;
        string _eroare;
        AdminBL adminBL;
        public string vecheaMaterie
        {
            get => _vecheaMaterie;
            set
            {
                _vecheaMaterie = value;
                OnPropertyChanged(nameof(vecheaMaterie));
            }
        }
        public string nouaMaterie
        {
            get => _nouaMaterie;
            set { _nouaMaterie = value; OnPropertyChanged(nameof(nouaMaterie)); }
        }
        public string specializareVeche
        {
            get => _specializareVeche; set
            {
                _specializareVeche = value;

                OnPropertyChanged(nameof(specializareVeche));
            }
        }
        public string specializareNoua
        {
            get => _specializareNoua; set
            {
                _specializareNoua = value;

                OnPropertyChanged(nameof(specializareNoua));
            }
        }
        public string eroare
        {
            get => _eroare; set
            {
                _eroare = value;
                OnPropertyChanged(nameof(eroare));
            }
        }
        public UpdateMaterieView()
        {
            adminBL = new AdminBL();
        }
        ICommand _actualizareaMateriei;
        public ICommand actualizareaMateriei
        {
            get
            {
                if (_actualizareaMateriei == null)
                {
                    _actualizareaMateriei = new RelayCommands(Actualizare);
                }
                return _actualizareaMateriei;
            }
        }
        public void Actualizare(object obj)
        {
           
            Specializare specializareN = adminBL.find(specializareNoua);
            Materie materieNoua = new Materie
            {
                Nume = nouaMaterie,
               
            };
            Specializare specializareV=adminBL.find(specializareVeche);
            obj = new Materie
            {
                MaterieID = adminBL.GetMateries(vecheaMaterie).MaterieID,
                Nume = vecheaMaterie,
               
            };
            adminBL.updateMaterie(obj,materieNoua);
            eroare = adminBL.ErrorMessage;
        }
    }
}
