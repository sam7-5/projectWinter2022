   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLPL  5   	       PL.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:PL     5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6(     � Title$  
MainWindow��5   	   $	��382��6   $	��294��6)    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�5
      .��5      � $��0,0,0,-6q�6   ��5   
   �� 5       �� ImageSource$ MVVM/view/font.jpg��6    �� Opacity$	 0.8Q�6:   .+�5   
   �� $��0��5      $��0��5      ���	#FF0E0C56$��25��5      $	��Top=�5      ._�5      �� -   5         ��Name$ MainTimerTextBlock��5      $��20(�5      $��0,0,80,0q�5      
�������$��Right=�5      $��Center=�5      5!      �� 5$   
   -   5        $
��Exit��5&      $��0��5%      $��36��5'      $��25��5(      $��Right=�5)      $	��Top=�5*      ���#E81123
������ ._�51      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�52      $��Center=�53      $��Center=�54      
�������$��26��56      $��34��57      5:      &   MaterialDesignThemes.Wpf.Flipper  5<   
      MaterialDesignCardFlipper#��[  5=      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5>      $��Center=�6A   $��0,17,0,0q�6^   $	��294��6q      FrontContent 5?      � 5@      $	��256��5A      $	��200��5B      	 � RowDefinitions	 5C      �� 5D      $	��160 �6(   �� 5E      $��* �6(   .+�5G      (  "MaterialDesignThemes.Wpf.ColorZone  
   Mode$
 PrimaryLight=�5H   	   $��Stretch=�5I   	   ���	#FF0E0C56.��5J        $ AccountCircle=�5K      $	��128��5L      $	��128��5M      $��Center=�5N      $��Center=�5O      
�������6)   5P      �� 5Q      $��1��5R   	   $��Center=�5S   	   $��Center=�5T   	   .+�5U      �� $��Administrator��6$   ���	#FFF9F4F4$��20(�6P   �� 5V         MaterialDesignOutlinedButton#��[ 5W         FlipCommand#��Z 5X      $��0 4 0 0q�5Y      ���	#FF0E0C56$��Enter��5[      ���	#FF0E0C566   5\      5]         BackContent 5_      � 5`      $	��256��6   $	��200��6$   	 5b      �� 5c      $
��Auto �6(   �� 5d      $��* �6(   .+�5g        $
 SecondaryMid=�5h   	   $��6q�5i   	   ���	#FF0E0C56.��5j      ��  �� Orientation$ 
Horizontal=�6%   .+�5k      ��  & "MaterialDesignToolForegroundButton#��[ 5l      #��Z 5m      $
��Left=�5n      .��5o   "     $ 	ArrowLeft=�5p      $��Right=�5q      5r      �� 5t      $��8 0 0 0q�5u      $��Center=�5v      $��Administrator��5w      $��16(�6"   5x      5y      � 5{      $��1��5|   	   $��0 6 0 0q�5}   	   $��Center=�5~   	   $	��Top=�5   	   $	��172��5�   	   	 5�      �� 5�      �� 5�      �� 5�      �� 5�      .+�5�      �� -   5         ��Name$ pseudoTxtBox��5�   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 name��5�         
IsFloating . $��0 12 0 0q�5�      $��admin��5�      ���	#FFF9F4F46   G� 5�      -   5         G�Name$ pswdBox��5�   &   $��1��5�      $ password��5�       . $��0 12 0 0q�5�      �� 5�      $��2��6%   $ 
Horizontal=�5�      $��0 12 0 0q�5�      $��Center=�5�      .+�5�      �� -   5        $ errorMsg��5�   (   $��15(�5�      
���  ����6   �� 5�      5�      �� 5�      $��3��6%   $ 
Horizontal=�5�      $��0 12 0 0q�5�      $��Center=�5�      .+�5�      �� -   5        ���	#FF0E0C56$��Center=�5�   
   $��8 4 0 0q�5�   
   $��Enter��5�   
   
�������62   5�      5�      5�      5�      5�      5�      