package Chapter2;
import java.util.Scanner;


/**
 * Basic Calculator
 *
 * @author (Raymond Fradella)
 * @version (v1.0)
 */
public class Ch2_3_BasicCalculator
{
   public static void main(String[] args){
    Scanner input=new Scanner(System.in);
    String result="";
    int firstNum,secondNum,calcResult;
    while(result.equals("")){
         System.out.println("Enter: ");
         System.out.println("\t\"s\" for Sum");
         System.out.println("\t\"sub\" for Subtract");
         System.out.println("\t\"q\" for Division");
         System.out.println("\t\"p\" for Multiplication");
         System.out.println("\t\"avg\" for Average");         
         result=input.nextLine();        
    }
    
    if(result.equals("s") || result.equals("sub") || result.equals("q")||result.equals("p")){
        System.out.println("Enter first number");
        firstNum=input.nextInt();
        System.out.println("Enter second number");
        secondNum=input.nextInt();
        
        //Individual Calculations
        if(result.equals("s")){
            calcResult= firstNum += secondNum;
            System.out.println("The sum is: " + calcResult);                
        }
        if(result.equals("sub")){
            calcResult= firstNum -= secondNum;
            System.out.println("The difference is: " + calcResult);
        }
        if(result.equals("p")){
            calcResult= firstNum *= secondNum;
            System.out.println("The product is: " + calcResult);
        }
        if(result.equals("q")){
            calcResult= firstNum /= secondNum;
            System.out.println("The quotient is: " + calcResult);
        }
    }
   
     if(result.equals("avg")){
        System.out.println("Enter first number");
        firstNum=input.nextInt();
        System.out.println("Enter second number");
        secondNum=input.nextInt();
        System.out.println("Enter third number");
        int thirdNum=input.nextInt();            
        
        calcResult=(firstNum + secondNum + thirdNum)/3;
        System.out.println("The average is: " + calcResult);
    }
    
}
}

