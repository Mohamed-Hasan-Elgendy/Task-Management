   M S B A M L   `   `   `  ����J  Ftask management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:task_managementtask_management  5   	       task_management.Employee   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:task_management     5   	     � Title$  Employee��5   	   $	��450��6   $	��810��6'   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6   � 5      $ 	#FF008DF9��6    � Offset$ 1Q�61   5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DG_completed��5         AutoGenerateColumns .    CanUserAddRows .  $��10,306,10,10q�6[   �� 5   
   -   5        $
��save��5      $
��Save��6   $
��Left=�6,   $��670,233,0,0q�6G   $	��Top=�6\   $��33��6t   $	��120��6�   $��16(�6�   
�������6�   �� 5   
   -   5         ��Name$ combo2_status��5      $
��Left=�6*   $��389,232,0,0q�6E   $	��Top=�6Z   $	��134��6r   $��31��6~   .@�5      �� $��Pending��6   �� 5      $��In Progress��6   �� 5      $��	Completed��6   5      �� 5   
   $&�� Employee Page : Welcome Employee��6   $
��Left=�6;   $��8,6,0,0q�6V   $	��Top=�6g   
�������$��18(�6�   $
��Bold"�6�   ��5      �� 5      5      �� 5   
   -   5        $��task_id��5      $
��Left=�6!   $��106,232,0,0q�6<   	 �� TextWrapping$
	 Wrap=�6Q   $	��Top=�6e   $	��136��6}   $��31��6�   �� 5   
   $��Task ID��6   $
��Left=�6"   $��
20,226,0,0q�6=   $	��Top=�6Q   
�������$��18(�6|   $
��Bold"�6�   $��87��6�   $��47��6�   ��5      �� 5      5!      �� 5"   
   $��Status��6   $
��Left=�6!   $��308,232,0,0q�6<   $	��Top=�6Q   
�������$��18(�6|   $
��Bold"�6�   $��72��6�   $��31��6�   ��5#      �� 5$      5&        5'   
   -   5        $ DG_tasks��5'       .  .  $��10,92,10,215q�6W   6m   �� 5(   
   $!��Pending / In Progress Tasks��6   $
��Left=�66   $��	10,45,0,0q�6Q   $	��Top=�6d   
�������$��18(�6�   $
��Bold"�6�   ��5)      �� 5*      5,      �� 5-   
   $��Completed Tasks��6   $
��Left=�6*   $��
20,263,0,0q�6E   $	��Top=�6Y   
�������$��18(�6�   $
��Bold"�6�   ��5.      �� 5/      51      53      54      