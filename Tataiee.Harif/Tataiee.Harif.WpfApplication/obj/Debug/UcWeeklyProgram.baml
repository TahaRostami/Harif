   M S B A M L   `   `   `  ����W  STataiee.Harif.WpfApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Tataiee.Harif.WpfApplicationTataiee.Harif.WpfApplication  5      2    ,Tataiee.Harif.WpfApplication.UcWeeklyProgram   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Tataiee.Harif.WpfApplication     5      V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
         MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	   
������   MaterialDesignFont#���  5   	   .��5      ]� .+�5   
   � -   5        $��wrapPanelMenu��5   *   $	��Top=�6    � Orientation$ 
Horizontal=�6?   $��RightToLeft=�6Y   $��0,5,0,5q�6u   .+�5      �� -   5        $��btnTab1��5      $��13(�6$   
������ $��0,0,0,1q�6`   
���   �$��3,0,35,0q�6�   $��4q�6�    � Cursor$
 Hand��6�   $��LeftToRight=�6�   .��6�   نمایش جدولی6�   �� 5      -   5        $��btnTab2��5      $��13(�6$   
������ $��0,0,0,0q�6`   
���   �$��3,0,35,0q�6�   $��4q�6�   $
 Hand��6�   $��LeftToRight=�6�   .��6�   لیست دروس6�   5      �� 5   
   -   5        $��	PanelMain��5      .+�5      �� -   5        $��stackPanelTab1��5      .+�5      �� -   5        $��canvas��5      $��RightToLeft=�6'   5      5      �� 5       -   5        $��stackPanelTab2��5       $y�	Collapsed=�6/   .+�5!      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridInfo��5!   4   
������ $��0 35 0 0q�6J   $��RightToLeft=�6\   $��Center=�6x   $��Stretch=�6�      CanUserResizeColumns .  "   VerticalScrollBarVisibility$
 Auto=�6�   $   HorizontalScrollBarVisibility$
 Auto=�6�      CanUserDeleteRows .  	   CanUserAddRows	 .  
   CanUserReorderColumns
 .     CanUserResizeRows .     CanUserSortColumns .  5#      5%      5&      5'      5(      