using Intranet.Commands;
using Intranet.Database;
using Intranet.ViewModelBase;
using Intranet.Views.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Intranet.ViewModels.CRUDClasa
{
    public class UpdateClassView:BaseVM
    {
        string _denumire;
        public string Denumire
        {
            get => _denumire;
            set
            {
                _denumire = value;
                OnPropertyChanged(nameof(Denumire));
            }
        }
        AdminBL adminBL;
        string _specializare;
        public string Specializare
        {
            get => _specializare;
            set
            {
                _specializare = value;
                OnPropertyChanged(nameof(Specializare));
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
        ICommand actualizeazaClasa;
        public ICommand ActualizeazaClasa
        {
            get
            {
                if (actualizeazaClasa == null)
                {
                    actualizeazaClasa = new RelayCommands(ModifyClass);
                }
                return actualizeazaClasa;
            }
        }
        public void ModifyClass(object obj)
        {
            if (Denumire == null || Denumire == "")
            {
                eroare = "Introduceti denumirea clasei";
            }
            else
            {
                adminBL = new AdminBL();
                Specializare specializare = new Specializare()
                {
                    NumeSpecializare = _specializare
                };
                obj = new Clasa()
                {
                    Nume = _denumire,
                    SpecializareID = adminBL.findSpec(_specializare)
                };
             
                adminBL.updateClass(obj);
                eroare = "Clasa a fost modificata";
            }
        }
    }
}
