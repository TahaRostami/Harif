   M S B A M L   `   `   `  ���� W  STataiee.Harif.WpfApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Tataiee.Harif.WpfApplicationTataiee.Harif.WpfApplication  ;    5Tataiee.Harif.WpfApplication.UcReductionStep2Settings   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     <local*clr-namespace:Tataiee.Harif.WpfApplication     V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�
������   MaterialDesignFont#���  .��#  MaterialDesignThemes.Wpf.Card  -   $��cardLeftSide��
������ $	��Top=�$
��Left=�$��14(�$��Medium"�$
��0,10q�.���� $��Center=�$��Center=�$	��500��$��RightToLeft=�.+�� .+��� $
��10,0q�.��WUتـــــــــــــــــــــــــــــــــــــــرم:�� -   $��txtTermNumber��$	��100��� .+��� $
��10,0q�.��<:حداقـــــــــــــــل واحــــد:�� -   $��txtMinUnits��$	��100��� .+��� $
��10,0q�.��<:حـــــــــــــداکثر واحـــــد:�� -   $��txtMaxUnits��$	��100���� $
��0,33q�� .+��� $
��10,0q�.��\Zحداکثر زمـــــان پردازش مجاز بودن اخذ الزامی درس:�� -   $��
txtTimeout��$	��100��� .+��� $
��10,0q�.��pnزمان پردازش الگوریتم پیشنهــــــــاد برنــــــامه تـــرمی:�� -   $��txtMaxAlgoTimeProc��$	��100��� .+��� $
��10,0q�.����حـــــــــــداکثر تـــــــــعداد برنـــــــــامه های پیشنهـــــــادی:�� -   $*��$txtMaxNumberOfSuggestedWeeklyProgram��$	��100���� $
��0,33q��� -   $��chkCapacityFiltering��$��10,10q�.��75فیلتر کردن سطر های بدون ظرفیت�� -	   $��chkExamCollideChecking��$
��10,0q�.��31بررسی تداخل زمانی امتحانات�� $
��0,28q��� $
��10,4q�.��جنسیت:� $
��65,0q�.+�	� -
   $��rdbMale�� 	� 	GroupName$ 	rdbGender��.��مرد	� -   $��	rdbFemale��$ 	rdbGender��.��زن�� $
��0,28q�� .+��� -   $��
btnSetting��$
��10,7q�
������ .��86اعمال تغییرات و بارگذاری مجدد�� -   $��btnResetSetting��$
��10,7q�
������ .��/-بازنشاندن مقادیر پیش فرض�� $
��0,33q��� -   $��lblMsg��