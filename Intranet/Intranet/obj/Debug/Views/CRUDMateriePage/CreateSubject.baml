   M S B A M L   `   `   `  ����C  ?Intranet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Intranet.ViewModels.CRUDMaterieIntranet.ViewModels.CRUDMaterie  5   	   2    ,Intranet.Views.CRUDMateriePage.CreateSubject   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:Intranet.ViewModels.CRUDMaterie     5   	     � Title$  CreateSubject��5   	   $	��450��6   $	��800��6,    � DataContext 5	      7   1Intranet.ViewModels.CRUDMaterie.CreateMaterieView  5
   
   6$   .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5      �� $(��"Introduceti specializarea materiei��6   $��Center=�6A   $��Center=�6\   �� 5   
   $��0��6   $	��300��6    $��40��6,   $��Bottom=�68   $��20(�6�   $��Garamond)�6�   ��6S   �� *numeSpecializari+ �� SelectedItem 6|   �� *selectedSpecializare+ �� Mode$ TwoWay=�6�   �� 5   
   $$��Introduceti denumirea materiei��6   $��1��69   $��Center=�6F   $��Center=�6a   �� 5   
   $��1��6   $	��300��6   $��40��6+   $��Bottom=�67    �� TextAlignment$ Center=�6R   $��20(�6�   $��Garamond)�6�   ��6i   �� *
Denumire+6�   �� 5   
   $
��Teza��6   $��2��6   $��Center=�6,   $��Center=�6I   $��Garamond)�6d   $��20(�6z   �� 5   
   $��2��6   $��Center=�6    $��Garamond)�6;   $��Right=�6Q   $��20(�6m   $��	1,0,360,0q�6|    d� 	IsChecked 6�   �� *Teza+�� 5   
   $��3��6   $	��300��6   $��40��6*   $��Center=�6X   $
��Left=�6s   $��Adauga materia��6�   $��20(�6�   $��Garamond)�6�   ��66   �� *AdaugaMaterie+6�   �� 5   
   $��3��6   $	��300��6   $��40��6*   $��Center=�66   $��Right=�6Q   $��Anuleaza��6m   $��20(�6�   $��Garamond)�6�   5      5      