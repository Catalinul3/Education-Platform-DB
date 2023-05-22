using Intranet.Commands;
using Intranet.Database;
using Intranet.Database.BL;
using Intranet.ViewModelBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Intranet.ViewModels.ProfessorActionView
{
    public class AddGradesView:BaseVM
    {
        ObservableCollection<string> catalog;
        public ObservableCollection<string> Catalog
        {
            get => profesor.getStudentByName();
            set
            {
                catalog = value;
                OnPropertyChanged("Catalog");
            }
        }
        string nume;
        public string Nume
        {
            get => nume;
            set
            {
                nume= value; OnPropertyChanged("Nume");
                Prenume = profesor.getStudentByNameF(Nume);
            }
        }
        ObservableCollection<string> materii;
        public ObservableCollection<string> Materii
        {
            get => profesor.GetMateries();
            set
            {
                materii = value; OnPropertyChanged("Materii");
            }
        }

        ObservableCollection<string> prenume;
        public ObservableCollection<string> Prenume
        {
            get => prenume;
            set
            {
                prenume = value;
                OnPropertyChanged("Prenume");
            }
        }
        string _materii;
        public string selectedMaterii
        {
            get => _materii;
            set
            {
                _materii = value;
                OnPropertyChanged("SMaterii");
            }
        }
        string selectedPrenume;
        public string SelectedPrenume
        {
            get => selectedPrenume;
            set
            {
                selectedPrenume= value; OnPropertyChanged("SelectedPrenume");

            }
        }
        ObservableCollection<int> grades;
        public ObservableCollection<int> Grades
        {
            get => profesor.Grades();
            set
            {
                Grades = value; OnPropertyChanged("Grades");
            }
        }
        int selectedGrade;
        public int SelectedGrade
        {
            get => selectedGrade;
            set
            {
                selectedGrade= value; OnPropertyChanged(nameof(SelectedGrade));
            }
        }
     
        ProfesorBL profesor;
        public AddGradesView()
        {
            profesor = new ProfesorBL();
        }
        ICommand add;
        public ICommand Add
        {
            get
            {
                if(add==null)
                {
                    add = new RelayCommands(AddGrade);
                }
                return add;
            }
        }
        ObservableCollection<int> _semestre;
        public ObservableCollection<int> Semestre
        {
            get => Semester();
            set
            {
                _semestre = value;
                OnPropertyChanged(nameof(Semester));
            }
        }
        int selectedSem;
        public int SelectedSem
        {
            get => selectedSem;
            set
            {
                selectedSem= value; OnPropertyChanged(nameof(SelectedSem));
            }
        }
        public void AddGrade(object obj)
        { AdminBL admin = new AdminBL();
            obj = new Student()
            {
                Nume = Nume,
                Prenume = SelectedPrenume,

            };
            Student student = obj as Student;
            Materie materii = admin.GetMateries(_materii);
            profesor.addGrade(student, materii, selectedGrade, selectedSem);




        }
        public ObservableCollection<int>Semester()
        {
            ObservableCollection<int> result = new ObservableCollection<int>();
            for(int i=1;i<=2;i++)
            {
                result.Add(i);
            }
            return result;
        }
    }
}
