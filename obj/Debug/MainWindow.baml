   M S B A M L   `   `   `  ����@  <JTDic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:JTDicJTDic  5   	       JTDic.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:JTDic     5   	     � Title$  JT Dic Mini��5   	   $��399.271��6   $��399.005��6.    � 
ResizeMode$ NoResize=�6>    � ShowInTaskbar .   � SizeToContent$ WidthAndHeight=�6j    � WindowStartupLocation$ CenterScreen=�6�    � Topmost . .��5	      � $��0,0,4.5,1.5q�6    � ColumnDefinitions 5
   
   �� 5      $	��94* �6   �� 5      $	��95* �6   �� 5      $��0* �6    � RowDefinitions 5   
   �� 5      $
��103* �6   �� 5      $
��108* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��	dataGrid1��5      $��0,37,0,0q�6A   $��2��6S   $��2��6d   $	��333��6x   $	��Top=�6�   $
��Left=�6�   $	��380��6�   $��20(�6�   ��6$   �� *Data+6�   �� 5   
   -   5         ��Name$ 	textbox_1��5      $
��Left=�6%   $��37��6@   	 �� TextWrapping$
	 Wrap=�6L   $	��Top=�6`   $	��295��6x   $��2��6�   $��24(�6�   �� 5   
   -   5        $��Search��5      $��1��6"   $��0,0,-2.5,119.5q�62   $��Right=�6J   $��96��6f   $��2��6q   6�   5      5      