namespace Intranet.Database
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Security.Policy;
    using System.Windows;
    using System.Windows.Forms;
    using MessageBox = System.Windows.Forms.MessageBox;

    public partial class AdminBL
    {
        private Entities context = Dependency._context;
        public ObservableCollection<Admin> adminList { get; set; }
        public string ErrorMessage { get; set; }
        public ObservableCollection<Specializare> ListaDeSpecializari { get; set; }
        public ObservableCollection<Clasa> ListaDeClase { get; set; }
        public ObservableCollection<Materie> ListaDeMaterii { get; set; }
        public List<MateriiSpecializari> materiiSpecializari { get; set; }
        public ObservableCollection<MateriiSpecializari> ListaDeSpecSiMat { get; set; }
        public ObservableCollection<Diriginte> ListaDeDiriginti { get; set; }
        public ObservableCollection<Profesor> ListaDeProfesori { get; set; }
        public List<MateriiProfesori> profesoriMaterii { get; set; }
        public ObservableCollection<Student> ListaDeStudenti { get; set; }
        public ObservableCollection<MateriiProfesori> ListaDeMateriiSiProfesori { get; set; }
        public AdminBL()
        {

        }
        public void findMethod(object obj)
        {
            Admin admin = obj as Admin;
            if (admin != null)
            {
                if (string.IsNullOrEmpty(admin.Username))
                {
                    ErrorMessage = "Numele de utilizator al adminului trebuie precizat";
                    System.Windows. MessageBox.Show(ErrorMessage);
                }
                if (string.IsNullOrEmpty(admin.Password))
                {
                    ErrorMessage = "Parola adminului trebuie precizata";
                    System.Windows.MessageBox.Show(ErrorMessage);
                }
                else
                {
                    int result = context.AdminF(admin.Username, admin.Password).FirstOrDefault() ?? -1;

                    if (result == 0)
                    {
                        ErrorMessage = "Administratorul nu a fost gasit";
                        MessageBox.Show(ErrorMessage);

                    }
                    else
                    {
                        MessageBox.Show("Administratorul a fost gasit");
                        ErrorMessage = "";
                    }
                }
            }
        }
        public void deleteClass(object obj)
        {
            Clasa clasa = obj as Clasa;
            if (clasa != null)
            {
                if (string.IsNullOrEmpty(clasa.Nume))
                {
                    ErrorMessage = "Numele clasei trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }
                else
                {
                    var result = context.StergeClasa(clasa.Nume);
                    if (result == 0)
                    {
                        ErrorMessage = "Clasa nu a fost stearsa";
                        MessageBox.Show(ErrorMessage);
                    }
                    else
                    {
                        MessageBox.Show("Clasa a fost stearsa");
                        ErrorMessage = "";
                    }
                }
            }
        }
        public void updateClass(object obj)
        {
            Clasa clasa = obj as Clasa;
            Specializare specializare = new Specializare()
            {
                NumeSpecializare = findSpecialization(clasa.SpecializareID)
            };
            if (clasa != null)
            {
                if (string.IsNullOrEmpty(clasa.Nume))
                {
                    ErrorMessage = "Numele clasei trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }
                else
                {
                    var result = context.ModificaSpecializareClasa(clasa.Nume, specializare.NumeSpecializare);
                    if (result == 0)
                    {
                        ErrorMessage = "Clasa nu a fost modificata";
                        MessageBox.Show(ErrorMessage);
                    }
                    else
                    {
                        MessageBox.Show("Clasa a fost modificata");
                        ErrorMessage = "";
                    }
                }
            }
        }
        public void addDiriginte(object obj)
        {
            Diriginte diriginte = obj as Diriginte;
           
            if (diriginte != null)
            {
                if (string.IsNullOrEmpty(diriginte.Nume))
                {
                    ErrorMessage = "Numele dirigintelui trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }
                if (string.IsNullOrEmpty(diriginte.PRENUME))
                {
                    ErrorMessage = "Prenumele dirigintelui trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }
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
                    var result = context.AdaugaDiriginte(diriginte.Nume, diriginte.PRENUME, diriginte.Username, diriginte.Parola, diriginte.Clasa, diriginte.MateriePredata);
                    Clasa clasa = getClasaByID((int)diriginte.Clasa);
                    clasa.Diriginte = diriginte;
                    context.SaveChanges();
                    if (result == 0)
                    {
                        ErrorMessage = "Dirigintele nu a fost adaugat";
                        MessageBox.Show(ErrorMessage);
                    }
                    else
                    {
                        MessageBox.Show("Dirigintele a fost adaugat");
                        ErrorMessage = "";
                    }
                   
                }
            }
        }
        public void updateDiriginte(object obj,object obj2)
        {
            Diriginte diriginteVechi = obj as Diriginte;
            Diriginte diriginteNou= obj2 as Diriginte;
            if (diriginteVechi != null&&diriginteNou!=null)
            {
                if (string.IsNullOrEmpty(diriginteNou.Nume)&&string.IsNullOrEmpty(diriginteVechi.Nume))
                {
                    ErrorMessage = "Numele diriginților trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }
                if (string.IsNullOrEmpty(diriginteNou.PRENUME) && string.IsNullOrEmpty(diriginteVechi.PRENUME))
                {
                    ErrorMessage = "Prenumele diriginților trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }
                else
                {
                    var result = context.ActualizareDiriginte(diriginteVechi.Nume, diriginteVechi.PRENUME, diriginteNou.Nume, diriginteNou.PRENUME);
                    if (result == 0)
                    {
                        ErrorMessage = "Dirigintele nu a fost actualizat";
                        MessageBox.Show(ErrorMessage);
                    }
                    else
                    {
                        MessageBox.Show("Dirigintele a fost actualizat");
                        ErrorMessage = "";
                    }
                }
            }
        }
        public void updateDiriginteParola(object obj,int?materie)
        {
            Diriginte diriginte = obj as Diriginte;
            ListaDeDiriginti = GetDiriginte();
            if (diriginte != null)
            {
                if (string.IsNullOrEmpty(diriginte.Parola))
                {
                    ErrorMessage = "Parola dirigintelui trebuie precizata";
                    MessageBox.Show(ErrorMessage);
                }
                else
                {
                    var result = context.ActualizareDiriginteParolaSiMaterie(diriginte.Nume, diriginte.PRENUME,diriginte.Parola, materie);
                    if (result == 0)
                    {
                        ErrorMessage = "Parola nu a fost actualizata";
                        MessageBox.Show(ErrorMessage);
                    }
                    else
                    {
                        MessageBox.Show("Parola a fost actualizata");
                        ListaDeDiriginti=GetDiriginte();
                        ErrorMessage = "";
                    }
                }
            }
        }
        public Clasa getClasaByID(int id)
        {
            Clasa clasa1 = new Clasa();
            ListaDeClase = GetClasa();
            foreach (var item in ListaDeClase)
            {
                if (item.ClasaID == id)
                {
                    clasa1 = item;
                }
            }
            return clasa1;
        }
        public void addClass(object obj, object obj2)
        {
            Clasa clasa = obj as Clasa;
            Specializare specializare = obj2 as Specializare;
            if (clasa != null)
            {
                if (string.IsNullOrEmpty(clasa.Nume))
                {
                    ErrorMessage = "Numele clasei trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }
                if (string.IsNullOrEmpty(specializare.NumeSpecializare))
                {
                    ErrorMessage = "Numele specializării trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }

                else
                {
                    var result = context.AdaugaClasa(specializare.NumeSpecializare, clasa.Nume);
                    if (result == 0)
                    {
                        ErrorMessage = "Clasa nu a fost adaugata";
                        MessageBox.Show(ErrorMessage);
                    }
                    else
                    {
                        MessageBox.Show("Clasa a fost adaugata");
                        ErrorMessage = "";
                    }
                }
            }
        }
        public void addSpecialization(object obj)
        {
            Specializare specializare = obj as Specializare;
            if (specializare != null)
            {
                if (string.IsNullOrEmpty(specializare.NumeSpecializare))
                {
                    ErrorMessage = "Numele specializarii trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }
                else
                {
                    ListaDeSpecializari = GetSpecializations();
                    context.Specializares.Add(specializare);
                    if (ListaDeSpecializari.Count == 0)
                    {
                        specializare.SpecializareID = 0;
                        context.SaveChanges();

                        ListaDeSpecializari.Add(specializare);
                        MessageBox.Show("Specializarea a fost adaugata");
                        ErrorMessage = "";
                    }
                    else
                    {
                        specializare.SpecializareID = context.Specializares.Max(item => item.SpecializareID) + 1;
                        context.SaveChanges();

                        ListaDeSpecializari.Add(specializare);
                        MessageBox.Show("Specializarea a fost adaugata");
                        ErrorMessage = "";
                    }
                }
            }
        }
        public Clasa getClass(string clasa)
        {
            Clasa clasa1 = new Clasa();
            ListaDeClase = GetClasa();
            foreach(var item in ListaDeClase)
            {
                if(item.Nume==clasa)
                {
                    clasa1 = item;
                }
            }
            return clasa1;
        }
        public Materie GetMateries(string materieN)
        {
            Materie materie = new Materie();
            ListaDeMaterii = GetMaterie();
            foreach (var item in ListaDeMaterii)
            {
                if (item.Nume == materieN)
                {
                    materie = item;
                }
            }
            return materie;
        }
        public MateriiSpecializari GetMateriiSpecializari(string materie)
        {
            MateriiSpecializari materiiSpecializari = new MateriiSpecializari();
            ListaDeSpecSiMat = GetMateriiSpecializari();
            Materie materieS=GetMateries(materie);
            foreach (var item in ListaDeSpecSiMat)
            {
                if (item.MaterieID == materieS.MaterieID)
                {
                    materiiSpecializari = item;
                }
            }
            return materiiSpecializari;
        }
        public void addProfesor(object obj,string materieN)
        {
            MateriiProfesori materiiProfesori = new MateriiProfesori();
            Profesor profesor = obj as Profesor;
            ListaDeMaterii = GetMaterie();
            Materie materie=GetMateries(materieN);
            if(profesor!=null)
            {
                if(string.IsNullOrEmpty(profesor.Nume))
                {
                    ErrorMessage = "Numele profesorului trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }
                if(string.IsNullOrEmpty(profesor.Prenume))
                {
                    ErrorMessage = "Prenumele profesorului trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }
                if(string.IsNullOrEmpty(profesor.Username))
                {
                    ErrorMessage = "Numele de utilizator al profesorului trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }
                if(string.IsNullOrEmpty(profesor.Parola))
                {
                    ErrorMessage = "Parola profesorului trebuie precizata";
                }
                else
                {
                    ListaDeProfesori = GetProfesori();
                   
                    context.Profesors.Add(profesor);
                    if(ListaDeProfesori.Count==0)
                    {
                        profesor.ProfesorID = 0;
                        context.SaveChanges();
                        ListaDeProfesori.Add(profesor);
 
                        MessageBox.Show("Profesorul a fost adaugat");
                        ErrorMessage = "";
                    }
                    else
                    {
                        profesor.ProfesorID = context.Profesors.Max(item => item.ProfesorID) + 1;
                        context.SaveChanges();
                        ListaDeProfesori.Add(profesor);
                        MessageBox.Show("Profesorul a fost adaugat");
                        ErrorMessage = "";
                    }
                    profesoriMaterii = context.MateriiProfesoris.ToList();
                    if(profesoriMaterii.Count==0)
                    {
                        materiiProfesori.MateriiProfesoriID = 0;
                        materiiProfesori.MaterieID=materie.MaterieID;
                        materiiProfesori.ProfesorID = profesor.ProfesorID;
                        context.MateriiProfesoris.Add(materiiProfesori);
                        context.SaveChanges();
                        profesoriMaterii.Add(materiiProfesori);
                    }
                    else
                    {
                        materiiProfesori.MateriiProfesoriID = context.MateriiProfesoris.Max(item => item.MateriiProfesoriID)+1;
                        materiiProfesori.MaterieID = materie.MaterieID;
                        materiiProfesori.ProfesorID = profesor.ProfesorID;
                        context.MateriiProfesoris.Add(materiiProfesori);
                        context.SaveChanges();
                        profesoriMaterii.Add(materiiProfesori);

                    }
                }

            }
        }
        public int findProfesorByUsername(string username)
        {
            int id = 0;
            ListaDeProfesori = GetProfesori();
            foreach(var item in ListaDeProfesori)
            {
                if(item.Username==username)
                {
                    id = item.ProfesorID;
                }
            }
            return id;
        }
        public int findStudentByUsername(string username)
        {
            int id = 0;
            ListaDeStudenti = GetStudents();
            foreach (var item in ListaDeStudenti)
            {
                if (item.Username == username)
                {
                    id = item.StudentID;
                }
            }
            return id;
        }
    
        public void updateProfessor(object obj,string nouaMaterie)
        {
            Profesor profesor = obj as Profesor;
            ListaDeProfesori = GetProfesori();
            MateriiProfesori materiiProfesori = new MateriiProfesori();
            ListaDeMaterii = GetMaterie();
            profesoriMaterii = context.MateriiProfesoris.ToList();
            Materie materie = GetMateries(nouaMaterie);
            if(profesor!=null)
            {
                if(string.IsNullOrEmpty(profesor.Username))
                {
                    ErrorMessage = "Numele profesorului trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }
                if(string.IsNullOrEmpty(profesor.Parola))
                {
                    ErrorMessage = "Prenumele profesorului trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }
                else
                {
                    foreach(var item in ListaDeProfesori)
                    {
                        if(item.ProfesorID==profesor.ProfesorID)
                        {
                            item.Username = profesor.Username;
                            item.Parola = profesor.Parola;
                            context.SaveChanges();
                            MessageBox.Show("Datele au fost modificate");
                        }
                    }
                    foreach(var item in profesoriMaterii)
                    {
                        if(item.ProfesorID==profesor.ProfesorID)
                        {
                            item.MaterieID = materie.MaterieID;
                            context.SaveChanges();
                            MessageBox.Show("Datele au fost modificate");
                        }
                    }
                }
            }
        }
        public void updateStudent(object obj,string nouaClasa)
        {
            Student student = obj as Student;
            ListaDeClase = GetClasa();
            Clasa clasa = getClass(nouaClasa);
            if(student!=null)
            {
               
                if(string.IsNullOrEmpty(student.Username))
                {
                    ErrorMessage = "Numele de utilizator al studentului trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }
                if(string.IsNullOrEmpty(student.Parola))
                {
                    ErrorMessage = "Parola studentului trebuie precizata";
                    MessageBox.Show(ErrorMessage);
                }
                else
                {
                    foreach(var item in ListaDeStudenti)
                    {
                        if(item.StudentID==student.StudentID)
                        {
                            item.Username = student.Username;
                            item.Parola = student.Parola;

                            break;
                        }
                    }
                    foreach(var item in ListaDeClase)
                    {
                        if(item.ClasaID==clasa.ClasaID)
                        {
                            student.ClasaElevului =new int?( clasa.ClasaID);
                            student.Clasa = clasa;
                            break;
                        }
                    }
                    context.SaveChanges();
                    MessageBox.Show("Datele au fost modificate");
                }
            }
        }
        public void deleteDiriginte(object obj,string username)
        {
            Diriginte diriginte = obj as Diriginte;
            if(diriginte!=null)
            {
                if(string.IsNullOrEmpty(diriginte.Username))
                {
                    ErrorMessage = "Numele de utilizator al dirigintelui trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }
                else
                {
                    var result=context.StergeDiriginte(username);
                    string mesaj = result.ToString();
                    if (mesaj== "Nu există un diriginte cu username-ul specificat.")
                    {
                        MessageBox.Show(mesaj);
                        ErrorMessage = mesaj;
                    }
                    else
                    {
                        MessageBox.Show(mesaj);
                    }
                }
            }


        }
        public void deleteProfesor(object obj,string usernmae)
        {
            Profesor profesor=obj as Profesor;

            ListaDeProfesori = GetProfesori();
            ListaDeMateriiSiProfesori = GetMateriiProfesori();
            if(profesor!=null)
            {
                foreach(var item in ListaDeProfesori)
                {
                    if(item.Username==usernmae)
                    {for(int i=ListaDeMateriiSiProfesori.Count-1;i>=0;i--)
                        {
                            if (ListaDeMateriiSiProfesori[i].ProfesorID==item.ProfesorID)
                            {
                                context.MateriiProfesoris.Remove(ListaDeMateriiSiProfesori[i]);
                                ListaDeMateriiSiProfesori.RemoveAt(i);
                            }
                        }
                        context.Profesors.Remove(item);
                        context.SaveChanges();
                        MessageBox.Show("Profesorul a fost sters");
                    }
                }
            }
        }
        public void deleteStudent(object obj,string username)
        {
            Student student=obj as Student;
            ListaDeStudenti = GetStudents();
            if(student!=null)
            {
                foreach(var item in ListaDeStudenti)
                {
                    if(item.Username==username)
                    {
                        context.Students.Remove(item);
                        context.SaveChanges();
                        MessageBox.Show("Studentul a fost sters");
                    }
                }
            }
        }
      
      
        public void addStudent(object obj,string clasa)
        {
            Student student=obj as Student;
            ListaDeClase = GetClasa();
            Clasa clasaElevului = getClass(clasa);
            if(student!=null)
            {
                if(string.IsNullOrEmpty(student.Nume))
                {
                    ErrorMessage = "Numele trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }
                if(string.IsNullOrEmpty(student.Prenume))
                {
                    ErrorMessage = "Prenumele trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }
                if(string.IsNullOrEmpty(student.Username))
                {
                    ErrorMessage = "Numele de utilizator trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }
                if(string.IsNullOrEmpty(student.Parola))
                {
                    ErrorMessage = "Parola trebuie precizata";
                    MessageBox.Show(ErrorMessage);

                }
                if(string.IsNullOrEmpty(clasa))
                {
                    ErrorMessage = "Clasa nu a fost precizata";
                    MessageBox.Show(ErrorMessage);
                }
                else
                {
                    ListaDeStudenti = GetStudents();
                    if(ListaDeStudenti.Count==0)
                    {
                        student.StudentID = 0;
                        context.Students.Add(student);
                        context.SaveChanges();
                        ListaDeStudenti.Add(student);
                        clasaElevului.Students.Add(student);
                        MessageBox.Show("Studentul a fost adaugat");
                        ErrorMessage = "";
                    }
                    else
                    {
                        student.StudentID = context.Students.Max(item => item.StudentID)+1;
                        context.Students.Add(student);
                        clasaElevului.Students.Add(student);
                        context.SaveChanges();
                        ListaDeStudenti.Add(student);
                        MessageBox.Show("Studentul a fost adaugat");
                        ErrorMessage = "";
                    }
                }

            }
            

        }
        public void DeleteSpecialization(object obj)
        {
            Specializare specializare = obj as Specializare;

            if (specializare != null)
            {
                if (string.IsNullOrEmpty(specializare.NumeSpecializare))
                {
                    ErrorMessage = "Numele specializarii trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }
                else
                {
                    ListaDeClase = GetClasa();
                    ListaDeSpecSiMat = GetMateriiSpecializari();
                    ListaDeSpecializari = GetSpecializations();
                    int id = findSpec(specializare.NumeSpecializare);

                    for (int i = ListaDeSpecializari.Count - 1; i >= 0; i--)
                    {
                        if (ListaDeSpecializari[i].NumeSpecializare == specializare.NumeSpecializare)
                        {
                            for (int c = ListaDeClase.Count - 1; c >= 0; c--)
                            {
                                if (ListaDeClase[c].SpecializareID == id)
                                {
                                    context.Clasas.Remove(ListaDeClase[c]);
                                    context.SaveChanges();
                                    ListaDeClase.RemoveAt(c);
                                }
                            }
                            for (int m = ListaDeSpecSiMat.Count - 1; m >= 0; m--)
                            {
                                if (ListaDeSpecSiMat[m].SpecializareID == id)
                                {
                                    context.MateriiSpecializaris.Remove(ListaDeSpecSiMat[m]);
                                    context.SaveChanges();
                                    ListaDeSpecSiMat.RemoveAt(m);
                                }
                            }
                            context.Specializares.Remove(ListaDeSpecializari[i]);
                            context.SaveChanges();
                            ListaDeSpecializari.RemoveAt(i);
                            break;

                        }
                    }

                    MessageBox.Show("Specializarea a fost stearsa");
                    ErrorMessage = "";
                }
            }
        }
        public int findSpec(string numeSpec)
        {
            var result = context.Specializares.Where(item => item.NumeSpecializare == numeSpec).FirstOrDefault();
            if (result != null)
            {
                return result.SpecializareID;
            }
            return 0;
        }
        public void updateSpec(object obj1, object obj2)
        {
            Specializare vecheaSpecializare = obj1 as Specializare;
            Specializare nouaSpecializare = obj2 as Specializare;
            if (vecheaSpecializare != null && nouaSpecializare != null)
            {
                if (string.IsNullOrEmpty(vecheaSpecializare.NumeSpecializare) && string.IsNullOrEmpty(nouaSpecializare.NumeSpecializare))
                {
                    ErrorMessage = "Numele specializarii trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }
                else
                {
                    var result = context.Specializares.FirstOrDefault(s => s.SpecializareID == vecheaSpecializare.SpecializareID);
                    if (result != null)
                    {
                        result.NumeSpecializare = nouaSpecializare.NumeSpecializare;
                        context.SaveChanges();
                        ListaDeSpecializari = GetSpecializations();
                        MessageBox.Show("Specializarea a fost modificata");
                        ErrorMessage = "";
                    }
                }
            }


        }
        public string findSpecialization(int? id)
        {
            var result = context.Specializares.Where(item => item.SpecializareID == id).FirstOrDefault();
            if (result != null)
            {
                return result.NumeSpecializare;
            }
            return "";
        }
        public Specializare find(string numeSpec)
        {
            var result = context.Specializares.Where(item => item.NumeSpecializare == numeSpec).FirstOrDefault();
            if (result != null)
            {
                return result;
            }
            return null;
        }
        public void addMaterie(object obj)
        {

            Materie materie = obj as Materie;



            if (materie != null)
            {
                if (string.IsNullOrEmpty(materie.Nume))
                {
                    ErrorMessage = "Numele materiei trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }

                else
                {

                    ListaDeMaterii = GetMaterie();
                    context.Materies.Add(materie);
                    if (ListaDeMaterii.Count == 0)
                    {
                        materie.MaterieID = 0;

                        context.SaveChanges();
                        ListaDeMaterii.Add(materie);
                        MessageBox.Show("Materia a fost adaugata");
                        ErrorMessage = "";
                    }
                    else
                    {
                        materie.MaterieID = context.Materies.Max(item => item.MaterieID) + 1;
                        context.SaveChanges();
                        ListaDeMaterii.Add(materie);
                        MessageBox.Show("Materia a fost adaugata");
                        ErrorMessage = "";
                    }
                }
            }
        }
        public void addMaterieSpecializare(object obj, object obj2)
        {
            MateriiSpecializari materieSpecializare = new MateriiSpecializari();
            Materie materie = obj as Materie;
            Specializare specializare = obj2 as Specializare;

            if (materieSpecializare != null)
            {
                materiiSpecializari = context.MateriiSpecializaris.ToList();
                if (materiiSpecializari.Count == 0)
                {
                    materieSpecializare.MaterieSpecializare = 0;
                    materieSpecializare.SpecializareID = specializare.SpecializareID;
                    materieSpecializare.MaterieID = materie.MaterieID;
                    context.MateriiSpecializaris.Add(materieSpecializare);
                    context.SaveChanges();
                    materiiSpecializari.Add(materieSpecializare);

                }
                else
                {
                    materieSpecializare.MaterieSpecializare = context.MateriiSpecializaris.Max(item => item.MaterieSpecializare) + 1;
                    materieSpecializare.SpecializareID = specializare.SpecializareID;
                    materieSpecializare.MaterieID = materie.MaterieID;
                    context.MateriiSpecializaris.Add(materieSpecializare);
                    context.SaveChanges();
                    materiiSpecializari.Add(materieSpecializare);
                }


            }
        }
        public void updateMaterie(object obj1, object obj2)
        {
            Materie vecheaMaterie = obj1 as Materie;
            Materie nouaMaterie = obj2 as Materie;
            MateriiSpecializari specializari = new MateriiSpecializari();
            specializari = GetMateriiSpecializari(vecheaMaterie.Nume);



            bool doarNumele =true;
            bool doarSpecializarea = false;
            if (vecheaMaterie != null && nouaMaterie != null)
            {
                if (string.IsNullOrEmpty(vecheaMaterie.Nume))
                {
                    ErrorMessage = "Numele materiei trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }
                if (string.IsNullOrEmpty(nouaMaterie.Nume))
                {
                    doarSpecializarea = true;
                }


                if (doarNumele)

                {
                    var result = context.Materies.Where(item => item.Nume == vecheaMaterie.Nume).FirstOrDefault();
                    if (result != null)
                    {
                        result.Nume = nouaMaterie.Nume;
                        specializari.Materie.Nume = nouaMaterie.Nume;
                        context.SaveChanges();
                        ListaDeMaterii = GetMaterie();
                        MessageBox.Show("Materia a fost modificata");
                        ErrorMessage = "";
                    }
                }
               

                if (!doarNumele && !doarSpecializarea)
                {
                    ErrorMessage = "Materia ramane neschimbata";
                    MessageBox.Show(ErrorMessage);

                }
            }
        }
        public void deleteAll()
        {

            var materii = context.Materies.FirstOrDefault();
            if (materii != null)
            {
                context.Materies.Remove(materii);
                context.SaveChanges();


            }
        }
        public void deleteSubject(object obj, object obj2)
        {

            Materie materie = obj as Materie;
            Specializare specializare = obj2 as Specializare;
            if (materie != null)
            {

                ListaDeMaterii = GetMaterie();

                int idS = findSpec(specializare.NumeSpecializare);
                bool one = false;
                int idMS = getMatAndSpec(materie.Nume, specializare.NumeSpecializare);
                ListaDeSpecSiMat = GetMateriiSpecializari();
                if (idMS == -1)
                {
                    System.Windows.MessageBox.Show("Materia nu a fost gasita");
                }
                ListaDeMateriiSiProfesori = GetMateriiProfesori();
                ListaDeDiriginti = GetDiriginte();
                for (int i = ListaDeMaterii.Count - 1; i >= 0; i--)
                {
                    if (ListaDeMaterii[i].Nume == materie.Nume)
                    {
                        for (int m = ListaDeSpecSiMat.Count - 1; m >= 0; m--)
                        {
                            if (ListaDeSpecSiMat[m].MaterieSpecializare == idMS)
                            {
                                context.MateriiSpecializaris.Remove(ListaDeSpecSiMat[m]);
                                context.SaveChanges();
                                ListaDeSpecSiMat.RemoveAt(m);
                                one = true;
                                break;
                            }
                            one = false;
                        }
                        for(int mp=ListaDeMateriiSiProfesori.Count-1; mp>=0; mp--)
                        {
                            if (ListaDeMateriiSiProfesori[mp].MaterieID==idMS)
                            {
                                context.MateriiProfesoris.Remove(ListaDeMateriiSiProfesori[mp]);
                                context.SaveChanges();
                                ListaDeMateriiSiProfesori.RemoveAt(mp);
                                one = true; 
                                break;
                            }
                            one = false;
                        }
                        for(int d=ListaDeDiriginti.Count-1; d>=0; d--)
                        {
                            if (ListaDeDiriginti[d].MateriePredata==idMS)
                            {
                                context.Dirigintes.Remove(ListaDeDiriginti[d]);
                                context.SaveChanges();
                                ListaDeDiriginti.RemoveAt(d);
                                one = true;
                                break;
                            }
                            one = false;
                        }
                        if (one)
                        {
                            context.Materies.Remove(ListaDeMaterii[i]);
                            context.SaveChanges();
                            ListaDeMaterii.RemoveAt(i);
                            System.Windows.MessageBox.Show("Materia a fost stearsa");


                            ErrorMessage = "";
                        }
                    }
                }

            }

        }
        public int getMatAndSpec(string materie, string specializare)
        {
            Materie m = new Materie()
            {
                Nume = materie,
            };
            List<int> materieID = findMaterieID(m);
            int SpecializareId = findSpec(specializare);
            int result = 0;
            for (int i = 0; i < materieID.Count; i++)
            {
                int idMS = materieID[i];
                MateriiSpecializari materieS = context.MateriiSpecializaris
        .FirstOrDefault(ms => ms.MaterieID == idMS && ms.SpecializareID == SpecializareId);

                if (materieS != null)
                {
                    result = materieS.MaterieSpecializare;
                }

            }
            return result;
        }
        public List<int> findMaterieID(object obj)
        {
            Materie materie = obj as Materie;
            List<int> list = new List<int>();
            if (materie != null)
            {
                if (string.IsNullOrEmpty(materie.Nume))
                {
                    ErrorMessage = "Numele materiei trebuie precizat";
                    MessageBox.Show(ErrorMessage);
                }
                else
                {
                    ListaDeMaterii = GetMaterie();
                    for (int i = ListaDeMaterii.Count - 1; i >= 0; i--)
                    {
                        if (ListaDeMaterii[i].Nume == materie.Nume)
                        {
                            list.Add(ListaDeMaterii[i].MaterieID);
                        }
                    }
                }
            }
            return list;
        }
        public string findMaterieByID(int id)
        {
            List<Materie> list = context.Materies.ToList();
            Materie materie = list.Where(item => item.MaterieID == id).FirstOrDefault();
            return materie.Nume;
        }
        

        public ObservableCollection<string> getNameOfSubjectAndSpec()
        {
            List<MateriiSpecializari> materii = context.MateriiSpecializaris.ToList();
            ObservableCollection<string> result = new ObservableCollection<string>();
            foreach (MateriiSpecializari m in materii)
            {
                string materiiSpecializare = findMaterieByID((int)m.MaterieID);
            
                result.Add(materiiSpecializare);
            }
            return result;
        }
        public ObservableCollection<string>getNameofSub()
        {
            List<Materie> materii = context.Materies.ToList();
            ObservableCollection<string>result=new ObservableCollection<string>();
            foreach(Materie m in materii)
            {
                result.Add(m.Nume);
            }
            return result;
        }
        public ObservableCollection<string> getSpecializationSubject(string subject)
        {
            materiiSpecializari = context.MateriiSpecializaris.ToList();
            List<Materie> materii = context.Materies.ToList();
            ObservableCollection<string> res = new ObservableCollection<string>();
            for (int ms = materiiSpecializari.Count - 1; ms >= 0; ms--)
            {
                if (materiiSpecializari[ms].Specializare.NumeSpecializare == subject)
                {
                    if (materiiSpecializari[ms].Materie.Nume != null)
                    {
                        res.Add(materiiSpecializari[ms].Materie.Nume);
                    }
                }
            }
            return res;
        }
        public ObservableCollection<Specializare> GetSpecializations()
        {
            List<Specializare> specializares = context.Specializares.ToList();
            ObservableCollection<Specializare> result = new ObservableCollection<Specializare>();
            foreach (Specializare specializare in specializares)
            {
                result.Add(specializare);
            }
            return result;
        }
        public ObservableCollection<string> NameSpecializations()
        {
            List<Specializare> specializares = context.Specializares.ToList();
            ObservableCollection<string> result = new ObservableCollection<string>();
            foreach (Specializare specializare in specializares)
            {
                result.Add(specializare.NumeSpecializare);
            }
            return result;
        }
        public ObservableCollection<Admin> GetAdmins()
        {
            List<Admin> admins = context.Admins.ToList();
            ObservableCollection<Admin> result = new ObservableCollection<Admin>();
            foreach (Admin admin in admins)
            {
                result.Add(admin);
            }
            return result;
        }
        public ObservableCollection<Clasa> GetClasa()
        {
            List<Clasa> clase = context.Clasas.ToList();
            ObservableCollection<Clasa> result = new ObservableCollection<Clasa>();
            foreach (Clasa clasa in clase)
            {
                result.Add(clasa);
            }
            return result;
        }
        public ObservableCollection<Materie> GetMaterie()
        {
            List<Materie> materies = context.Materies.ToList();
            ObservableCollection<Materie> result = new ObservableCollection<Materie>();
            foreach (Materie materie in materies)
            {
                result.Add(materie);
            }
            return result;
        }
        public ObservableCollection<MateriiSpecializari> GetMateriiSpecializari()
        {
            List<MateriiSpecializari> materiiSpecializaris = context.MateriiSpecializaris.ToList();
            ObservableCollection<MateriiSpecializari> result = new ObservableCollection<MateriiSpecializari>();
            foreach (MateriiSpecializari materiiSpecializari in materiiSpecializaris)
            {
                result.Add(materiiSpecializari);
            }
            return result;
        }
        public ObservableCollection<MateriiProfesori> GetMateriiProfesori()
        {
            List<MateriiProfesori> materiiProfesoris = context.MateriiProfesoris.ToList();
            ObservableCollection<MateriiProfesori> result = new ObservableCollection<MateriiProfesori>();
            foreach (MateriiProfesori materiiProfesori in materiiProfesoris)
            {
                result.Add(materiiProfesori);
            }
            return result;
        }
        public ObservableCollection<Diriginte> GetDiriginte()
        {
            List<Diriginte> dirigintes = context.Dirigintes.ToList();
            ObservableCollection<Diriginte> result = new ObservableCollection<Diriginte>();
            foreach (Diriginte diriginte in dirigintes)
            {
                result.Add(diriginte);
            }
            return result;
        }
        public ObservableCollection<Profesor>GetProfesori()
        {
            List<Profesor> profesors = context.Profesors.ToList();
            ObservableCollection<Profesor> result = new ObservableCollection<Profesor>();
            foreach(Profesor profesor in profesors)
            {
                result.Add(profesor);
            }
            return result;
        }
        public ObservableCollection<Student> GetStudents()
        {
            List<Student>students= context.Students.ToList();
            ObservableCollection<Student>result= new ObservableCollection<Student>();
            foreach(Student student in students)
            {
                result.Add(student);
            }
            return result;
        }
        public ObservableCollection<string> ClassName()
        {
            List<Clasa> clase = context.Clasas.ToList();
            ObservableCollection<string> classes = new ObservableCollection<string>();
            foreach (Clasa clasa in clase)
            {
                classes.Add(clasa.Nume);
            }
            return classes;

        }
        public ObservableCollection<string>NumeleDirigintilor()
        {
            List<Diriginte>diriginti=context.Dirigintes.ToList();
            ObservableCollection<string>result=new ObservableCollection<string>();
            foreach(Diriginte diriginte in diriginti)
            {
                result.Add(diriginte.Nume);
            }
            return result;
        }
        public ObservableCollection<string>PrenumeleDirigintilor()
        {
     
            List<Diriginte>diriginti=context.Dirigintes.ToList();
            ObservableCollection<string>result=new ObservableCollection<string>();
            foreach(Diriginte diriginte in diriginti)
            {
                result.Add(diriginte.PRENUME);
            }
            return result;
        }
        public Clasa getClassas(string className)
        {

            var result = context.Clasas.Where(item => item.Nume == className).FirstOrDefault();
            if (result != null)
            {
                return result;
            }
            return null;
        }
        public ObservableCollection<string>getProfesorUsername()
        {
            List<Profesor> profesors = context.Profesors.ToList();
            ObservableCollection<string> result = new ObservableCollection<string>();
            foreach(Profesor p in profesors)
            {
                result.Add(p.Username);
            }
            return result;
        }
        public ObservableCollection<string>getStudentUsername()
        {
            List<Student>student=context.Students.ToList();
            ObservableCollection<string> result = new ObservableCollection<string>();
            foreach(Student s in student)
            {
                result.Add(s.Username);
            }
            return result;
        }
        public ObservableCollection<string>getDiriginteUsername()
        {
            List<Diriginte>diriginti=context.Dirigintes.ToList();
            ObservableCollection<string> result = new ObservableCollection<string>();
            foreach(Diriginte d in diriginti)
            {
                result.Add(d.Username);
            }
            return result;
        }

    }
}