   M S B A M L   `   `   `  ����Q  MCorbelliSaviniLinq-WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:CorbelliSaviniLinq_WPFCorbelliSaviniLinq_WPF  5   	   '    !CorbelliSaviniLinq_WPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:CorbelliSaviniLinq_WPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ 	btn_Cerca��5
      $��Cerca��6$   $
��Left=�64   $��
213,43,0,0q�6O   $	��Top=�6c   $��75��6{   6�   �� 5   
   -   5         ��Name$ 
lst_Output��5      $
��Left=�6&   $	��285��6A   $��
616,25,0,0q�6N   $	��Top=�6b   $	��166��6z   6�   �� 5   
   -   5         ��Name$ 
txt_Autore��5      $
��Left=�6&   $��23��6A   $��	45,43,0,0q�6M    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5   
   -   5         ��Name$ 
lbl_Autore��5      $��Autore��6$   $
��Left=�65   $��	45,12,0,0q�6P   $	��Top=�6c   $	��120��6{   �� 5   
   -   5        $ 	txt_Testo��5      $
��Left=�6%   $��23��6@   $��
45,135,0,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5   
   -   5        $ 
lbl_Titolo��5      $��Titolo��6$   $
��Left=�65   $��
45,104,0,0q�6P   $	��Top=�6d   $	��120��6|   �� 5   
   -   5        $ 	btn_Conta��5      $��Conta��6$   $
��Left=�64   $��213,135,0,0q�6O   $	��Top=�6d   $��75��6|   6�   �� 5   
   -   5        $ 
lbl_titolo��5      $�� ��6$   $
��Left=�6/   $��
45,163,0,0q�6J   $	��Top=�6^   $	��120��6v   �� 5   
   -	   5        $ btn_Romanzo��5      $��Conta Romanzi��6&   $
��Left=�6>   $��
394,43,0,0q�6Y   $	��Top=�6m   $	��101��6�   $��43��6�   6�   �� 5   
   -
   5        $ btn_Abstract��5      $��ELIMINA ABSTRACT��6'   $
��Left=�6B   $��394,148,0,0q�6]   $	��Top=�6r   $	��129��6�   $��77��6�   6�   �� 5   
   -   5        $ btn_NewFile��5      $��Crea Nuovo File��6&   $
��Left=�6@   $��394,268,0,0q�6[   $	��Top=�6p   $	��129��6�   $��61��6�   6�   �� 5   
   -   5        $ txt_newGenere��5      $
��Left=�6)   $��23��6D   $��
45,362,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5   
   -   5        $ txt_searchTitolo��5      $
��Left=�6,   $��23��6G   $��
45,306,0,0q�6S   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5   
   $��Titolo��6   $
��Left=�6!   $��
45,275,0,0q�6<   $	��Top=�6P   $	��120��6h   �� 5   
   $��Genere��6   $
��Left=�6!   $��
45,334,0,0q�6<   $	��Top=�6P   $	��120��6h   �� 5   
   -   5        $ btn_Sostituisci��5      $��Cerca e Sostituisci��6*   $
��Left=�6H   $��194,319,0,0q�6c   $	��Top=�6x   $	��107��6�   $��41��6�   6�   5      5      