package Chapter2;
import java.util.Scanner;

/**
 * Program asks for miles and converts it to kilometers
 *
 * @author (Raymond Fradella)
 * @version (v1.0)
 */
public class Ch2_5_MilesToKilometers
{
   public static void main(String[] args){
       Scanner input = new Scanner(System.in);
       double milesValue;
       System.out.print("Enter miles: ");
            milesValue = input.nextInt() ;                            //Get Input
            double calcValue=milesValue*1.60395;                     //Calculation
       System.out.println(milesValue + "mi in km is: " + calcValue);
    }
}