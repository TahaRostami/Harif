   M S B A M L   `   `   `  ���� W  STataiee.Harif.WpfApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Tataiee.Harif.WpfApplicationTataiee.Harif.WpfApplication  3    -Tataiee.Harif.WpfApplication.UcReductionStep2   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     <local*clr-namespace:Tataiee.Harif.WpfApplication     V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�
������   MaterialDesignFont#���  .��� .+�� -    �Name$ GridBackgroundPage�� K� ZIndex$
 1000��
���   � J� Opacity$	 0.5Q�$y�	Collapsed=�]� .+�� $��Right=� � RowDefinitions �� $
��Auto ���  � ColumnDefinitions �� �� $
��Auto �$	��290��.+�� -   $��wrapPanelButtons��$��0��$��1��$	��Top=�$��Right=�.+��� -   $��btnAllRowsWhite�����#f7f7f7$��1q�$
��20,5q�$��46��$��46���� -   $��btnAllRowsRed�����#f0513c$��1q�$
��20,5q�$��46��$��46���� -   $��btnMustBeTake��
������ $��1q�$
��20,5q�$��46��$��46���� -   $��stackPanelRightSide��$��1��$��1��$��Right=�$��RightToLeft=�$	��Top=�$��Right=��� -   $��stackPanelCenterContent��$��1��$��0��$��2��$��RightToLeft=�$	��0,0q��� -   $��stackPanelLeftSide��$	��0,5q�$
��Left=�$	��Top=�$
��Left=�.+��� $��RightToLeft=�$*��$پیشنهاد برنامه درسی��$	��340��$
��0,10q�.���� .+��� -	   $��canvasAlgorithmMsg��$��LeftToRight=�$	��300��$��50��$��Center=�$��Center=��� $
��5,20q��  �� �� $
��Auto �.+��� -
   $��btnRunAlgorithm��$��0��$
��Left=�$	��5,0q���0  *MaterialDesignThemes.Wpf.PackIconExtension  *ArrowRightDropCircleOutline+�� -   $!��btnShowLastAlgorithmOutputs��$��1��$��Right=���  *FolderOutline+�� $��RightToLeft=�$��فیلتر زمانی��$	��340��.���� .+��� .��برای روز (های):� $��RightToLeft=�.+��� -    ��Name$
 Day0�� d� IsThreeState .  	 d� 	IsChecked$	 FalseY�$��0 8 0 0q�.��ش�� -   $
 Day1�� .  $	 FalseY�$��0 8 0 0q�.��1ش�� -   $
 Day2�� .  $	 FalseY�$��0 8 0 0q�.��2ش�� -   $
 Day3�� .  $	 FalseY�$��0 8 0 0q�.��3ش�� -   $
 Day4�� .  $
	 TrueY�$��0 8 0 0q�.��4ش�� -   $
 Day5�� .  $	 FalseY�$��0 8 0 0q�.��5ش�� -   $
 Day6�� .  $	 FalseY�$��0 8 0 0q�.��
جمعه�� $
��5,20q�� .+��� .��از ساعت�� -   $��txtStartTime��$	��100���� .��تا ساعت�� -   $��txtFinishTime��$	��100���� $
��5,20q��� .��fdهمه سطر هایی که با این بازه تداخل زمانی دارند را با رنگ :� $
��0,20q�.+�	� -   $��rdbRedColor��
 	� 	GroupName$
 rdbColor��$
	 TrueY�  MaterialDesignRadioButton#��[ .��
قرمز	� -   $��rdbWhiteColor��$
 rdbColor��$	 FalseY�#��[ .��
سفید�� $��	20,-4,0,0q�.��رنگ آمیزی کن.�� $
��5,20q��� -   $��lblMsgActionPerform���� $
��5,20q��  �� �� $
��Auto �.+��� -   $��btnTimeFilter��$��0��$
��Left=�$	��5,0q�.��اعمال تغییرات�� $��1��$��Right=�$y�	Collapsed=���  *DotsVertical+�� $��RightToLeft=�$��ذخیره سازی��$	��340��$
��0,10q�.���� .+��  �� �� $
��Auto �.+��� -   $��btnSave��$��0��$
��Left=�$	��5,0q���  *ContentSaveAll+