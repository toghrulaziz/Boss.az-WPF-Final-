   M S B A M L   `   `   `  ����G  CBoss_az_Task, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Boss_az_Task.ViewsBoss_az_Task.Views  5      %    Boss_az_Task.Views.WorkerSignUp   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Boss_az_Task.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��Name:��6-   �� 5   
   -   5        $��txtName��5   /   $��0��6   $��1��6   $��50,10q�6>   ��6M   �� *WorkerSignUptxtName+�� 5   
   $��1��6   $��0��6   $��Surname:��6-   �� 5   
   -   5        $��
txtSurname��5   /   $��1��6   $��1��6   $��50,10q�6A   ��6P   �� *WorkerSignUptxtSurname+�� 5!   
   $��2��6   $��0��6   $��	Password:��6-   �� 5"   
   -   5        $��txtPassword��5"   0   $��2��6   $��1��6    $��50,10q�6C   ��6R   �� *WorkerSignUptxtPassword+�� 5$   
   $��3��6   $��0��6   $��Phone:��6-   �� 5%   
   -   5        $��txtPhone��5%   /   $��3��6   $��1��6   $��50,10q�6?   ��6N   �� *WorkerSignUptxtPhone+�� 5'   
   $��4��6   $��0��6   $��Address:��6-   �� 5(   
   -   5        $��
txtAddress��5(   /   $��4��6   $��1��6   $��50,10q�6A   ��6P   �� *WorkerSignUptxtAddress+�� 5*   
   $��5��6   $��0��6   $
��Age:��6-   �� 5+   
   -   5        $��txtAge��5+   /   $��5��6   $��1��6   $��50,10q�6=   ��6L   �� *WorkerSignUpAge+�� 5-   
   $��6��6   $��0��6   $��	Birthday:��6-   (  "System.Windows.Controls.DatePicker  5.   
   -   5        $��
dpBirthday��5.   2   $��6��6   $��1��6"   $��50,10q�6D      SelectedDate 6S   �� *WorkerSignUpBirthday+�� 50   
   -   5        $��chkTermsAndConditions��50   0   $��7��6   $��1��6    $)��#I agree to the terms and conditions��6M   $��50,20q�6{   �� 51   
   $��8��6   $��1��6   $��Sign Up��6.   
��� d �$	��200��6W   $��50��6c   ��6o   �� *SignUpShowWorkerMainView+52      53      