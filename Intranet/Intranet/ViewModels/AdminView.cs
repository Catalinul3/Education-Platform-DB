using Intranet.Commands;
using Intranet.Commands.CRUDPeClase;
using Intranet.Commands.CRUDPeDiriginti;
using Intranet.Commands.CRUDPeMaterie;
using Intranet.Commands.CRUDPeProfesor;
using Intranet.Commands.CRUDPeSpecializari;
using Intranet.Commands.CRUDPeStudenti;
using Intranet.Database;
using Intranet.ViewModelBase;
using Intranet.ViewModels.CRUDClasa;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Intranet.ViewModels
{
   public class AdminView:BaseVM
    {
        private AdminBL adminBL;
        private string image;
        public string Image
        {
            get => image;
            set
            {
                image = value;
                OnPropertyChanged(nameof(Image));
            }
        }
        public ICommand _createProfesor { get; set; }
        public ICommand _createDiriginte { get; set; }
        public ICommand _createStudent { get; set; }
        public ICommand _createMaterie { get; set; }
        public ICommand _createClasa { get; set; }
        public  ICommand _createSpecializare { get; set; }

        public ICommand _deleteProfesor { get; set; }
        public ICommand _deleteDiriginte { get; set; }
        public ICommand _deleteStudent { get; set; }
        public ICommand _deleteMaterie { get; set; }
        public ICommand _deleteClasa { get; set; }
        public ICommand _deleteSpecialzare { get; set; }

        public ICommand _updateProfesor { get; set; }
        public ICommand _updateDiriginte { get; set; }
        public ICommand _updateStudent { get; set; }
        public ICommand _updateMaterie { get; set; }
        public ICommand _updateClasa { get; set; }
        public ICommand _updateSpecialzare { get; set; }
        public ICommand _updateDirigParola { get; set; }
        public ICommand _viewProfesor { get; set; }
        public ICommand _viewDiriginte { get; set; }
        public ICommand _viewStudent { get; set; }
        public ICommand _viewMaterie { get; set; }
        public ICommand _viewClasa { get; set; }
        public ICommand _viewSpecialzare { get; set; }
    
        public AdminView()
        {
            string based = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(based, "Resources/admin.png");
            image = path;
            adminBL = new AdminBL();
            AdminList = adminBL.GetAdmins();
            
            _createClasa = new CreateClassButton();
            _createSpecializare = new CreateSpecializationButton();
            _createMaterie= new CreateSubjectButton();
            _createDiriginte = new CreateDiriginteButton();
            _createProfesor= new CreateProfessorButton();
            _createStudent = new CreateStudentButton();
            
            _viewClasa = new ReadClassButton();
            _viewSpecialzare =new ReadSpecializationButton();
            _viewMaterie = new ReadSubjectButton();
            _viewProfesor = new ReadProfesorButton();
            _viewStudent = new ReadStudentsButton();
            _viewDiriginte = new ReadDiriginteButton();

            _updateSpecialzare = new UpdateSpecializationButton();
            _updateClasa= new UpdateClassButton();
            _updateMaterie= new UpdateSubjectButton();
            _updateDiriginte = new UpdateDiriginteButton();
            _updateDirigParola = new UpdateDirigintePassButton();
            _updateProfesor = new UpdateProfessorButton();
            _updateStudent = new UpdateStudentButton();

            _deleteSpecialzare = new DeleteSpecializationButton();
            _deleteClasa = new DeleteClassButton();
            _deleteMaterie= new DeleteSubjectButton();
            _deleteProfesor = new DeleteProfesorButton();
            _deleteDiriginte = new DeleteDirginteButton();
            _deleteStudent  =new DeleteStudentButton();
        }
        public ObservableCollection<Admin> AdminList { 
            get => adminBL.adminList;
            set => adminBL.adminList = value;
        }
    }
}
