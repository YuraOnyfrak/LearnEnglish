   M S B A M L   `   `   `  ����Z  VEnglishStudy.Common.UserControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:EnglishStudy.Common.UserControl.UserControl+EnglishStudy.Common.UserControl.UserControl  5      6    0EnglishStudy.Common.UserControl.UserControl.Test   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Klocal9clr-namespace:EnglishStudy.Common.UserControl.UserControl     5        � 	Resources  5	       �� 
TargetType �� Property �� Value �� Triggers ]� 
Conditions �� Property �� Value��%7  '��       �� 5
   
   " ��6   �5      �� 5       � ��$ Center=�6?   �� 5       � ��$ 5q�6,   �� 5       � ��$ 20(�6-    5      ]� 5       5      �� 5       �@J�IsMouseOver . 6;   /�5      �� 5       � ��$ 24(�65   5      5      5      .��5      � .+�5   
   ]� ��. .+�5      � $	��Top=�6   $��15q�6)   .+�5       �� $
��Left=�6    �� Orientation$ 
Horizontal=�69   .+�5!      �� 6   �� 5"      $��14(�6   .��6+   Вивчаємо слова6;   5#      �� 5$      $��Right=�6   $ 
Horizontal=�6:   .+�5%      �� $��14(�6    .��6.   Автовимова6:   5&      5'      �� 5(      
����  �$��2q�6,   $��Center=�6@   $��Center=�6]   ._�5)      ]� ��. $	��500��61   $	��500��6@   .+�5*      � $��Bottom=�6   
�������.+�5+      �� $ 
Horizontal=�6%   $
��Left=�6>   .+�5,      �� $��10q�6$   62   �� 5-      $��10q�6$   $��14(�60   .��6>   	cbbjbgh6G   5.      �� 5/      $��Right=�6!   $��5q�6=   $��10q�6I   $��Вивчити��6U   $��14(�6g   6w   50      � 51      .+�53      ]� ��. .+�54      � $
��Left=�6#   .+�5?   "   �� $��Center=�6-   .+�5@   &   �� $ 
Horizontal=�61   .+�5A   *   �� $	��200��62   $��10q�6A   ��6N   �� 	 �� Path$	 EnglishWord�
 �� UpdateSourceTrigger$
 PropertyChanged=�6�   5B   '   �� 5C   &   $ 
Horizontal=�61   .+�5D   *   �� $��10q�60   6?   �� 5E   *   $	��200��62   $��10q�6A   ��6M   �� $	 Transcription�$
 PropertyChanged=�6�   5F   '   �� 5G   &   $��Bottom=�6-   $��10q�6H   $	��280��6T   $	��250��6a   ��6m   �� $	 ResoursePhoto�$
 PropertyChanged=�6�   5I   #   5J      � 5K      $��Right=�6$   .+�5L   "   �� $��Center=�6-   .+�5M   &   �� $ 
Horizontal=�61   .+�5N   *   �� -   5         ��Name$ version2��5N   3   $	��200��6E   $��10q�6T   ��6a   �� $	 
VersionOne�$
 PropertyChanged=���6�   �� *
BrushObj+.��6�    J� InputBindings 5O   .   d� 5P   2    d� MouseAction$ 	LeftClicke�6h    �� Command 6?   �� *YourShooseVersionOne+6�   .��5Q   E   5R   +   �� 5S   *   $��1��60   $��10q�6<   6K   5T   '   �� 5U   &   $ 
Horizontal=�61   .+�5V   *   �� -   5        $ version3��5V   3   $	��200��6E   $��10q�6T   ��6a   �� $	 
VersionTwo�$
 PropertyChanged=�.��6�    5W   .   d� 5X   2   $ 	LeftClicke�6h    6?   �� *YourShooseVersionTwo+6�   .��5Y   E   5Z   +   �� 5[   *   $��2��60   $��10q�6<   6K   5\   '   �� 5]   &   $ 
Horizontal=�61   .+�5^   *   �� $	��200��62   $��10q�6A   ��6N   �� $	 VersionThree�$
 PropertyChanged=�.��6�    5_   .   d� 5`   2   $ 	LeftClicke�6j    6?   �� *YourShooseVersionThree+6�   .��5a   E   5b   +   �� 5c   *   $��3��60   $��10q�6<   6K   5d   '   �� 5e   &   $ 
Horizontal=�61   .+�5f   *   �� $	��200��62   $��10q�6A   ��6N   �� $	 VersionFour�$
 PropertyChanged=�.��6�    5g   .   d� 5h   2   $ 	LeftClicke�6i    6?   �� *YourShooseVersionFour+6�   .��5i   E   5j   +   �� 5k   *   $��4��60   $��10q�6<   6K   5l   '   �� 5m   &   $ 
Horizontal=�61   .+�5n   *   �� $	��200��62   $��10q�6A   ��6N   �� $	 VersionFive�$
 PropertyChanged=�.��6�    5o   .   d� 5p   2   $ 	LeftClicke�6i    6?   �� *YourShooseVersionFive+6�   .��5q   E   5r   +   �� 5s   *   $��5��60   $��10q�6<   6K   5t   '   �� 5u   &   $ 
Horizontal=�61   .+�5v   *   �� $	��200��62   $��10q�6A   ��6N   �� $	 
VersionSix�$
 PropertyChanged=�.��6�    5w   .   d� 5x   2   $ 	LeftClicke�6h    6?   �� *YourShooseVersionSix+6�   .��5y   E   5z   +   �� 5{   *   $��6��60   $��10q�6<   6K   5|   '   �� 5}   &   $ 
Horizontal=�61   $��Right=�6J   $��20q�6f   .+�5~   *   �� $��next frgfrgbgfgb��61   $��10q�6L   $��5q�6X   ��6d   �� *Next+6   �� 5   *   $��Enter��60   $��10q�6@   6O   5�   '   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      