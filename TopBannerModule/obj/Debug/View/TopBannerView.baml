   M S B A M L   `   `   `  ����J  FTopBannerModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:TopBannerModuleTopBannerModule  5   	   #    TopBannerModule.TopBannerView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   9topBannerModuleclr-namespace:TopBannerModule     5   	     � 	Resources  5       �� Source�� 5   
   $J Dpack://application:,,,/CommonLibrary;component/Resources/Colors.xaml?�6   %    .��5      �  � ColumnDefinitions 5	   
   �� 5
      $��50 �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   d� -   5        $��MenuPopupOpened��5      $��0��6.    d� 	IsChecked$ FalseY�6>   .��5      (� .��5      �� $��50��6   $��50��6$    J� Clip4 ��        � ��    � �� ���     ���        .+�5      F� $��38��6   $��39��6&    �� Left$ 6��62   
 �� Top$ 6��6B    �� Stretch$
 Fill=�6Q   
���iii��������!��!�@�e��!�@�e@x}���!@x}���!��!���O uр�7 uр�7�uр�O�uр�O u�@��@�q��)�@�q��)��)��@���)��@��@�q�@x}�����2
�����2
 Q%�@x} Q%�@x}���6o   5      5      5      � 5   
   $��1��6      WarmBlue#���   6   .+�5      �� ��6   �� *EventDictionnary+��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6%   5      ��5      5  -System.Windows.Controls.ItemContainerTemplate�  5      .R�5       �� .+�5!      � 	 � RowDefinitions	 5"   "   �� 5#   &   �� 5$   &   .+�5&   "   �� $��0��6,   ��69   �� *Key+�� 5'   "   $��1��6/   ��6<   �� *Value+��5(   &   �� 5)   *   .R�5*   .   �� ��68   �� *	EventName+5+   +   5-   #   5.      5/      50      52      53      �� 55   
   -   5        $��2��55      .��63   Next6;   (   "TopBannerModule.TopBannerMenuPopup  59   
   $	��200��5:   -   $��Bottom=�5<   -   ��59   -   �� 
 �� ElementName$
 MenuPopupOpened�� �� Path$ 	IsChecked� �� Mode$ TwoWay=� � PlacementTarget 5;   -   �� $
 MenuPopupOpened��5<   -   5>      5?      