   M S B A M L   `   `   `  ����C  ?Intranet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Intranet.ViewModels.CRUDDiriginte!Intranet.ViewModels.CRUDDiriginte  5   	   6    0Intranet.Views.CRUDDirigintePage.UpdateDiriginte   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:Intranet.ViewModels.CRUDDiriginte     5   	     � Title$  UpdateDiriginte��5   	   $	��450��6!   $	��800��6.    � DataContext 5	      ;   5Intranet.ViewModels.CRUDDiriginte.UpdateDiriginteView  5
   
   6&   .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $+��%Introduceti numele dirigintelui vechi��6   $��Center=�6@   $��Center=�6[   �� 5   
   $��0��6   $	��300��6    $��40��6,   $��Bottom=�68   $��20(�6�   $��Garamond)�6�   ��6S   �� *	vechiul+ �� SelectedItem 6s   �� *numeDiriginteVechi+6�   �� 5   
   $)��#Introduceti numele noului diriginte��6   $��0��6>   $��1��6K   $��Center=�6[   $��Center=�6v   �� 5   
   $/��)Introduceti prenumele vechiului diriginte��6   $��1��6D   $��0��6Q   $��Center=�6a   $��Center=�6|   �� 5   
   $,��&Introduceti prenumele noului diriginte��6   $��1��6A   $��1��6N   $��Center=�6^   $��Center=�6y   �� 5   
   $��1��6   $��1��6    $	��300��60   $��40��6<   $��Bottom=�6H   $��Garamond)�6�   $��20(�6�   ��6c   �� *NoulP+ 6�   �� *prenumeDiriginteNou+6�   �� 5   
   $��1��6   $��0��6    $	��300��60   $��40��6<   $��Bottom=�6H   $��Garamond)�6�   $��20(�6�   ��6c   �� *VechiP+ 6�   �� *prenumeDiriginteVechi+6�   �� 5   
   $��0��6   $��1��6    $	��300��60   $��40��6<   $��Bottom=�6H   $��20(�6�   $��Garamond)�6�   ��6c   �� *noul+ 6�   �� *numeDiriginteNou+6�   �� 5   
   $��2��6   $	��300��6   $��40��6*   $��Bottom=�6Q   $
��Left=�6l   $��Actualizeaza materia��6�   $��20(�6�   $��Garamond)�6�   ��66   �� *update+6�   �� 5    
   $��2��6   $��1��6   $	��300��6.   $��40��6:   $��Bottom=�6F   $��Right=�6a   $��Anuleaza��6}   $��20(�6�   $��Garamond)�6�   5!      5"      