   M S B A M L   `   `   `  ����H  DWPF-LoginForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPF_LoginFormWPF_LoginForm  5   	       WPF_LoginForm.Resultados   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WPF_LoginForm     5   	   -   5          � Title$  
Resultados��5   	   $	��680��6   $	��900��6)    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency . .��5      � .+�5   
   ��  �� CornerRadius$ 12��6   ��5      �� 5       �� ImageSource$ /Images/back-image.jpg��6    j� Stretch$ UniformToFill=�5      ._�5      �� $ 10��6   $��2q�5       J� Opacity$	 0.8Q�5      ��5      �� 5      	 �� 
StartPoint$		 0,0&�6*   
 �� EndPoint$	
 1,1&�6;   .��5      �  � Color$ #462AD8��6'    � Offset$ 0Q�67   � 5      $ #DA34AE��6'   $
 0.75Q�67   � 5      $ #8A16C1��6'   $ 1Q�67   5      ��5"      �� 5#      $		 0,1&�6*   $	
 1,0&�6;   .��5$      � $ #060531��6'   $ 0Q�67   � 5%      $ #1B1448��6'   $ 1Q�67   5&      ._�5)      �  � RowDefinitions 5*      �� 5+      $��30 �6(   �� 5,      .+�5/      � $��0��6    � ColumnDefinitions 51      �� 52      �� 53      $��25 �6/   �� 54      $��25 �6/   �� 55      $��5 �6/   .+�58      �� $����39andThem Results                                                                                                                                                                                           Made by Derek Meneses and Victoria Valencia��6$   
�������$��10(�5:       $��
Montserrat)�5;       $��0��5<       $��Center=�5=       $��10,0,0,0q�5>       �� 5@      -   5         ��Name$ btnMinimize��5@   !   $��0q�5A      $��-��5B      
�������$��16(�5D      $��
Montserrat)�5E       � Cursor$
 Hand��5F      $��1��5G      ��5J      �� 5K   "    �� 
TargetType" ��6(   .�5L   &   ��  �� Property � �� �� Value �#28AEED6C    �� Triggers 5M   &   P� 5N   *    P� Property �@J�IsMouseOver P� Value . . �5O   .   ��  � �� �#278BEF6K   5P   +   5R   #   ��5U      �� 5V   "    �� 
TargetType" ��62   .R�5W   &   �� $��18��6-   $��18��68   $ 9��5X   )   #��z��5Y   )   ._�5Z   *   �� $��Center=�6;   $��Center=�5[   7   5\   '   5]   #   5`      �� 5b      -   5        $ btnClose��5b   !   $��0q�5c      $��X��5d      
�������$��12(�5f      $��
Montserrat)�5g      $
 Hand��5h      $��2��5i      ��5l      �� 5m   "   " ��6(   .�5n   &   ��  � �� �#DA34AE6C    5o   &   P� 5p   *    �@J�IsMouseOver . . �5q   .   ��  � �� �#C62DAE6K   5r   +   5t   #   ��5w      �� 5x   "   " ��62   .R�5y   &   �� $��18��6-   $��18��68   $ 9��5z   )   #��z��5{   )   ._�5|   *   �� $��Center=�6;   $��Center=�5}   7   5~   '   5   #   5�      5�      �� 5�      $��1��5�       �� Orientation$ Vertical=�5�      $��706,0,9,460q�5�       J� RenderTransformOrigin$ 0.5,0.5&�62   z�5�      V� 5�      .~�5�   "   �� �� 5�   "    �� AngleY$
 -0.6Q�60   �� 5�   "   T� 5�   "    T� Y$ -0.99Q�65   5�      .+�5�      �� $ ��/Images/logo_39andthem.png��6    $��50��5�      $��50��6'   �� 5�      $��	39andThem��6$   
�������$��25(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��Center=�5�       �� 5�      $��Dog DNA Genetic Analysis��6$   
�������$	��7.5(�5�       $��Medium"�5�       $��
Montserrat)�5�       $
��Wrap=�5�        �� TextAlignment$ Center=�5�       $��0,5,0,0q�5�       �� 5�      $ 
Horizontal=�6%   $��Center=�5�   !   $��0,15,0,0q�5�   !   5�      �� 5�      $��1��5�      $ Vertical=�5�      $��20,5,177,472q�5�      $ 0.5,0.5&�6/   .+�5�      �� -   5         ��Name$ resultadosnombre��5�   $   $��Results of ��6>   
�������$��35(�5�   $   $
��Bold"�5�   $   $��
Montserrat)�5�   $   $��Center=�5�   $   6C   �� 5�      -   5        $ resultadoshumano��5�   $   $z��tthis analysis was made using a DOGgene dataset created to analyze your dog's genome using the blastn software (NCBI)��6>   
����ح�$��11(�5�   $   $��Medium"�5�   $   $��
Montserrat)�5�   $   $ Center=�5�   $   $	��674��5�   $   $
��Wrap=�5�   $   5�   '   �� 5�      
����ح�$��11(�5�   $   $��Light"�5�   $   $��
Montserrat)�5�   $   $ Center=�5�   $   $��34��5�   $   $
��Wrap=�5�   $   $����The genes analyzed here are a calculated probability based on blastn. They do not necessarily determine a phenotypic characteristic or a genetic disease; this is just a statistical approximation made for simulation purposes.��68   5�      �� 5�      $��1��5�      $ Vertical=�5�      $��50,100,450,20q�5�      $ 0.5,0.5&�60   .+�5�      �� $��Genetic diseases��6(   ���#DA34AE$��
Montserrat)�5�   $   $��17(�5�   $   $��	ExtraBold"�5�   $   $��Center=�5�   $   $��0,0,0,10q�5�   $   68   �� 5�      $��/Images/4.png��6    $��50��5�       �� 5�      $��
Cystinuria��6$   ���#28AEED$��
Montserrat)�5�   $   $��17(�5�   $   $��Medium"�5�   $   $��Center=�5�   $   $��0��5�   $   �� 5�      -   5        $ Cystinuriatb��5�   $   $	��70%��5�   $   
�������$��
Montserrat)�5�   $   $��17(�5�   $   $��Medium"�5�   $   $��Center=�5�   $   $��0,0,0,10q�5�   $   68   �� 5�      $��/Images/5.png��6    $��50��5�       6-   �� 5�      $��Hip dysplasia��6$   ���#28AEED$��
Montserrat)�5�       $��17(�5�       $��Medium"�5�       $��Center=�5�       �� 5�      -   5        $ HipDysplasiatb��5�   $   $	��70%��6<   
�������$��
Montserrat)�5�       $��17(�5�       $��Medium"�5�       $��Center=�5�       $��0,0,0,10q�5�       64   �� 5�      $��/Images/6.png��6    $��50��5�       6-   �� 5�      $��Congenital deafness��6$   ���#28AEED$��
Montserrat)�5�       $��17(�5�       $��Medium"�5�       $��Center=�5�       �� 5�      -   5        $ CongenitalDeafnesstb��5�   $   $	��70%��6B   
�������$��
Montserrat)�5�       $��17(�5�       $��Medium"�5       $��Center=�5      $��0,0,0,10q�5      64   �� 5     $��/Images/7.png��6    $��50��5      6-   �� 5     $��
Narcolepsy��6$   ���#28AEED$��
Montserrat)�5      $��17(�5      $��Medium"�5	      $��Center=�5
      �� 5     -	   5        $ Narcolepsytb��5  $   $	��70%��6:   
�������$��
Montserrat)�5      $��17(�5      $��Medium"�5      $��Center=�5      $��0,0,0,10q�5      64   �� 5     $��/Images/8.png��6    $��50��5      6-   �� 5     $!��Progressive Retinal Atrophy��6$   ���#28AEED$��
Montserrat)�5      $��17(�5      $��Medium"�5      $��Center=�5      �� 5     -
   5        $! ProgressiveRetinalAtrophytb��5  $   $	��70%��6I   
�������$��
Montserrat)�5      $��17(�5      $��Medium"�5      $��Center=�5      6?   5�     �� 5�     $��1��5�     $ Vertical=�5�     $��470,100,50,20q�5�     $ 0.5,0.5&�60   .+�5�     �� $��	Phenotype��6$   
����+��$��
Montserrat)�5�     $��17(�5�     $��	ExtraBold"�5�     $��Center=�5�     $��0,0,0,10q�5�     6-   �� 5�     $��/Images/11.png��6    $��50��5�      6-   �� 5�     $��
Short coat��5�     ���#DA3$��
Montserrat)�5�     $��17(�5�     $��Medium"�5�     $��Center=�5�     �� 5�     -   5        $ ShortCoattb��5�  $   $	��70%��5�     
�������$��
Montserrat)�5�     $��17(�5�     $��Medium"�5�     $��Center=�5�     $��0,0,0,10q�5�     61   �� 5�     $��/Images/10.png��6    $��50��5�      6-   �� 5�     $��Heat Tolerance��5�     ���#DA3$��
Montserrat)�5�     $��17(�5�     $��Medium"�5�     $��Center=�5�     �� 5�     -   5        $ HeatTolerancetb��5�  $   $	��70%��5�     
�������$��
Montserrat)�5�     $��17(�5�     $��Medium"�5�     $��Center=�5�     $��0,0,0,10q�5�     61   �� 5�     $��/Images/9.png��6    $��50��5�      6-   �� 5�     $��Elongated Muzzle��5�     ���#DA3$��
Montserrat)�5�     $��17(�5�     $��Medium"�5�     $��Center=�5�     �� 5�     -   5        $ ElongatedMuzzletb��5�  $   $	��70%��5�     
�������$��
Montserrat)�5�     $��17(�5�     $��Medium"�5�     $��Center=�5�     $��0,0,0,10q�5�     61   �� 5�     $��/Images/12.png��6    $��50��5�      6-   �� 5�     $��Large bones��5�     ���#DA3$��
Montserrat)�5�     $��17(�5�     $��Medium"�5�     $��Center=�5�     �� 5�     -   5        $ LargeBonestb��5�  $   $	��70%��5�     ���	#FFFAE6E6$��
Montserrat)�5�     $��17(�5�     $��Medium"�5�     $��Center=�5�     $��0,0,0,10q�5�     61   �� 5�     $��/Images/13.png��6    $��50��5�      6-   �� 5�     $��	Agressive��5�     ���#DA3$��
Montserrat)�5�     $��17(�5�     $��Medium"�5�     $��Center=�5�     �� 5      -   5        $ Agressivetb��5   $   $	��70%��5     
�������$��
Montserrat)�5     $��17(�5     $��Medium"�5     $��Center=�5     $��0,0,0,10q�5     61   5
     5�     5�     5�     5�     5�     