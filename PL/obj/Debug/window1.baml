   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLPL  5   	   +clr-namespace:PL.MVVM.viewPL.MVVM.view  5   	   7 clr-namespace:PL.MVVM.ViewModelsPL.MVVM.ViewModels  5   	       PL.essai   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:PL     5   	   +viewclr-namespace:PL.MVVM.view     5   	   7
ViewModels clr-namespace:PL.MVVM.ViewModels     5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  essai��5
   	   $	��600��6   $
��1000��6$    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	    � 	Resources 5        OpenMenu �� TargetProperty t� From		 t� To
 g� DecelerationRatio g� Duration  	CloseMenu��%F  &	       &	 �     �� 5   
   .��5      t� $ Margin�5       $ 
-110,0,0,0X�5!      $	 0,0,0,0X�5"      $	
 0.9Q�5#      $ 0:0:0.3D�5$      5&      �� 5(   
   .��5*      t� $ Margin�5+      $ 0,0,0,0X�5,      $	 
-110,0,0,0X�5-      $	
 0.9Q�5.      $ 0:0:0.3D�5/      51      53      ��54      �� 55   
    �� ImageSource$ MVVM/view/font.jpg��6    �� Opacity$	 0.3Q�66   .��57      �� -   5        ._�58   
   � -   5        $��MainGrid��59   	    � RowDefinitions 5:      �� 5;      $��27 �6    �� 5<      $	��64* �6    �� 5=      $
��509* �6     � ColumnDefinitions 5?      �� 5@      $	��109 �6#   �� 5A      $
��Auto �6#   .+�5D      �� $��1��6!   $��1��6.   $��10,0,201,10q�5E      $��2��5F      ��6.   �� *CurrentView+ 5G       �� DataType%   PL.MVVM.ViewModels.dayPictureVM#   PL.MVVM.view.TodayPictureView&    PL.MVVM.ViewModels.solarSystemVM"   PL.MVVM.view.solarSystemView   PL.MVVM.ViewModels.infoVM   PL.MVVM.view.infoView    PL.MVVM.ViewModels.mediaVM	   PL.MVVM.view.mediaView$
   PL.MVVM.ViewModels.asteroidsVM    PL.MVVM.view.asteroidsView��%w  (��       5H   #   *, +)(�� 2     5K   #   *, +)(�� d     5N   #   *, +)(�� �     5Q   #   *, +)(�� �     5T   #   *,
 +)�� 5H      "  6#   .R�5I        5J      �� 5K      "  6#   .R�5L        5M      �� 5N      "  6#   .R�5O        5P      �� 5Q      "  6#   .R�5R      	  5S      �� 5T      " 
 6#   .R�5U        5V      5X      5Z      �� 5`      $��0��5a      $��2��5b      ���	#FF0E0C56$��50��5d      $��Center=�5e      $��	0,0,201,0q�6(   ._�5g      �� -   5         ��Name$ MainTimerTextBlock��5g      $��20(�5h      $��0,0,80,0q�5i      
�������$��Right=�5k      $��Center=�5l      5o      �� 5r      -   5        $
��Exit��5t      $��1��5s      $��50��5u      $��Center=�5v      ���#E81123
������ $��854,0,193,0q�5{   *   ._�5}      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�5~      $��Center=�5      
�������$��34��5�      $��39��5�      5�      � 5�      -   5        $��SideBar��5�      $��0��5�      $��2��5�      $��0��5�      $��3��5�      ���	#FF0E0C56$	��200��5�      $
��Left=�5�      $��0,0,0,0q�6(    5�      �� 5�      $��80 �6$   �� 5�      $	��115 �6$   �� 5�      $	��115 �6$   �� 5�      $	��115 �6$   �� 5�      $	��115 �6$   �� 5�      $	��115 �6$   .+�5�      �� -   5        $��0��5�      $��Center=�5�      $��Right=�5�      
������ $��90��5�      $��80��5�      
������  � Cursor$
 Hand��5�      .��5�        -   5        $��OpenCloseButtonIcon��5�      
�������$ MenuOpen=�5�      $��50��5�      $��50��5�      5�      �� 5�      -   5        $��
InfoButton��5�      $��0��5�      $��Center=�5�      $
��Left=�5�      ���	#FF0E0C56$��90��5�      $��80��5�      
������ $
 Hand��5�   +   ��5�      �� *infoCommand+.��5�        
�������$ InformationOutline=�5�      $��50��5�      $��50��5�      5�      �� 5�        MenuButtonCustom#��[ 5�       �� ContentStringFormat$ PanoramaVariantOutline��5�      $��Today
Picture��5�      $��1��5�      
������ $	��120��5�      $��	0,0,0,110q�5�      $��2��6$   ��5�      �� *daypictureCommand+�� 5�      #��[ 5�      $ Earth��5�      $��Solar 
System��5�      $��2��5�      
������ $	��120��5�      $��0,0,0,0q�5�      ��5�      �� *solarSystemCommand+�� 5�      #��[ 5�      $ MovieSearchOutline��5�      $��Search 
media��5�      $��3��5�      
������ $	��120��5�      $��0,0,0,0q�5�      ��6"   �� *mediaSearchCommand+�� 5�      #��[ 5�      $ AlertOctagon��5�      $��Asteroids 
Comets��5�      $��4��5�      
������ $	��120��5�      $��0,0,0,0q�5�      ��6"   �� *asteroidsCommand+5�      �� 5�      $��1��6   $
��Left=�6(   $��208,229,0,0q�6C   $��2��6X   $
��Wrap=�6e   $	��Top=�6�   ��6y   �� *
stamText+6�   5�      5�      5�      