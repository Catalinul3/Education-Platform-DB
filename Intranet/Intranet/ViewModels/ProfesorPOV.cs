using Intranet.Commands.Grades;
using Intranet.ViewModelBase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Intranet.ViewModels
{
    public class ProfesorPOV : BaseVM
    {

        private string image;
        public ICommand addGrade { get; set; }
        public ICommand viewGrade { get; set; }
        public string Image
        {
            get => image;
            set
            {
                image = value;
                OnPropertyChanged(nameof(Image));
            }
        }
        public ProfesorPOV()
        {
            string based = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(based, "Resources/profesor.png");
            image = path;
            addGrade = new AddGradesButton();
            viewGrade= new ViewGradesButton();
        }
    }
}
