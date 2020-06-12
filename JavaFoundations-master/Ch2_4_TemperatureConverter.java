package Chapter2;
import java.util.Scanner;

/**
 * Program asks for degrees in fahrenheit and converts the to celsius
 *
 * @author (Raymond Fradella)
 * @version (v1.0)
 */
public class Ch2_4_TemperatureConverter
{
   public static void main(String[] args){
       Scanner input = new Scanner(System.in);
       float fahrenheitValue;
       System.out.print("Enter Degrees in fahrenheit: ");
            fahrenheitValue = input.nextFloat();                            //Get Input
            float calcValue=((fahrenheitValue-32)*5/9);                     //Calculation
       System.out.println(fahrenheitValue + " in celsius is: " + calcValue);
    }
}
