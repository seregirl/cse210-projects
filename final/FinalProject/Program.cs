using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Exercise Program!");
        string [] options =  {"Jogging Exercise", "Skipping Exercise", "Pushup Exercise", "Quit"};
        bool quit = false;
        while (quit == false) {
            int index = 1;
        Console.WriteLine("Please choose one from the exercise options below: ");      
         foreach (string option in options)
         {
           
            
             Console.WriteLine($"{index}. {option}");
            index ++;
        }
      
        switch (Console.ReadLine())
        {
            case "1":
                JoggingExercise jogging = new JoggingExercise();
                jogging.ShowOpeningMessage();
                jogging.RunExercise();
                jogging.ShowConclusionMessage();
                break;
            case "2":
                SkippingExercise skipping = new SkippingExercise();
                skipping.ShowOpeningMessage();
                skipping.RunExercise();
                skipping.ShowConclusionMessage();
                break;
            case "3":
                PushupExercise pushup = new PushupExercise();
                pushup.ShowOpeningMessage();
                pushup.RunExercise();
                pushup.ShowConclusionMessage();
                break;
            case "4":
                quit = true;
                Console.WriteLine("You have quit the exercise program");
                break;
            default:
                Console.WriteLine("You have selected an invalid option. Please choose from 1 to 4.");
                break;
        }
        }
                   
    }
        

}