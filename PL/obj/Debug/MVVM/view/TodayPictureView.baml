   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PL.MVVM.viewPL.MVVM.view  5      7 clr-namespace:PL.MVVM.ViewModelsPL.MVVM.ViewModels  67   #    PL.MVVM.view.TodayPictureView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:PL.MVVM.view     5      7
viewmodels clr-namespace:PL.MVVM.ViewModels     67   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � .+�5   
   �� $��Picture of the Day ��6   
�������$
��Left=�6B   $��53��6]   $��30(�6i   $��
276,10,0,0q�6w   $
��Wrap=�6�   $	��Top=�6�   $	��292��6�   �� 5   
   $����Each day a different image or photograph of our fascinating universe is featured, along with a brief explanation written by a professional astronomer. ��6   
�������$��Center=�6�   $��53��6�   $��14(�6�   $��0,63,0,0q�6�   $
��Wrap=�6  $	��Top=�6#  $	��625��6;  &   MaterialDesignThemes.Wpf.Flipper  5   
   -   5        $��flipper��5   !   
������ +  %MaterialDesignThemes.Wpf.ShadowAssist    ShadowDepth$  Depth3=�6K   $��Center=�6|   $��
0,116,0,15q�6�   $	��574��6�      FrontContent 5      � 5      $	��256��6   $	��200��6%    � RowDefinitions 5      �� 5      $	��160 �6(   �� 5      $��* �6(   .+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryLight=�60   $	��120��6E   $	��150��6R   $��Stretch=�6^   ��5      �� 5       �� ImageSource 6)   �� *url+ �� IsAsync . 5      �� 5       �� Orientation$ 
Horizontal=�6!   .+�5      ��  &  "MaterialDesignToolForegroundButton#��[  6!      FlipCommand#��Z 6_   $��	175,0,0,0q�6�   $��Bottom=�6�   $��Right=�6�   ���	#FF0E0C56
������� � Cursor$
 Hand��6  .��5      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 
ArrowRight=�67   $��Right=�6K   5      5      5       
   BackContent
 5#      � 5$      $	��256��6   $	��200��6$   .+�5%        $ SecondaryMid=�6/   $��6q�6D   
������ .��5&      �� $ 
Horizontal=�6%   .+�5'      �� #��[  6%   #��Z 6c   $
��Left=�6�   .��5(   "     $	 	ArrowLeft=�6;   $��Right=�6L   5)      5*      5+      � 5,      $��1��5-   	   $��0 6 0 0q�5.   	   $��Center=�5/   	   $	��Top=�50   	   $	��172��51   	   .+�55      �� -   5         ��Name$ title��55       $��0,10,0,0q�6/   $��Center=�6\   $��5(�6z   ���	#FFF9F4F4��6A   �� *title+6�   �� 56      -   5        $
 date��56       $��0,18,0,0q�6.   $��Center=�6\   $��4(�6z   ���	#FFF9F4F4��6A   �� *date+6�   �� 57      $	��120��6%   $	��150��61   .+�58      �� -   5        $��description��58   (   $��Center=�59       $
��Wrap=�5:       $��0,30,0,0q�5;       $��4(�5<        �� 
LineHeight$ 7��5=       
�������$��Britannic Bold)�5>   4   ��58   ;   �� *explanation+5>   4   5?      5@      5A      5D      5G      5H      