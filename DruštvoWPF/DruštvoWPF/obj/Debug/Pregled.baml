   M S B A M L   `   `   `  ����F  BDruštvoWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:DruštvoWPFDruštvoWPF  5   	       DruštvoWPF.Pregled   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:DruštvoWPF     5   	   -   5          � Title$  Pregled��5   	   $	��450��6   $	��800��6&    � 	Resources 5
         RowDetailTemplate �Name �� CornerRadius �� 
StartPoint �� EndPoint � Offset � Color � RowDefinitions	 
� Center
 
� GradientOrigin �� Opacity 
� RadiusX 
� RadiusY��%)  &	        �� 5   
   .R�5      � $ RowDetailGrid��6   $	��470��5      $
��Auto��5      $��5q�5      .+�5      �� $
��Left=�6   $	��Top=�5   	   $ 5��5   	   ��5      �� 5      $	 0,0&�6.   $	 0,1&�6?   .��5      � $ 0Q�6+   $ 
WhiteSmoke��66   � 5      $
 0.75Q�6+   $ 	#AAFFFFAA��69   � 5      $ 1Q�6+   $ 	#AAFFD455��66   5      ._�5      �  5      �� 5      $
��Auto �6,   �� 5      $��* �6,   .+�5      �� $��0��6$   $��10q�5       $��Center=�5!      $��18(�5"      $��Black"�5#      $��Opombe��5$      �� 5%      $��1��6$   $��10q�5&      $
��Left=�5'      $��WrapWithOverflow=�5)      ��5(      �� *Opombe+5)      5*      5+      �� 5,      $��0 0 8 0q�6   $ 5��6*   ��5-      
� 5.      $	 0.5,1&�6.   $	
 0,1&�6=   $	 0.3Q�6R   $	 0.8Q�6`   $	 0.8Q�6n   .��5/      � $ 1Q�6+   $ 	#AA58BD03��66   � 50      $ 1Q�6+   $ 
WhiteSmoke��66   51      53      54      55      56      .��57      �  58   
   �� 59      $
��Auto �6   �� 5:      .+�5=   
   c� $��0��6   $
��Left=�6   $	��Top=�6:   $��40��6R   .@�5>      �� -   5        $��	btnShrani��5>   H   $�� ��6   $��0,0,0,1q�6    $��34��61   $��34��6<   ��5?      �� 5@       �� ImageSource$ Slike/FloppyDisk.ico��6!   5B      �� 5C      -   5        $��	btnBriši��5C   H   $�� ��6   $��0,0,0,1q�6    $��34��61   $��34��6<   ��5D      �� 5E      $ Slike/delete.ico��6!   5G      �� 5H      $�� ��6   $��0,0,0,1q�6    $��34��61   $��34��6<   ��5I      �� 5J      $ Slike/help.ico��6!   5L      5M      &   System.Windows.Controls.DataGrid  5N   
   -   5        $��	dgPodatki��5O   +   $��1��5N      $
��Left=�6    $��0,40,0,0q�6;   $	��Top=�5O         AutoGenerateColumns .     RowDetailsTemplate# [  5Q      $	��481��6K      RowHeaderTemplate 5R      �� 5S      .R�5T      d�  d�Name$ RowHeaderToggleButton��6#   -   5         � Cursor$
 Hand��5V      5W         Columns 5Y      0  *System.Windows.Controls.DataGridTextColumn  5Z      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 20 6%      Header$
 Št.��6J   1  +System.Windows.Controls.DataGridBoundColumn   Binding 60   �� *ZapŠt+6J     5[      $	 120 6%   $ Datum��6K    61   �� *Datum+6K     5\      $	 150 6%   $ Namen��6K    61   �� *Namen+6K     5]      $	 120 6%   $ Znesek��6L    61   �� *Znesek+6L   5`      5a      5b      