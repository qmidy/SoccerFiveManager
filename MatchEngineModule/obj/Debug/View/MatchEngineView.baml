   M S B A M L   `   `   `  ����  MatchEngineModule'    !MatchEngineModule.MatchEngineView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � 	Resources  5       �� Source�� 5   
   $J Dpack://application:,,,/CommonLibrary;component/Resources/Colors.xaml?�6   %    .��5      �    MiddleFadeClearGreen#���   6    � ColumnDefinitions 5   
   �� 5	      $	��80* �6   �� 5
      $	��20* �6   .+�5   
   � $��0��6     
ClearGreen#���  6   .+�5      �� ��6   �� *PlayersTeam1+��5      �� 5      .R�5      �� 5      ��5      5  -System.Windows.Controls.ItemContainerTemplate�  5      .R�5      �� .+�5      �� 
���  ��$��50��63   $��50��6>    �� Left 6J   �� *
Position.X+
 �� Top 6m   �� *
Position.Y+5      5      5      �� 5      ��6   �� *PlayersTeam2+��5      �� 5      .R�5       �� 5!      ��5#        5$      .R�5%      �� .+�5&      �� 
����  �$��50��64   $��50��6?    6K   �� *
Position.X+ 6n   �� *
Position.Y+5'      5(      5*      5+      � 5-   
   $��1��6   
���   �.+�5.      �  � RowDefinitions 5/      �� 50      $	��10* �6$   �� 51      $	��10* �6$   �� 52      $	��10* �6$   �� 53      .+�55      �� -   5        $��0��55      .��67   Next6=   � 56      $��1��6    57      �� 58      �� 59      .+�5;      �� $��0��6    
���  ����60   ��  �� Path$ Score1� �� UpdateSourceTrigger$ PropertyChanged=�6r   �� 5<      $��1��6    
����  ���60   �� $ Score2�$ PropertyChanged=�6r   5=      �� 5>      $��2��6   
���������6)   �� *
BallTeam+$ PropertyChanged=�6h   5?      5A      5C      5D      