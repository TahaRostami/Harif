   M S B A M L   `   `   `  ����W  STataiee.Harif.WpfApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Tataiee.Harif.WpfApplicationTataiee.Harif.WpfApplication  5      7    1Tataiee.Harif.WpfApplication.UcProcessingSettings   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Tataiee.Harif.WpfApplication     5      V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
         MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	   
������   MaterialDesignFont#���  5   	   .��5      #  MaterialDesignThemes.Wpf.Card  -   5        $��cardLeftSide��5      
������ $	��Top=�6H   $
��Left=�6`   $��14(�6{   $��Medium"�6�   $
��0,10q�6�   .��5   
   �� $��Center=�6   $��Center=�60   $	��500��6M   $��RightToLeft=�6\   .+�5      � .+�5      �� $
��10,0q�6   .��6&   WUتـــــــــــــــــــــــــــــــــــــــرم:6S   �� 5      -   5        $��txtTermNumber��5      $	��100��6/   6@   5      � 5      .+�5      �� $
��10,0q�6   .��6&   <:حداقـــــــــــــــل واحــــد:6F   �� 5      -   5        $��txtMinUnits��5      $	��100��6-   6>   5      � 5      .+�5      �� $
��10,0q�6   .��6&   <:حـــــــــــــداکثر واحـــــد:6F   �� 5      -   5        $��txtMaxUnits��5      $	��100��6-   6>   5       �� 5!      $
��0,33q�6   � 5"      .+�5#      �� $
��10,0q�6   .��6&   \Zحداکثر زمـــــان پردازش مجاز بودن اخذ الزامی درس:6Y   �� 5$      -   5        $��
txtTimeout��5$      $	��100��6,   6=   5%      � 5&      .+�5'      �� $
��10,0q�6   .��6&   pnزمان پردازش الگوریتم پیشنهــــــــاد برنــــــامه تـــرمی:6b   �� 5(      -   5        $��txtMaxAlgoTimeProc��5(      $	��100��64   6E   5)      � 5*      .+�5+      �� $
��10,0q�6   .��6&   ��حـــــــــــداکثر تـــــــــعداد برنـــــــــامه های پیشنهـــــــادی:6m   �� 5,      -   5        $*��$txtMaxNumberOfSuggestedWeeklyProgram��5,      $	��100��6F   6W   5-      �� 5.      $
��0,33q�6   �� 5/      -   5        $��chkCapacityFiltering��5/      $��10,10q�64   .��6C   75فیلتر کردن سطر های بدون ظرفیت6b   �� 50      -	   5        $��chkExamCollideChecking��50   %   $
��10,0q�6   .��6C   31بررسی تداخل زمانی امتحانات6_   �� 51      $
��0,28q�6   �� 52      $
��10,4q�6   .��6"   جنسیت:6*   � 53      $
��65,0q�6   .+�54      	� -
   5        $��rdbMale��54       	� 	GroupName$ 	rdbGender��6-   .��6C   مرد6H   	� 55      -   5        $��	rdbFemale��55      $ 	rdbGender��6/   .��6E   زن6I   56      �� 57      $
��0,28q�6   � 58      .+�59      �� -   5        $��
btnSetting��59   '   $
��10,7q�6   
������ .��6l   86اعمال تغییرات و بارگذاری مجدد6�   �� 5:      -   5        $��btnResetSetting��5:   '   $
��10,7q�6   
������ .��6v   /-بازنشاندن مقادیر پیش فرض6�   5;      �� 5<      $
��0,33q�6   �� 5=      -   5        $��lblMsg��5=      6$   5>      5?      5@      