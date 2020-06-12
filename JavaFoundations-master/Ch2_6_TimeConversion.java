package Chapter2;
import java.util.Scanner;

/**
 * User gives hours, min, and seconds convert to total seconds
 * User gives total seconds convert to hours min and seconds
 *
 * @author (Raymond Fradella)
 * @version (v1.0)
 */
public class Ch2_6_TimeConversion
{
    public static void main(String[] args){
    Scanner input = new Scanner(System.in);
    
    System.out.println("Enter what you would like to convert from \n\t\"seconds\" to convert from total seconds to hr min sec.\n\t\"time\" to convert from hr min sec to total seconds.");
    String conversionType = input.nextLine();
    //CONVERT SECONDS TO HR MIN SEC
    if(conversionType.equals("seconds")){
        System.out.print("Enter Total seconds: ");
        int totalSeconds = input.nextInt();        
        int hr, min, sec ;
        
        //Converts hours, minutes and second into their total seconds. 
        //Then it subtracts that value from the total seconds entered and converts it back into the hr min sec format.
        if (totalSeconds >= 3600){                          //>= 1 hour               
            hr = totalSeconds / 3600;
            min = (totalSeconds - (hr * 3600)) / 60;
            sec=(totalSeconds - (hr * 3600) - (min * 60));
            System.out.println(totalSeconds + " is the equivalent to " + hr +" hr " + min + " min " + sec + " sec");
        }
        if (totalSeconds < 3600){                           //0 hours, >=1 min 
            hr = 0;
            min = (totalSeconds - (hr * 3600)) / 60;
            sec = (totalSeconds - (hr * 3600) - (min * 60));
                
            System.out.println(totalSeconds + " is the equivalent to " + min + " min" + sec + " sec");
        
        }
        if (totalSeconds < 60){                             //0 hours, 0min, >=0sec
            hr = 0;
            min = 0;
            sec = (totalSeconds - (hr * 3600) - (min * 60));
            if (totalSeconds < 0){                          //Cant have - seconds
                sec = 0;
            }
            System.out.println(totalSeconds + " is the equivalent to " + sec + " sec");
        }
    }
   
    //CONVERT HR MIN SEC TO TOTAL SEC
    if(conversionType.equals("time")){
        System.out.println("Enter the hours (0-24)");
        int hr = input.nextInt();       
        System.out.println("Enter the minutes (0-60)");
        int min = input.nextInt();
        System.out.println("Enter the seconds (0-60)");
        int sec = input.nextInt();
        
        int totalSeconds = (hr * 3600) + (min * 60) + sec;
        
        System.out.println(hr + " hrs " + min + " min " + sec + "sec equates to " + totalSeconds);
        
        
    }
}
}
