using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Intranet.Database.BL
{
    public class ElevBL
    {
        private Entities context = Dependency._context;
        public ObservableCollection<Student> StudentList { get; set; }
        public string ErrorMessage { get; set; }
        public ElevBL()
        {

        }
        public void findMethod(object obj)
        {
            Student student = obj as Student;
            if (student != null)
            {
                if (string.IsNullOrEmpty(student.Username))
                {
                    ErrorMessage = "Numele de utilizator al Studentlui trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }
                if (string.IsNullOrEmpty(student.Parola))
                {
                    ErrorMessage = "Parola Studentlui trebuie precizata";
                    MessageBox.Show(ErrorMessage);
                }
                else
                {
                    int result = context.StudentF(student.Username, student.Parola).FirstOrDefault() ?? -1;

                    if (result == 0)
                    {
                        ErrorMessage = "Studentle nu a fost gasit";
                        MessageBox.Show(ErrorMessage);

                    }
                    else
                    {
                        MessageBox.Show("Studentle a fost gasit");
                        ErrorMessage = "";
                    }
                    
                }
            }
        }
    }
}
  
