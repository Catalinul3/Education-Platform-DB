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

namespace Intranet.ViewModels.CRUDMaterie
{
    public class DeleteMaterieView : BaseVM
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

        ObservableCollection<string> subjects;
        public ObservableCollection<string> Subjects
        {
            get => subjects;
            set
            {


                if (subjects != value)
                {
                    subjects = value;
                    OnPropertyChanged(nameof(Subjects));
                }
            }
        }

        string subject;
        public string Subject
        {
            get => subject;
            set
            {
                if (subject != value)
                {
                    subject = value;
                    OnPropertyChanged(nameof(Subject));

                }
            }
        }
        ObservableCollection<string> _species;
        public ObservableCollection<string> Species
        {
            get => admin.NameSpecializations();
            set
            {
                if (_species != value)
                {
                    _species = value;
                    OnPropertyChanged(nameof(Species));

                }
            }
        }
        string _spec;
        public string spec
        {
            get => _spec;
            set
            {
                _spec = value;
                OnPropertyChanged(nameof(spec));
                Subjects = admin.getSpecializationSubject(spec);
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
        public DeleteMaterieView()
        {
            admin = new AdminBL();

        }
        public ICommand Elimina
        {
            get
            {
                if (_elimina == null)
                {
                    _elimina = new RelayCommands(EliminaMaterie);
                }
                return _elimina;
            }
        }
        public void EliminaMaterie(object obj)
        {
            obj = new Materie()
            {
                Nume= Subject
            };
            Specializare spece = new Specializare()
            {
                NumeSpecializare = spec
            };
            admin.deleteSubject(obj,spece);
            
            eroare = admin.ErrorMessage;
        }

    }
}
