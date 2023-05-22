using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Intranet.Database.BL
{
    public class DiriginteBL
    {
        private Entities context = Dependency._context;
        public ObservableCollection<Diriginte> diriginteList { get; set; }
        public string ErrorMessage { get; set; }
        public DiriginteBL()
        {

        }
        public void findMethod(object obj)
        {
            Diriginte diriginte = obj as Diriginte;
            if (diriginte != null)
            {
                if (string.IsNullOrEmpty(diriginte.Username))
                {
                    ErrorMessage = "Numele de utilizator al dirigintelui trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }
                if (string.IsNullOrEmpty(diriginte.Parola))
                {
                    ErrorMessage = "Parola dirigintelui trebuie precizata";
                    MessageBox.Show(ErrorMessage);
                }
                else
                {
                    int result = context.DiriginteF(diriginte.Username, diriginte.Parola).FirstOrDefault() ?? -1;

                    if (result == 0)
                    {
                        ErrorMessage = "Dirigintele nu a fost gasit";
                        MessageBox.Show(ErrorMessage);

                    }
                    else
                    {
                        MessageBox.Show("Dirigintele a fost gasit");
                        ErrorMessage = "";
                    }
                }
            }
        }
    }
}
