using Intranet.Database;
using Intranet.ViewModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Intranet.Commands;
using System.Collections.ObjectModel;

namespace Intranet.ViewModels.CRUD
{
    public class DeleteSpecView:BaseVM
    {
        string _denumire;
      
        public string denumire
        {
            get => _denumire;
            set
            {
                _denumire = value;
                OnPropertyChanged(nameof(denumire));
            }
        }
        string _eroare;
        public string eroare
        {
            get => _eroare;
            set
            {
                _eroare = value;
                OnPropertyChanged(nameof(eroare));
            }
        }
         ICommand _elimina;
        AdminBL admin;
        public DeleteSpecView()
        {
            admin = new AdminBL();
            
        }
        public ICommand Elimina
        {
            get
            {
               if(_elimina==null)
                {
                    _elimina = new RelayCommands(EliminaSpecializare);
                }
                return _elimina;
            }
        }
        public void EliminaSpecializare(object obj)
        {
            obj = new Specializare()
            {
                NumeSpecializare = denumire
            };
            admin.DeleteSpecialization(obj);
            eroare = admin.ErrorMessage;
        }
        
    }
}
