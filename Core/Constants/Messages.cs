namespace Core.Constants;
public class Messages
{
    public static void ErrorOccuredMessage() { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"Error occured"); }
    public static void InputMessage(string title) { Console.ForegroundColor = ConsoleColor.White; Console.WriteLine($"Input this {title}"); }
    public static void InvalidInputMessage(string title) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"this {title} is invalid, try again"); }
    public static void SuccessMessage(string title) { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine($"{title} successfully done!"); }
    public static void PasswordFormMessage() { Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("Password must contain a minimum 1  character, it must contain 1 uppercase, 1 lowercase symbol and 1 special character "); }
    public static void NotFoundMessage(string title) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"{title} not found"); }
}