﻿using System;  
public class calculator
{  
    public static void Main() 
   {


   double num1;
   double num2;
   int menu;
   while(true){
   
           Console.Write("\n\n");
           Console.Write("A menu driven program for a calculator:\n");
           Console.Write("------------------------------------------------");
           Console.Write("\n\n");


  

  
    Console.Write("\nHere are the options :\n");
    Console.Write("1-Addition.\n2-Substraction.\n3-Multiplication.\n4-Division.\n5-Exit.\n");
    Console.Write("\nInput your choice :");
    menu = Convert.ToInt32(Console.ReadLine());
    

    switch(menu) {

      case 1:

       Console.Write("Enter the first integer number:");
       num1 = Convert.ToDouble(Console.ReadLine());
       Console.Write("Enter the second integer number:");
       num2 = Convert.ToDouble(Console.ReadLine());
        //Addition
       Console.Write("The Addition of  {0} and {1} is: {2}\n",num1,num2,num1+num2);
       Console.Write("Any keys return to the menu"  );
        
        break;
        
      case 2:

       Console.Write("Enter the first integer number:");
       num1 = Convert.ToDouble(Console.ReadLine());
       Console.Write("Enter the second integer number:");
       num2 = Convert.ToDouble(Console.ReadLine());
       //Substraction
       Console.Write("The Substraction of {0} and {1} is: {2}\n",num1,num2,num1-num2);
       Console.Write("Any key return to the menu"  );
        
        break;
        
      case 3:

        Console.Write("Enter the first integer number:");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second integer number:");
        num2 = Convert.ToDouble(Console.ReadLine());
        //Multiplication
        Console.Write("The Multiplication of {0} and {1} is: {2}\n",num1,num2,num1*num2);
        Console.Write("Any key return to the menu"  );
        
        break;  
      
      case 4:
       
       Console.WriteLine("Try to divide by zero, enter the first integer number:");
       num1 = Convert.ToDouble(Console.ReadLine());
       Console.Write("Enter the second integer number:");
       num2 = Convert.ToDouble(Console.ReadLine());
       //When users input 0
        if(num1==0 || num2==0) {
          Console.Write( " Divide by zero is : 0 " );
          
        } else {
          //Division
          Console.Write("The Division of {0}  and {1} is : {2}\n",num1,num2, num1/num2  );
         
        }  
        Console.Write("\n");
        Console.WriteLine("Any key return to the menu"  );
        break;
        
      case 5: 
       Console.Write("Exiting program" );
       System.Environment.Exit(0);
         
      
        break; 
        
      default:
        Console.Write( "Input correct option\n"+ menu );
        Console.WriteLine("Any key return to the menu\n"  );
        
        break; 
    }
   
   Console.ReadKey();
  }
}  
} 
