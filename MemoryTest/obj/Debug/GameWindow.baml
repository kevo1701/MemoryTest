   M S B A M L   `   `   `  ����E  AMemoryTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MemoryTest
MemoryTest  5   	   =#clr-namespace:MemoryTest.ViewModelsMemoryTest.ViewModels  5   	   =#clr-namespace:MemoryTest.ConvertersMemoryTest.Converters  5   	       MemoryTest.GameWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MemoryTest     5   	   :
viewmodels#clr-namespace:MemoryTest.ViewModels     5   	   :
converters#clr-namespace:MemoryTest.Converters     5   	   -   5          �Name$  GWindow��5   )    � Title$ 
GameWindow��5
   	   $
��1080��6   $
��1024��6*    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � WindowState$ 	Maximized=�5   	    � DataContext 5      /   )MemoryTest.ViewModels.GameWindowViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $	��35* �6   �� 5      $	��23* �6   �� 5      $
��210* �6    � ColumnDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $��1* �6   �� 5      $
��0.2* �6   .+�5    
   �� $��0��6   $��0��6   $��5,5,0,0q�6.   $
��Left=�6?   $	��Top=�6Z   $��40,20q�6r   $
��Back��6�   $��20(�6�   ��6�   �� *BackCommand+��6�   ��  �� ElementName$ GWindow���� 5"   
   -   5        	 ��Name$	 timer��5"      $��0��6   $��1��6,   $��Center=�6<   $��Center=�6W   $��26(�6t   $��1q�6�   
���   �$��357,64q�6�   ��6�   �� *	TimerText+6�   �� 5$   
   $��0��6   $��2��6   $��0,5,5,0q�6.   $��Restart��6?   $��20(�6Q   $��Right=�6_   $	��Top=�6{   $��40,20q�6�   ��6�   �� *RestartCommand+��6�   �� $ GWindow���� 5&   
   $��1��6   $��1��6$   $��Stretch=�6R   $��Stretch=�6n   $��2��6�   ��64   �� *Cards+��5'      �� 5(      .R�5)      � 5*      ��5,      �� 5-      .R�5.      �� $	��150��6   $	��280��6)   $��5q�66   ��6A   �� *ClickCommand+��6b   �� $ GWindow��
 �� Path$
 DataContext.Cards�{�6�   �� *	IsFlipped+ �� 	Converter 3   -MemoryTest.Converters.InverseBooleanConverter  .��5/      �� $
��Fill=�6    $��Stretch=�6/   $��Stretch=�6K   ��6i   �� *CurrentImage+50      51      53      54      55      