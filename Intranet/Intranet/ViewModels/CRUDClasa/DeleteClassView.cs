using Intranet.Commands;
using Intranet.Database;
using Intranet.ViewModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Intranet.ViewModels.CRUDClasa
{
    public class DeleteClassView:BaseVM
    {
        string _denumireClasa;
        public string DenumireClasa
        {
            get
            {
                return _denumireClasa;
            }
            set
            {
                _denumireClasa = value;
                OnPropertyChanged("DenumireClasa");
            }
        }
        string _eroare;
        public string Eroare
        {
            get
            {
                return _eroare;
            }
            set
            {
                _eroare = value;
                OnPropertyChanged("Eroare");
            }
        }
        AdminBL admin;
        public DeleteClassView()
        {
            admin = new AdminBL();
        }
        ICommand sterge;
        public ICommand Sterge
        {
            get
            {
                if (sterge == null)
                {
                    sterge = new RelayCommands(StergeClasa);
                }
                return sterge;
            }
        }
        public void StergeClasa(object obj)
        {
            obj = new Clasa
            {
                Nume = DenumireClasa
            };
            
            if (DenumireClasa != null)
            {
                admin.deleteClass(obj);
                Eroare = "Clasa a fost stearsa cu succes!";
            }
            else
            {
                Eroare = "Nu ati introdus denumirea clasei!";
            }
        }
    }
}
