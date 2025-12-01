// My name is Andrew Hoorelbek. I originated this code.
// Input name and what you did here (like: My name is John and I edited the code second)
// Input name and what you did here (like: My name is John and I edited the code third)
// Input name and what you did here (like: My name is John and I edited the code fourth)
// Input name and what you did here (like: My name is John and I edited the code fifth)
// DO NOT delete this line!!! 

Console.WriteLine("Hello, World!");
Console.WriteLine("What shall we do?");
Console.Write("Do you want to see some math? (y/n): "); // From here...
// Get user input
if (Console.ReadLine()?.ToLower().Contains("y") == true)
{
    Console.WriteLine("Great! Let's do some math.");
    Console.Write("Input the first number here: "); int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the second number here: "); int num2 = Convert.ToInt32(Console.ReadLine());

    if (num1 > num2)
    {
        int math = num1 % num2; // This line was changed to perform a modulus operation.
        Console.WriteLine($"{num1}/{num2} has a remainder of {math}");
        Console.WriteLine();
        Console.Write("Do you want some more? (y/n): ");
    }
    else
    {
        Console.Write("Cannot perform modulus operation as the first number is not greater than the second. Would you like to continue? (y/n): ");
    }

    // Get user input
    if (Console.ReadLine()?.ToLower().Contains("y") == true)
    {
        // The Quadratic Equation! x = (-b +/- √(b^2 - 4ac))/2a, where the original equation looks like this: ax^2 + bx + c = 0
        Console.WriteLine();
        Console.WriteLine("==================================================================");
        Console.WriteLine("=== Welcome to the Quadratic Equation solver, where we find x! ===");
        Console.WriteLine("=== Enter the values of a, b, and c here. (Hint: The original  ===");
        Console.WriteLine("=== equation looks like this: ax^2 + bx + c = 0)               ===");
        Console.WriteLine("==================================================================");

        // Acquiring the neccesary variables.
        Console.Write("a: "); double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b: "); double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c: "); double c = Convert.ToDouble(Console.ReadLine());

        // Finding "x".
        double negativeX = (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
        double positiveX = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);

        // Ahh, but what happens if there are no real solutions?
        if (double.IsNaN(negativeX) || double.IsNaN(positiveX))
        {
            Console.WriteLine("Hmm, it seems like there are no real solutions for the values you provided.");
        }
        else
        {
            Console.WriteLine("These are the real solutions for the quadratic equation based on the values you provided.");

            // Now we display the values of "x" back to the user.
            Console.WriteLine($"x = {negativeX} and {positiveX}");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
    else
    {
        Console.WriteLine("No problem! Maybe next time.");
    }
}
else
{
    Console.WriteLine("Ok, bye!");
}                                       // ...to here, I, Andrew, added simple math operations based on the user's input. If anyone wants to add error handling, feel free to do so! Don't forget to add your name above and where you edited.

Console.WriteLine("Goodbye, World!");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
// Try the program! Go ahead and run it. You should see the output in the console window.
// Now, make a change to the code. Change the math variable to do a different calculation