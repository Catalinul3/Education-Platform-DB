   M S B A M L   `   `   `  ����C  ?Intranet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Intranet.ViewModels.CRUDProfesor Intranet.ViewModels.CRUDProfesor  5   	   4    .Intranet.Views.CRUDProfesorPage.UpdateProfesor   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:Intranet.ViewModels.CRUDProfesor     5   	     � Title$  UpdateProfesor��5   	   $	��450��6    $	��800��6-    � DataContext 5	      9   3Intranet.ViewModels.CRUDProfesor.UpdateProfesorView  5
   
   6%   .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��Numele de utilizator:��6   $��0��60   $��Center=�6@   $��Center=�6[   �� 5   
   $��0��6   $	��300��6$   $��40��60   $��Bottom=�6<   $��20(�6�   $��Garamond)�6�   ��6W   �� *
Profiles+ �� SelectedItem 6x   �� *oldUsername+6�   �� 5   
   $��Numele nou de utilizator:��6   $��0��64   $��1��6A   $��Center=�6Q   $��Center=�6l   �� 5   
   $��1��6   $	��300��6"   $��40��6.   $��Bottom=�6:   ��6U   �� *newUsername+�� 5   
   $��Noua parola:��6   $��1��6'   $��0��64   $��2��6D   $��Center=�6X   $��Center=�6s   �� 5   
   $��1��6   $��0��6   $��2��6/   $	��300��6C   $��40��6O   $��Bottom=�6[   $��20(�6�   $��Garamond)�6�   ��6v   �� *newPassword+6�   �� 5   
   $��Noua materie:��6   $��2��6(   $��0��65   $��2��6E   $��Center=�6Y   $��Center=�6v   �� 5   
   $��2��6   $��0��6    $��2��60   $	��300��6D   $��40��6P   $��Bottom=�6\   $��Center=�6w   ��6�   �� *
subjects+ 6�   �� *
newSubject+�� 5    
   $��3��6   $	��300��6   $��40��6*   $��Bottom=�6Q   $
��Left=�6l   $��Actualizeaza profesorul��6�   $��20(�6�   $��Garamond)�6�   ��66   �� *Update+6�   �� 5!   
   $��3��6   $��1��6   $	��300��6.   $��40��6:   $��Bottom=�6F   $��Right=�6a   $��Anuleaza��6}   $��20(�6�   $��Garamond)�6�   5"      5#      