   M S B A M L   `   `   `  ����K  GWPF-LazyTreeNode, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WPF_LazyTreeNode.ViewsWPF_LazyTreeNode.Views  5   	   A%clr-namespace:WPF_LazyTreeNode.ModelsWPF_LazyTreeNode.Models  5   	   %    WPF_LazyTreeNode.Views.MainView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:WPF_LazyTreeNode.Views     5   	   8models%clr-namespace:WPF_LazyTreeNode.Models     5   	     � Title$  MainView��5	   	   $	��450��6   $	��800��6'   .��5      � .+�5   
   R� $��20(�65   ��6   �� *	PathNodes+ � 	Resources 5       �� 
TargetType �� Property �� Value �� Mode��%y   'Q�       �� 5      " Q�6   .�5      ��  �@Q�
IsExpanded 63   �� *
IsExpanded+$ TwoWay=�5      5      ��5      �� 5       �� DataType*   $WPF_LazyTreeNode.Models.LazyTreeNode"  6+    �� ItemsSource 6S   �� *
Children+.R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� 	 ��Name$	 	treeImage��6    $��24��63   $��24��6>   ��6J   �� *ClosedImage+�� 5      ��6$   �� *Text+5      
 �� Triggers
 5      �� 5       �� Value$
 True��6E    �� Binding 6&   �� *
IsExpanded+.a�5      ��  �� 
TargetName$ 	treeImage��6%    5   %   �� *OpenedImage+ � ��5      5!      5#      5$      5%      