   M S B A M L   `   `   `  ����G  CBoss_az_Task, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Boss_az_Task.ViewsBoss_az_Task.Views  5      A%clr-namespace:Boss_az_Task.ViewModelsBoss_az_Task.ViewModels  5      2    ,Boss_az_Task.Views.EmployerCreateVacancyView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Boss_az_Task.Views     5      8local1%clr-namespace:Boss_az_Task.ViewModels     5        N� Title$  EmployerCreateVacancyView��5
       � DataContext 5      <  6Boss_az_Task.ViewModels.EmployerCreateVacancyViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5    
   �� $��0��6   $��0��6   $��Name:��6-   �� 5!   
   $��0��6   $��1��6   $��50,10q�6/   ��6>   �� *EmployerCreateVacancytxtName+�� 5#   
   $��1��6   $��0��6   $��Title:��6-   �� 5$   
   $��1��6   $��1��6   $��50,10q�6/   ��6>   �� *EmployerCreateVacancytxtTitle+�� 5&   
   $��2��6   $��0��6   $��Salary:��6-   �� 5'   
   $��2��6   $��1��6   $��50,10q�6/   ��6>   �� *EmployerCreateVacancySalary+�� 5)   
   $��3��6   $��0��6   $��Minimum Experience:��6-   �� 5*   
   $��3��6   $��1��6   $��50,10q�6/   ��6>   �� *$"EmployerCreateVacancyMinExperience+�� 5,   
   $��4��6   $��0��6   $��Maximum Age:��6-   �� 5-   
   $��4��6   $��1��6   $��50,10q�6/   ��6>   �� *EmployerCreateVacancyMaxAge+�� 5/   
   $��5��6   $��0��6   $��
Work Type:��6-   �� 50   
   $��5��6   $��1��6   $��50,10q�6/   ��6>   �� *" EmployerCreateVacancytxtWorkType+�� 52   
   $��6��6   $��1��6   $��Create��6.   
��� d �$��50��6V   $	��200��6b   ��6n   �� * EmployerCreateVacancyOkCommand+54      55      