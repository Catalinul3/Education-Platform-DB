using Intranet.Commands;
using Intranet.Database;
using Intranet.ViewModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Intranet.ViewModels.CRUD
{
    public class UpdateSpecView:BaseVM
    {
        string vecheaDenumire;
        string nouaDenumire;
        string eroare;
        public string VecheaDenumire
        {
            get => vecheaDenumire;
            set
            {
                vecheaDenumire = value;
                OnPropertyChanged(nameof(VecheaDenumire));
            }
        }
        public string NouaDenumire
        {
            get => nouaDenumire;
            set
            {
                nouaDenumire = value;
                OnPropertyChanged(nameof(NouaDenumire));
            }
        }
        public string Eroare
        {
            get => eroare;
            set
            {
                eroare = value;
                OnPropertyChanged(nameof(Eroare));
            }
        }
        AdminBL admin;
        public UpdateSpecView()
        {
            admin= new AdminBL();
        }
        ICommand _actualizareSpecializare;
        public ICommand ActualizareSpecializare
        {
            get
            {
                               if(_actualizareSpecializare==null)
                {
                    _actualizareSpecializare = new RelayCommands(Actualizare);
                }
                return _actualizareSpecializare;
            }
        }
        public void Actualizare(object obj) {
            Specializare veche = new Specializare()
            {SpecializareID=admin.find(vecheaDenumire).SpecializareID,
                NumeSpecializare = vecheaDenumire
            };
            
            Specializare noua = obj as Specializare;
            obj = new Specializare()
            {
                NumeSpecializare = nouaDenumire
            };
            admin.updateSpec(veche, obj);
            eroare = admin.ErrorMessage;
        }
    }
}
