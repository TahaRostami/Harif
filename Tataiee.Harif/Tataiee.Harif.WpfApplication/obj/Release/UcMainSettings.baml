   M S B A M L   `   `   `  ���� W  STataiee.Harif.WpfApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Tataiee.Harif.WpfApplicationTataiee.Harif.WpfApplication  1    +Tataiee.Harif.WpfApplication.UcMainSettings   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     <local*clr-namespace:Tataiee.Harif.WpfApplication     V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�
������   MaterialDesignFont#���  .���� $��RightToLeft=�.+�9� $��Stretch=�$,��&تنظیمات برنامه هفتگی��$��25q�$��14(�$��Medium"�
�������$��0,0,0,1q�.����  �� Orientation$ Vertical=�$��Center=�$��Center=�$	��500��#���   $��
24,8,24,16q�.+�� .+��� $
��10,0q�.��VTساعت شروع در جــــــــــــــدول برنامه هفتگی:�� -   $��txtWpStartHour��$	��100��� .+��� $
��10,0q�.��\Zساعت پایان در جــــــــــــــــدول برنامه هفتگی:�� -   $��txtWpFinishHour��$	��100��� .+��� $
��10,0q�.��QOطول هر دقیقه در جـــــــــدول برنامه هفتگی:�� -   $��txtWpMinuteWidth��$	��100��� .+��� $
��10,0q�.��ECضخامت حاشیه ها در جـدول برنامه هفتگی:�� -   $��txtWpBorderThickness��$	��100��� .+��� $
��10,0q�.��MKتو رفتگی داخلی الـــمان های برنامه هفتگی:�� -   $��
txtPadding��$	��100��� .+��� $
��10,0q�.��sqانــــــــــــدازه فـــــــــونت در برنــــــــــامه هفتگی:�� -   $��txtFontSize��$	��100��� .+��� $
��10,0q�.��QOحداقل ارتفاع هر سطـــــــر در برنامه هفتگی:�� -   $��txtMinHeight��$	��100��� .+��� $
��10,0q�.��TRطول لیست دروس در برنــــــــــــــامه هفتگی:�� -   $ ��txtDataGridCourseInfoWidth��$	��100��� $
��0,35q�.+��� -	   $!��btnSaveSettingWeeklyProgram��$
��10,7q�.��86اعمال تغییرات و بارگذاری مجدد�� -
   $"��btnResetSettingWeeklyProgram��$
��10,7q�.��/-بازنشاندن مقادیر پیش فرض9� $��Stretch=�$=��7تنظیمات قابیل رویت بودن منو ها��$��25q�$��14(�$��Medium"�
�������$��0,0,0,1q�.���� $ Vertical=�$��Center=�$��Center=�$	��500��#���   $��
24,8,24,16q�.+��� -   $��chkHomePageVis��$��10,10q�.����قــــــــــابل رویــــــــــت بـــــــــــــودن خــــــــــــــــــانه�� -   $��chkCreditDeterminerVis��$��10,10q�.��VTقابل رویت بودن تعیین گــــــــرایش و تمرکـــز�� -   $��chkAdaptTblVis��$��10,10q�.��USقابل رویت بـــــــودن جـــــــدول تطبیق دروس�� -   $��chkStudHistoryVis��$��10,10q�.��dbقابل رویت بـــودن تـــــــــاریخچه دانشجــــــــــو�� -   $ ��chkOfferedCourseManagerVis��$��10,10q�.��HFقابل رویت بودن بارگذاری دروس ارائه شده�� -   $!��chkReductionStep2SettingVis��$��10,10q�.��ZXقابل رویت بـــودن تنظـــــــیمات پردازشــــــی� $
��0,35q�.+��� -   $��btnSaveSettingVisMenus��$
��10,7q�.��86اعمال تغییرات و بارگذاری مجدد�� -   $��btnResetSettingVisMenus��$
��10,7q�.��/-بازنشاندن مقادیر پیش فرض9� $��Stretch=�$=��7تنظیمات قابیل رویت بودن منو ها��$��25q�$��14(�$��Medium"�
�������$��0,0,0,1q�.���� $ Vertical=�$��Center=�$��Center=�$	��500��#���   $��
24,8,24,16q�.+�� $��
10,0,35,35q�.+��� $��0,-5,0,0q�.��xvوضعیت افکت انیمیشنی به هنگام اجرای الگوریتم پیشنهاد برنامه درسی:	� -   $ ��rdbAlgorithmStandardEffect�� 	� 	GroupName$ rdbGroupALgoAnimEffect��$	��5,0q�.��حالت استاندارد	� -   $#��rdbAlgorithmNonStandardEffect��$ rdbGroupALgoAnimEffect��$	��5,0q�.��$"حالت غیر استاندارد	� -   $ ��rdbAlgorithmEffectDisabled��$ rdbGroupALgoAnimEffect��$	��5,0q�.��1/غیرفعال کردن افکت انیمیشن� .+��� $
��10,0q�.��VTآدرس ذخیره سازی برنامه های پیشنهادی نرم افزار:�� -   $��txtWpSaveDirectory��$	��600��$��RightToLeft=��� -   $��cmbStartPage��$��0 25 0 8q�$��Stretch=�$��8q�.@��� .��
خانه�� .��تاریخچه دانشجو�� .��-+بارگذاری دروس ارائه شده�� .��تنظیمات پردازشی�� .��انتخاب واحد�� .��'%برنامه های ذخیره شده� $
��0,35q�.+��� -   $��btnSaveSettingOthers��$
��10,7q�.��86اعمال تغییرات و بارگذاری مجدد�� -   $��btnResetSettingOthers��$
��10,7q�.��/-بازنشاندن مقادیر پیش فرض9� $��Stretch=�$��اطلاعات بیشتر��$��25q�$��14(�$��Medium"�
�������$��0,0,0,1q�.���� $ Vertical=�$��Center=�$��Center=�$	��500��#���   $��
24,8,24,16q�.+���  J� Opacity$
 0.70Q�$
��Wrap=�$����این نسخه آزمایشی مخصوص رشته مهندسی کامپیوتر و منطبق با برنامه درسی مصوب سال 92 وزارت علوم برای این رشته توسعه داده شده است���� $
��0,10q�$
 0.70Q�$/��)تولید شده در سال 1397 ه.ش.��