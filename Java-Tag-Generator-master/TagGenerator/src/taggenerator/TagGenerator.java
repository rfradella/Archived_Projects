/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


package taggenerator;
import java.util.Scanner;
/**
 *
 * @author Ray F
 */
public class TagGenerator {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner input = new Scanner(System.in);         //input
        
        String[] location=new String[20];               //Locations
        
         int index = 1;                                   //index for location array
        boolean noMoreLoc = false;                        
        
        for(index = 1; index < location.length; index++){
            if (noMoreLoc == false){
                System.out.print("Enter a new location or enter '--' to finish adding locations: ");
                
                location[index] = input.nextLine();     //Get next Input    
                
                if (location[index].equals("--")){      //Break out of loop if -- entered
                   noMoreLoc = true;
               }
                location[index] += 1;                   //increment index     

                System.out.println("Locations Entered: " + index);
            }
        }
       if(noMoreLoc == true){
        System.out.println("Locations: " + index);
        
        System.out.print("Enter the tag you would like to use: ");
        String tag =input.nextLine();
        
        for (index=1;index<location[index].length();index++){
        System.out.print(tag + " "+ location[index] + ",\n");
        System.out.print( location[index]+ " " +tag +",\n");
        }
       }
    }
    
}
