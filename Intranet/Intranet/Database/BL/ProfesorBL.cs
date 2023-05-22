using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Intranet.Database.BL
{

    public class ProfesorBL
    {
        private Entities context = Dependency._context;
        public ObservableCollection<Profesor> ProfesorList { get; set; }
        public ObservableCollection<NOTA> NotaList { get; set; }
        public ObservableCollection<Student> StudentList { get; set; }
        public ObservableCollection<Absente> AbsenteList { get; set; }
        public string ErrorMessage { get; set; }
        public ProfesorBL()
        {

        }
        public void findMethod(object obj)
        {
            Profesor profesor = obj as Profesor;
            if (profesor != null)
            {
                if (string.IsNullOrEmpty(profesor.Username))
                {
                    ErrorMessage = "Numele de utilizator al Profesorlui trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }
                if (string.IsNullOrEmpty(profesor.Parola))
                {
                    ErrorMessage = "Parola Profesorlui trebuie precizata";
                    MessageBox.Show(ErrorMessage);
                }
                else
                {
                    int result = context.ProfesorF(profesor.Username, profesor.Parola).FirstOrDefault() ?? -1;

                    if (result == 0)
                    {
                        ErrorMessage = "Profesorle nu a fost gasit";
                        MessageBox.Show(ErrorMessage);

                    }
                    else
                    {
                        MessageBox.Show("Profesorle a fost gasit");
                        ErrorMessage = "";
                    }
                }
            }
        }
        public ObservableCollection<string> viewAbsences()
        {
            List<Absente> list = context.Absentes.ToList();
            ObservableCollection<string> absences = new ObservableCollection<string>();
            foreach (Absente absenta in list)
            {
                absences.Add(absenta.ToString());
            }
            return absences;
        }
        public NOTA addGradeByGrade(int grade, int semestru, Materie materie)
        {
            NOTA nota = new NOTA()
            {
                Grad = grade,
            Semestru = semestru,
            Materia = materie.MaterieID
        };
            return nota;
        }
        public ObservableCollection<string> viewGrades()
        {
            List<NOTA> list = context.NOTAs.ToList();
            ObservableCollection<string> grades = new ObservableCollection<string>();
            foreach (NOTA nota in list)
            {
                grades.Add(nota.ToString());
            }
            return grades;
        }
        public void addAbsences(Student student, Materie materie,int semestru)
        {

        }
        public void addGrade(Student student, Materie materie,int grade,int semestru)
        {
            NOTA nOTA = addGradeByGrade(grade,semestru,materie);
            nOTA.Elev = student.StudentID;
            student.NOTAs.Add(nOTA);
            context.NOTAs.Add(nOTA);
            context.SaveChanges();

        }


        public void clearAbsences(Student student, Materie materie) { }
        public void clearGrades(Student student, Materie materie, int grade, int semestru) { }

        public float average(Student student,Materie materie)
        { 
            
            float sum=0;
          
            return sum;
        }
        public ObservableCollection<NOTA>GetNOTA()
        {
            List<NOTA> nota = context.NOTAs.ToList();
            ObservableCollection<NOTA>result= new ObservableCollection<NOTA>();
            foreach(NOTA nOTA in nota)
            {
                result.Add(nOTA);

            }
            return result;
        }
        public ObservableCollection<string> getStudentByName()
        {
            List<Student> student=context.Students.ToList();
            ObservableCollection<string>result= new ObservableCollection<string>();
            foreach(Student s in student)
            {
                result.Add(s.Nume);
            }
            return result;
        }
        public ObservableCollection<string> getStudentByNameF(string nume)
        {
            List<Student>students=context.Students.ToList();
            ObservableCollection<string> result = new ObservableCollection<string>();
            foreach(Student s in students)
            {
                if(s.Nume==nume)
                {
                    result.Add(s.Prenume);
                }
            }
            return result;
        }
        public ObservableCollection<int>Grades()
        {
            ObservableCollection<int>result= new ObservableCollection<int>();
            for(int i=1;i<=10;i++)
            {
                result.Add(i);
            }
            return result;
        }
        public List<Materie> GetMaterie()
        {
            return context.Materies.ToList();
        }
        public ObservableCollection<string>GetMateries()
        {
            List<Materie>materii=context.Materies.ToList();
            ObservableCollection<string>materiie=new ObservableCollection<string>();
            foreach(Materie m in materii)

            {
                materiie.Add(m.Nume);
            }
            return materiie;
        }
        public ObservableCollection<NOTA> GetStudentsGrade()
        {
            List<NOTA>student=context.NOTAs.ToList();
            ObservableCollection<NOTA>students=new ObservableCollection<NOTA>();
            foreach(NOTA s in student)
            {
                students.Add(s);
            }
            return students;
        }

    }
}

