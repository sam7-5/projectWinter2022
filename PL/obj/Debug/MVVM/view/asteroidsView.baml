   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PL.MVVM.viewPL.MVVM.view  5           PL.MVVM.view.asteroidsView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:PL.MVVM.view     5      e aTelerik.Windows.Controls, Version=2022.1.222.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j fTelerik.Windows.Controls.Data, Version=2022.1.222.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2022.1.222.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a ]Telerik.Windows.Data, Version=2022.1.222.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p	 lTelerik.Windows.Controls.Navigation, Version=2022.1.222.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Gtelerik1http://schemas.telerik.com/2008/xaml/presentation     	 5      .��5
      �   � ColumnDefinitions  5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5        $��	menuTitle��5      $��	Asteroids��6!   $��30(�65   $
��Left=�6C   $��
150,50,0,0q�6^   $	��Top=�6r   $
��Bold"�6�   ���	#DDFFFFFF6�   �� 5   
   -   5        $
��list��5      $��Hidden=�6#   $��Disabled=�6J   $��0,91,0,0q�6q   .��5      �� -   5        $��listAsteroids��5       �� SelectedIndex$ 0��6,   $��1��6a   $	��200��6u   $	��302��6�   $��0,0,0,0q�6�   ��6>   �� *	asteroids+��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6%   $��Center=�6>   .+�5      �� $��nameast��6)   ��68   �� *Name+5      5      5      5      � 5    
   -   5         �Name$ 
parameters��5       $��2��6#   $��4,0,-4,0q�68   $	��450��6J   $	��800��6W    � RowDefinitions 5!      �� 5"      $	��92* �6    �� 5#      $
��133* �6    .+�5%      �� $&�� Choose your asteroids parameters��6   $
��Left=�6?   $	��540��6Z   $��50��6f   $	��Top=�6r   $��
150,47,0,0q�6�   $��30(�6�   $
��Bold"�6�   $&�� Segoe UI Variable Small Semibold)�6�   (  "System.Windows.Controls.DatePicker  5&      -   5        $��	startDate��5&         SelectedDateFormat$ Short=�6*      Text$ 
29/04/2022��6E   
�������$	��124��6k   $��26��6w   $��606,175,70,0q�6�   $	��Top=�6�   $��2��6�   �� 5'      -   5         ��Name$ 	hazardous��5'      $(��"is potentially hazardous asteroids��6+   ���	#FFFDFDFD$��22��6r   $	��223��6~   $��537,68,40,176q�6�   $��1��6�   �� 5(      $��diameter above:��6   $	��135��61   $��24��6=   $��43,62,622,180q�6I   $��1��6`   �� 5)      -   5        $��slider��5)          MaterialDesignDiscreteSlider#��[  6#    � ToolTip$" MaterialDesignDiscreteSlider��6Y   $	��342��6�   	 � Maximum$	 10000Q�6�   $��20��6�   $��43,177,415,253q�6�   $��2��6�   �� 5*      $��
From date:��6   $��24��6*   $��496,176,199,250q�66   $��2��6O   �� 5+      -   5        $��diameter��5+      
 �� TextWrapping$

 Wrap=�6)   $��86��6�    � Cursor$ Arrow��6�   
�������$��25��6�   $��147,61,567,180q�6�   $��1��6�   ��6=   �� *Value+ �� ElementName$ slider�� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5,      -	   5        $
��send��5,         MaterialDesignOutlinedButton#��[ 6%   $��32��6[   $
 Hand��6�   $��322,187,322,47q�6�   $��1��6�   �� 5-      
�������$��5q�6)   $��Center=�6=   $	��216��6Z   $��	0,110,0,0q�6g   $	��Top=�6z   $	��780��6�   $��2��6�   50      � 51   
   -
   5        $��asteroidData��51   ;   1  +Telerik.Windows.Controls.CornerRadiusHelper   
ClipRadius$	 100��6   $��1��6O   $��0,0,0,0q�6_   ���	#FF113470$	��300��6�   $	��400��6�   .+�52      �� $��Informations��6   $��Center=�6+   $	��Top=�6I   $	��180��6a   $��25(�6m   $
��Bold"�6{   $��0,36,0,0q�6�   �� 53      -   5        $��nameAsteroid��53      $��Center=�6(   $	��Top=�6F   $	��170��6^   $��13(�6j   $
��Bold"�6x   $��0,82,0,0q�6�   �� 55      -   5        $��different parameters��55      #��[ 64   $
��Left=�6j   $��	73,0,0,10q�6�   $��Bottom=�6�   $
 Hand��6�   �� 56      -   5         ��Name$ id��56      $
��Left=�6$   $��150,130,0,0q�6?   $
��Wrap=�6T   $��TextBox��6h   $	��Top=�6w   $	��120��6�   $ Arrow��6�   $��24��6�   �� 57      -   5        $ 	diameters��57      $
��Left=�6+   $��150,170,0,0q�6F   $
��Wrap=�6[   $��TextBox��6o   $	��Top=�6~   $	��140��6�   $ Arrow��6�   $��24��6�   �� 58      -   5        $ hazar��58      $
��Left=�6'   $��153,210,0,0q�6B   $
��Wrap=�6W   $��TextBox��6k   $	��Top=�6z   $	��117��6�   $��24��6�   �� 59      -   5        $ orbit��59      $
��Left=�6'   $��150,250,0,0q�6B   $
��Wrap=�6W   $��TextBox��6k   $	��Top=�6z   $	��120��6�   $ Arrow��6�   $��24��6�   �� 5:      -   5         ��Name$ moreInfo��5:      $
��Left=�6(   $��
90,310,0,0q�6C   $��For more info��6Y   $	��Top=�6q   $	��120��6�   $ Arrow��6�   �� 5<      $
��Left=�6   $��Id��60   $��
10,130,0,0q�6=   $	��Top=�6Q   $	��120��6i   $ Arrow��6u   �� 5=      $
��Left=�6   $��Diameter��60   $��
10,170,0,0q�6C   $	��Top=�6W   $	��120��6o   $ Arrow��6{   �� 5>      $
��Left=�6   $��
hazardous?��6/   $��
10,210,0,0q�6E   $	��Top=�6Y   $	��135��6q   $ Arrow��6}   �� 5?      $
��Left=�6   $��Orbiting body��60   $��
10,250,0,0q�6H   $	��Top=�6\   $	��120��6t   $ Arrow��6�   5@      5A      5B      