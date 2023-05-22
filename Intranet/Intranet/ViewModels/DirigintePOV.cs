using Intranet.ViewModelBase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intranet.ViewModels
{
    public class DirigintePOV : BaseVM
    {

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
        public DirigintePOV()
        {
            string based = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(based, "Resources/admin.png");
            image = path;
        }
    }
}
