   M S B A M L   `   `   `  ����E  AMemoryTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MemoryTest
MemoryTest  5   	   =#clr-namespace:MemoryTest.ViewModelsMemoryTest.ViewModels  5   	       MemoryTest.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MemoryTest     5   	   :
viewmodels#clr-namespace:MemoryTest.ViewModels     5   	   -   5          �Name$  MWindow��5   )    � Title$ 
MainWindow��5	   	   $	��450��6   $	��800��6)    � DataContext 5
      /   )MemoryTest.ViewModels.MainWindowViewModel  5   
   .��5      � $��150, 50q�6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ btnPlay��5      $��0��6"   $
��PLAY��6/   ���	#FF150303$��5q�6U   ���	#FF060000���	#FFF9F7F7$��32(�6�   ��5      �� *PlayCommand+��61   ��  �� ElementName$ MWindow���� 5   
   -   5        $ btnExit��5      $��1��6#   $
��EXIT��60   
�������$��5q�6R   ���	#FF130101$��32(�6t   ��5      �� *ExitCommand+��61   �� $ MWindow��5      5      