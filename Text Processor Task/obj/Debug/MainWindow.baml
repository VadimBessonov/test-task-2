   M S B A M L   `   `   `  ����N  JText Processor Task, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Text_Processor_TaskText_Processor_Task  5   	   $    Text_Processor_Task.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Text_Processor_Task     5   	     � Title$  Text Processor��5   	   $	��450��6    $	��800��6-   $	��300��69   $	��600��6I    � 	Resources 5
         ButtonTemplate �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value �� Property �� Value��%�   &	        �� 5   
   " ��61   .R�5      �� $ 15��6   #��z��6'   ._�5      �� #��z��6#   #��z��6f   5       5      P� 5       �@J�IsMouseOver . . �5      ��  � �� �#28c20663   5      5      5      .��5      � .+�5   
   �� -   5        $��InputFilePathes��5      $��30,25,277,130q�6)   	 �� TextWrapping$
	 Wrap=�6@   $/��)Путь до входных файлов��6T   �� 5   
   -   5        $!��Выбрать файл(ы)��5   $   $��
0,175,14,0q�6>   $	��Top=�6R   $��26��6j   #��[  6v   $��Right=�6�   $	��170��6�   �� 5   
   -   5        $��MinCharsInWord��5      $��24��6(   $��	0,50,14,0q�64   $
	 Wrap=�6G   $��1��6[   $	��Top=�6d   $��14(�6�   
 �� TextAlignment$
 Right=�6�   $��Right=�6�   $	��220��6�   �� 5   
   $��17��6   $��	0,25,14,0q�6    $
��Wrap=�63   $H��BМинимальное количество букв в слове��6G   $	��Top=�6r    �� TextAlignment$ Right=�6�   $��Right=�6�   $	��220��6�   �� 5   
   $��56��6   $E��?Нужно ли убирать знаки препинания?��6   $��
0,100,14,0q�6K   $	��Top=�6_   $��Right=�6w   $	��233��6�   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5       	� -   5        $��IsNeedPunctuation��5       $
��Да��67   $
��Left=�6D   $	��Top=�6_   $��
10,10,60,0q�6w   	� 5!       d� 	IsChecked$
 TrueY�6   $��Нет��6/   $
��Left=�6=   $	��Top=�6X   $��
60,10,10,0q�6p   5"      5#      �� 5$   
   -   5        $'��!Обработать файл(ы)��5$   '   $��
0,217,14,0q�6D   $	��Top=�6X   $��26��6p   #��[  6|   $��Right=�6�   $	��170��6�   �� 5%   
   -   5        $��OutputPathes��5%      $��87��6&   $��30,0,277,25q�62   $
	 Wrap=�6G   $����Путь до выходных файлов. Если оставить пустым или путь будет неверен, то выходной файл будет лежать рядом с входным.��6[   $��Bottom=�6�   5'      5(      