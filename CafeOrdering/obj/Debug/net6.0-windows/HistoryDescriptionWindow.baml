   M S B A M L   `   `   `  ����G  CCafeOrdering, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:CafeOrderingCafeOrdering  5   	   +    %CafeOrdering.HistoryDescriptionWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   ,localclr-namespace:CafeOrdering     5   	   -   5          � Title$  Таколэнд��5   	   $
��1366��6   $
��1366��6'   $	��768��67   $	��768��6D    � WindowState$ 	Maximized=�6T    � WindowStyle$ SingleBorderWindow=�5	   	    � WindowStartupLocation$ CenterScreen=�6*   .��5      �  � RowDefinitions 5   
   �� 5      $	��120 �6   �� 5      $��* �6   .+�5   
   � $��0��6   ���#212529.+�5      �� -   5         ��Name$ 	TbWelcome��5      $��Заказ: AAA-000��6+   ���#ffffff$��22(�6V   $��Center=�5      $��Center=�65   �� 5      -   5         ��Name$ BtnBack��5      $��
Назад��6&   $
��Left=�66   $��Center=�6Q   $��20 0 0 0q�5      $
��30 5q�6'   ���#ffffff���#ffffff���#212529$��15(�5   U   $��18(�5      6-   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridProducts��5      $��1��6-   $��Stretch=�6:   $��Stretch=�6X   $��18(�5         CanUserAddRows$ False��5      	   CanUserDeleteRows$	 False��6*   
   CanUserResizeRows$
 False��6D      AutoGenerateColumns$ False��5         SelectionMode$ Single=�6/      RowHeaderWidth$ 0Q�5      $��2q�6&      HorizontalGridLinesBrush
 ��������#212529   GridLinesVisibility$ 
Horizontal=�5         	RowHeight$ 35Q�64      
IsReadOnly$
 True��6C      Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ Наименование��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6;   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   ��  �� Path$
 Name�  5"      $ Количество��6%   $	 150 69    6E   �� $ Quantity�  5#      $ Цена��6%   $	 150 63    6?   �� $ Price�  5$      $ 
Сумма��6%   $	 150 64    6@   �� $	 Sum�  5%      $ Id��6%   $ * 61      
Visibility$ 	Collapsed=�6W    6;   �� $ Id�6W   5'      5(      5)      