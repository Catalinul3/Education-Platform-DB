   M S B A M L   `   `   `  ����C  ?Intranet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Intranet.ViewModels.CRUDStudentIntranet.ViewModels.CRUDStudent  5   	   2    ,Intranet.Views.CRUDStudentPage.DeleteStudent   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:Intranet.ViewModels.CRUDStudent     5   	     � Title$  DeleteStudent��5   	   $	��450��6   $	��800��6,    � DataContext 5	      7   1Intranet.ViewModels.CRUDStudent.DeleteStudentView  5
   
   6$   .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� $��0��6   $��2��6   $��Center=�61   $&�� Introduceti numele de utilizator��6L   $��Center=�6w   �� 5   
   $��2��6   $��0��6$   $��2��61   $��Center=�6�   $��Center=�6�   $	��300��6�   ��6E   �� *
Profiles+ �� SelectedItem 6f   �� *
Username+6�   �� 5   
   $��Sterge studentul��6   $��1��6G   $	��200��6T   $��70��6`   $
��Left=�6l   ��6,   �� *Delete+6l   �� 5   
   $��Anuleaza��6   $��1��6%   $��1��62   $	��200��6B   $��70��6N   $��Right=�6Z   5      5      