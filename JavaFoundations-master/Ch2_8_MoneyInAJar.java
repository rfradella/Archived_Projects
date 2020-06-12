package Chapter2;
 import java.util.Scanner;

/**
 * User enters the ammount of each coin type in a jar and then gets the total value
 *
 * @author (Raymond Fradella)
 * @version (v1.0)
 */
public class Ch2_8_MoneyInAJar
{
 public static void main(String[] args){
     Scanner input = new Scanner(System.in);  
     int quarters, nickels, dimes, pennies;
    System.out.print("How many Quarters: ");
        quarters = input.nextInt();
    System.out.print("How many Dimes: ");
        dimes = input.nextInt();
    System.out.print("How many Nickels: ");
        nickels = input.nextInt();
    System.out.print("How many Pennies: ");
        pennies = input.nextInt();
    
    System.out.print("\n\tQuarters: " + quarters + "\n\tDimes: " + dimes + "\n\tNickels: " + nickels + "\n\tPennies: " + pennies + 
                    "\nThe total in the jar is $" + ((quarters * 0.25) +(dimes * 0.10)+(nickels * 0.05)+(pennies * 0.01)));
 }
}
