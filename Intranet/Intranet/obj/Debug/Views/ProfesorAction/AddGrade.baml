   M S B A M L   `   `   `  ����C  ?Intranet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Intranet.ViewModels.ProfessorActionView'Intranet.ViewModels.ProfessorActionView  5   	   ,    &Intranet.Views.ProfesorAction.AddGrade   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:Intranet.ViewModels.ProfessorActionView     5   	     � Title$  AddGrade��5   	   $	��450��6   $	��800��6'    � DataContext 5	      ;   5Intranet.ViewModels.ProfessorActionView.AddGradesView  5
   
   6    .��5      �  � ShowGridLines .  � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��0��6   $��Student Name��6   $	��Top=�64   $��Center=�6S   6y   �� 5   
   $��0��6   $��40��6    $��Bottom=�6j   $��Bottom=�6�   $��Center=�6�   $	��400��6�   ��6,   �� *	Catalog+ �� SelectedItem 6L   �� *Nume+6�   �� 5   
   $��1��6   $��Student first name��6   $	��Top=�6:   $��Center=�6Y   �� 5   
   $��1��6   $��40��6    $	��400��6u   $��Bottom=�6�   ��6,   �� *	Prenume+ 6L   �� *SelectedPrenume+6�   �� 5   
   $��2��6   $��Grade��6   $	��Top=�6-   $��Center=�6L   �� 5   
   $��2��6   $��40��6    $	��400��6r   $��Bottom=�6~   ��6,   �� *Grades+ 6K   �� *SelectedGrade+6~   �� 5   
   $��3��6   $��Course��6   $	��Top=�6.   $��Center=�6M   �� 5   
   $��3��6   $��40��6    $	��400��6u   $��Bottom=�6�   ��6,   �� *	Materii+ 6L   �� *selectedMaterii+6�   �� 5   
   $��4��6   $��Semester��6   $	��Top=�60   $��Center=�6O   �� 5   
   $��4��6   $��40��6    $	��400��6r   $��Bottom=�6~   ��6,   �� *
Semestre+ 6M   �� *SelectedSem+6~   �� 5   
   $��5��6   $��	Add Grade��6   $	��100��6J   $��40��6V   $��Bottom=�6b   $��Center=�6}   ��62   �� *Add+6}   5       5!      