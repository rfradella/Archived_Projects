
/**
 * Write an application that prints the phrase in the following 3 ways
 * a. On one line
 * b. On three lines one word per line and centered relative to each other
 * c. inside a box made up of the characters = and |
 *
 * @author (Raymond Fradella)
 * @version (v1.0)
 */
public class Ch1_4_PrintPhrase3Ways
{
   public static void main(String[] args){
       System.out.println("Knowledge is power\n");        //part a
       
       System.out.print("Knowledge\nis\npower\n\n");      //part b
       
       System.out.println("|====================|");      //part c
       System.out.println("| Knowledge is power |");
       System.out.println("|====================|");       
   }
}
