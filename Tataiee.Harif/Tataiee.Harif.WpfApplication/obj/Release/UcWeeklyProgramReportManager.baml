   M S B A M L   `   `   `  ���� W  STataiee.Harif.WpfApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Tataiee.Harif.WpfApplicationTataiee.Harif.WpfApplication  ?    9Tataiee.Harif.WpfApplication.UcWeeklyProgramReportManager   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     <local*clr-namespace:Tataiee.Harif.WpfApplication     V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�
������   MaterialDesignFont#���  .��]� -   $��	panelMain��.+�� $��RightToLeft=�$	��Top=�$��Stretch=�$��Center=�.+��� -   $#��btnDeleteCurrentWeeklyProgram��
������ $��0,0,0,0q� � Cursor$
 Hand��$��LeftToRight=���0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ Delete=�   Size$ 24X��� -   $!��btnSaveCurrentWeeklyProgram��
������ $��5,0,0,0q�$
 Hand��$��LeftToRight=���  $ ContentSave=�$ 24X�(  "MaterialDesignThemes.Wpf.RatingBar  -   $��ratingBarUserScore��$
��15,5q�   Value$ 0���� $	��Top=�$��5q��� $
��Left=�$	��Top=�$
��Left=�.+��� -   $$��lstBoxWeeklyProgramsNavigation��$	��250��$	��350�� �� SelectionMode$ Single=��� $��5q��� -   $!��grpBoxWeeklyProgramMoreInfo��$��RightToLeft=�$��سایر اطلاعات��$	��250��$
��0,20q�.���� .+�� .+��� .��'%امــــــــــــتیاز:�� -   $��txtScore�� �� 
IsReadOnly . $	��230��� .+��� .��تعداد واحد:�� -   $��txtUnits�� . $	��230��� .+��� .��-+تــــــــــــــــــرم:�� -	   $��txtTermNumber��$	��230��� .+��� .��توضیـــحات:�� -
   $��txtDescription�� �� TextWrapping$
 Wrap=�$��Stretch=�$	��230��$��1q�	 �� AcceptsReturn	 . "
 �� VerticalScrollBarVisibility$

 Auto=�$��90��.��� -   $��panelContent��