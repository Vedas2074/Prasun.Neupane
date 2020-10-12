using System;

class SelectionStatement
{
   public void LearnIfElse()
    {
       Console.WriteLine("Enter your age");
       string ageString = Console.ReadLine();
       byte a = byte.Parse(ageString);
        if(a > 60)
        {
            Console.WriteLine("You are eligible for pension.");
        }
        else if(a > 50)
        {
             Console.WriteLine("You are about to eligible for pension.");
        }
        else
        {
            Console.WriteLine("You are not eligible for pension");
        }
        
    }
    public void LearnSwitchCases()
    {
        Console.Write("Enter your hobby: ");
        string hobby = Console.ReadLine();

        switch(hobby)
        {
            case "books":
            Console.WriteLine("You really are a genius.");
            break;
            case "sports":
             Console.WriteLine("You must be healthy");
            break;
            case "movie":
            Console.WriteLine("You must be a dreamer");
            break;
            case "manga":
            Console.WriteLine("You enjoy things that normal people don't");
            break;
            default:
            Console.WriteLine("Don't worry you'll find one day");
            break;
        }
    }
}