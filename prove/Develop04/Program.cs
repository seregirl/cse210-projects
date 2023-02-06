using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        string [] usermenus =  {"Breathing Activity", "Reflection Activity", "Listing Activity", "Quit"};
        int index = 1;
        Console.WriteLine("Please choose from the below activities.");      
         foreach (string usermenu in usermenus)
         {
           
            
             Console.WriteLine($"{index}. {usermenu}");
            index ++;
        }
        
        string userinput = Console.ReadLine();

        if (userinput == "1")
            {
                Console.WriteLine("");
            
                // BreathingActivity breathingactivity = new BreathingActivity("Alternating message", "This the breathing activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 10, "You have come to the end of the activity"  );
                BreathingActivity breathingactivity = new BreathingActivity();
                breathingactivity.DisplayStartingMessage();
                breathingactivity.runActivity();
                breathingactivity.DisplayEndingMessage();
            
            }
            else if (userinput == "2")
            {
                ReflectionActivity reflectionactivity = new ReflectionActivity();
                reflectionactivity.DisplayStartingMessage();
                reflectionactivity.DisplayPrompt();
                reflectionactivity.runActivity();
                reflectionactivity.DisplayEndingMessage();
            }
            else if (userinput == "3")
            {
                
                ListingActivity listingactivity = new ListingActivity();
                listingactivity.DisplayStartingMessage();
                listingactivity.DisplayListPrompt();
                listingactivity.runActivity();
                listingactivity.DisplayEndingMessage();
                
                
            }
            
            else{
                Console.WriteLine("You have quit the mindful game.");
            }

        // Console.WriteLine($"{index}. {usermenus}");
        // switch (Console.Readline())
        // {
        //     case "1";
        //         "BreathingActivity";
        //         return true;
        //     case "2";
        //         "ReflectionActivity";
        //         return true;
        //     case "3"
        //         "ListingActivity";
        //         return true;
        //     case "4";
        //         "Quit";
        //         return "End of mindful game";
        //     default:
        //     return true;


        // }
        

        // Console.WriteLine(activity.DisplayStartingMessage());
            
    }
        // Console.WriteLine("Welcome to the breathing Activity");
        // BreathingActivity breathingactivity = new BreathingActivity("", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",  "", "");

}