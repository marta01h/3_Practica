   M S B A M L   `   `   `  ����  
Плеер    WpfApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Audio Player��5   	   $	��450��6   $	��800��6+   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $��* �6   �� 5
      $
��Auto �6   .+�5   
   �� -   5        $��Select Folder��5      $��Center=�6J   $��10q�6g   �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��10q�6X   .+�5      �� -   5         ��Name$ previousButton��5      $��Previous��6-   6@   �� 5      -   5        $ 
playButton��5      $
��Play��6)   $
��10 0q�6Q   �� 5      -   5        $ 
nextButton��5      $
��Next��6)   68   �� 5      -   5        $ repeatButton��5      $��
Repeat Off��6+   $
��10 0q�6[   �� 5      -   5        $ shuffleButton��5      $��Shuffle Off��6,   $
��10 0q�6^   5      �� 5   
   $��2��6   $ Vertical=�6"   $��Center=�69   $��10q�6V   .+�5      �� -   5         ��Name$ currentPositionLabel��5      $��00:00 / 00:00��62   $y�Hidden=�6J   �� 5      -   5         ��Name$ positionSlider��5       � Minimum$ 0Q�6-    � Maximum$	 100Q�69   $y�Hidden=�6r   5      5      5      