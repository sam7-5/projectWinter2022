   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PL.MVVM.viewPL.MVVM.view  5          PL.MVVM.view.mediaView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:PL.MVVM.view     5      e aTelerik.Windows.Controls, Version=2022.1.222.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j fTelerik.Windows.Controls.Data, Version=2022.1.222.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2022.1.222.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a ]Telerik.Windows.Data, Version=2022.1.222.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p	 lTelerik.Windows.Controls.Navigation, Version=2022.1.222.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Gtelerik1http://schemas.telerik.com/2008/xaml/presentation     	 5      .��5
      �   � RowDefinitions  5   
   �� 5      $	��21* �6   �� 5      $	��29* �6   .+�5   
   �� $��0��6   ��5      �� 5       �� ImageSource$  /MVVM/view/mediaSearch.png��6   5      �� 5   
   -   5        $��
dataSearch��5      $	��Top=�6%   $
��Left=�6=   $��16(�6Y    �� TextWrapping$
 Wrap=�6h   $#��Search for ... (e.g. "Orion")��6|   
������ ���	#FF16191E���	#FF5A5A5B$��35��6�    �� 
CaretBrush �	#FF113470 � Cursor$ Arrow��6  $	��400��6%   �� SelectionTextBrush
 ���� $��220,132,0,0q�6S  6h  �� 5   
   -   5        $
��Left=�5      $	��Top=�6,   $��38��6D   $��35��6O   $
 Hand��6[   $��623,130,0,0q�6j   ���	#FF113470��5      �� 5      $ /MVVM/view/searchIcon.png��6   5      �� 5   
   $��1��6   $��0,0,0,25q�6$   $��Hidden=�66   $��Disabled=�6[   .��5      �� 
������ $��1��5"      $��0,0,0,25q�6   $	��402��5#      ��5!      �� *medias+��5%      �� 5&      .R�5'      A�  A� Columns$ 4��6&   5(      ��5+      �� 5,      .R�5-      ��  �� Orientation$ 
Horizontal=�6%   $��Center=�6>   .+�5/      �� $	��200��6$   $	��140��50   !   $��10q�6-   $��Uniform=�69   ��51       �� *
imageUri+ �� IsAsync . 52      54      56      57      5;      5<      