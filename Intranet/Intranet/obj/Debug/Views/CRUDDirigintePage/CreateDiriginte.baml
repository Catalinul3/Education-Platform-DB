   M S B A M L   `   `   `  ����C  ?Intranet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Intranet.ViewModels.CRUDDiriginte!Intranet.ViewModels.CRUDDiriginte  5   	   6    0Intranet.Views.CRUDDirigintePage.CreateDiriginte   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:Intranet.ViewModels.CRUDDiriginte     5   	     � Title$  CreateDiriginte��5   	   $	��450��6!   $	��800��6.    � DataContext 5	      ;   5Intranet.ViewModels.CRUDDiriginte.CreateDiriginteView  5
   
   6&   .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $
��Nume��6   $��0��6   $��Center=�6,   �� 5   
   $��0��6(   $��Center=�65   $��Bottom=�6R   $��20��6m   $	��100��6y   ��6   �� *nume+6y   �� 5   
   $��Prenume��6   $��Center=�6"   $��1��6?   �� 5   
   $��Center=�6+   $��Bottom=�6H   $��1��6c   $��20��6p   $	��100��6|   ��6   �� *	prenume+6|   �� 5   
   $��Username��6   $��Center=�6#   $��2��6@   �� 5   
   $��Center=�6,   $��Bottom=�6I   $��2��6d   $��20��6q   $	��100��6}   ��6   �� *
username+6}   �� 5   
   $��Password��6   $��Center=�6#   $��3��6@   �� 5   
   $��Center=�6,   $��Bottom=�6I   $��3��6d   $��20��6q   $	��100��6}   ��6   �� *
password+6}   �� 5   
   $��Materie��6   $��Center=�6"   $��4��6?   �� 5    
   $��Center=�6T   $��Bottom=�6q   $��4��6�   $��20��6�   $	��100��6�   ��6   �� *	Materii+ �� SelectedItem 63   �� *	materie+6�   �� 5!   
   $��Clasa��6   $��Center=�6    $��5��6=   �� 5"   
   $��Center=�6P   $��Bottom=�6m   $��5��6�   $��20��6�   $	��100��6�   ��6   �� *Clase+ 61   �� *clasa+6�   �� 5#   
   $��Create��6   $��7��6=   $
��Left=�6J   $��Bottom=�6e   $��50��6�   $	��300��6�   ��6"   �� *Create+6�   �� 5$   
   $��Cancel��6   $��7��6"   $��Right=�6/   $��Bottom=�6K   $��50��6f   $	��300��6r   5%      5&      