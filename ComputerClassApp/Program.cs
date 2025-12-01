// My name is Andrew Hoorelbek. I originated this code.
// Input name and what you did here (like: My name is John and I edited the code first)
// Input name and what you did here (like: My name is John and I edited the code first)
// Input name and what you did here (like: My name is John and I edited the code first)
// Input name and what you did here (like: My name is John and I edited the code first)
// DO NOT delete this line!!! 


Console.WriteLine("Hello, World!");
Console.WriteLine("What shall we do?");
Console.WriteLine("Do you want to see some math?"); // From here...
// Get user input
if (Console.ReadLine()?.ToLower() == "yes")
{
    Console.WriteLine("Great! Let's do some math.");
    byte math = 100 % 6;
    Console.WriteLine($"100 % 6 = {math}");
}
else
{
    Console.WriteLine("No problem! Maybe next time.");
}                                                      // ...to here, I, Andrew, added a simple math operation based on user input.

Console.WriteLine("Goodbye, World!");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
// Try the program! Go ahead and run it. You should see the output in the console window.
// Now, make a change to the code. Change the math variable to do a different calculation