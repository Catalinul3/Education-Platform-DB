   M S B A M L   `   `   `  ����C  ?Intranet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Intranet.ViewModels.CRUDMaterieIntranet.ViewModels.CRUDMaterie  5   	   2    ,Intranet.Views.CRUDMateriePage.UpdateSubject   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:Intranet.ViewModels.CRUDMaterie     5   	     � Title$  UpdateSubject��5   	   $	��450��6   $	��800��6,    � DataContext 5	      7   1Intranet.ViewModels.CRUDMaterie.UpdateMaterieView  5
   
   6$   .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $$��Introduceti denumirea materiei��6   $��Center=�69   $��Center=�6T   �� 5   
   $��0��6   $	��300��6   $��40��6+   $��Bottom=�67    �� TextAlignment$ Center=�6R   $��20(�6�   $��Garamond)�6�   ��6i   �� *vecheaMaterie+6�   �� 5   
   $*��$Introduceti noua denumire a materiei��6   $��0��6?   $��1��6L   $��Center=�6\   $��Center=�6w   �� 5   
   $&�� Introduceti numele specializarii��6   $��1��6;   $��0��6H   $��Center=�6X   $��Center=�6s   �� 5   
   $+��%Introduceti numele noii specializarii��6   $��1��6@   $��1��6M   $��Center=�6]   $��Center=�6x   �� 5   
   $��1��6   $��1��6   $	��300��6/   $��40��6;   $��Bottom=�6G   $ Center=�6�   $��Garamond)�6�   $��20(�6�   ��6b   �� *specializareNoua+6�   �� 5   
   $��1��6   $��0��6   $	��300��6/   $��40��6;   $��Bottom=�6G   $ Center=�6�   $��Garamond)�6�   $��20(�6�   ��6b   �� *specializareVeche+6�   �� 5   
   $��0��6   $��1��6   $	��300��6/   $��40��6;   $��Bottom=�6G   $ Center=�6   $��20(�6�   $��Garamond)�6�   ��6b   �� *nouaMaterie+6�   �� 5   
   $��2��6   $	��300��6   $��40��6*   $��Bottom=�6_   $
��Left=�6z   $��Actualizeaza materia��6�   $��20(�6�   $��Garamond)�6�   ��66   �� *actualizareaMateriei+6�   �� 5    
   $��2��6   $��1��6   $	��300��6.   $��40��6:   $��Bottom=�6F   $��Right=�6a   $��Anuleaza��6}   $��20(�6�   $��Garamond)�6�   5!      5"      