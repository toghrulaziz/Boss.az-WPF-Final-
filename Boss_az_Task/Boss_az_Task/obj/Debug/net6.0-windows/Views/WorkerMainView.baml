   M S B A M L   `   `   `  ����G  CBoss_az_Task, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Boss_az_Task.ViewsBoss_az_Task.Views  5      A%clr-namespace:Boss_az_Task.ViewModelsBoss_az_Task.ViewModels  6=   '    !Boss_az_Task.Views.WorkerMainView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Boss_az_Task.Views     5      8local1%clr-namespace:Boss_az_Task.ViewModels     6=   .��5	      �   � ColumnDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   .+�5      �� $��	Create CV��6   
��� d �$��50��6@   ��6L   �� *ShowWorkerCreateCvPage+�� 5      $��Show All Vacancies��6   
��� d �$��50��6I   ��6U   �� *ShowWorkerShowAllVacancies+�� 5      $��Notifications��6   
��� d �$��50��6D   �� 5      $
��Back��6   
��� d �$��50��6;   ��6G   �� *WorkerBackCommand+5       � 5   
   -   5          �Name$ WorkerViewCrossPages��5      $��1��6.     � NavigationUIVisibility$ Hidden=�6W   ��6>   �� *Page+6W   5      5      